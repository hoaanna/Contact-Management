namespace CNPM_FINAL.Context
{
    public class SettingContext
    {
        private static string language = "en";
        public static string Language
        {
            get { return language; }
            set
            {
                if (value != "en" && value != "vi")
                {
                    language = "en";
                    return;
                }

                language = value;
            }
        }
    }
}
