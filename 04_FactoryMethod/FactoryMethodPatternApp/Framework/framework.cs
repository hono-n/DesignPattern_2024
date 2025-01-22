using System;

namespace FactoryMethodPatternApp.Framework
{

    // Product役
    public abstract class Delivery
    {
        public string? Plan { get; set; }
        public int? Price { get; set; }
        public abstract void AssignPlan();
        public abstract void CalcPrice();
    }



    // Creator役
    public abstract class DeliveryFactory
    {
        public Delivery Create(int size_1, int size_2, int size_3){
            Delivery delivery = CreateDelivery(size_1, size_2, size_3);
            return delivery;
        }

        protected abstract Delivery CreateDelivery(int size_1, int size_2, int size_3);
    }
}