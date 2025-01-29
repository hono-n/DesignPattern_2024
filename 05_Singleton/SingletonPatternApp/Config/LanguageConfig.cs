using System;

namespace SingletonPatternApp
{
    namespace Config
    {
        class LanguageConfig
        {
            private static readonly LanguageConfig _languageConfig = new LanguageConfig();

            public string? CurrentLanguage { get; private set; }

            // コンストラクタ
            private LanguageConfig(){}

            // インスタンス取得
            public static LanguageConfig GetInstance()
            {
                return _languageConfig;
            }

            public void SetToJa()
            {
                CurrentLanguage = "Ja";
            }

            public void SetToEn()
            {
                CurrentLanguage = "En";
            }
        }
    }

}