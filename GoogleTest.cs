using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

public class GoogleTest : IDisposable {
    IWebDriver driver;
    public GoogleTest() {
        driver = new ChromeDriver();
    }

    public void Dispose() {
        if (driver != null) {
            driver.Quit();
        }
    }

    [Fact]
    public void Access_Google_OpenGoogle() {
        Console.WriteLine("Teste 1: Simples acesso ao site do Google");
        
        // Arrange: Definição do domínio
        var googleUrl = new String("https://www.google.com.br");

        // Act: Acesso ao site do Google
        driver.Navigate().GoToUrl(googleUrl);

        // Assert: Google está contido no título da página
        Assert.Contains("Google", driver.Title);
    }

    [Fact]
    public void Search_DogImages_ShowDogImages() {
        Console.WriteLine("Teste 2: Busca por imagens de cachorros");

        // Arrange
        var googleUrl = new String("https://www.google.com.br");
        var assertPageTitle = new String("Imagens de cachorros");
        var searchTerm = new String("Imagens de cachorro");
        var googleSection = new String("Imagens");

        // Act:
        // Acesso ao site do Google
        driver.Navigate().GoToUrl(googleUrl);

        // Insere o termo de busca no campo de pesquisa
        driver.FindElement(By.Name("q")).SendKeys(searchTerm);

        // Aciona a busca
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        // Clique na aba de imagens
        driver.FindElement(By.LinkText(googleSection)).Click();

        // Assert
        Assert.Contains(assertPageTitle, driver.Title);
    }

    [Fact]
    public void Search_Stock_ShowStockDetails() {
        Console.WriteLine("Teste 3: Busca por ação do Itaú");

        // Arrange
        var googleUrl = new String("https://www.google.com.br");
        var assertPageTitle = new String("Itaú Unibanco");
        var searchTerm = new String("ITUB4");
        var googleSection = new String("Finanças");

        // Act:
        // Acesso ao site do Google
        driver.Navigate().GoToUrl(googleUrl);

        // Insere o termo de busca no campo de pesquisa
        driver.FindElement(By.Name("q")).SendKeys(searchTerm);

        // Aciona a busca
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        // Clique na aba de finanças
        driver.FindElement(By.LinkText(googleSection)).Click();

        // Assert
        Assert.Contains(assertPageTitle, driver.Title);
    }

    [Fact]
    public void Search_BrazilNews_ShowPopularNews() {
        Console.WriteLine("Teste 4: Busca por notícias do Brasil");

        // Arrange
        var googleUrl = new String("https://www.google.com.br");
        var assertPageTitle = new String("Notícias Brasil");
        var searchTerm = new String("Notícias Brasil");
        var googleSection = new String("Notícias");

        // Act:
        // Acesso ao site do Google
        driver.Navigate().GoToUrl(googleUrl);

        // Insere o termo de busca no campo de pesquisa
        driver.FindElement(By.Name("q")).SendKeys(searchTerm);

        // Aciona a busca
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        // Clique na aba de notícias
        driver.FindElement(By.LinkText(googleSection)).Click();

        // Assert
        Assert.Contains(assertPageTitle, driver.Title);
    }

    [Fact]
    public void Search_Lyrics_ShowSongLyrics() {
        Console.WriteLine("Teste 5: Busca por letra de música");

        // Arrange
        var googleUrl = new String("https://www.google.com.br");
        var assertPageTitle = new String("Letra de john mayer neon");
        var searchTerm = new String("Letra de john mayer neon");

        // Act:
        // Acesso ao site do Google
        driver.Navigate().GoToUrl(googleUrl);

        // Insere o termo de busca no campo de pesquisa
        driver.FindElement(By.Name("q")).SendKeys(searchTerm);

        // Aciona a busca
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        // Assert
        Assert.Contains(assertPageTitle, driver.Title);
    }

    [Fact]
    public void Search_CountryAge_ShowCountryAge() {
        Console.WriteLine("Teste 6: Busca pela idade do Brasil");

        // Arrange
        var googleUrl = new String("https://www.google.com.br");
        var assertPageTitle = new String("Idade do Brasil");
        var searchTerm = new String("Idade do Brasil");

        // Act:
        // Acesso ao site do Google
        driver.Navigate().GoToUrl(googleUrl);

        // Insere o termo de busca no campo de pesquisa
        driver.FindElement(By.Name("q")).SendKeys(searchTerm);

        // Aciona a busca
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        // Assert
        Assert.Contains(assertPageTitle, driver.Title);
    }

    [Fact]
    public void Search_Weather_ShowWheaterInfo() {
        Console.WriteLine("Teste 7: Busca pelo clima do RJ");

        // Arrange
        var googleUrl = new String("https://www.google.com.br");
        var assertPageTitle = new String("Tempo rio de janeiro");
        var searchTerm = new String("Tempo rio de janeiro");

        // Act:
        // Acesso ao site do Google
        driver.Navigate().GoToUrl(googleUrl);

        // Insere o termo de busca no campo de pesquisa
        driver.FindElement(By.Name("q")).SendKeys(searchTerm);

        // Aciona a busca
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        // Assert
        Assert.Contains(assertPageTitle, driver.Title);
    }

    [Fact]
    public void Search_Pizzarias_ShowNearPizzarias() {
        Console.WriteLine("Teste 8: Busca por pizzarias");

        // Arrange
        var googleUrl = new String("https://www.google.com.br");
        var assertPageTitle = new String("Pizzarias - Google Maps");
        var searchTerm = new String("Pizzarias");
        var googleSection = new String("Maps");

        // Act:
        // Acesso ao site do Google
        driver.Navigate().GoToUrl(googleUrl);

        // Insere o termo de busca no campo de pesquisa
        driver.FindElement(By.Name("q")).SendKeys(searchTerm);

        // Aciona a busca
        driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

        // Clique na aba do Maps
        driver.FindElement(By.LinkText(googleSection)).Click();

        // Assert
        Assert.Contains(assertPageTitle, driver.Title);
    }
}