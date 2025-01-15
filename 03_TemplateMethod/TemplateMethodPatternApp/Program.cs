// See https://aka.ms/new-console-template for more information
using System;

namespace TemplateMethodPatternApp
{

    public class Program
    {
        public static void Main()
        {
            // PRテンプレートの表示
            AbstractDraftTemplate pr = new PRTemplate("危険箇所一覧にIDを表示", 3164);
            pr.ShowTemplate();

            Console.WriteLine();

            // TimesStartTemplate の表示
            AbstractDraftTemplate times_start = new TimesStartTemplate();
            times_start.ShowTemplate();
        }
    }
}