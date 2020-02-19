using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
    class Oyun
    {
       public Tavuk tavuk;
       public Ordek ordek;
       public Inek inek;
       public Keci keci;
       public int saniye;
       public int toplamKazanilanPara;
       Label lblSaniye;
       Label lblTYAdet;
       Label lblOYAdet;
       Label lblISKG;
       Label lblKSKG;
       Label lblTL;

        public Oyun(ProgressBar prgbarTavuk, ProgressBar prgbarOrdek, ProgressBar prgbarInek, ProgressBar prgbarKeci, Label lblSaniye, Label lblTYAdet, Label lblOYAdet, Label lblISKG, Label lblKSKG, Label lblTL)
        {
            saniye = 0;
            toplamKazanilanPara = 0;


            tavuk = new Tavuk(prgbarTavuk);
            ordek = new Ordek(prgbarOrdek);
            inek = new Inek(prgbarInek);
            keci = new Keci(prgbarKeci);

            this.lblSaniye = lblSaniye;
            this.lblTYAdet = lblTYAdet;
            this.lblOYAdet = lblOYAdet;
            this.lblISKG = lblISKG;
            this.lblKSKG = lblKSKG;
            this.lblTL = lblTL;
        }

        public void OyunuOynat()
        {
            saniye++;
            lblSaniye.Text = Convert.ToString(saniye) + " SN";

            if (tavuk.CanliMi == true)
                tavuk.canAzalt();
            if (tavuk.progressBar.Value <= 0 && tavuk.ilkOlum == false)
            {
                tavuk.ilkOlum = true;
                tavuk.CanliMi = false;
                tavuk.sesCal();
            }
            if (saniye % 3 == 0 && tavuk.CanliMi == true)
            {
                int tavukYumurtaSayisi = tavuk.YumurtaUret();
                lblTYAdet.Text = Convert.ToString(tavukYumurtaSayisi) + " ADET";
            }





            if (ordek.CanliMi == true)
            {
                ordek.canAzalt();
                if (ordek.progressBar.Value < 5)
                {
                    ordek.progressBar.Value = 0;
                    ordek.CanliMi = false;
                }
            }
            if (ordek.progressBar.Value <= 0 && ordek.ilkOlum == false)
            {
                ordek.ilkOlum = true;
                ordek.CanliMi = false;
                ordek.sesCal();
            }
            if (saniye % 5 == 0 && ordek.CanliMi == true)
            {
                int ordekYumurtaSayisi = ordek.YumurtaUret();
                lblOYAdet.Text = Convert.ToString(ordekYumurtaSayisi) + " ADET";
            }



            if (inek.CanliMi == true)
            {
                inek.canAzalt();
                if (inek.progressBar.Value < 8)
                {
                    inek.progressBar.Value = 0;
                    inek.CanliMi = false;
                }
            }
            if (inek.progressBar.Value <= 0 && inek.ilkOlum == false)
            {
                inek.ilkOlum = true;
                inek.CanliMi = false;
                inek.sesCal();
            }
            if (saniye % 8 == 0 && inek.CanliMi == true)
            {
                int inekSutMiktari = inek.SutUret();
                lblISKG.Text = Convert.ToString(inekSutMiktari) + " ADET";
            }




            if (keci.CanliMi == true)
            {
                keci.canAzalt();
                if (keci.progressBar.Value < 8)
                {
                    keci.progressBar.Value = 0;
                    keci.CanliMi = false;
                }
            }
            if (keci.progressBar.Value <= 0 && keci.ilkOlum == false)
            {
                keci.ilkOlum = true;
                keci.CanliMi = false;
                keci.sesCal();
            }
            if (saniye % 7 == 0 && keci.CanliMi == true)
            {
                int keciSutMiktari = keci.SutUret();
                lblKSKG.Text = Convert.ToString(keciSutMiktari) + " ADET";
            }
        }

        public void YemVerTavuk()
        {
            if(tavuk.CanliMi==true)
                tavuk.yemVer();
        }
        public void TavukYumurtasiSat()
        {
            if (tavuk.TavukYumurtaSayisi != 0)
            {
                toplamKazanilanPara += tavuk.YumurtaSat();
                lblTYAdet.Text = "0 ADET";
                lblTL.Text =toplamKazanilanPara.ToString() + "TL";
            }
        }
        public void YemVerOrdek()
        {
            if (ordek.CanliMi == true)
                ordek.yemVer();
        }
        public void OYSat()
        {
            if (ordek.OrdekYumurtaSayisi != 0)
            {
                toplamKazanilanPara += ordek.YumurtaSat();
                lblOYAdet.Text = "0 ADET";
                lblTL.Text = toplamKazanilanPara.ToString() + "TL";
            }
        }
        public void YemVerInek()
        {
            if (inek.CanliMi == true)
                inek.yemVer();
        }
        public void ISSat()
        {
            if (inek.InekSutMiktari != 0)
            {
                toplamKazanilanPara += inek.SutSat();
                lblISKG.Text = "0 ADET";
                lblTL.Text = toplamKazanilanPara.ToString() + "TL";
            }
        }

        public void YemVerKeci()
        {
            if (keci.CanliMi == true)
                keci.yemVer();
        }
        public void KSSat()
        {
            if (keci.KeciSutMiktari != 0)
            {
                toplamKazanilanPara += keci.SutSat();
                lblKSKG.Text = "0 ADET";
                lblTL.Text = toplamKazanilanPara.ToString() + "TL";
            }
        }
    }
}
