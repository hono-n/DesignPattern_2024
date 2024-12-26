// See https://aka.ms/new-console-template for more information
using System;

namespace IteratorPatternApp
{

    public class Program
    {
        public static void Main()
        {
            ZatsudanTopicList ZatsudanTopicList = new ZatsudanTopicList();
            ZatsudanTopicList.AppendZatsudanTopic(new ZatsudanTopic("箕面散歩", "箕面を散歩してインテリアショップに行った"));
            ZatsudanTopicList.AppendZatsudanTopic(new ZatsudanTopic("つまみ細工", "母が送ってくれたつまみ細工キットで12月の花（深緋）を作った"));
            ZatsudanTopicList.AppendZatsudanTopic(new ZatsudanTopic("キッチンの引き出し", "2年間存在に気づかなかったキッチンの引き出し"));

            // インデックス2（「キッチンの引き出し」は雑談タイムで話したため、Consumedフラグを立てる
            ZatsudanTopicList.GetZatsudanTopicAt(2).MarkAsConsumed();

            System.Console.WriteLine("=== すべて ====");
            IIterator it = ZatsudanTopicList.Iterator();
            while (it.HasNext())
            {
                ZatsudanTopic zt = (ZatsudanTopic)it.Next();
                System.Console.WriteLine(zt);
            }

            System.Console.WriteLine("=== まだ話していないもののみ ====");
            IIterator available_it = ZatsudanTopicList.AvailableIterator();

            while (available_it.HasNext())
            {
                ZatsudanTopic zt = (ZatsudanTopic)available_it.Next();
                System.Console.WriteLine(zt);
            }
        }
    }
}
