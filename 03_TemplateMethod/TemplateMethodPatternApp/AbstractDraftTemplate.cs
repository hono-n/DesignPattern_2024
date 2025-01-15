using System;

namespace TemplateMethodPatternApp
{

    public abstract class AbstractDraftTemplate
    {
        protected abstract string DisplayTitle();
        protected abstract string DisplayContent();

        public void ShowTemplate()
        {
            Console.WriteLine("----- タイトル ------");
            Console.WriteLine(DisplayTitle());
            Console.WriteLine("----- コンテンツ ------");
            Console.WriteLine(DisplayContent());
        }

    }
}