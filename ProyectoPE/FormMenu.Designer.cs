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
			this.lblMenu = new System.Windows.Forms.Label();
			this.BtnCerrarSesion = new System.Windows.Forms.Button();
			this.btnIdioma = new System.Windows.Forms.Button();
			this.BtnPanelAdmin = new System.Windows.Forms.Button();
			this.BtnJugar = new System.Windows.Forms.Button();
			this.cmbModulosJugador = new System.Windows.Forms.ComboBox();
			this.lblpuntuacion = new System.Windows.Forms.Label();
			this.lblNombreUsuario = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMenu
			// 
			this.lblMenu.BackColor = System.Drawing.Color.Transparent;
			this.lblMenu.Font = new System.Drawing.Font("Haettenschweiler", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblMenu.Location = new System.Drawing.Point(331, 4);
			this.lblMenu.Name = "lblMenu";
			this.lblMenu.Size = new System.Drawing.Size(401, 61);
			this.lblMenu.TabIndex = 1;
			this.lblMenu.Text = "Menú Principal";
			this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BtnCerrarSesion
			// 
			this.BtnCerrarSesion.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnCerrarSesion.Location = new System.Drawing.Point(12, 386);
			this.BtnCerrarSesion.Name = "BtnCerrarSesion";
			this.BtnCerrarSesion.Size = new System.Drawing.Size(135, 36);
			this.BtnCerrarSesion.TabIndex = 2;
			this.BtnCerrarSesion.Text = "Cerrar Sesión";
			this.BtnCerrarSesion.UseVisualStyleBackColor = true;
			this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesionClick);
			// 
			// btnIdioma
			// 
			this.btnIdioma.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnIdioma.Location = new System.Drawing.Point(12, 344);
			this.btnIdioma.Name = "btnIdioma";
			this.btnIdioma.Size = new System.Drawing.Size(135, 36);
			this.btnIdioma.TabIndex = 3;
			this.btnIdioma.Text = "Idioma/Language";
			this.btnIdioma.UseVisualStyleBackColor = true;
			this.btnIdioma.Click += new System.EventHandler(this.BtnIdiomaClick);
			// 
			// BtnPanelAdmin
			// 
			this.BtnPanelAdmin.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPanelAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnPanelAdmin.Location = new System.Drawing.Point(3, 65);
			this.BtnPanelAdmin.Name = "BtnPanelAdmin";
			this.BtnPanelAdmin.Size = new System.Drawing.Size(189, 36);
			this.BtnPanelAdmin.TabIndex = 4;
			this.BtnPanelAdmin.Text = "Panel de Administrador";
			this.BtnPanelAdmin.UseVisualStyleBackColor = true;
			this.BtnPanelAdmin.Click += new System.EventHandler(this.BtnPanelAdminClick);
			// 
			// BtnJugar
			// 
			this.BtnJugar.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnJugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnJugar.Location = new System.Drawing.Point(465, 385);
			this.BtnJugar.Name = "BtnJugar";
			this.BtnJugar.Size = new System.Drawing.Size(210, 36);
			this.BtnJugar.TabIndex = 5;
			this.BtnJugar.Text = "Jugar";
			this.BtnJugar.UseVisualStyleBackColor = true;
			this.BtnJugar.Click += new System.EventHandler(this.BtnJugarClick);
			// 
			// cmbModulosJugador
			// 
			this.cmbModulosJugador.FormattingEnabled = true;
			this.cmbModulosJugador.Items.AddRange(new object[] {
									"Arquitectura y Estructura del Computador",
									"Antropología Filosófica",
									"Cálculo",
									"Educación Física"});
			this.cmbModulosJugador.Location = new System.Drawing.Point(465, 344);
			this.cmbModulosJugador.Name = "cmbModulosJugador";
			this.cmbModulosJugador.Size = new System.Drawing.Size(210, 21);
			this.cmbModulosJugador.TabIndex = 6;
			// 
			// lblpuntuacion
			// 
			this.lblpuntuacion.BackColor = System.Drawing.Color.Transparent;
			this.lblpuntuacion.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpuntuacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblpuntuacion.Location = new System.Drawing.Point(70, 34);
			this.lblpuntuacion.Name = "lblpuntuacion";
			this.lblpuntuacion.Size = new System.Drawing.Size(149, 25);
			this.lblpuntuacion.TabIndex = 7;
			this.lblpuntuacion.Text = "Puntuación: 0";
			// 
			// lblNombreUsuario
			// 
			this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lblNombreUsuario.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblNombreUsuario.Location = new System.Drawing.Point(70, 9);
			this.lblNombreUsuario.Name = "lblNombreUsuario";
			this.lblNombreUsuario.Size = new System.Drawing.Size(207, 25);
			this.lblNombreUsuario.TabIndex = 8;
			this.lblNombreUsuario.Text = "Usuario";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(3, 9);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(61, 50);
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(687, 436);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblNombreUsuario);
			this.Controls.Add(this.lblpuntuacion);
			this.Controls.Add(this.cmbModulosJugador);
			this.Controls.Add(this.BtnJugar);
			this.Controls.Add(this.BtnPanelAdmin);
			this.Controls.Add(this.btnIdioma);
			this.Controls.Add(this.BtnCerrarSesion);
			this.Controls.Add(this.lblMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Activated += new System.EventHandler(this.FormMenuActivated);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblNombreUsuario;
		private System.Windows.Forms.Label lblpuntuacion;
		private System.Windows.Forms.ComboBox cmbModulosJugador;
		private System.Windows.Forms.Button BtnJugar;
		private System.Windows.Forms.Button BtnPanelAdmin;
		private System.Windows.Forms.Button btnIdioma;
		private System.Windows.Forms.Button BtnCerrarSesion;
		private System.Windows.Forms.Label lblMenu;
		
		
	}
}
