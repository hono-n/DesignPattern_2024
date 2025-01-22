using System;

namespace TemplateMethodPatternApp
{

    public class PRTemplate : AbstractDraftTemplate
    {
        public string Title { get; }
        public int IssueId { get; }

        public PRTemplate(string title, int issueId)
        {
            Title = title;
            IssueId = issueId;
        }

        protected override string DisplayTitle()
        {
            return $"【2割共有】{Title}";
        }

        protected override List<DraftContent> DisplayContent()
        {
            contents.Add(new DraftContent(3, "Issue", $"- #{IssueId}"));
            contents.Add(new DraftContent(3, "2割共有後TODO"));
            contents.Add(new DraftContent(3, "エビデンス"));
            contents.Add(new DraftContent(3, "備考"));
            return contents;
        }
    }
}