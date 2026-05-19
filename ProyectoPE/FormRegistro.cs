using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoPE
{
	
	public partial class FormRegistro : Form
	{
		string cadenaConexion = "Server=localhost; Database=proyectope; Uid=root; Pwd=;";
		
		public FormRegistro()
		{
			InitializeComponent();
			cargarnombre();
			Actualizartextos();
		}
		
		void cargarnombre(){
			using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) {
			conexion.Open();
					//tabla de nombres que no se pueden usar
					string sqlnames = "SELECT nombre FROM usuario";
					MySqlDataAdapter adapter = new MySqlDataAdapter(sqlnames, conexion);
					DataTable table = new DataTable();
					adapter.Fill(table);
					dgvNombres.DataSource = table;
			}
		}
		
		void BtnRegistrarseClick(object sender, EventArgs e)
		{
			string user = textNuevoUsuario.Text.Trim();
			string pass = textNuevaPass.Text.Trim();
			string rol = cmbRol.Text;

			if (user == "" || pass == "" || rol == "") {
				string m = Objetos.idiEspañol ? "Todos los campos son obligatorios" : "All fields are required";
					string t = Objetos.idiEspañol ? "Advertencia" : "Warning";
				MessageBox.Show(m, t, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (Objetos.Usuarios.Contains(user)) {
				string men = Objetos.idiEspañol ? "El usuario " + user +  " ya existe. Intenta con otro." : "The user " + user + " already exists. Try another one.";
				string tit = Objetos.idiEspañol ? "Advertencia" : "Warning";
				MessageBox.Show("El usuario " + user +  " ya existe. Intenta con otro."  , "¡Advertencia!");
				return;
			}
			
			using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
			{
				try{
					
					conexion.Open();

					//verificador de usuarios registrados
					string sqlCheck = "SELECT COUNT(*) FROM usuario WHERE nombre = @name";
           			MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conexion);
            		cmdCheck.Parameters.AddWithValue("@name", user);
            		// ExecuteScalar devuelve el primer valor de la consulta
            		int usuarioExiste = Convert.ToInt32(cmdCheck.ExecuteScalar());
            		if (usuarioExiste > 0)
            			{
            			string me = Objetos.idiEspañol ? "El usuario '" + user + "' ya existe. Intenta con otro." : "The user " + user + " already exists. Try another one.";
            			string ti = Objetos.idiEspañol ? "Registro fallido" : "Registration failed";
               		 MessageBox.Show(me, ti, MessageBoxButtons.OK, MessageBoxIcon.Error);
               	 	 return; 
            			}
            		
					//registrador de usuarios
					string sqlInsert = "INSERT INTO usuario (nombre, contraseña, puntaje, rol) VALUES (@name, @con, @punt, @rol)";
					
					MySqlCommand cmd = new MySqlCommand(sqlInsert, conexion);
					cmd.Parameters.AddWithValue("@name", user);
					cmd.Parameters.AddWithValue("@con", pass);
					cmd.Parameters.AddWithValue("@punt", 0);
					cmd.Parameters.AddWithValue("@rol", rol);
					
					//cerrar consulta de insertado
					cmd.ExecuteNonQuery();
					
					long idgenerado = cmd.LastInsertedId;
					
					Objetos.Usuarios.Add(user);
					Objetos.Claves.Add(pass);
					Objetos.Roles.Add(rol);
				} catch (Exception ex) {
					MessageBox.Show("Error al añadir al usuario a la base de datos: "+ex.Message, "Error");
				}}
				
				
				
				if (!Objetos.PuntuacionesJugadores.ContainsKey(user)) {
					Objetos.PuntuacionesJugadores.Add(user, 0);
				}
				string mens = Objetos.idiEspañol ? "Ya puedes iniciar sesión." : "You can now log in.";
				string titu = Objetos.idiEspañol ? "Registro exitoso" : "Successful registration";
				string n = Objetos.idiEspañol ? "Fuiste registrado como: " + cmbRol.Text : "You were registered as: " + cmbRol.Text;
				string z = Objetos.idiEspañol ? "Advertencia" : "Warning";
				MessageBox.Show(mens, titu, MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show(n, z, MessageBoxButtons.OK, MessageBoxIcon.Information);
				VolverAlInicio();
			}
		
		void BtnVolverClick(object sender, EventArgs e)
		{	
			string mensa = Objetos.idiEspañol ? "¿Seguro que deseas volver?" : "Are you sure you want to come back?";
			string titul = Objetos.idiEspañol ? "Advertencia" : "Warning";
			DialogResult dialogResult = MessageBox.Show(mensa
				,titul ,
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
		void Actualizartextos(){
		if (Objetos.idiEspañol) {
				lblregi.Text = "Registro";
				lblusu.Text = "Nombre de Usuario:";
				lblcon.Text = "Contraseña:";
				lblrol.Text = "Rol:";
				lblns.Text = "Nombres que no se pueden usar:";
				BtnRegistrarse.Text = "Registrarse";
				BtnVolver.Text = "Volver";
		}
			else{
				lblregi.Text = "Registration";
				lblusu.Text = "User Name:";
				lblcon.Text = "Password:";
				lblrol.Text = "Role:";
				lblns.Text = "Names that cannot be used:";
				BtnRegistrarse.Text = "Register";
				BtnVolver.Text = "Return";			
			}
	}
}
}
