using System;
using System.IO.Pipelines;

namespace BuilderPatternApp
{

    public class RakutenShoppingDetail
    {
        DateOnly PurchaseDate { get; }
        string ProductName { get; }
        int Price { get; }
        bool UseRakutenPoint { get; }
        int? ConsumedRakutenPoint { get; }
        int EarnedRakutenPoint { get; }

        public RakutenShoppingDetail(
            DateOnly purchaseDate,
            string productName,
            int price,
            bool useRakutenPoint,
            int? consumedRakutenPoint,
            int EarnedRakutenPoint)
        {
            this.PurchaseDate = purchaseDate;
            this.ProductName = productName;
            this.Price = price;
            this.UseRakutenPoint = useRakutenPoint;
            this.ConsumedRakutenPoint = consumedRakutenPoint;
            this.EarnedRakutenPoint = EarnedRakutenPoint;
        }

        public override String ToString()
        {
            string result = $"""
            プラットフォーム：楽天市場
            購入日：{this.PurchaseDate}
            商品名：{this.ProductName}
            価格：{this.Price}
            楽天ポイント利用：{(this.UseRakutenPoint ? "あり" : "なし")}
            消費ポイント数：{this.ConsumedRakutenPoint}
            実質消費金額：{this.CalcConsumedPrice()}
            獲得ポイント数：{this.EarnedRakutenPoint}
            """;
            return result;
        }


        public int CalcConsumedPrice()
        {
            int consumedPrice = this.Price;
            if (this.UseRakutenPoint)
            {
                consumedPrice = consumedPrice - (int)ConsumedRakutenPoint;
            }
            return consumedPrice;
        }

    }

    public class AmazonShoppingDetail
    {
        DateOnly PurchaseDate { get; }
        string ProductName { get; }
        int Price { get; }
        int? ConsumedGiftCardPrice { get; }

        public AmazonShoppingDetail(
            DateOnly purchaseDate,
            string productName,
            int price,
            int? consumedGiftCardPrice)
        {
            this.PurchaseDate = purchaseDate;
            this.ProductName = productName;
            this.Price = price;
            this.ConsumedGiftCardPrice = consumedGiftCardPrice;
        }

        public override String ToString()
        {
            string result = $"""
            プラットフォーム：Amazon
            購入日：{this.PurchaseDate}
            商品名：{this.ProductName}
            価格：{this.Price}
            消費ギフトカード額：{this.ConsumedGiftCardPrice}
            実質消費金額：{this.CalcConsumedPrice()}
            """;
            return result;
        }


        public int CalcConsumedPrice()
        {
            int consumedPrice = this.Price;
            if (this.ConsumedGiftCardPrice != null)
            {
                consumedPrice = consumedPrice - (int)ConsumedGiftCardPrice;
            }
            return consumedPrice;
        }

    }
}