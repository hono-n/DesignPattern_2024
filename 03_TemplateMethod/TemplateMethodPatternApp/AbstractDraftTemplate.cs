using System;

namespace TemplateMethodPatternApp
{

    public abstract class AbstractDraftTemplate
    {
        public abstract string DisplayTitle();
        public abstract string DisplayContent();

        public void ShowTemplate()
        {
            Console.WriteLine("----- タイトル ------");
            Console.WriteLine(DisplayTitle());
            Console.WriteLine("----- コンテンツ ------");
            Console.WriteLine(DisplayContent());
        }

    }
}