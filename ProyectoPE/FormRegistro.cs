using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
	
	public partial class FormRegistro : Form
	{
		public FormRegistro()
		{
			InitializeComponent();
		}
		void BtnRegistrarseClick(object sender, EventArgs e)
		{
			string user = textNuevoUsuario.Text.Trim();
            string pass = textNuevaPass.Text.Trim();
            string rol = cmbRol.Text;

            if (user == "" || pass == "" || rol == "") {
                MessageBox.Show("Todos los campos son obligatorios" , "¡Advertencia! Registro fallido");
                return;
            }

            if (Objetos.Usuarios.Contains(user)) {
                MessageBox.Show("El usuario " + user +  " ya existe. Intenta con otro."  , "¡Advertencia! Registro fallido");
                return;
            }

            Objetos.Usuarios.Add(user);
            Objetos.Claves.Add(pass);
            Objetos.Roles.Add(rol);
            
            if (!Objetos.PuntuacionesJugadores.ContainsKey(user)) {
       		 Objetos.PuntuacionesJugadores.Add(user, 0);
            }
            MessageBox.Show("Ya puedes iniciar sesión", "¡Registro exitoso!");
   			MessageBox.Show("Fuiste registrado como: " + cmbRol.Text , "¡Advertencia!");
            VolverAlInicio();
        }
		void BtnVolverClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show(
			"¿Seguro que deseas volver?", 
			"Advertencia", 
			MessageBoxButtons.YesNo, 
			MessageBoxIcon.Question
			);
			if (dialogResult == DialogResult.Yes)
			{
				foreach (Form f in Application.OpenForms)
				{
					if (f is MainForm)
					{
						f.Show();
				        break;
				     }
	        	}
        		this.Close();
			}
		}
		void VolverAlInicio()
        {
            foreach (Form f in Application.OpenForms) {
                if (f is MainForm) { f.Show(); break; }
            }
            this.Close();
        }	
	}
}
	