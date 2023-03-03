namespace Cobra.Tests.Api;

using Cobra;
using Cobra.Api.Node.Cirrus;

public class CirrusNodeApiTests
{
    Client client = new Client("http://localhost:37223/", Runtime.HttpClient);
    
    [Fact]
    public void CanCallWalletApiMethods()
    {
        var b = client.ListWalletsAsync().Result;
        Assert.NotNull(b);
    }
}
