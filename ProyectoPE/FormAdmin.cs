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
			ActualizarTabla();
			ActualizarComboModulos();
		}
		void ActualizarTabla()
			{
    	dgvUsuarios.Rows.Clear();
    	if (dgvUsuarios.Columns.Count == 0) {
        dgvUsuarios.Columns.Add("user", "Usuario");
        dgvUsuarios.Columns.Add("rol", "Rol");
        dgvUsuarios.Columns.Add("score", "Puntuación");
    		}

    	for (int i = 0; i < Objetos.Usuarios.Count; i++) {
        string nombre = Objetos.Usuarios[i];
        string rol = Objetos.Roles[i];
        int puntos = Objetos.PuntuacionesJugadores.ContainsKey(nombre) ? Objetos.PuntuacionesJugadores[nombre] : 0;
        
        dgvUsuarios.Rows.Add(nombre, rol, puntos);
    		}
		}
		void BtnEliminarUsuarioClick(object sender, EventArgs e)
			{
    	if (dgvUsuarios.CurrentRow != null) {
        int index = dgvUsuarios.CurrentRow.Index;
        string nombre = Objetos.Usuarios[index];

        // Eliminar de todas las listas
        Objetos.Usuarios.RemoveAt(index);
        Objetos.Claves.RemoveAt(index);
        Objetos.Roles.RemoveAt(index);
        Objetos.PuntuacionesJugadores.Remove(nombre);

        ActualizarTabla();
        MessageBox.Show("Usuario eliminado.");
    		}
		}
		void BtnGuardarClick(object sender, EventArgs e)
{
    string u = txtUsuario.Text.Trim();
    string p = txtPass.Text.Trim();

    if (u != "" && p != "") {
        Objetos.Usuarios.Add(u);
        Objetos.Claves.Add(p);
        Objetos.Roles.Add("Jugador"); // Por defecto
        Objetos.PuntuacionesJugadores.Add(u, 0);

        ActualizarTabla();
        txtUsuario.Clear();
        txtPass.Clear();
    }
}
		
    void ActualizarComboModulos()
		{
    	// Limpiamos los items actuales
    cmbModulos.Items.Clear();
    
    // Recorremos la lista global y los añadimos al ComboBox
    foreach (string m in Objetos.ListaModulos)
    {
        cmbModulos.Items.Add(m);
    }
    
    // Opcional: Seleccionar el primer elemento si la lista no está vacía
    if (cmbModulos.Items.Count > 0)
    {
        cmbModulos.SelectedIndex = 0;
    }
	}


void BtnGuardarPreguntaClick(object sender, EventArgs e)
{
    string moduloSel = cmbModulos.Text;
    if (string.IsNullOrEmpty(moduloSel)) return;

    Objetos.DatosPregunta nuevaP = new Objetos.DatosPregunta();
    
    // Capturamos textos en español
    nuevaP.PreguntaEsp = txtPreguntaEsp.Text;
    nuevaP.Op1Esp = txtOp1Esp.Text; // Asegúrate que estos nombres sean tus TextBox
    nuevaP.Op2Esp = txtOp2Esp.Text;
    nuevaP.Op3Esp = txtOp3Esp.Text;
    nuevaP.Op4Esp = txtOp4Esp.Text;
    nuevaP.RespEsp = txtRespEsp.Text;

    // Capturamos textos en inglés
    nuevaP.PreguntaIng = txtPreguntaIng.Text;
    nuevaP.Op1Ing = txtOp1Ing.Text;
    nuevaP.Op2Ing = txtOp2Ing.Text;
    nuevaP.Op3Ing = txtOp3Ing.Text;
    nuevaP.Op4Ing = txtOp4Ing.Text;
    nuevaP.RespIng = txtRespIng.Text;

    // Guardamos o actualizamos en el diccionario global
    if (Objetos.PreguntasDinamicas.ContainsKey(moduloSel))
        Objetos.PreguntasDinamicas[moduloSel] = nuevaP;
    else
        Objetos.PreguntasDinamicas.Add(moduloSel, nuevaP);

    MessageBox.Show("Datos del módulo " + moduloSel + " guardados correctamente.");
}
		
		bool esEspanol;

		void BtnVolverClick(object sender, EventArgs e)
		{
			FormMenu f = new FormMenu();
				f.Show();
        		this.Close();
    		}			
		
		void BtnCrearMClick(object sender, EventArgs e)
		{
// Microsoft.VisualBasic permite usar Interaction.InputBox 
    
    string nuevoModulo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del nuevo módulo:", "Crear Módulo");

    if (!string.IsNullOrWhiteSpace(nuevoModulo))
    {
        if (!Objetos.ListaModulos.Contains(nuevoModulo))
        {
            Objetos.ListaModulos.Add(nuevoModulo);
            MessageBox.Show("Módulo '" + nuevoModulo + "' creado exitosamente.");
        }
        else
        {
            MessageBox.Show("Ese módulo ya existe.");
        }
    }	
    ActualizarComboModulos();
		}
		
		void BtnModificarMClick(object sender, EventArgs e)
		{
			string viejoNombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre del módulo que desea cambiar:", "Modificar Módulo");

    if (Objetos.ListaModulos.Contains(viejoNombre))
    {
        string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre para '" + viejoNombre + "':", "Nuevo Nombre");
        
        if (!string.IsNullOrWhiteSpace(nuevoNombre))
        {
            int indice = Objetos.ListaModulos.IndexOf(viejoNombre);
            Objetos.ListaModulos[indice] = nuevoNombre;
            MessageBox.Show("Módulo actualizado.");
        }
    }
    else if (!string.IsNullOrWhiteSpace(viejoNombre))
    {
        MessageBox.Show("El módulo no existe.");
    }
    ActualizarComboModulos();
		}
		
		void BtnVisualizarMClick(object sender, EventArgs e)
		{
			string lista = "Módulos actuales:\n\n";
    foreach (string m in Objetos.ListaModulos)
    {
        lista += "- " + m + "\n";
    }
    MessageBox.Show(lista, "Lista de Módulos");
    ActualizarComboModulos();
		}
		
		void BtnEliminarMClick(object sender, EventArgs e)
		{
		string moduloAEliminar = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre exacto del módulo a eliminar:", "Eliminar Módulo");

    if (Objetos.ListaModulos.Contains(moduloAEliminar))
    {
        Objetos.ListaModulos.Remove(moduloAEliminar);
        MessageBox.Show("Módulo eliminado correctamente.");
    }
    else if (!string.IsNullOrWhiteSpace(moduloAEliminar))
    {
        MessageBox.Show("No se encontró ningún módulo con ese nombre.");
    }	
    ActualizarComboModulos();
		}
		}
	}
	


