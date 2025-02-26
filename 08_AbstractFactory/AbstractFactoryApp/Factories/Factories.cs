using System;
using AbstractFactoryApp.AbstractFactory;
using AbstractFactoryApp.JapanPostFactory;
using AbstractFactoryApp.YamatoFactory;

namespace AbstractFactoryApp
{
    namespace Factories
    {
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