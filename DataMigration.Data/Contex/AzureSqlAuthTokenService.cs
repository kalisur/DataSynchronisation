using Microsoft.Azure.Services.AppAuthentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration.Data.Contex
{
    public class AzureSqlAuthTokenService
    {
        public async Task<string> GetToken()
        {
            AzureServiceTokenProvider provider = new AzureServiceTokenProvider();
            var token = await provider.GetAccessTokenAsync("https://database.windows.net/");

            return token;
        }
    }
}
