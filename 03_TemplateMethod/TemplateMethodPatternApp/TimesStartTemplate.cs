using System;

namespace TemplateMethodPatternApp
{

    public class TimesStartTemplate : AbstractDraftTemplate
    {
        public DateOnly Date {get; }

        public TimesStartTemplate(){
            Date = DateOnly.FromDateTime(DateTime.Now);
        }


        public override string DisplayTitle(){
            return $"{Date} 日報";
        }

        public override string DisplayContent(){
            string content = $"""
            ### 本日の予定

            ### 意識する課題

            """;
            return content;
        }
    }
}