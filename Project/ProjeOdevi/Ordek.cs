using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
    class Ordek: Hayvan, IKumesHayvani
    {
        public int OrdekYumurtaSayisi { get; set; }
        public Ordek(ProgressBar progressBar)
        {
            ses = new SoundPlayer();
            OrdekYumurtaSayisi = 0;
            ilkOlum = false;
            CanliMi = true;
            this.progressBar = progressBar;
            this.progressBar.Value = this.progressBar.Maximum;
            ses.SoundLocation = Application.StartupPath + "\\ordek.wav";
        }
        public override void yemVer()
        {
            progressBar.Value = progressBar.Maximum;
        }
        public override void canAzalt()
        {
            progressBar.Value -= 3;
        }
        public override void sesCal()
        {
            ses.Play();
        }
        public int YumurtaSat()
        {
            int ordekYumurtaSayisi = OrdekYumurtaSayisi;
            OrdekYumurtaSayisi = 0;
            return (3 * ordekYumurtaSayisi);
        }
        public int YumurtaUret()
        {
            OrdekYumurtaSayisi++;
            return OrdekYumurtaSayisi;
        }
    }
}
