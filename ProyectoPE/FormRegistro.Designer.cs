/*
 * Creado por SharpDevelop.
 * Usuario: Sira
 * Fecha: 18/4/2026
 * Hora: 10:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoPE
{
	partial class FormRegistro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.BtnVolver = new System.Windows.Forms.Button();
			this.BtnRegistrarse = new System.Windows.Forms.Button();
			this.textNuevaPass = new System.Windows.Forms.TextBox();
			this.textNuevoUsuario = new System.Windows.Forms.TextBox();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Nombr = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Haettenschweiler", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(264, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(225, 62);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registro";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BtnVolver);
			this.panel1.Controls.Add(this.BtnRegistrarse);
			this.panel1.Controls.Add(this.textNuevaPass);
			this.panel1.Controls.Add(this.textNuevoUsuario);
			this.panel1.Controls.Add(this.cmbRol);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.Nombr);
			this.panel1.Location = new System.Drawing.Point(33, 82);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(629, 324);
			this.panel1.TabIndex = 1;
			// 
			// BtnVolver
			// 
			this.BtnVolver.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnVolver.Location = new System.Drawing.Point(487, 261);
			this.BtnVolver.Name = "BtnVolver";
			this.BtnVolver.Size = new System.Drawing.Size(100, 31);
			this.BtnVolver.TabIndex = 9;
			this.BtnVolver.Text = "Volver";
			this.BtnVolver.UseVisualStyleBackColor = true;
			this.BtnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// BtnRegistrarse
			// 
			this.BtnRegistrarse.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRegistrarse.Location = new System.Drawing.Point(26, 261);
			this.BtnRegistrarse.Name = "BtnRegistrarse";
			this.BtnRegistrarse.Size = new System.Drawing.Size(100, 31);
			this.BtnRegistrarse.TabIndex = 8;
			this.BtnRegistrarse.Text = "Registrarse";
			this.BtnRegistrarse.UseVisualStyleBackColor = true;
			this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarseClick);
			// 
			// textNuevaPass
			// 
			this.textNuevaPass.Location = new System.Drawing.Point(26, 117);
			this.textNuevaPass.Name = "textNuevaPass";
			this.textNuevaPass.Size = new System.Drawing.Size(156, 20);
			this.textNuevaPass.TabIndex = 7;
			// 
			// textNuevoUsuario
			// 
			this.textNuevoUsuario.Location = new System.Drawing.Point(26, 47);
			this.textNuevoUsuario.Name = "textNuevoUsuario";
			this.textNuevoUsuario.Size = new System.Drawing.Size(156, 20);
			this.textNuevoUsuario.TabIndex = 6;
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.Items.AddRange(new object[] {
									"Administrador",
									"Jugador"});
			this.cmbRol.Location = new System.Drawing.Point(26, 191);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(121, 21);
			this.cmbRol.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(26, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 27);
			this.label4.TabIndex = 4;
			this.label4.Text = "Contraseña:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(26, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 27);
			this.label3.TabIndex = 3;
			this.label3.Text = "Rol:";
			// 
			// Nombr
			// 
			this.Nombr.BackColor = System.Drawing.Color.Transparent;
			this.Nombr.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Nombr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Nombr.Location = new System.Drawing.Point(26, 17);
			this.Nombr.Name = "Nombr";
			this.Nombr.Size = new System.Drawing.Size(131, 27);
			this.Nombr.TabIndex = 2;
			this.Nombr.Text = "Nombre de usuario:";
			// 
			// FormRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(687, 468);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormRegistro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button BtnRegistrarse;
		private System.Windows.Forms.Button BtnVolver;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.TextBox textNuevoUsuario;
		private System.Windows.Forms.TextBox textNuevaPass;
		private System.Windows.Forms.Label Nombr;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
	}
}
