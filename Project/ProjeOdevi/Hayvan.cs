using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
	abstract class Hayvan
	{
        public bool ilkOlum;// aslinda ilkÖlüm olması lazim ama türkce karakter kullanmadim
		public SoundPlayer ses;
		public ProgressBar progressBar;
		public bool CanliMi { get; set; }

		public abstract void yemVer();
		public abstract void canAzalt();
		public abstract void sesCal();

	}
}
