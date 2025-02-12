using System;

namespace BuilderPatternApp
{
    // ConcreteBuilderクラス（楽天市場バージョン）
    public class RakutenShoppingDetailBuilder : OnlineShoppingDetailBuilder
    {
        public override void SetShopInfo()
        {
            this.PlatformName = "楽天市場";
        }

        public override void SetPurchaseDate(DateOnly purchaseDate)
        {
            this.PurchaseDate = purchaseDate;
        }

        public override void SetPurchaseInfo(string productName, int price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public override void SetPointInfo(int consumedPoint)
        {
            this.UsePoint = true;
            this.PointName = "楽天ポイント";
            this.ConsumedPoint = consumedPoint;
        }

        public override OnlineShoppingDetail GetResult()
        {
            return new OnlineShoppingDetail(
                this.PlatformName,
                (DateOnly)this.PurchaseDate,
                this.ProductName,
                (int)this.Price,
                (bool)this.UsePoint,
                this.PointName,
                this.ConsumedPoint
            );
        }
    }

    // ConcreteBuilderクラス（Amazonバージョン）
    public class AmazonShoppingDetailBuilder : OnlineShoppingDetailBuilder
    {
        public override void SetShopInfo()
        {
            this.PlatformName = "Amazon";
        }

        public override void SetPurchaseDate(DateOnly purchaseDate)
        {
            this.PurchaseDate = purchaseDate;
        }

        public override void SetPurchaseInfo(string productName, int price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public override void SetPointInfo(int consumedPoint)
        {
            this.UsePoint = true;
            this.PointName = "Amazonギフトカード";
            this.ConsumedPoint = consumedPoint;
        }

        public override OnlineShoppingDetail GetResult()
        {
            return new OnlineShoppingDetail(
                this.PlatformName,
                (DateOnly)this.PurchaseDate,
                this.ProductName,
                (int)this.Price,
                (bool)this.UsePoint,
                this.PointName,
                this.ConsumedPoint
            );
        }
    }
}