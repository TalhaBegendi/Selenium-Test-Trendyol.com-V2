//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
//TALHA BEĞENDİ

namespace TalhaBegendi
{
    public class TrendyolPomMethods
{
    IWebDriver webDriver;
    IWebElement element;
    public TrendyolPomMethods(IWebDriver driver)
    {
        this.webDriver = driver;
    }
    public void SepetTrendyolClick()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.sepetTrendyolClick)).Click();
    }
    public void ReklamKapat()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.reklamKapat)).Click();
    }
    public void GirisYap()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.girisYap)).Click();
    }
    public void EmailGiris(string userEmailGiris)
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.emailGiris)).SendKeys(userEmailGiris);
    }
    public void SifreGiris(string userSifreGiris)
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.sifreGiris)).SendKeys(userSifreGiris);
    }
    public void GirisYapButton()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.girisYapButton)).Click();
        Thread.Sleep(1980);
    }
    public void UrunArama(string userUrunArama)
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunArama)).SendKeys(userUrunArama);
    }
    public void AraButton()
    {
        Thread.Sleep(199);
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.araButton)).Click();
    }
    public void FiyatRadio1()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.fiyatRadio1)).Click();
    }
    public void FiyatRadio2()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.fiyatRadio2)).Click();
    }
    public void FiyatRadio3()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.fiyatRadio3)).Click();
    }
    public void FiyatRadio4()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.fiyatRadio4)).Click();
    }
    public void FiyatRadio5()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.fiyatRadio5)).Click();
    }
    public void FiyatRadio6()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.fiyatRadio6)).Click();
    }
    public void UrunClick1()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunClick1)).Click();
    }
    public void FavEkle()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.favEkle)).Click();
    }
    public void FavMenu()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.favMenu)).Click();
    }
    public void FavCikarMenu()
    {

        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.favCikarMenu)).Click();
    }
    public void SepeteEkle()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.sepeteEkle)).Click();
    }
    public void Sepetim()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.sepetim)).Click();
    }
    public void SepetiOnaylaAlt()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.sepetiOnaylaAlt)).Click();
    }
    public void OnBilgiTik()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.onBilgiTik)).Click();
    }
    public void KaydetVeDevam()
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.kaydetVeDevam)).Click();
    }

        //ASSERT

    public bool GirisAssert(string girisText)
    {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.girisAssert_01_giris));
        return element.Text == girisText;
    }
    public bool UrunAramaAssert_Arama(string aramaText)
    {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunAramaAssert_02_arama));
        return element.Text == aramaText;
    }
    public bool UrunAramaAssert_Radio(string radioText)
    {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunAramaAssert_02_radio));
        return element.Text == radioText;
    }
    public bool UrunFavEkleCikarAssert_03_Urun(string urunAdText)
    {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunFavEkleCikarAssert_03_urun));
        return element.Text == urunAdText;
    }
    public bool UrunFavEkleCikarAssert_03_FavEkle()
    {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunFavEkleCikarAssert_03_favEkle));
        return element.Displayed;
    }
    public bool UrunFavEkleCikarAssert_03_FavCikar()
    {
        Thread.Sleep(350);
        if (webDriver.FindElements(kontrolOzellikleri.urunFavEkleCikarAssert_03_favCikar).Count == 0) {
        return true;
        }
        else
        {
        return false;
        }
    }
    public bool UrunFavEkleCikarAssert_03_FavDogruTespit()
    {
        Thread.Sleep(350);
        if (webDriver.FindElements(kontrolOzellikleri.urunFavEkleCikarAssert_03_favDogruTespit).Count == 1) {
        return true;
        }
        else
        {
        return false;
        }
    }
    public bool UrunSepetEkleAssert_04_sepetEkle(string sepetEkleText)
    {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunSepetEkleAssert_04_sepetEkle));
        return element.Text == sepetEkleText;
    }
    public bool UrunSepetEkleAssert_04_kaydetVeDevam(string kaydetVeDevamText)
    {
        WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(kontrolOzellikleri.urunSepetEkleAssert_04_kaydetVeDevam));
        return element.Text == kaydetVeDevamText;
    }
}
}
