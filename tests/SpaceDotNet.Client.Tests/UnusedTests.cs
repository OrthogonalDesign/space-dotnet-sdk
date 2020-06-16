using System.Net.Http;
using System.Threading.Tasks;
using SpaceDotNet.Client.TDMemberProfileDtoExtensions;
using SpaceDotNet.Client.TDProfileNameDtoExtensions;
using SpaceDotNet.Common;
using Xunit;

namespace SpaceDotNet.Client.Tests
{
    public class UnusedTests
    {
        [Fact(Skip = "Skipped as it has no use yet.")]
        public async Task UnusedTestAsync()
        {
            var connection = new ClientCredentialsConnection(
                "TODO",
                "TODO",
                "TODO",
                new HttpClient());

            var teamDirectoryClient = new TeamDirectoryClient(connection);

            // ReSharper disable once UnusedVariable
            var memberProfile = await teamDirectoryClient.Profiles.GetProfileByUsernameAsync("Heather.Stewart", partial => partial
                .WithAllFieldsWildcard() // Include all first-level fields
                .WithManagers(manager => manager
                    .WithId()
                    .WithUsername()
                    .WithName(name => name
                        .WithFirstName()
                        .WithLastName())));
        }
    }
}