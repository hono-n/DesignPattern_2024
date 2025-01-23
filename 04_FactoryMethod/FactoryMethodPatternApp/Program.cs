using System;
using FactoryMethodPatternApp.Framework;
using FactoryMethodPatternApp.DeliveryCompany;

namespace FactoryMethodPatternApp
{

    // Product役
    public abstract class Program
    {
        public static void Main()
        {
            // ---- ライブラリの機能を使う -----
            DeliveryFactory factory_yamato = new YamatoFactory();
            DeliveryFactory factory_jp = new JapanPostFactory();

            // ---- アプリ側の業務ロジック -----
            Console.WriteLine("送りたい荷物の3辺の長さを順に入力してください");
            Console.WriteLine("1辺目: ");
            string? input = Console.ReadLine();
            int length_1 = int.Parse(input);

            Console.WriteLine("2辺目: ");
            input = Console.ReadLine();
            int length_2 = int.Parse(input);

            Console.WriteLine("3辺目: ");
            input = Console.ReadLine();
            int length_3 = int.Parse(input);

            Console.WriteLine("ありがとうございました。クロネコヤマトと日本郵便で比較します。");

            Delivery yamato_1 = factory_yamato.Create(length_1, length_2, length_3);
            Delivery jp_1 = factory_jp.Create(length_1, length_2, length_3);

            // フレームワークの機能を使う
            CompareDeliveries.Report(new List<Delivery>{yamato_1, jp_1});
        }
    }
}