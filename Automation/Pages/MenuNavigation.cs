using Microsoft.Playwright;

namespace Automation.Pages
{
    public class MenuNavigation
    {
        private readonly IPage _page;
        private readonly ILocator _whitePapersAndeBooks;

        public MenuNavigation(IPage page)
        {
            _page = page;
            _whitePapersAndeBooks = _page.Locator("(//a//span[contains(text(),'White Papers & eBooks')])[3]");
        }
        
        public async Task ClickOnWhitePaperAndEBookAsync()
            => await _whitePapersAndeBooks.ClickAsync();
    }
}
