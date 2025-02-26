using System;

namespace BuilderPatternApp
{
    // ConcreteBuilderクラス（楽天市場バージョン）
    public class RakutenShoppingDetailBuilder : OnlineShoppingDetailBuilder
    {
        private int EarnedRakutenPoint { get; set; }

        public override void SetPurchaseDate(DateOnly purchaseDate)
        {
            this.PurchaseDate = purchaseDate;
        }

        public override void SetPurchaseInfo(string productName, int price)
        {
            this.ProductName = productName;
            this.Price = price;
            this.EarnedRakutenPoint = CalcEarnedRakutenPoint();
        }

        public override void SetConsumedPointInfo(int consumedPoint)
        {
            this.UsePoint = true;
            this.ConsumedPoint = consumedPoint;
        }

        private int CalcEarnedRakutenPoint(){
            return (int) Math.Round((decimal)(Price * 0.03));
        }

        public RakutenShoppingDetail GetResult()
        {
            return new RakutenShoppingDetail(
                (DateOnly)this.PurchaseDate,
                this.ProductName,
                (int)this.Price,
                (bool)this.UsePoint,
                this.ConsumedPoint,
                this.EarnedRakutenPoint
            );
        }
    }

    // ConcreteBuilderクラス（Amazonバージョン）
    public class AmazonShoppingDetailBuilder : OnlineShoppingDetailBuilder
    {

        public override void SetPurchaseDate(DateOnly purchaseDate)
        {
            this.PurchaseDate = purchaseDate;
        }

        public override void SetPurchaseInfo(string productName, int price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public override void SetConsumedPointInfo(int consumedPoint)
        {
            this.ConsumedPoint = consumedPoint;
        }

        public AmazonShoppingDetail GetResult()
        {
            return new AmazonShoppingDetail(
                (DateOnly)this.PurchaseDate,
                this.ProductName,
                (int)this.Price,
                this.ConsumedPoint
            );
        }
    }
}