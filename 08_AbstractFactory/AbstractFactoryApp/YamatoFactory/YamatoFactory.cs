using System;
using AbstractFactoryApp;
using AbstractFactoryApp.AbstractFactory;

namespace AbstractFactoryApp
{
    namespace YamatoFactory
    {
        // ====== ConcreteProduct(1) ：梱包箱 =====
        public class YamatoPackingBox : PackingBox
        {
            public YamatoPackingBox(DeliveryItemSize deliveryItemSize) : base(deliveryItemSize)
            {
            }

            public override void AssignBoxSize()
            {
                int s = DeliveryItemSize.LengthS;
                int m = DeliveryItemSize.LengthM;
                int l = DeliveryItemSize.LengthL;
                if (l <= 31 && m <= 23 && s <= 3)
                {
                    BoxType = "ネコポス専用箱";
                }
                else if (l <= 31 && m <= 25 && s <= 5)
                {
                    BoxType = "宅急便コンパクト専用箱";
                }
                else
                {
                    BoxType = "60サイズ";
                }

            }
        }

        // ====== ConcreteProduct(2)：配送 ======
        public class YamatoDelivery : Delivery
        {
            public YamatoDelivery(string contentName, PackingBox packingBox) : base(contentName, packingBox)
            {
            }

            public override int CalcPrice()
            {
                int price = 0;
                switch (PackingBox.BoxType)
                {
                    case "ネコポス専用箱":
                        price = 210;
                        break;
                    case "宅急便コンパクト専用箱":
                        price = 450;
                        break;
                    case "60サイズ":
                        price = 750;
                        break;
                }
                return price;
            }
            public override void Transport()
            {
                string content = $"""
                ==== ヤマトから出荷します ====
                * 品名：{ContentName}
                * 梱包箱：{PackingBox.BoxType}
                * 料金：{CalcPrice()}
                """;
                Console.WriteLine(content);
            }
        }

        // ------ ConcreteFactory ------
        public class YamatoFactory: Factory
        {
            public override PackingBox CreatePackingBox(DeliveryItemSize size){
                return new YamatoPackingBox(size);

            }
            public override Delivery CreateDelivery(string contentName, PackingBox packingBox){
                return new YamatoDelivery(contentName, packingBox);
            }
        }
    }
}