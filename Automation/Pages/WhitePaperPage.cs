using Microsoft.Playwright;

namespace Automation.Pages
{
    public class WhitePaperPage
    {
        private readonly IPage _page;
        private readonly ILocator _firstName;
        private readonly ILocator _lastName;
        private readonly ILocator _company;
        private readonly ILocator _industry;
        private readonly ILocator _sendMeACopyBtn;
        private readonly ILocator _validation;


        public WhitePaperPage(IPage page)
        {
            _page = page;
            _firstName = _page.Locator("//input[@id='18882_231669pi_18882_231669']");
            _lastName = _page.Locator("//input[@id='18882_231671pi_18882_231671']");
            _company = _page.Locator("//input[@id='18882_231675pi_18882_231675']");
            _industry = _page.Locator("//input[@id='18882_231677pi_18882_231677']");
            _sendMeACopyBtn = _page.Locator("//input[@value='Send me a copy']");
            _validation = _page.Locator("(//input[@id='18882_231673pi_18882_231673']//following::p)[1]");
        }

        public async Task EnterFirstNameAsync(string fName)
            => await _firstName.FillAsync(fName);

        public async Task EnterLastNameAsync(string lName)
            => await _lastName.FillAsync(lName);

        public async Task EnterCompanyAsync(string companyName)
            => await _company.FillAsync(companyName);

        public async Task EnterIndustryAsync(string industryName)
            => await _industry.FillAsync(industryName);

        public async Task ClickOnSendMeACopyAsync()
            => await _sendMeACopyBtn.ClickAsync();

        public async Task<string> GetValidationTextAsync()
            => await _validation.InnerTextAsync();

    }
}
