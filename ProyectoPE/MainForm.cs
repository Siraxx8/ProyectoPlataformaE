
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoPE
{
	
	public partial class MainForm : Form
	{
		string cadenaConexion = "Server=localhost; Database=proyectope; Uid=root; Pwd=;";
		public MainForm()
		{
			
			InitializeComponent();
			Actualizartextos();
			ConectarBaseDatos();
		}
		
		void ConectarBaseDatos() 
		{
			
			MySqlConnection conexion = new MySqlConnection(cadenaConexion);
			
			try
			{
				conexion.Open();
				MessageBox.Show("Conexion realizada con exito a la base de datos");
			} catch (MySqlException ex) {
				MessageBox.Show("Error al conectar: "+ex.Message);
			} finally {
				conexion.Close();
			}
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
		void Actualizartextos(){
		if (Objetos.idiEspañol) {
			btnIrLogin.Text = "Iniciar Sesión";
			btnIrRegistro.Text = "Registrarse";
			btnSalir.Text = "Salir";
			btnIdioma.Text = "Change to English";
			lbltitulo.Text = "Plataforma Educativa Interactiva";
		}
			else{
			btnIrLogin.Text = "Login";
			btnIrRegistro.Text = "Register";
			btnSalir.Text = "Leave";
			btnIdioma.Text = "Cambiar a Español";
			lbltitulo.Text = "Interactive Educational Platform";
			}
		}
		
		
		
		void BtnIdiomaClick(object sender, EventArgs e)
		{
		Objetos.idiEspañol = !Objetos.idiEspañol;
		Actualizartextos();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}