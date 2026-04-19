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
			this.label1 = new System.Windows.Forms.Label();
			this.btnIrLogin = new System.Windows.Forms.Button();
			this.btnIrRegistro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(77, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(529, 77);
			this.label1.TabIndex = 2;
			this.label1.Text = "Plataforma Educativa Interactiva.";
			// 
			// btnIrLogin
			// 
			this.btnIrLogin.BackColor = System.Drawing.Color.White;
			this.btnIrLogin.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIrLogin.Location = new System.Drawing.Point(170, 167);
			this.btnIrLogin.Name = "btnIrLogin";
			this.btnIrLogin.Size = new System.Drawing.Size(133, 47);
			this.btnIrLogin.TabIndex = 3;
			this.btnIrLogin.Text = "Iniciar Sesión";
			this.btnIrLogin.UseVisualStyleBackColor = false;
			this.btnIrLogin.Click += new System.EventHandler(this.BtnIrLoginClick);
			// 
			// btnIrRegistro
			// 
			this.btnIrRegistro.BackColor = System.Drawing.Color.White;
			this.btnIrRegistro.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIrRegistro.Location = new System.Drawing.Point(355, 167);
			this.btnIrRegistro.Name = "btnIrRegistro";
			this.btnIrRegistro.Size = new System.Drawing.Size(133, 47);
			this.btnIrRegistro.TabIndex = 4;
			this.btnIrRegistro.Text = "Registrarse";
			this.btnIrRegistro.UseVisualStyleBackColor = false;
			this.btnIrRegistro.Click += new System.EventHandler(this.BtnIrRegistroClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(677, 416);
			this.Controls.Add(this.btnIrRegistro);
			this.Controls.Add(this.btnIrLogin);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inicio";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnIrRegistro;
		private System.Windows.Forms.Button btnIrLogin;
		private System.Windows.Forms.Label label1;
	}
}
