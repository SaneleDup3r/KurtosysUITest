using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace Automation.Tests.Setup
{
    public class BasePageTest : PageTest
    {
        [SetUp]
        public async Task SetupAsync()
        {
            await Page.GotoAsync(TestContext.Parameters["AppUrl"]);
        }
    }
}
