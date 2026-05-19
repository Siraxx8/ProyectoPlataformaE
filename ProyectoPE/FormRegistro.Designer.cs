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
			this.lblregi = new System.Windows.Forms.Label();
			this.lblusu = new System.Windows.Forms.Label();
			this.lblrol = new System.Windows.Forms.Label();
			this.lblcon = new System.Windows.Forms.Label();
			this.cmbRol = new System.Windows.Forms.ComboBox();
			this.textNuevoUsuario = new System.Windows.Forms.TextBox();
			this.textNuevaPass = new System.Windows.Forms.TextBox();
			this.BtnRegistrarse = new System.Windows.Forms.Button();
			this.BtnVolver = new System.Windows.Forms.Button();
			this.dgvNombres = new System.Windows.Forms.DataGridView();
			this.lblns = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvNombres)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblregi
			// 
			this.lblregi.BackColor = System.Drawing.Color.Transparent;
			this.lblregi.Font = new System.Drawing.Font("Haettenschweiler", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblregi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblregi.Location = new System.Drawing.Point(48, 0);
			this.lblregi.Name = "lblregi";
			this.lblregi.Size = new System.Drawing.Size(572, 79);
			this.lblregi.TabIndex = 0;
			this.lblregi.Text = "Registro";
			this.lblregi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblusu
			// 
			this.lblusu.BackColor = System.Drawing.Color.Transparent;
			this.lblusu.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblusu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblusu.Location = new System.Drawing.Point(26, 17);
			this.lblusu.Name = "lblusu";
			this.lblusu.Size = new System.Drawing.Size(211, 27);
			this.lblusu.TabIndex = 2;
			this.lblusu.Text = "Nombre de usuario:";
			// 
			// lblrol
			// 
			this.lblrol.BackColor = System.Drawing.Color.Transparent;
			this.lblrol.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblrol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblrol.Location = new System.Drawing.Point(26, 161);
			this.lblrol.Name = "lblrol";
			this.lblrol.Size = new System.Drawing.Size(131, 27);
			this.lblrol.TabIndex = 3;
			this.lblrol.Text = "Rol:";
			// 
			// lblcon
			// 
			this.lblcon.BackColor = System.Drawing.Color.Transparent;
			this.lblcon.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblcon.Location = new System.Drawing.Point(26, 87);
			this.lblcon.Name = "lblcon";
			this.lblcon.Size = new System.Drawing.Size(131, 27);
			this.lblcon.TabIndex = 4;
			this.lblcon.Text = "Contraseña:";
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
			// textNuevoUsuario
			// 
			this.textNuevoUsuario.Location = new System.Drawing.Point(26, 47);
			this.textNuevoUsuario.Name = "textNuevoUsuario";
			this.textNuevoUsuario.Size = new System.Drawing.Size(156, 20);
			this.textNuevoUsuario.TabIndex = 6;
			// 
			// textNuevaPass
			// 
			this.textNuevaPass.Location = new System.Drawing.Point(26, 117);
			this.textNuevaPass.Name = "textNuevaPass";
			this.textNuevaPass.Size = new System.Drawing.Size(156, 20);
			this.textNuevaPass.TabIndex = 7;
			// 
			// BtnRegistrarse
			// 
			this.BtnRegistrarse.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRegistrarse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnRegistrarse.Location = new System.Drawing.Point(26, 261);
			this.BtnRegistrarse.Name = "BtnRegistrarse";
			this.BtnRegistrarse.Size = new System.Drawing.Size(100, 31);
			this.BtnRegistrarse.TabIndex = 8;
			this.BtnRegistrarse.Text = "Registrarse";
			this.BtnRegistrarse.UseVisualStyleBackColor = true;
			this.BtnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarseClick);
			// 
			// BtnVolver
			// 
			this.BtnVolver.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnVolver.Location = new System.Drawing.Point(174, 261);
			this.BtnVolver.Name = "BtnVolver";
			this.BtnVolver.Size = new System.Drawing.Size(100, 31);
			this.BtnVolver.TabIndex = 9;
			this.BtnVolver.Text = "Volver";
			this.BtnVolver.UseVisualStyleBackColor = true;
			this.BtnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// dgvNombres
			// 
			this.dgvNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvNombres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNombres.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNombres.Location = new System.Drawing.Point(366, 47);
			this.dgvNombres.Name = "dgvNombres";
			this.dgvNombres.Size = new System.Drawing.Size(240, 266);
			this.dgvNombres.TabIndex = 10;
			// 
			// lblns
			// 
			this.lblns.BackColor = System.Drawing.Color.Transparent;
			this.lblns.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblns.Location = new System.Drawing.Point(351, 9);
			this.lblns.Name = "lblns";
			this.lblns.Size = new System.Drawing.Size(292, 35);
			this.lblns.TabIndex = 11;
			this.lblns.Text = "Nombres que no se pueden usar:";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.dgvNombres);
			this.panel1.Controls.Add(this.BtnVolver);
			this.panel1.Controls.Add(this.BtnRegistrarse);
			this.panel1.Controls.Add(this.textNuevaPass);
			this.panel1.Controls.Add(this.textNuevoUsuario);
			this.panel1.Controls.Add(this.cmbRol);
			this.panel1.Controls.Add(this.lblcon);
			this.panel1.Controls.Add(this.lblrol);
			this.panel1.Controls.Add(this.lblusu);
			this.panel1.Controls.Add(this.lblns);
			this.panel1.Location = new System.Drawing.Point(32, 82);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 325);
			this.panel1.TabIndex = 1;
			// 
			// FormRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(687, 468);
			this.Controls.Add(this.lblregi);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormRegistro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro";
			((System.ComponentModel.ISupportInitialize)(this.dgvNombres)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dgvNombres;
		private System.Windows.Forms.Label lblns;
		private System.Windows.Forms.Button BtnRegistrarse;
		private System.Windows.Forms.Button BtnVolver;
		private System.Windows.Forms.ComboBox cmbRol;
		private System.Windows.Forms.TextBox textNuevoUsuario;
		private System.Windows.Forms.TextBox textNuevaPass;
		private System.Windows.Forms.Label lblusu;
		private System.Windows.Forms.Label lblrol;
		private System.Windows.Forms.Label lblcon;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblregi;
	}
}
