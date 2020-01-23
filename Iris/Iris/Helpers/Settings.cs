namespace Pedidos.Helpers
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;
    public static class Settings
    {
        static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }
        const string token = "Token";
        const string tokenType = "TokenType";
        static readonly string stringDefaul = string.Empty;

        public static string Token
        {
            get
            {
                return AppSettings.GetValueOrDefault(token, stringDefaul);
            }
            set
            {
                AppSettings.AddOrUpdateValue(token, value);
            }
        }
        public static string TokenType
        {
            get
            {
                return AppSettings.GetValueOrDefault(tokenType, stringDefaul);
            }
            set
            {
                AppSettings.AddOrUpdateValue(tokenType, value);
            }
        }
    }
}
