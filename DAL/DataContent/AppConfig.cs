using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DAL.DataContent
{
    public class AppConfig
    {
        public AppConfig()
        {
            ///<summary>
            ///Използваме Този ConfigurationBuilder 
            ///за да извлечем connection string от appsettings, 
            ///който connection string ни е нужен 
            ///за да осъществим връзка с датабазата
            /// </summary>

            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            string path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            IConfigurationRoot root = configurationBuilder.Build();
            IConfigurationSection appSettings = root.GetSection("ConnectionStrings:DefaultConnection");
            SqlConnectionString = appSettings.Value;



        }

        public string SqlConnectionString { get; set; }

    }
}
