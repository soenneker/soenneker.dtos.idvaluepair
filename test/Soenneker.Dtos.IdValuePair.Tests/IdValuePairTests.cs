using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.IdValuePair.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class IdValuePairTests : HostedUnitTest
{

    public IdValuePairTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
