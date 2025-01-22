using System;
using System.Collections;
using FactoryMethodPatternApp.Framework;

namespace FactoryMethodPatternApp.DeliveryCompany
{

    // ConcreteProduct役
    public class JapanPost : Delivery
    {
        int Height{ get; }
        int Width {get; }
        int Thickness { get; }

        int TotalLength { get; set;}
        int LongSideLength { get; set; }

        internal JapanPost(int size_1, int size_2, int size_3){
            int[] sizes = [size_1, size_2, size_3];
            Array.Sort(sizes);

            LongSideLength = sizes[2];
            Height = sizes[2];
            Width = sizes[1];
            Thickness = sizes[0];
            TotalLength = Height + Width + Thickness;
        }


        public override void AssignPlan(){
            if (TotalLength <= 60 && LongSideLength <= 34 && Thickness <= 3){
                Plan = "ゆうぱけっと";
            } else if (Height <= 24 && Width <= 17 && Thickness <= 7){
                Plan = "ゆうパケットプラス";
            } else {
                Plan = "ゆうパック";
            }
        }
        public override void CalcPrice(){
            switch (Plan){
                case "ゆうぱけっと":
                    Price = 215;
                    break;
                case "ゆうパケットプラス":
                    Price = 450;
                    break;
                case "ゆうパック":
                    Price = 750;
                    break;
            }
        }
    }

    // ConcreteCreator役
    public class JapanPostFactory : DeliveryFactory{

        protected override Delivery CreateDelivery(int size_1, int size_2, int size_3){
            Delivery delivery = new JapanPost(size_1, size_2, size_3);
            return delivery;
        }
    }
}