using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private Button[] b = new Button[6]; 
		public MainPage()
		{
			InitializeComponent();
            b[0] = ah;
            b[1] = fw;
            b[2] = oa;
            b[3] = s;
            b[4] = e;
            b[5] = ct;
		}
        private void Ahcd(object sender, EventArgs e)
        {
           // b[0].BackgroundColor = Color.Red;
        }
        private void Fwcd(object sender, EventArgs e)
        {
            Console.Write(3);
        }
        private void  Oacd(object sender, EventArgs e)
        {
            Console.Write(3);
        }
        private void Scd(object sender, EventArgs e)
        {
            Console.Write(3);
        }
        private void Ecd(object sender, EventArgs e)
        {
            Console.Write(3);
        }

        private void Ctcd(object sender, EventArgs e)
        {
            Console.Write(3);
        }
    }
   
    
}
