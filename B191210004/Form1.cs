/*************************************************************************************************************************
 **
 **                                             	SAKARYA ÜNİVERSİTESİ
 **                                        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                            BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 **                                           NESNEYE DAYALI PROGRAMLAMA DERSİ
 **	                                             2019-2020 BAHAR DÖNEMİ
 **    
 **
 **
 **
 **                                            ÖDEV NUMARASI..........: PROJE ODEVI
 **                                            ÖĞRENCİ ADI............: Mustafa Melih TÜFEKCİOĞLU
 **                                            ÖĞRENCİ NUMARASI.......: B191210004
 **                                            DERSİN ALINDIĞI GRUP...: 1.Öğretim B grubu
 **
 **
 **
 ***************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B191210004
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();  //resimleri random atamak için tanımlandı.
        int resim; // random resim için tanımlandı.
        int puan; //puan değerini tutması için.
        int süre = 60;//timer için başlangıç değeri.

        Atik camSise = new Atik("camSise", "organik", 600,2);      //atıklardan nesne oluşturuldu ve özellikleri bu kısımda verildi.
        Atik bardak = new Atik("bardak", "cam", 250,1);
        Atik gazete = new Atik("gazete", "kagit", 250,4);
        Atik dergi = new Atik("dergi", "kagit", 200,3);
        Atik domates = new Atik("domates", "organik", 150,5);
        Atik salatalik = new Atik("salatalık", "organik", 120,6);
        Atik kolaKutusu = new Atik("kolaKutusu", "metal", 350,7);
        Atik salcaKutusu = new Atik("salcaKutusu", "metal", 550,8);

        AtikKutusu organikAtikKutusu = new AtikKutusu(700, 0, 0); //atık kutularından nesne oluşturuldu ve özellikleri bu bölümde verildi
        AtikKutusu kagitAtikKutusu = new AtikKutusu(1200, 0,1000);
        AtikKutusu camAtikKutusu = new AtikKutusu(2200, 0, 600);
        AtikKutusu metalAtikKutusu = new AtikKutusu(2300, 0, 800);

        public Form1()
        {
            InitializeComponent();
            btnOrganikBosalt.Enabled = false; //başlangıçta butonların pasif olması için.
            btnKagitBosalt.Enabled = false;
            btnMetalBosalt.Enabled = false;
            btnCamBosalt.Enabled = false;
            btnOrganikAtik.Enabled = false;
            btnKagitAtik.Enabled = false;
            btnCamAtik.Enabled = false;
            btnMetalAtik.Enabled = false;
            btnYeniOyun.Enabled = true;
            btnCikis.Enabled = true;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            btnOrganikBosalt.Enabled = true;       //butonların aktif edilmesi burda yapılıyor.
            btnKagitBosalt.Enabled = true;
            btnMetalBosalt.Enabled = true;
            btnCamBosalt.Enabled = true;
            btnOrganikAtik.Enabled = true;
            btnKagitAtik.Enabled = true;
            btnCamAtik.Enabled = true;
            btnMetalAtik.Enabled = true;
            btnYeniOyun.Enabled = false;

            //sıfırlama ve yeniden başlatma işlemleri aşağıdaki kısımda yapılıyor.

            progOrnagik.Value = 0;   
            progKagit.Value = 0;
            progCam.Value = 0;
            progMetal.Value = 0;

            puan = 0;
            lblPuanSayi.Text = 0.ToString();

            lstOrganikAtik.Items.Clear();
            lstKagitAtik.Items.Clear();
            lstCamAtik.Items.Clear();
            lstMetalAtik.Items.Clear();

            organikAtikKutusu.DoluHacim = 0;
            kagitAtikKutusu.DoluHacim = 0;
            camAtikKutusu.DoluHacim = 0;
            metalAtikKutusu.DoluHacim = 0;

            resim = rnd.Next(1,8);  //rastgele bir sayı döndürüyor ve bu sayıya denk gelen resim ekrana basılıyor.
            ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbRstResim.Image = Image.FromFile(Application.StartupPath +"\\"+ resim + ".jpg");

            timer1.Start();  //zamanlayıcıyı başlatıyor.
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            lblSaniye.Text = süre.ToString(); 
            timer1.Interval = 1000;
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (süre == 0)   //süre 0 a gelince butonlar pasifleşiyo ve süre tekrardan 60 saniyeye getirilip duruyor.
            {
                timer1.Stop();
                btnCamBosalt.Enabled = false;
                btnMetalBosalt.Enabled = false;
                btnKagitBosalt.Enabled = false;
                btnOrganikBosalt.Enabled = false;
                btnOrganikAtik.Enabled = false;
                btnKagitAtik.Enabled = false;
                btnCamAtik.Enabled = false;
                btnMetalAtik.Enabled = false;
                btnYeniOyun.Enabled = true;
                süre = 60;
            }

            lblSaniye.Text = süre.ToString();
            süre--;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOrganikAtik_Click(object sender, EventArgs e)
        {
            if(resim==5 && organikAtikKutusu.Ekle(domates))  //ekrandaki resim domates resmi ve atik kutusunda boş yer varsa bu işlem yapılıyo.
            {
                lstOrganikAtik.Items.Add(domates.ad + "(" + domates.hacim + ")");
                organikAtikKutusu.DoluHacim += domates.hacim;
                progOrnagik.Value += domates.hacim;
                puan += domates.hacim;
                lblPuanSayi.Text = puan.ToString();
                resim = rnd.Next(1,8);                //eğer resim domates resmiyse ve organik atık kutusuna eklenmişse yeniden bir resim atanıyor ve ekrana çıkarılıyor.
                ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbRstResim.Image = Image.FromFile(Application.StartupPath + "\\" + resim + ".jpg");

            }
           else if(resim==6 && organikAtikKutusu.Ekle(salatalik))
           {
                organikAtikKutusu.DoluHacim += salatalik.hacim;
                lstOrganikAtik.Items.Add(salatalik.ad + "(" + salatalik.hacim + ")");
                progOrnagik.Value += salatalik.hacim;
                puan += salatalik.hacim;
                lblPuanSayi.Text = puan.ToString();
                resim = rnd.Next(1, 8);
                ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbRstResim.Image = Image.FromFile(Application.StartupPath + "\\" + resim + ".jpg");

            }
            else { }
        }

        private void btnKagitAtik_Click(object sender, EventArgs e)
        {
            if(resim==3 && kagitAtikKutusu.Ekle(dergi) )
            {
                kagitAtikKutusu.DoluHacim += dergi.hacim;
                lstKagitAtik.Items.Add(dergi.ad + "(" + dergi.hacim + ")");
                progKagit.Value += dergi.hacim;
                puan += dergi.hacim;
                lblPuanSayi.Text = puan.ToString();
                resim = rnd.Next(1, 8);
                ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbRstResim.Image = Image.FromFile(Application.StartupPath + "\\" + resim + ".jpg");

            }
            else if(resim==4 &&kagitAtikKutusu.Ekle(gazete))
            {
                kagitAtikKutusu.DoluHacim += gazete.hacim;
                lstKagitAtik.Items.Add(gazete.ad + "(" + gazete.hacim + ")");
                progKagit.Value += gazete.hacim;
                puan += gazete.hacim;
                lblPuanSayi.Text = puan.ToString();
                resim = rnd.Next(1, 8);
                ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbRstResim.Image = Image.FromFile(Application.StartupPath + "\\" + resim + ".jpg");
            }
            else { }
        }

        private void btnCamAtik_Click(object sender, EventArgs e)
        {
            if(resim==1 && camAtikKutusu.Ekle(bardak))
            {
                camAtikKutusu.DoluHacim += bardak.hacim;
                lstCamAtik.Items.Add(bardak.ad + "(" + bardak.hacim + ")");
                progCam.Value += bardak.hacim;
                puan += bardak.hacim;
                lblPuanSayi.Text = puan.ToString();
                resim = rnd.Next(1, 8);
                ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbRstResim.Image = Image.FromFile(Application.StartupPath + "\\" + resim + ".jpg");
            }
            else if(resim == 2 && camAtikKutusu.Ekle(camSise))
            {
                camAtikKutusu.DoluHacim += camSise.hacim;
                lstCamAtik.Items.Add(camSise.ad + "(" + camSise.hacim + ")");
                progCam.Value += camSise.hacim;
                puan += camSise.hacim;
                lblPuanSayi.Text = puan.ToString();
                resim = rnd.Next(1, 8);
                ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbRstResim.Image = Image.FromFile(Application.StartupPath + "\\" + resim + ".jpg");
            }
            else { }
        }

        private void btnMetalAtik_Click(object sender, EventArgs e)
        {
            if(resim==7 && metalAtikKutusu.Ekle(kolaKutusu))
            {
                metalAtikKutusu.DoluHacim += kolaKutusu.hacim;
                lstMetalAtik.Items.Add(kolaKutusu.ad + "(" + kolaKutusu.hacim + ")");
                progMetal.Value += kolaKutusu.hacim;
                puan += kolaKutusu.hacim;
                lblPuanSayi.Text = puan.ToString();
                resim = rnd.Next(1, 8);
                ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbRstResim.Image = Image.FromFile(Application.StartupPath + "\\" + resim + ".jpg");
            }
            else if(resim == 8 && metalAtikKutusu.Ekle(salcaKutusu))
            {
                metalAtikKutusu.DoluHacim += salcaKutusu.hacim;
                lstMetalAtik.Items.Add(salcaKutusu.ad + "(" + salcaKutusu.hacim + ")");
                progMetal.Value += salcaKutusu.hacim;
                puan += salcaKutusu.hacim;
                lblPuanSayi.Text = puan.ToString();
                resim = rnd.Next(1, 8);
                ptbRstResim.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbRstResim.Image = Image.FromFile(Application.StartupPath + "\\" + resim + ".jpg");
            }
            else { }
        }

        private void btnOrganikBosalt_Click(object sender, EventArgs e)
        {
            if(organikAtikKutusu.Bosalt()) //eğer atık kutusunun doluluk oranı %75 ten fazlaysa true dönüyo ve boşaltma işlemi yapılıyor.
            {
                progOrnagik.Value = 0;
                puan += organikAtikKutusu.BosaltmaPuani;
                lblPuanSayi.Text = puan.ToString();
                lstOrganikAtik.Items.Clear();
                organikAtikKutusu.DoluHacim = 0;
                süre += 3;
            }
            else { }
        }

        private void btnKagitBosalt_Click(object sender, EventArgs e)
        {
            if (kagitAtikKutusu.Bosalt())
            {
                progKagit.Value = 0;
                puan += kagitAtikKutusu.BosaltmaPuani;
                lblPuanSayi.Text = puan.ToString();
                lstKagitAtik.Items.Clear();
                kagitAtikKutusu.DoluHacim = 0;
                süre += 3;
            }
            else { }
        }
         
        private void btnCamBosalt_Click(object sender, EventArgs e)
        {
            if(camAtikKutusu.Bosalt())
            {
                progCam.Value = 0;
                puan += camAtikKutusu.BosaltmaPuani;
                lblPuanSayi.Text = puan.ToString();
                lstCamAtik.Items.Clear();
                camAtikKutusu.DoluHacim = 0;
                süre += 3;
            }
            else { }
        }

        private void btnMetalBosalt_Click(object sender, EventArgs e)
        {
            if (metalAtikKutusu.Bosalt())
            {
                progMetal.Value = 0;
                puan += metalAtikKutusu.BosaltmaPuani;
                lblPuanSayi.Text = puan.ToString();
                lstMetalAtik.Items.Clear();
                metalAtikKutusu.DoluHacim = 0;
                süre += 3;
            }
            else { }
        }
    }
}
