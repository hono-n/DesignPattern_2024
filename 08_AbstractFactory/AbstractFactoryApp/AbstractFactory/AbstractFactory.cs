using System;
using AbstractFactoryApp;

namespace AbstractFactoryApp
{
    namespace AbstractFactory
    {
        // ====== AbstractProduct(1) ：梱包箱 =====
        public abstract class PackingBox
        {
            // プロパティ
            public DeliveryItemSize DeliveryItemSize { get; }
            public string? BoxType { get; set; }

            // コンストラクタ
            public PackingBox(DeliveryItemSize deliveryItemSize)
            {
                DeliveryItemSize = deliveryItemSize;
            }

            // 抽象メソッド
            public abstract void AssignBoxSize();
        }


        // ====== AbstractProduct(2)：配送 ======
        public abstract class Delivery {
            // プロパティ
            public string ContentName { get; }
            public PackingBox PackingBox { get; }

            // コンストラクタ
            public Delivery(string contentName, PackingBox packingBox){
                ContentName = contentName;
                PackingBox = packingBox;
            }

            // 抽象メソッド
            public abstract int CalcPrice();
            public abstract void Transport();
        }


        // ------ AbstractFactory ------
        public abstract class Factory {
            public static Factory GetFactory(string className){
                Factory factory = null;
                try {
                    var type = Type.GetType(className);
                    factory = (Factory) Activator.CreateInstance(type);
                } catch (Exception e) {
                    Console.WriteLine(e.ToString());
                }
                return factory;
            }
            // 抽象メソッド
            public abstract PackingBox CreatePackingBox(DeliveryItemSize size);
            public abstract Delivery CreateDelivery(string contentName, PackingBox packingBox);
        }
    }
}