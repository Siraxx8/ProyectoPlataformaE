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
	partial class FormMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnCerrarSesion = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.BtnPanelAdmin = new System.Windows.Forms.Button();
			this.BtnJugar = new System.Windows.Forms.Button();
			this.cmbModulos = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblNombreUsuario = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(191, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(302, 192);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(231, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 48);
			this.label1.TabIndex = 1;
			this.label1.Text = "Menú Principal";
			// 
			// BtnCerrarSesion
			// 
			this.BtnCerrarSesion.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCerrarSesion.Location = new System.Drawing.Point(538, 358);
			this.BtnCerrarSesion.Name = "BtnCerrarSesion";
			this.BtnCerrarSesion.Size = new System.Drawing.Size(114, 36);
			this.BtnCerrarSesion.TabIndex = 2;
			this.BtnCerrarSesion.Text = "Cerrar Sesión";
			this.BtnCerrarSesion.UseVisualStyleBackColor = true;
			this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesionClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(32, 358);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 36);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cambiar a inglés";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// BtnPanelAdmin
			// 
			this.BtnPanelAdmin.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPanelAdmin.Location = new System.Drawing.Point(262, 367);
			this.BtnPanelAdmin.Name = "BtnPanelAdmin";
			this.BtnPanelAdmin.Size = new System.Drawing.Size(155, 36);
			this.BtnPanelAdmin.TabIndex = 4;
			this.BtnPanelAdmin.Text = "Panel de Administrador";
			this.BtnPanelAdmin.UseVisualStyleBackColor = true;
			this.BtnPanelAdmin.Click += new System.EventHandler(this.BtnPanelAdminClick);
			// 
			// BtnJugar
			// 
			this.BtnJugar.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnJugar.Location = new System.Drawing.Point(262, 258);
			this.BtnJugar.Name = "BtnJugar";
			this.BtnJugar.Size = new System.Drawing.Size(155, 36);
			this.BtnJugar.TabIndex = 5;
			this.BtnJugar.Text = "Jugar";
			this.BtnJugar.UseVisualStyleBackColor = true;
			this.BtnJugar.Click += new System.EventHandler(this.BtnJugarClick);
			// 
			// cmbModulos
			// 
			this.cmbModulos.FormattingEnabled = true;
			this.cmbModulos.Items.AddRange(new object[] {
									"Arquitectura y Estructura del Computador",
									"Antropología Filosófica",
									"Cálculo",
									"Educación Física"});
			this.cmbModulos.Location = new System.Drawing.Point(231, 300);
			this.cmbModulos.Name = "cmbModulos";
			this.cmbModulos.Size = new System.Drawing.Size(210, 21);
			this.cmbModulos.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(538, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Puntuación: 0";
			// 
			// lblNombreUsuario
			// 
			this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblNombreUsuario.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNombreUsuario.Location = new System.Drawing.Point(12, 9);
			this.lblNombreUsuario.Name = "lblNombreUsuario";
			this.lblNombreUsuario.Size = new System.Drawing.Size(167, 25);
			this.lblNombreUsuario.TabIndex = 8;
			this.lblNombreUsuario.Text = "Usuario";
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(687, 436);
			this.Controls.Add(this.lblNombreUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbModulos);
			this.Controls.Add(this.BtnJugar);
			this.Controls.Add(this.BtnPanelAdmin);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.BtnCerrarSesion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblNombreUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbModulos;
		private System.Windows.Forms.Button BtnJugar;
		private System.Windows.Forms.Button BtnPanelAdmin;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button BtnCerrarSesion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
