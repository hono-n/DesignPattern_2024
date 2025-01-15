using System;

namespace TemplateMethodPatternApp
{

    public class PRTemplate : AbstractDraftTemplate
    {
        public string Title { get; }
        public int IssueId { get; }

        public PRTemplate(string title, int issueId){
            Title = title;
            IssueId = issueId;
        }

        public override string DisplayTitle(){
            return $"【2割共有】{Title}";
        }

        public override string DisplayContent(){
            string content = $"""
            ### Issue
            - #{IssueId}

            ### 2割共有後TODO

            ### エビデンス

            ### 備考

            """;
            return content;
        }
    }
}