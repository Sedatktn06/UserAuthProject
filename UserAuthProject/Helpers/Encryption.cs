using NETCore.Encrypt.Extensions;

namespace UserAuthProject.Helpers
{
    public static class Encryption
    {
        private static IConfiguration config;
        public static IConfiguration Configuration
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                config = builder.Build();
                return config;
            }
        }

        public static string md5Salt = Configuration.GetValue<string>("AppSettings:MD5Salt");
        public static string Encrypt(string password)
        {
            string saltedPassword = password + md5Salt;
            string hashedPassword = saltedPassword.MD5();

            return hashedPassword;
        }
    }
}
