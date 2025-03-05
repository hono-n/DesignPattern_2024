using System;

namespace BridgePatternApp
{

    public abstract class Program
    {
        public static void Main()
        {
            NoteViewer noteViewer_light = new NoteViewer(new LightTheme());
            noteViewer_light.DisplayText("普通の文章");
            noteViewer_light.DisplayCaption("キャプション的な文章");

            Console.WriteLine("=======================");

            NoteViewer noteViewer_dark = new NoteViewer(new DarkTheme());
            noteViewer_dark.DisplayText("普通の文章");
            noteViewer_dark.DisplayCaption("キャプション的な文章");

            Console.WriteLine("=======================");

            AdvancedNoteViewer advanced_light = new AdvancedNoteViewer(new LightTheme());
            advanced_light.DisplayText("普通の文章");
            advanced_light.DisplayCaption("キャプション的な文章");
            advanced_light.DisplayTextWithHilight("強調したい文章");
        }
    }
}