using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjeOdevi
{
	class Tavuk:Hayvan,IKumesHayvani
	{
		public int TavukYumurtaSayisi { get; set; }
		public Tavuk(ProgressBar progressBar)
		{
            ses = new SoundPlayer();
            TavukYumurtaSayisi = 0;
            ilkOlum = false;
			CanliMi = true;
			this.progressBar = progressBar;
			this.progressBar.Value = this.progressBar.Maximum; 
			ses.SoundLocation = Application.StartupPath + "\\tavuk.wav"; 
		}
		public override void yemVer()
		{
			progressBar.Value = progressBar.Maximum;
		}
		public override void canAzalt()
		{
			progressBar.Value -= 2;
		}
		public override void sesCal()
		{
			ses.Play(); 
		}
		public int YumurtaSat()
		{
            int tavukYumurtaSayisi = TavukYumurtaSayisi;
            TavukYumurtaSayisi = 0;
            return (1*tavukYumurtaSayisi);
		}
		public int YumurtaUret()
		{
			TavukYumurtaSayisi++;
            return TavukYumurtaSayisi;
		}
	}
}
