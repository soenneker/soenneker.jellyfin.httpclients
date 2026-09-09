using Soenneker.Jellyfin.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Jellyfin.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class JellyfinOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IJellyfinOpenApiHttpClient _httpclient;

    public JellyfinOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IJellyfinOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
