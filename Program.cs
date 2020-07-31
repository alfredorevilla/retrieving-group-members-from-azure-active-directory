using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Microsoft.Graph;

namespace retrieving_group_members_from_azure_active_directory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private static async Task MainAsync(string[] args)
        {
            var tokenProvider = new DefaultAzureCredential(true);

            var client = new GraphServiceClient(
                new DelegateAuthenticationProvider(async context =>
                {
                    var token = (await tokenProvider.GetTokenAsync(new TokenRequestContext(new[] { "https://graph.microsoft.com/.default" }))).Token;
                    context.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                }));

            var groups = await client.Groups.Request().Top(5).Expand("members").GetAsync();

            foreach (var item in groups)
            {
                Console.WriteLine($"Group {item.Id} member count: {item.Members.Count}");
            }
        }
    }
}