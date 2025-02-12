using System;
using System.IO.Pipelines;

namespace BuilderPatternApp
{

    public class OnlineShoppingDetail
    {
        string PlatformName { get; }
        DateOnly PurchaseDate { get; }
        string ProductName { get; }
        int Price { get; }
        bool UsePoint { get; }
        string? PointName { get; }
        int? ConsumedPoint { get; }

        public OnlineShoppingDetail(
            string platformName,
            DateOnly purchaseDate,
            string productName,
            int price,
            bool usePoint,
            string? pointName,
            int? consumedPoint)
        {
            this.PlatformName = platformName;
            this.PurchaseDate = purchaseDate;
            this.ProductName = productName;
            this.Price = price;
            this.UsePoint = usePoint;
            this.PointName = pointName;
            this.ConsumedPoint = consumedPoint;
        }

        public override String ToString()
        {
            string result = $"""
            プラットフォーム：{this.PlatformName}
            購入日：{this.PurchaseDate}
            商品名：{this.ProductName}
            価格：{this.Price}
            ポイント利用：{(this.UsePoint ? "あり" : "なし")}
            利用ポイント名：{this.PointName}
            消費ポイント数：{this.ConsumedPoint}
            実質消費金額：{this.CalcConsumedPrice()}
            """;
            return result;
        }


        public int CalcConsumedPrice()
        {
            int consumedPrice = this.Price;
            if (this.UsePoint)
            {
                consumedPrice = consumedPrice - (int)ConsumedPoint;
            }
            return consumedPrice;
        }

    }
}