using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using elysium.crypt;
namespace NugetPackages
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{

				textBox2.Text = crypto.EncryptData(textBox1.Text);
			}

			catch (Exception ex)
			{
				_ = MessageBox.Show(ex.Message);

			}


		}


		private void button2_Click(object sender, EventArgs e)
		{

			try
			{

				// This encrypted password would be read from a                 database
				var storedEncrPassw = textBox2.Text;
				var password = textBox3.Text;

				if (crypto.ValidateEncryptedData(password, storedEncrPassw))
				{

					label1.Text = "Match";
				}
				else
				{ label1.Text = "No Match"; }

			}


			catch (Exception ex)
			{
				_ = MessageBox.Show(ex.Message);

			}


		}
	}






}


