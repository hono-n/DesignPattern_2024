using System;

namespace TemplateMethodPatternApp
{

    public abstract class AbstractDraftTemplate
    {
        protected abstract string DisplayTitle();
        protected abstract List<DraftContent> DisplayContent();

        protected List<DraftContent> contents = new List<DraftContent>();

        public void ShowTemplate()
        {
            Console.WriteLine("----- タイトル ------");
            Console.WriteLine(DisplayTitle());

            List<DraftContent> conents = DisplayContent();
            Console.WriteLine("----- コンテンツ ------");
            foreach(DraftContent content in conents){
                string markdown = new string('#', content.HeaderLevel);
                Console.WriteLine($"{markdown} {content.Header}");
                Console.WriteLine($"{content.Body}");
                Console.WriteLine();
            }
        }

    }
}