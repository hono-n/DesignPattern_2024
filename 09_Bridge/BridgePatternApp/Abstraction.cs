using System;

namespace BridgePatternApp
{
    public class NoteViewer
    {
        protected Theme Theme { get; }

        // コンストラクタ
        public NoteViewer(Theme theme)
        {
            Theme = theme;
            SetBackGroundColor();
        }

        // メソッド
        private void SetBackGroundColor()
        {
            Console.WriteLine($"【{GetType().Name} / {Theme.GetType().Name}】背景色を{Theme.BackGroundColor()}に設定しました");
        }

        public void DisplayText(string text){
            Console.WriteLine($"表示するテキスト：「{text}」（フォント色：{Theme.TextBaseColor()}）");
        }

        public void DisplayCaption(string text){
            Console.WriteLine($"表示するテキスト：「{text}」（フォント色：{Theme.TextMutedColor()}）");
        }
    }

    public class AdvancedNoteViewer: NoteViewer
    {
        // コンストラクタ
        public AdvancedNoteViewer(Theme theme): base(theme){}

        // 拡張メソッド
        public void DisplayTextWithHilight(string text){
            Console.WriteLine($"表示するテキスト：「{text}」（フォント色：{Theme.TextMutedColor()}／背景色：{Theme.BgScale01()}）");
        }
    }
}