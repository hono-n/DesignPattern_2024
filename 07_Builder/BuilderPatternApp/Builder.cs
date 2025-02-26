using System;

namespace BuilderPatternApp
{
    // Builderクラス
    public abstract class OnlineShoppingDetailBuilder
    {
        // プロパティ
        public DateOnly? PurchaseDate { get; set; }
        public string? ProductName { get; set; }
        public int? Price { get; set; }
        public bool? UsePoint { get; set; } = false;
        public int? ConsumedPoint { get; set; }

        // Builderメソッド
        public abstract void SetPurchaseDate(DateOnly purchaseDate);
        public abstract void SetPurchaseInfo(string productName, int price);
        public abstract void SetConsumedPointInfo(int consumedPoint);
    }
}