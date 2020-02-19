using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
    class Keci : Hayvan, IAhırHayvani
    {
        public int KeciSutMiktari { get; set; }
        public Keci(ProgressBar progressBar)
        {
            ses = new SoundPlayer();
            KeciSutMiktari = 0;
            ilkOlum = false;
            CanliMi = true;
            this.progressBar = progressBar;
            this.progressBar.Value = this.progressBar.Maximum;
            ses.SoundLocation = Application.StartupPath + "\\keci.wav";
        }
        public override void yemVer()
        {
            progressBar.Value = progressBar.Maximum;
        }
        public override void canAzalt()
        {
            progressBar.Value -= 6;
        }
        public override void sesCal()
        {
            ses.Play();
        }
        public int SutSat()
        {
            int keciSutMiktari = KeciSutMiktari;
            KeciSutMiktari = 0;
            return (8 * keciSutMiktari);
        }
        public int SutUret()
        {
            KeciSutMiktari++;
            return KeciSutMiktari;
        }
    }
}
