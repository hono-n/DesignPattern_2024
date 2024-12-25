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
            IIterator it = ZatsudanTopicList.Iterator();
            while (it.HasNext())
            {
                ZatsudanTopic zt = (ZatsudanTopic)it.Next();
                System.Console.WriteLine(zt);
            }
        }
    }
}
