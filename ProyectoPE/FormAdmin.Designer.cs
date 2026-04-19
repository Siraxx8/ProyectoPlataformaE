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
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Usuarios.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
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
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox2);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dataGridView1);
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
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(20, 60);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(135, 46);
			this.button3.TabIndex = 8;
			this.button3.Text = "Ver puntuación";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(20, 128);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 46);
			this.button2.TabIndex = 7;
			this.button2.Text = "Eliminar Usuario";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(530, 275);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 36);
			this.button1.TabIndex = 6;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(350, 275);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(136, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(350, 310);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(136, 20);
			this.textBox1.TabIndex = 4;
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(185, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(446, 236);
			this.dataGridView1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button7);
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(637, 338);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Módulos";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(314, 79);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(135, 46);
			this.button7.TabIndex = 12;
			this.button7.Text = "MODIFICAR";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(314, 167);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(135, 46);
			this.button6.TabIndex = 11;
			this.button6.Text = "ELIMINAR";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(149, 167);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(135, 46);
			this.button5.TabIndex = 10;
			this.button5.Text = "VISUALIZAR";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(149, 79);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(135, 46);
			this.button4.TabIndex = 9;
			this.button4.Text = "CREAR";
			this.button4.UseVisualStyleBackColor = true;
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
			this.tabPage3.Controls.Add(this.button8);
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
			this.tabPage3.Controls.Add(this.comboBox1);
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
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(318, 302);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(115, 36);
			this.button8.TabIndex = 20;
			this.button8.Text = "Guardar";
			this.button8.UseVisualStyleBackColor = true;
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
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Arquitectura y Estructura del computador",
									"Antropología Filosófica",
									"Cálculo",
									"Educación Física"});
			this.comboBox1.Location = new System.Drawing.Point(35, 46);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(146, 21);
			this.comboBox1.TabIndex = 0;
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button BtnVolver;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
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
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl Usuarios;
	}
}
