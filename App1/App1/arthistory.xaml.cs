using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class arthistory : ContentPage
	{
        private Button[] b = new Button[5];
        public arthistory ()
		{
			InitializeComponent ();

            b[0] = MV;
            b[1] = EX;
            b[2] = SH;
            b[3] = ART;
            b[4] = SC;
        }
	}
}