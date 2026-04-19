using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
	
	public partial class FormAdmin : Form
	{
		public FormAdmin(bool idiomaActual)
		{	
			InitializeComponent();
			this.esEspanol = idiomaActual;
		}
		bool esEspanol;

		void BtnVolverClick(object sender, EventArgs e)
		{
			FormMenu f = new FormMenu();
				f.Show();
        		this.Close();
    		}			
		}
	}


