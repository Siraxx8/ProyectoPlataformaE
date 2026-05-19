/*
 * Creado por SharpDevelop.
 * Usuario: Sira
 * Fecha: 18/4/2026
 * Hora: 10:25 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoPE
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lbltitulo = new System.Windows.Forms.Label();
			this.btnIrLogin = new System.Windows.Forms.Button();
			this.btnIrRegistro = new System.Windows.Forms.Button();
			this.btnIdioma = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbltitulo
			// 
			this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
			this.lbltitulo.Font = new System.Drawing.Font("Haettenschweiler", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbltitulo.Location = new System.Drawing.Point(12, 20);
			this.lbltitulo.Name = "lbltitulo";
			this.lbltitulo.Size = new System.Drawing.Size(653, 77);
			this.lbltitulo.TabIndex = 2;
			this.lbltitulo.Text = "Plataforma Educativa Interactiva.";
			// 
			// btnIrLogin
			// 
			this.btnIrLogin.BackColor = System.Drawing.SystemColors.Control;
			this.btnIrLogin.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIrLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnIrLogin.Location = new System.Drawing.Point(267, 165);
			this.btnIrLogin.Name = "btnIrLogin";
			this.btnIrLogin.Size = new System.Drawing.Size(133, 47);
			this.btnIrLogin.TabIndex = 3;
			this.btnIrLogin.Text = "Iniciar Sesión";
			this.btnIrLogin.UseVisualStyleBackColor = false;
			this.btnIrLogin.Click += new System.EventHandler(this.BtnIrLoginClick);
			// 
			// btnIrRegistro
			// 
			this.btnIrRegistro.BackColor = System.Drawing.SystemColors.Control;
			this.btnIrRegistro.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIrRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnIrRegistro.Location = new System.Drawing.Point(267, 218);
			this.btnIrRegistro.Name = "btnIrRegistro";
			this.btnIrRegistro.Size = new System.Drawing.Size(133, 47);
			this.btnIrRegistro.TabIndex = 4;
			this.btnIrRegistro.Text = "Registrarse";
			this.btnIrRegistro.UseVisualStyleBackColor = false;
			this.btnIrRegistro.Click += new System.EventHandler(this.BtnIrRegistroClick);
			// 
			// btnIdioma
			// 
			this.btnIdioma.BackColor = System.Drawing.SystemColors.Control;
			this.btnIdioma.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnIdioma.Location = new System.Drawing.Point(12, 357);
			this.btnIdioma.Name = "btnIdioma";
			this.btnIdioma.Size = new System.Drawing.Size(134, 47);
			this.btnIdioma.TabIndex = 5;
			this.btnIdioma.Text = "change to english";
			this.btnIdioma.UseVisualStyleBackColor = false;
			this.btnIdioma.Click += new System.EventHandler(this.BtnIdiomaClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
			this.btnSalir.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSalir.Location = new System.Drawing.Point(572, 363);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(93, 41);
			this.btnSalir.TabIndex = 6;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(677, 416);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnIdioma);
			this.Controls.Add(this.btnIrRegistro);
			this.Controls.Add(this.btnIrLogin);
			this.Controls.Add(this.lbltitulo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inicio";
			this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnIdioma;
		private System.Windows.Forms.Button btnIrRegistro;
		private System.Windows.Forms.Button btnIrLogin;
		private System.Windows.Forms.Label lbltitulo;
	}
}
