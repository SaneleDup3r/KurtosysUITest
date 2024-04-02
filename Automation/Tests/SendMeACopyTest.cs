using Automation.Tests.Setup;
using NUnit.Framework;
using Automation.Pages;

namespace Automation.Tests
{
    [Parallelizable(ParallelScope.All)]
    public class SendMeACopyTest : BasePageTest
    {
        [Test(Description = "Send me a copy"), Retry(2)]
        public async Task SendMeACopyAsync()
        {
            string firstName = "Sanele";
            string lastName = "Gwiji";
            string company = "Kurtosys";
            string industry = "IT";

            //Navigating to White Papers & eBooks
            var menuNavigation = new MenuNavigation(Page);
            await menuNavigation.ClickOnWhitePaperAndEBookAsync();

            //Verifying that Title reads “White Papers”
            await Expect(Page).ToHaveTitleAsync("White Papers | Kurtosys");

            //Navigating to UCITS Whitepaper
            var whitePaperMenuPage = new WhitePaperMenuPage(Page);
            await whitePaperMenuPage.ClickOnAWhitePaperAsync();

            //Navigating to IFrame that contains input fields
            await Page.GotoAsync("https://www2.kurtosys.com/l/18882/2020-06-04/bx16sd");

            //Fill in form
            var whitePaperPage = new WhitePaperPage(Page);
            await whitePaperPage.EnterFirstNameAsync(firstName);
            await whitePaperPage.EnterLastNameAsync(lastName);
            await whitePaperPage.EnterCompanyAsync(company);
            await whitePaperPage.EnterIndustryAsync(industry);
            await whitePaperPage.ClickOnSendMeACopyAsync();

            await Page.ScreenshotAsync(new()
            {
                Path = "Error.png",
            });

            var getError = await whitePaperPage.GetValidationTextAsync();
            Assert.That(getError, Is.EqualTo("This field is required."));
        }
    }
                
}
