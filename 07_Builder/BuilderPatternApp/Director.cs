using System;

namespace BuilderPatternApp
{
    // Directorクラス
    public class OnlineShoppingDeetailDirector
    {
        // プロパティ
        OnlineShoppingDetailBuilder Builder { get; }

        public OnlineShoppingDeetailDirector(OnlineShoppingDetailBuilder builder)
        {
            this.Builder = builder;
        }

        public void ConstructTodayWithoutPoint(string productName, int price){
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            Builder.SetPurchaseDate(today);
            Builder.SetPurchaseInfo(productName, price);
        }

        public void ConstructTodayWithPoint(string productName, int price, int consumedPoint){
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            this.ConstructTodayWithoutPoint(productName, price);
            Builder.SetConsumedPointInfo(consumedPoint);
        }

    }
}