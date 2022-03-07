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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210004
{
    class Atik : IAtik
    {

        public string ad { get; }
        public string tur { get; } 

        private int _hacim;
        public int hacim { get { return _hacim; } }

        private Image _image;
        public Image Image { get { return _image; } }

       
       public Atik(string ad,string tur,int _hacim,int resimAdisayisi )  // her atığın özelliklerini atamak için yazıldı.
       {
            this.ad = ad;
            this.tur = tur;
            this._hacim = _hacim;
            _image = Image.FromFile(resimAdisayisi + ".jpg");
       }
       
        
    }
}
