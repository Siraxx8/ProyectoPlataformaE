/*
 * Creado por SharpDevelop.
 * Usuario: Sira
 * Fecha: 18/4/2026
 * Hora: 10:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoPE
{
	partial class FormAdmin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
			this.Usuarios = new System.Windows.Forms.TabControl();
			this.tabusu = new System.Windows.Forms.TabPage();
			this.BtnVolver = new System.Windows.Forms.Button();
			this.BtnEliminarUsuario = new System.Windows.Forms.Button();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.lblcontr = new System.Windows.Forms.Label();
			this.lblusu = new System.Windows.Forms.Label();
			this.lblcrearnu = new System.Windows.Forms.Label();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.tabmod = new System.Windows.Forms.TabPage();
			this.btnModificarM = new System.Windows.Forms.Button();
			this.btnEliminarM = new System.Windows.Forms.Button();
			this.btnVisualizarM = new System.Windows.Forms.Button();
			this.btnCrearM = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tabpreg = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.BtnGuardarPregunta = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtRespIng = new System.Windows.Forms.TextBox();
			this.txtPreguntaIng = new System.Windows.Forms.TextBox();
			this.txtOp1Esp = new System.Windows.Forms.TextBox();
			this.txtOp4Esp = new System.Windows.Forms.TextBox();
			this.txtOp4Ing = new System.Windows.Forms.TextBox();
			this.txtOp3Ing = new System.Windows.Forms.TextBox();
			this.txtOp1Ing = new System.Windows.Forms.TextBox();
			this.txtOp3Esp = new System.Windows.Forms.TextBox();
			this.txtOp2Esp = new System.Windows.Forms.TextBox();
			this.txtOp2Ing = new System.Windows.Forms.TextBox();
			this.txtRespEsp = new System.Windows.Forms.TextBox();
			this.txtPreguntaEsp = new System.Windows.Forms.TextBox();
			this.cmbModulos = new System.Windows.Forms.ComboBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Usuarios.SuspendLayout();
			this.tabusu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.tabmod.SuspendLayout();
			this.tabpreg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Usuarios
			// 
			this.Usuarios.Controls.Add(this.tabusu);
			this.Usuarios.Controls.Add(this.tabmod);
			this.Usuarios.Controls.Add(this.tabpreg);
			this.Usuarios.Location = new System.Drawing.Point(23, 58);
			this.Usuarios.Name = "Usuarios";
			this.Usuarios.SelectedIndex = 0;
			this.Usuarios.Size = new System.Drawing.Size(645, 364);
			this.Usuarios.TabIndex = 1;
			// 
			// tabusu
			// 
			this.tabusu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabusu.BackgroundImage")));
			this.tabusu.Controls.Add(this.BtnVolver);
			this.tabusu.Controls.Add(this.BtnEliminarUsuario);
			this.tabusu.Controls.Add(this.BtnGuardar);
			this.tabusu.Controls.Add(this.txtUsuario);
			this.tabusu.Controls.Add(this.txtPass);
			this.tabusu.Controls.Add(this.lblcontr);
			this.tabusu.Controls.Add(this.lblusu);
			this.tabusu.Controls.Add(this.lblcrearnu);
			this.tabusu.Controls.Add(this.dgvUsuarios);
			this.tabusu.Location = new System.Drawing.Point(4, 22);
			this.tabusu.Name = "tabusu";
			this.tabusu.Padding = new System.Windows.Forms.Padding(3);
			this.tabusu.Size = new System.Drawing.Size(637, 338);
			this.tabusu.TabIndex = 0;
			this.tabusu.Text = "Usuarios/Users";
			this.tabusu.UseVisualStyleBackColor = true;
			// 
			// BtnVolver
			// 
			this.BtnVolver.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnVolver.Location = new System.Drawing.Point(6, 294);
			this.BtnVolver.Name = "BtnVolver";
			this.BtnVolver.Size = new System.Drawing.Size(87, 36);
			this.BtnVolver.TabIndex = 9;
			this.BtnVolver.Text = "Volver";
			this.BtnVolver.UseVisualStyleBackColor = true;
			this.BtnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// BtnEliminarUsuario
			// 
			this.BtnEliminarUsuario.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnEliminarUsuario.Location = new System.Drawing.Point(15, 90);
			this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
			this.BtnEliminarUsuario.Size = new System.Drawing.Size(135, 46);
			this.BtnEliminarUsuario.TabIndex = 7;
			this.BtnEliminarUsuario.Text = "Eliminar Usuario";
			this.BtnEliminarUsuario.UseVisualStyleBackColor = true;
			this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuarioClick);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnGuardar.Location = new System.Drawing.Point(530, 275);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(87, 36);
			this.BtnGuardar.TabIndex = 6;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(350, 275);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(136, 20);
			this.txtUsuario.TabIndex = 5;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(350, 310);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(136, 20);
			this.txtPass.TabIndex = 4;
			// 
			// lblcontr
			// 
			this.lblcontr.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcontr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblcontr.Location = new System.Drawing.Point(260, 306);
			this.lblcontr.Name = "lblcontr";
			this.lblcontr.Size = new System.Drawing.Size(121, 25);
			this.lblcontr.TabIndex = 3;
			this.lblcontr.Text = "Contraseña:";
			// 
			// lblusu
			// 
			this.lblusu.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblusu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblusu.Location = new System.Drawing.Point(280, 275);
			this.lblusu.Name = "lblusu";
			this.lblusu.Size = new System.Drawing.Size(121, 25);
			this.lblusu.TabIndex = 2;
			this.lblusu.Text = "Usuario:";
			// 
			// lblcrearnu
			// 
			this.lblcrearnu.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcrearnu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblcrearnu.Location = new System.Drawing.Point(341, 245);
			this.lblcrearnu.Name = "lblcrearnu";
			this.lblcrearnu.Size = new System.Drawing.Size(156, 25);
			this.lblcrearnu.TabIndex = 1;
			this.lblcrearnu.Text = "Crear nuevo usuario:";
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(185, 6);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuarios.Size = new System.Drawing.Size(446, 236);
			this.dgvUsuarios.TabIndex = 0;
			// 
			// tabmod
			// 
			this.tabmod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabmod.BackgroundImage")));
			this.tabmod.Controls.Add(this.btnModificarM);
			this.tabmod.Controls.Add(this.btnEliminarM);
			this.tabmod.Controls.Add(this.btnVisualizarM);
			this.tabmod.Controls.Add(this.btnCrearM);
			this.tabmod.Controls.Add(this.label5);
			this.tabmod.Location = new System.Drawing.Point(4, 22);
			this.tabmod.Name = "tabmod";
			this.tabmod.Padding = new System.Windows.Forms.Padding(3);
			this.tabmod.Size = new System.Drawing.Size(637, 338);
			this.tabmod.TabIndex = 1;
			this.tabmod.Text = "Módulos/Modules";
			this.tabmod.UseVisualStyleBackColor = true;
			// 
			// btnModificarM
			// 
			this.btnModificarM.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificarM.Location = new System.Drawing.Point(314, 79);
			this.btnModificarM.Name = "btnModificarM";
			this.btnModificarM.Size = new System.Drawing.Size(135, 46);
			this.btnModificarM.TabIndex = 12;
			this.btnModificarM.Text = "MODIFICAR";
			this.btnModificarM.UseVisualStyleBackColor = true;
			this.btnModificarM.Click += new System.EventHandler(this.BtnModificarMClick);
			// 
			// btnEliminarM
			// 
			this.btnEliminarM.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarM.Location = new System.Drawing.Point(314, 167);
			this.btnEliminarM.Name = "btnEliminarM";
			this.btnEliminarM.Size = new System.Drawing.Size(135, 46);
			this.btnEliminarM.TabIndex = 11;
			this.btnEliminarM.Text = "ELIMINAR";
			this.btnEliminarM.UseVisualStyleBackColor = true;
			this.btnEliminarM.Click += new System.EventHandler(this.BtnEliminarMClick);
			// 
			// btnVisualizarM
			// 
			this.btnVisualizarM.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVisualizarM.Location = new System.Drawing.Point(149, 167);
			this.btnVisualizarM.Name = "btnVisualizarM";
			this.btnVisualizarM.Size = new System.Drawing.Size(135, 46);
			this.btnVisualizarM.TabIndex = 10;
			this.btnVisualizarM.Text = "VISUALIZAR";
			this.btnVisualizarM.UseVisualStyleBackColor = true;
			this.btnVisualizarM.Click += new System.EventHandler(this.BtnVisualizarMClick);
			// 
			// btnCrearM
			// 
			this.btnCrearM.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrearM.Location = new System.Drawing.Point(149, 79);
			this.btnCrearM.Name = "btnCrearM";
			this.btnCrearM.Size = new System.Drawing.Size(135, 46);
			this.btnCrearM.TabIndex = 9;
			this.btnCrearM.Text = "CREAR";
			this.btnCrearM.UseVisualStyleBackColor = true;
			this.btnCrearM.Click += new System.EventHandler(this.BtnCrearMClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(193, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(289, 47);
			this.label5.TabIndex = 3;
			this.label5.Text = "Configurar Módulos.";
			// 
			// tabpreg
			// 
			this.tabpreg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabpreg.BackgroundImage")));
			this.tabpreg.Controls.Add(this.button9);
			this.tabpreg.Controls.Add(this.BtnGuardarPregunta);
			this.tabpreg.Controls.Add(this.label12);
			this.tabpreg.Controls.Add(this.label11);
			this.tabpreg.Controls.Add(this.label10);
			this.tabpreg.Controls.Add(this.label9);
			this.tabpreg.Controls.Add(this.label8);
			this.tabpreg.Controls.Add(this.label7);
			this.tabpreg.Controls.Add(this.label6);
			this.tabpreg.Controls.Add(this.txtRespIng);
			this.tabpreg.Controls.Add(this.txtPreguntaIng);
			this.tabpreg.Controls.Add(this.txtOp1Esp);
			this.tabpreg.Controls.Add(this.txtOp4Esp);
			this.tabpreg.Controls.Add(this.txtOp4Ing);
			this.tabpreg.Controls.Add(this.txtOp3Ing);
			this.tabpreg.Controls.Add(this.txtOp1Ing);
			this.tabpreg.Controls.Add(this.txtOp3Esp);
			this.tabpreg.Controls.Add(this.txtOp2Esp);
			this.tabpreg.Controls.Add(this.txtOp2Ing);
			this.tabpreg.Controls.Add(this.txtRespEsp);
			this.tabpreg.Controls.Add(this.txtPreguntaEsp);
			this.tabpreg.Controls.Add(this.cmbModulos);
			this.tabpreg.Controls.Add(this.pictureBox2);
			this.tabpreg.Controls.Add(this.pictureBox1);
			this.tabpreg.Location = new System.Drawing.Point(4, 22);
			this.tabpreg.Name = "tabpreg";
			this.tabpreg.Size = new System.Drawing.Size(637, 338);
			this.tabpreg.TabIndex = 2;
			this.tabpreg.Text = "Preguntas y Respuestas/questions and answers";
			this.tabpreg.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(161, 302);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(115, 36);
			this.button9.TabIndex = 21;
			this.button9.Text = "Modificar";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// BtnGuardarPregunta
			// 
			this.BtnGuardarPregunta.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGuardarPregunta.Location = new System.Drawing.Point(318, 302);
			this.BtnGuardarPregunta.Name = "BtnGuardarPregunta";
			this.BtnGuardarPregunta.Size = new System.Drawing.Size(115, 36);
			this.BtnGuardarPregunta.TabIndex = 20;
			this.BtnGuardarPregunta.Text = "Guardar";
			this.BtnGuardarPregunta.UseVisualStyleBackColor = true;
			this.BtnGuardarPregunta.Click += new System.EventHandler(this.BtnGuardarPreguntaClick);
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(284, 86);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(110, 25);
			this.label12.TabIndex = 19;
			this.label12.Text = "Pregunta en inglés:";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label11.Location = new System.Drawing.Point(45, 18);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(121, 25);
			this.label11.TabIndex = 18;
			this.label11.Text = "Módulos:";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(333, 238);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(121, 25);
			this.label10.TabIndex = 17;
			this.label10.Text = "Respuesta en inglés:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(284, 45);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(121, 25);
			this.label9.TabIndex = 16;
			this.label9.Text = "Pregunta en español:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(333, 133);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(121, 25);
			this.label8.TabIndex = 15;
			this.label8.Text = "Opciones en inglés:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(45, 238);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 25);
			this.label7.TabIndex = 14;
			this.label7.Text = "Respuesta en español:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(45, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 25);
			this.label6.TabIndex = 13;
			this.label6.Text = "Opciones en español:";
			// 
			// txtRespIng
			// 
			this.txtRespIng.Location = new System.Drawing.Point(333, 266);
			this.txtRespIng.Name = "txtRespIng";
			this.txtRespIng.Size = new System.Drawing.Size(100, 20);
			this.txtRespIng.TabIndex = 12;
			// 
			// txtPreguntaIng
			// 
			this.txtPreguntaIng.Location = new System.Drawing.Point(411, 86);
			this.txtPreguntaIng.Name = "txtPreguntaIng";
			this.txtPreguntaIng.Size = new System.Drawing.Size(100, 20);
			this.txtPreguntaIng.TabIndex = 11;
			// 
			// txtOp1Esp
			// 
			this.txtOp1Esp.Location = new System.Drawing.Point(45, 161);
			this.txtOp1Esp.Name = "txtOp1Esp";
			this.txtOp1Esp.Size = new System.Drawing.Size(100, 20);
			this.txtOp1Esp.TabIndex = 10;
			// 
			// txtOp4Esp
			// 
			this.txtOp4Esp.Location = new System.Drawing.Point(176, 209);
			this.txtOp4Esp.Name = "txtOp4Esp";
			this.txtOp4Esp.Size = new System.Drawing.Size(100, 20);
			this.txtOp4Esp.TabIndex = 9;
			// 
			// txtOp4Ing
			// 
			this.txtOp4Ing.Location = new System.Drawing.Point(463, 209);
			this.txtOp4Ing.Name = "txtOp4Ing";
			this.txtOp4Ing.Size = new System.Drawing.Size(100, 20);
			this.txtOp4Ing.TabIndex = 8;
			// 
			// txtOp3Ing
			// 
			this.txtOp3Ing.Location = new System.Drawing.Point(333, 209);
			this.txtOp3Ing.Name = "txtOp3Ing";
			this.txtOp3Ing.Size = new System.Drawing.Size(100, 20);
			this.txtOp3Ing.TabIndex = 7;
			// 
			// txtOp1Ing
			// 
			this.txtOp1Ing.Location = new System.Drawing.Point(333, 161);
			this.txtOp1Ing.Name = "txtOp1Ing";
			this.txtOp1Ing.Size = new System.Drawing.Size(100, 20);
			this.txtOp1Ing.TabIndex = 6;
			// 
			// txtOp3Esp
			// 
			this.txtOp3Esp.Location = new System.Drawing.Point(45, 209);
			this.txtOp3Esp.Name = "txtOp3Esp";
			this.txtOp3Esp.Size = new System.Drawing.Size(100, 20);
			this.txtOp3Esp.TabIndex = 5;
			// 
			// txtOp2Esp
			// 
			this.txtOp2Esp.Location = new System.Drawing.Point(176, 161);
			this.txtOp2Esp.Name = "txtOp2Esp";
			this.txtOp2Esp.Size = new System.Drawing.Size(100, 20);
			this.txtOp2Esp.TabIndex = 4;
			// 
			// txtOp2Ing
			// 
			this.txtOp2Ing.Location = new System.Drawing.Point(463, 161);
			this.txtOp2Ing.Name = "txtOp2Ing";
			this.txtOp2Ing.Size = new System.Drawing.Size(100, 20);
			this.txtOp2Ing.TabIndex = 3;
			// 
			// txtRespEsp
			// 
			this.txtRespEsp.Location = new System.Drawing.Point(45, 266);
			this.txtRespEsp.Name = "txtRespEsp";
			this.txtRespEsp.Size = new System.Drawing.Size(100, 20);
			this.txtRespEsp.TabIndex = 2;
			// 
			// txtPreguntaEsp
			// 
			this.txtPreguntaEsp.Location = new System.Drawing.Point(411, 46);
			this.txtPreguntaEsp.Name = "txtPreguntaEsp";
			this.txtPreguntaEsp.Size = new System.Drawing.Size(100, 20);
			this.txtPreguntaEsp.TabIndex = 1;
			// 
			// cmbModulos
			// 
			this.cmbModulos.FormattingEnabled = true;
			this.cmbModulos.Items.AddRange(new object[] {
									"Arquitectura y Estructura del computador",
									"Antropología Filosófica",
									"Cálculo",
									"Educación Física"});
			this.cmbModulos.Location = new System.Drawing.Point(35, 46);
			this.cmbModulos.Name = "cmbModulos";
			this.cmbModulos.Size = new System.Drawing.Size(146, 21);
			this.cmbModulos.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Silver;
			this.pictureBox2.Location = new System.Drawing.Point(35, 124);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(550, 172);
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Silver;
			this.pictureBox1.Location = new System.Drawing.Point(269, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(316, 267);
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(12, -1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(684, 56);
			this.label4.TabIndex = 3;
			this.label4.Text = "Panel de Administrador";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(708, 464);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Usuarios);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Panel de Administrador";
			this.Usuarios.ResumeLayout(false);
			this.tabusu.ResumeLayout(false);
			this.tabusu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.tabmod.ResumeLayout(false);
			this.tabpreg.ResumeLayout(false);
			this.tabpreg.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button BtnVolver;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbModulos;
		private System.Windows.Forms.TextBox txtPreguntaEsp;
		private System.Windows.Forms.TextBox txtRespEsp;
		private System.Windows.Forms.TextBox txtOp2Ing;
		private System.Windows.Forms.TextBox txtOp2Esp;
		private System.Windows.Forms.TextBox txtOp3Esp;
		private System.Windows.Forms.TextBox txtOp1Ing;
		private System.Windows.Forms.TextBox txtOp3Ing;
		private System.Windows.Forms.TextBox txtOp4Ing;
		private System.Windows.Forms.TextBox txtOp4Esp;
		private System.Windows.Forms.TextBox txtOp1Esp;
		private System.Windows.Forms.TextBox txtPreguntaIng;
		private System.Windows.Forms.TextBox txtRespIng;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button BtnGuardarPregunta;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TabPage tabpreg;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCrearM;
		private System.Windows.Forms.Button btnVisualizarM;
		private System.Windows.Forms.Button btnEliminarM;
		private System.Windows.Forms.Button btnModificarM;
		private System.Windows.Forms.TabPage tabmod;
		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.Label lblcrearnu;
		private System.Windows.Forms.Label lblusu;
		private System.Windows.Forms.Label lblcontr;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Button BtnEliminarUsuario;
		private System.Windows.Forms.TabPage tabusu;
		private System.Windows.Forms.TabControl Usuarios;
	}
}
