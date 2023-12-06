using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace FilePermissionCheck.Pages;

public class Index_Tests : FilePermissionCheckWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
