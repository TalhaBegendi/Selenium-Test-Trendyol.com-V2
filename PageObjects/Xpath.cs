//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;

namespace TalhaBegendi
{
    public static class kontrolOzellikleri
    {   //ASSERTION
        [CacheLookup] public static By girisAssert_01_giris = By.XPath("//span[@id='logged-in-container']/span[text()='Hesabım']");
        [CacheLookup] public static By urunAramaAssert_02_arama = By.XPath("//div[@class='dscrptn']//h1[text()='Samsung']");
        [CacheLookup] public static By urunAramaAssert_02_radio = By.XPath("//div[@class='slctd-fltr-item']//span[text()='4500 TL - 40000 TL']");
        [CacheLookup] public static By urunFavEkleCikarAssert_03_urun = By.XPath("//div[@class='pr-in-nm']//span[text()='Galaxy A70 2019 128 GB Beyaz (Samsung Türkiye Garantili) SM-A705']");
        [CacheLookup] public static By urunFavEkleCikarAssert_03_favEkle = By.XPath("//button[@class='pr-in-btn fv favored']/div[1]");
        [CacheLookup] public static By urunFavEkleCikarAssert_03_favCikar = By.XPath("//div[@data-id='6363206']/a");
        [CacheLookup] public static By urunFavEkleCikarAssert_03_favDogruTespit = By.XPath("//div[@data-id='6363206']/a");
        [CacheLookup] public static By urunSepetEkleAssert_04_sepetEkle = By.XPath("//button[@class='pr-in-btn add-to-bs success']/div[2][text()='Sepete Eklendi']");
        [CacheLookup] public static By urunSepetEkleAssert_04_kaydetVeDevam = By.XPath("//a[@Class='btn paymentCheckoutButton'][text()='Ödeme Yap']");

        //XPATH
        [CacheLookup] public static By sepetTrendyolClick = By.XPath("//div[@class='wrapper']/a");
        [CacheLookup] public static By girisYap = By.Id("accountBtn");
        [CacheLookup] public static By reklamKapat = By.XPath("//div[@class='fancybox-wrap fancybox-desktop fancybox-type-html fancybox-opened']/div/a");
        [CacheLookup] public static By emailGiris = By.Id("email");
        [CacheLookup] public static By sifreGiris = By.Id("password");
        [CacheLookup] public static By girisYapButton = By.ClassName("send-button");
        [CacheLookup] public static By urunArama = By.XPath("//input[@class='search-box']");
        [CacheLookup] public static By araButton = By.XPath("//i[@class='search-icon']");
        [CacheLookup] public static By fiyatRadio1 = By.XPath("//div[@class='aggrgtn-cntnr-wrppr']/div[3]/div[3]/a[1]/div[2]");//a değiştir
        [CacheLookup] public static By fiyatRadio2 = By.XPath("//div[@class='aggrgtn-cntnr-wrppr']/div[3]/div[3]/a[2]/div[2]");
        [CacheLookup] public static By fiyatRadio3 = By.XPath("//div[@class='aggrgtn-cntnr-wrppr']/div[3]/div[3]/a[3]/div[2]");
        [CacheLookup] public static By fiyatRadio4 = By.XPath("//div[@class='aggrgtn-cntnr-wrppr']/div[3]/div[3]/a[4]/div[2]");
        [CacheLookup] public static By fiyatRadio5 = By.XPath("//div[@class='aggrgtn-cntnr-wrppr']/div[3]/div[3]/a[5]/div[2]");
        [CacheLookup] public static By fiyatRadio6 = By.XPath("//div[@class='aggrgtn-cntnr-wrppr']/div[3]/div[3]/a[6]/div[2]");
        [CacheLookup] public static By urunClick1 = By.XPath("//div[@data-id='6363206']");
        [CacheLookup] public static By favEkle = By.ClassName("fv-hv-img");
        [CacheLookup] public static By favMenu = By.XPath("//li[@id='favoritesButton']");
        [CacheLookup] public static By favCikarMenu = By.ClassName("ufvrt-btn");
        [CacheLookup] public static By sepeteEkle = By.ClassName("add-to-bs");
        [CacheLookup] public static By sepetim = By.XPath("//li[@id='myBasketListItem']");
        [CacheLookup] public static By sepetiOnaylaAlt = By.ClassName("Basket_CheckoutButton");
        [CacheLookup] public static By onBilgiTik = By.XPath("//section[@class='termsCondition contentBox']/div/label");
        [CacheLookup] public static By kaydetVeDevam = By.ClassName("saveandcontinue");
    }
}
