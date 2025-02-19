using System;
using AbstractFactoryApp.AbstractFactory;

namespace AbstractFactoryApp
{
    public abstract class Program
    {
        public static void Main()
        {
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

            Console.WriteLine("配送業者はどちらにしますか？【1: クロネコヤマト, 2: 日本郵便】");
            input = Console.ReadLine();
            int company = int.Parse(input);

            Console.WriteLine("品名を入力してください");
            string contentName = Console.ReadLine();

            string className = company == 1 ? "AbstractFactoryApp.YamatoFactory.YamatoFactory" : "AbstractFactoryApp.JapanPostFactory.JapanPostFactory";
            Factory factory = Factory.GetFactory(className);
            PackingBox box = factory.CreatePackingBox(new DeliveryItemSize(length_1, length_2, length_3));
            box.AssignBoxSize();
            Delivery delivery = factory.CreateDelivery(contentName, box);
            delivery.Transport();
        }
    }

    // 商品の大きさを表すクラス
    public class DeliveryItemSize
    {
        public int LengthS { get; }
        public int LengthM { get; }
        public int LengthL { get; }

        // コンストラクタ
        public DeliveryItemSize(int length1, int length2, int length3)
        {
            int[] sizes = [length1, length2, length3];
            Array.Sort(sizes);
            LengthS = sizes[0];
            LengthM = sizes[1];
            LengthL = sizes[2];
        }

    }
}