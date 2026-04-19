
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();

		}
		void BtnIrLoginClick(object sender, EventArgs e)
		{
			FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
		}
		void BtnIrRegistroClick(object sender, EventArgs e)
		{
			FormRegistro f = new FormRegistro();
            f.Show();
            this.Hide();
		}
	}
}

	
