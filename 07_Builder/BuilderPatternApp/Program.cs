using System;

namespace BuilderPatternApp
{

    public abstract class Program
    {
        public static void Main()
        {
            RakutenShoppingDetailBuilder r_builder = new RakutenShoppingDetailBuilder();
            AmazonShoppingDetailBuilder a_builder = new AmazonShoppingDetailBuilder();

            OnlineShoppingDeetailDirector r_director = new OnlineShoppingDeetailDirector(r_builder);
            OnlineShoppingDeetailDirector a_director = new OnlineShoppingDeetailDirector(a_builder);

            Console.WriteLine("=============================");

            r_director.ConstructTodayWithoutPoint("バッグインバッグ", 2380);
            RakutenShoppingDetail bag_in_bag_detail = r_builder.GetResult();
            Console.WriteLine(bag_in_bag_detail.ToString());

            Console.WriteLine("=============================");

            r_director.ConstructTodayWithoutPoint("トラベルメイクポーチ", 2930);
            RakutenShoppingDetail travel_pouch_detail = r_builder.GetResult();
            Console.WriteLine(travel_pouch_detail.ToString());

            Console.WriteLine("=============================");

            r_director.ConstructTodayWithPoint("キッチンマット", 2580, 580);
            RakutenShoppingDetail kitchen_mat_detail = r_builder.GetResult();
            Console.WriteLine(kitchen_mat_detail.ToString());

            Console.WriteLine("=============================");

            a_director.ConstructTodayWithoutPoint("コロコロ本体L", 3290);
            AmazonShoppingDetail korokoro_detail = a_builder.GetResult();
            Console.WriteLine(korokoro_detail.ToString());

            Console.WriteLine("=============================");

            a_director.ConstructTodayWithPoint("Caroteフライパンセット", 3480, 480);
            AmazonShoppingDetail carote_detail = a_builder.GetResult();
            Console.WriteLine(carote_detail.ToString());
        }
    }
}