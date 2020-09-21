using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net.Http;


namespace Infrastructure.Repositories
{
    public class BaseRepository
    {
        public string connectionString;

        public IConfigurationRoot configuration { get; set; }

        public string UrlConnection()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                return configuration.GetConnectionString("Connection");
        }

        public string ApiKey()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration.GetSection("ApiKey").Value;
        }

        protected static HttpClient HttpRequest()
        {
            return HttpClientFactory.Create();
        }
    }
}
