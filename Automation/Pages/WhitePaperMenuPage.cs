using Microsoft.Playwright;

namespace Automation.Pages
{
    public class WhitePaperMenuPage
    {
        private readonly IPage _page;
        private readonly ILocator _whitePaper;

        public WhitePaperMenuPage(IPage page)
        {
            _page = page;
            _whitePaper = _page.Locator("//a[contains(text(),'UCITS White Paper')]");
        }

        public async Task ClickOnAWhitePaperAsync()
            => await _whitePaper.ClickAsync();

    }
}
