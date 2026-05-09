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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.BtnVolver = new System.Windows.Forms.Button();
			this.BtnEliminarUsuario = new System.Windows.Forms.Button();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnModificarM = new System.Windows.Forms.Button();
			this.btnEliminarM = new System.Windows.Forms.Button();
			this.btnVisualizarM = new System.Windows.Forms.Button();
			this.btnCrearM = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.BtnGuardarPregunta = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.cmbModulos = new System.Windows.Forms.ComboBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Usuarios.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Usuarios
			// 
			this.Usuarios.Controls.Add(this.tabPage1);
			this.Usuarios.Controls.Add(this.tabPage2);
			this.Usuarios.Controls.Add(this.tabPage3);
			this.Usuarios.Location = new System.Drawing.Point(23, 58);
			this.Usuarios.Name = "Usuarios";
			this.Usuarios.SelectedIndex = 0;
			this.Usuarios.Size = new System.Drawing.Size(645, 364);
			this.Usuarios.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.BtnVolver);
			this.tabPage1.Controls.Add(this.BtnEliminarUsuario);
			this.tabPage1.Controls.Add(this.BtnGuardar);
			this.tabPage1.Controls.Add(this.txtUsuario);
			this.tabPage1.Controls.Add(this.txtPass);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dgvUsuarios);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(637, 338);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Usuarios";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// BtnVolver
			// 
			this.BtnVolver.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.BtnEliminarUsuario.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.BtnGuardar.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(280, 310);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Contraseña:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(299, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Usuario:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(365, 247);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Crear nuevo usuario:";
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(185, 6);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuarios.Size = new System.Drawing.Size(446, 236);
			this.dgvUsuarios.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnModificarM);
			this.tabPage2.Controls.Add(this.btnEliminarM);
			this.tabPage2.Controls.Add(this.btnVisualizarM);
			this.tabPage2.Controls.Add(this.btnCrearM);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(637, 338);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Módulos";
			this.tabPage2.UseVisualStyleBackColor = true;
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
			this.label5.Location = new System.Drawing.Point(193, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(289, 47);
			this.label5.TabIndex = 3;
			this.label5.Text = "Configurar Módulos.";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button9);
			this.tabPage3.Controls.Add(this.BtnGuardarPregunta);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.textBox14);
			this.tabPage3.Controls.Add(this.textBox13);
			this.tabPage3.Controls.Add(this.textBox12);
			this.tabPage3.Controls.Add(this.textBox11);
			this.tabPage3.Controls.Add(this.textBox10);
			this.tabPage3.Controls.Add(this.textBox9);
			this.tabPage3.Controls.Add(this.textBox8);
			this.tabPage3.Controls.Add(this.textBox7);
			this.tabPage3.Controls.Add(this.textBox6);
			this.tabPage3.Controls.Add(this.textBox5);
			this.tabPage3.Controls.Add(this.textBox4);
			this.tabPage3.Controls.Add(this.textBox3);
			this.tabPage3.Controls.Add(this.cmbModulos);
			this.tabPage3.Controls.Add(this.pictureBox2);
			this.tabPage3.Controls.Add(this.pictureBox1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(637, 338);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Preguntas y Respuestas";
			this.tabPage3.UseVisualStyleBackColor = true;
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
			this.label11.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.label6.Location = new System.Drawing.Point(45, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 25);
			this.label6.TabIndex = 13;
			this.label6.Text = "Opciones en español:";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(333, 266);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(100, 20);
			this.textBox14.TabIndex = 12;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(411, 86);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(100, 20);
			this.textBox13.TabIndex = 11;
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(45, 161);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(100, 20);
			this.textBox12.TabIndex = 10;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(176, 209);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(100, 20);
			this.textBox11.TabIndex = 9;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(463, 209);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(100, 20);
			this.textBox10.TabIndex = 8;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(333, 209);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 20);
			this.textBox9.TabIndex = 7;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(333, 161);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 20);
			this.textBox8.TabIndex = 6;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(45, 209);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 20);
			this.textBox7.TabIndex = 5;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(176, 161);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 4;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(463, 161);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(45, 266);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(411, 46);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 1;
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
			this.cmbModulos.SelectedIndexChanged += new System.EventHandler(this.CmbModulosSelectedIndexChanged);
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
			this.label4.Location = new System.Drawing.Point(157, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(379, 46);
			this.label4.TabIndex = 3;
			this.label4.Text = "Panel de Administrador.";
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
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button BtnVolver;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbModulos;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button BtnGuardarPregunta;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnCrearM;
		private System.Windows.Forms.Button btnVisualizarM;
		private System.Windows.Forms.Button btnEliminarM;
		private System.Windows.Forms.Button btnModificarM;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Button BtnEliminarUsuario;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl Usuarios;
	}
}
