using System;

namespace BridgePatternApp
{

    public abstract class Theme
    {
        public abstract string BackGroundColor();
        public abstract string TextBaseColor();
        public abstract string TextMutedColor();
        public abstract string BgScale01();
        public abstract string BgScale02();

    }

    public class LightTheme : Theme
    {
        public override string BackGroundColor()
        {
            return "#ffffff";
        }
        public override string TextBaseColor()
        {
            return "#000000";

        }
        public override string TextMutedColor()
        {
            return "#9b9b9b";
        }

        public override string BgScale01()
        {
            return "#e2e3e5";
        }

        public override string BgScale02()
        {
            return "d6d8d9";
        }
    }
    public class DarkTheme : Theme
    {
        public override string BackGroundColor()
        {
            return "#1b1e21";
        }
        public override string TextBaseColor()
        {
            return "#ffffff";

        }
        public override string TextMutedColor()
        {
            return "#e2e325";
        }

        public override string BgScale01()
        {
            return "#818182";
        }

        public override string BgScale02()
        {
            return "6c757d";
        }
    }
}