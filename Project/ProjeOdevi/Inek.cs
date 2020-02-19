using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
    class Inek:Hayvan, IAhırHayvani
    {
        public int InekSutMiktari { get; set; }
        public Inek(ProgressBar progressBar)
        {
            ses = new SoundPlayer();
            InekSutMiktari = 0;
            ilkOlum = false;
            CanliMi = true;
            this.progressBar = progressBar;
            this.progressBar.Value = this.progressBar.Maximum;
            ses.SoundLocation = Application.StartupPath + "\\inek.wav";
        }
        public override void yemVer()
        {
            progressBar.Value = progressBar.Maximum;
        }
        public override void canAzalt()
        {
            progressBar.Value -= 8;
        }
        public override void sesCal()
        {
            ses.Play();
        }
        public int SutSat()
        {
            int inekSutMiktari = InekSutMiktari;
            InekSutMiktari = 0;
            return (5 * inekSutMiktari);
        }
        public int SutUret()
        {
            InekSutMiktari++;
            return InekSutMiktari;
        }
    }
}
