using System;
using System.Collections;
using FactoryMethodPatternApp.Framework;

namespace FactoryMethodPatternApp.DeliveryCompany
{

    // ConcreteProduct役
    public class Yamato : Delivery
    {

        int Height { get; }
        int Width { get; }
        int Thickness { get; }


        internal Yamato(int height, int width, int thickness)
        {
            CompanyName = "クロネコヤマト";
            Height = height;
            Width = width;
            Thickness = thickness;
        }

        public override void AssignPlan()
        {
            if (Height <= 31 && Width <= 23 && Thickness <= 3)
            {
                Plan = "ネコポス";
            }
            else if (Height <= 31 && Width <= 25 && Thickness <= 5)
            {
                Plan = "宅急便コンパクト";
            }
            else
            {
                Plan = "宅急便";
            }
        }
        public override void CalcPrice()
        {
            switch (Plan)
            {
                case "ネコポス":
                    Price = 210;
                    break;
                case "宅急便コンパクト":
                    Price = 450;
                    break;
                case "宅急便":
                    Price = 750;
                    break;
            }
        }
    }



    // ConcreteCreator役
    public class YamatoFactory : DeliveryFactory
    {

        protected override Delivery CreateDelivery(int size_1, int size_2, int size_3)
        {
            int[] sizes = [size_1, size_2, size_3];
            Array.Sort(sizes);

            Delivery delivery = new Yamato(sizes[2], sizes[1], sizes[0]);
            return delivery;
        }
    }
}