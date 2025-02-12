using System;

namespace BuilderPatternApp
{
    // Builderクラス
    public abstract class OnlineShoppingDetailBuilder
    {
        // プロパティ
        public string? PlatformName { get; set; }
        public DateOnly? PurchaseDate { get; set; }
        public string? ProductName { get; set; }
        public int? Price { get; set; }
        public bool? UsePoint { get; set; } = false;
        public string? PointName { get; set; }
        public int? ConsumedPoint { get; set; }

        // Builderメソッド
        public abstract void SetShopInfo();
        public abstract void SetPurchaseDate(DateOnly purchaseDate);
        public abstract void SetPurchaseInfo(string productName, int price);
        public abstract void SetPointInfo(int consumedPoint);

        // 作成したインスタンスの返却メソッド
        public abstract OnlineShoppingDetail GetResult();
    }
}