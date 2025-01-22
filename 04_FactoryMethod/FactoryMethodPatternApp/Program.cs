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
            // ---- ライブラリを使っているイメージ -----
            DeliveryFactory factory_yamato = new YamatoFactory();
            DeliveryFactory factory_jp = new JapanPostFactory();

            // ---- アプリ側のコード -----
            // 12 * 20 * 6 の荷物
            Delivery yamato_1 = factory_yamato.Create(12, 20, 6);
            Delivery jp_1 = factory_jp.Create(12, 20, 6);

            yamato_1.AssignPlan();
            yamato_1.CalcPrice();

            jp_1.AssignPlan();
            jp_1.CalcPrice();

            Console.WriteLine("===== 12 * 20 * 6 の荷物 ======");
            Console.WriteLine($"【ヤマト】プラン：{yamato_1.Plan}（{yamato_1.Price}円）");
            Console.WriteLine($"【日本郵便】プラン：{jp_1.Plan}（{jp_1.Price}円）");


            // 5 * 6 * 2 の荷物
            Delivery yamato_2 = factory_yamato.Create(5, 6, 2);
            Delivery jp_2 = factory_jp.Create(5, 6, 2);

            yamato_2.AssignPlan();
            yamato_2.CalcPrice();

            jp_2.AssignPlan();
            jp_2.CalcPrice();

            Console.WriteLine("===== 5 * 6 * 2 の荷物 =====");
            Console.WriteLine($"【ヤマト】プラン：{yamato_2.Plan}（{yamato_2.Price}円）");
            Console.WriteLine($"【日本郵便】プラン：{jp_2.Plan}（{jp_2.Price}円）");
        }
    }
}