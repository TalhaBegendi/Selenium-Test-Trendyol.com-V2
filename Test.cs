//TALHA BEĞENDİ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using Assert = NUnit.Framework.Assert;
//TALHA BEĞENDİ

namespace TalhaBegendi
{
    public class ChromeAcilisTrendyol
    {
        IWebDriver Webdriver;
        [OneTimeSetUp]
        public void TrendyolGiris()
        {
            Webdriver = new ChromeDriver();
            Webdriver.Manage().Window.Maximize();
            Webdriver.Navigate().GoToUrl("https://www.trendyol.com/"); 
        }
        [Test, Category("Trendyol Test")]
        public void Senaryo_01_Giris()
        {
            TrendyolPomMethods girisYap = new TrendyolPomMethods(Webdriver);
            girisYap.ReklamKapat();
            girisYap.GirisYap();
            girisYap.EmailGiris("asd@gmail.com"); 
            girisYap.SifreGiris("123456"); 
            girisYap.GirisYapButton(); 
            Assert.IsTrue(girisYap.GirisAssert("Hesabım"),"Giris Yapildi");
        }
        [Test, Category("Trendyol Test")]
        public void Senaryo_02_UrunArama()
        {
            TrendyolPomMethods urunArama = new TrendyolPomMethods(Webdriver);
            urunArama.UrunArama("Samsung");
            urunArama.AraButton();
            Assert.IsTrue(urunArama.UrunAramaAssert_Arama("Samsung"), "Arama Basariyla Yapildi.");
            urunArama.FiyatRadio6();
            Assert.IsTrue(urunArama.UrunAramaAssert_Radio("4500 TL - 40000 TL"), "İstenilen Radio Button Seçimi Yapildi.");
        }
        [Test, Category("Trendyol Test")]
        public void Senaryo_03_UrunSepetEkleAl()
        {
            TrendyolPomMethods urunSepetEkleAl = new TrendyolPomMethods(Webdriver);
            urunSepetEkleAl.UrunClick1();
            Assert.IsTrue(urunSepetEkleAl.UrunFavEkleCikarAssert_03_Urun("Galaxy A70 2019 128 GB Beyaz (Samsung Türkiye Garantili) SM-A705"), "Urun Basariyla Tiklandi.");
            urunSepetEkleAl.SepeteEkle();
            Assert.IsTrue(urunSepetEkleAl.UrunSepetEkleAssert_04_sepetEkle("Sepete Eklendi"), "Urun Basariyla Sepete Eklendi.");
            urunSepetEkleAl.Sepetim();
            urunSepetEkleAl.SepetiOnaylaAlt();
            urunSepetEkleAl.OnBilgiTik();
            urunSepetEkleAl.KaydetVeDevam();
            Assert.IsTrue(urunSepetEkleAl.UrunSepetEkleAssert_04_kaydetVeDevam("Ödeme Yap"), "Urun İçin Ödeme Yapılabilir.");
        }
        [Test, Category("Trendyol Test")]
        public void Senaryo_04_UrunFavEkleCikar()
        {
            TrendyolPomMethods urunFavEkleCikar = new TrendyolPomMethods(Webdriver);
            //urunFavEkleCikar.SepetTrendyolClick();
            Senaryo_02_UrunArama();
            urunFavEkleCikar.UrunClick1();
            Assert.IsTrue(urunFavEkleCikar.UrunFavEkleCikarAssert_03_Urun("Galaxy A70 2019 128 GB Beyaz (Samsung Türkiye Garantili) SM-A705"), "Urun Basariyla Tiklandi.");
            urunFavEkleCikar.FavEkle();
            Assert.IsTrue(urunFavEkleCikar.UrunFavEkleCikarAssert_03_FavEkle(), "Favori Basariyla Eklendi.");
            urunFavEkleCikar.FavMenu();
            Assert.IsTrue(urunFavEkleCikar.UrunFavEkleCikarAssert_03_FavDogruTespit(),"Favori Basariyla Eklendiği Görüldü.");
            urunFavEkleCikar.FavCikarMenu();
            Assert.IsTrue(urunFavEkleCikar.UrunFavEkleCikarAssert_03_FavCikar(),"Favori Basariyla Kaldirildi.");
        }
    }
}