using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyCalculator {
	public partial class CurrencyCalculator : Form {
		private double b;
		double a;
		double suma;

		public CurrencyCalculator() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e){
			a = getNumber();
			b = przelicznik();
			suma = (a * b);
			textBox2.Text = suma.ToString();   //%2d
		}

		private double getNumber() { return Convert.ToDouble(textBox1.Text); }

		private double przelicznik(){
			if (radioButton1.Checked == true){
				if (radioButton5.Checked == true) { b = 1; }
				if (radioButton6.Checked == true) { b = (1/4.3); }
				if (radioButton7.Checked == true) { b = (1/4.9); }
				if (radioButton8.Checked == true) { b = (1/3.7); }
			}
			if (radioButton2.Checked == true){
				if (radioButton5.Checked == true) { b = 4.3; }
				if (radioButton6.Checked == true) { b = 1; }
				if (radioButton7.Checked == true) { b = 0.87; }
				if (radioButton8.Checked == true) { b = 1.1; }
			}
			if (radioButton3.Checked == true){
				if (radioButton5.Checked == true) { b = 4.9; }
				if (radioButton6.Checked == true) { b = 1.1; }
				if (radioButton7.Checked == true) { b = 1; }
				if (radioButton8.Checked == true) { b = 1.3; }
			}
			if (radioButton4.Checked == true){
				if (radioButton5.Checked == true) { b = 3.7; }
				if (radioButton6.Checked == true) { b = 0.8; }
				if (radioButton7.Checked == true) { b = 0.7; }
				if (radioButton8.Checked == true) { b = 1; }
			}
			return b;
			}

		WebClient client = new WebClient();
	//	String downloadedString = client.DownloadString("http://www.nbp.pl/home.aspx?f=/kursy/kursya.html");
	}
}
	

