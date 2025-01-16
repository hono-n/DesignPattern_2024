using System;

namespace TemplateMethodPatternApp
{

    public class DraftContent
    {
        public int HeaderLevel { get; }
        public string Header { get; }
        public string Body { get; }

        public DraftContent(int headerLevel, string header, string body = ""){
            HeaderLevel = headerLevel;
            Header = header;
            Body = body;
        }
    }
}