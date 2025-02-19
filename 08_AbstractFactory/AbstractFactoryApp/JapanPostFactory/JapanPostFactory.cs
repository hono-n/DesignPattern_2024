using System;
using AbstractFactoryApp;
using AbstractFactoryApp.AbstractFactory;

namespace AbstractFactoryApp
{
    namespace JapanPostFactory
    {
        // ====== ConcreteProduct(1) ：梱包箱 =====
        public class JapanPostPackingBox : PackingBox
        {
            public JapanPostPackingBox(DeliveryItemSize deliveryItemSize) : base(deliveryItemSize)
            {
            }

            public override void AssignBoxSize()
            {
                int s = DeliveryItemSize.LengthS;
                int m = DeliveryItemSize.LengthM;
                int l = DeliveryItemSize.LengthL;
                if (l <= 60 && m <= 34 && s <= 3)
                {
                    BoxType = "ゆうぱけっと専用封筒";
                }
                else if (l <= 24 && m <= 17 && s <= 7)
                {
                    BoxType = "ゆうパケットプラス専用封筒";
                }
                else
                {
                    BoxType = "ゆうパック";
                }

            }
        }

        // ====== ConcreteProduct(2)：配送 ======
        public class JapanPostDelivery : Delivery
        {
            public JapanPostDelivery(string contentName, PackingBox packingBox) : base(contentName, packingBox)
            {
            }

            public override int CalcPrice()
            {
                int price = 0;
                switch (PackingBox.BoxType)
                {
                    case "ゆうぱけっと専用封筒":
                        price = 210;
                        break;
                    case "ゆうパケットプラス専用封筒":
                        price = 450;
                        break;
                    case "ゆうパック":
                        price = 750;
                        break;
                }
                return price;
            }
            public override void Transport()
            {
                string content = $"""
                ==== 日本郵便から出荷します ====
                * 品名：{ContentName}
                * 梱包：{PackingBox.BoxType}
                * 料金：{CalcPrice()}
                """;
                Console.WriteLine(content);
            }
        }

        // ------ ConcreteFactory ------
        public class JapanPostFactory: Factory
        {
            public override PackingBox CreatePackingBox(DeliveryItemSize size){
                return new JapanPostPackingBox(size);

            }
            public override Delivery CreateDelivery(string contentName, PackingBox packingBox){
                return new JapanPostDelivery(contentName, packingBox);
            }
        }
    }
}