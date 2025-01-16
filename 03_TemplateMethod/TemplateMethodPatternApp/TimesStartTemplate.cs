using System;

namespace TemplateMethodPatternApp
{

    public class TimesStartTemplate : AbstractDraftTemplate
    {
        public DateOnly Date { get; }

        public TimesStartTemplate()
        {
            Date = DateOnly.FromDateTime(DateTime.Now);
        }


        protected override string DisplayTitle()
        {
            return $"{Date} 日報";
        }

        protected override List<DraftContent> DisplayContent()
        {
            contents.Add(new DraftContent(4, "本日の予定"));
            contents.Add(new DraftContent(4, "意識する課題"));
            return contents;
        }
    }
}