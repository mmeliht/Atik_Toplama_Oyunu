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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B191210004
{
    class AtikKutusu : IAtikKutusu
    {
        private int _bosaltmaPuani;
        public int BosaltmaPuani { get { return _bosaltmaPuani; } }

        private int _kapasite;
        public int kapasite { get { return _kapasite; } set { _kapasite = value; } }

        private int _doluHacim;
        public int DoluHacim { get { return _doluHacim; } set { _doluHacim = value; } }

        public int DolulukOranı { get { return DoluHacim * 100 / kapasite ; } }

       
        public AtikKutusu(int kapasite,int doluHacim,int bosaltmaPuani) //her atık türünün çöp kutusu özelliklerini atamak için.
        {
            this._kapasite = kapasite;
            this._doluHacim = doluHacim;
            this._bosaltmaPuani = bosaltmaPuani;
        }

        public bool Bosalt() //çöp kutusunu boşaltmak için gerekli doluluk oranına uygun olup olmadığını kontrol eder.
        {
            if(DolulukOranı >= 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ekle(Atik atik)  // eklenecek atığın hacmini kontrol ediyo.
        {
            if(atik.hacim <= kapasite-DoluHacim)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
