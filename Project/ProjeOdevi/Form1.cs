using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
	public partial class Form1 : Form
	{  
        Timer time;
        Oyun oyun;
        public Form1()
		{
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = new Timer();
            time.Enabled = true;
            time.Interval = 1000;
            time.Tick += Time_Tick;

            btnYemVerTavuk.Click += BtnYemVerTavuk_Click;

            oyun = new Oyun(prgbarTavuk, prgbarOrdek, prgbarInek, prgbarKeci,lblSaniye,lblTYAdet,lblOYAdet,lblISKG,lblKSKG,lblTL);


        }

        private void Time_Tick(object sender, EventArgs e)
        {
            oyun.OyunuOynat();
        }

        private void BtnYemVerTavuk_Click(object sender, EventArgs e)
        {
            oyun.YemVerTavuk();
        }

        private void btnTYSat_Click(object sender, EventArgs e)
        {
            oyun.TavukYumurtasiSat();     
        }

        private void btnYemVerOrdek_Click(object sender, EventArgs e)
        {
            oyun.YemVerOrdek();
        }

        private void btnOYSat_Click(object sender, EventArgs e)
        {
            oyun.OYSat();
        }

        private void btnYemVerInek_Click(object sender, EventArgs e)
        {
            oyun.YemVerInek();
        }

        private void btnISSat_Click(object sender, EventArgs e)
        {
            oyun.ISSat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyun.YemVerKeci();
        }

        private void btnKSSat_Click(object sender, EventArgs e)
        {
            oyun.KSSat();
        }
    }
}
