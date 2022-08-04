namespace BugTrucker
{
    partial class FormularioLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnUser = new System.Windows.Forms.Label();
            this.lblnPsw = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnUser
            // 
            this.lblnUser.AutoSize = true;
            this.lblnUser.Location = new System.Drawing.Point(54, 57);
            this.lblnUser.Name = "lblnUser";
            this.lblnUser.Size = new System.Drawing.Size(46, 15);
            this.lblnUser.TabIndex = 0;
            this.lblnUser.Text = "usuario";
            // 
            // lblnPsw
            // 
            this.lblnPsw.AutoSize = true;
            this.lblnPsw.Location = new System.Drawing.Point(54, 91);
            this.lblnPsw.Name = "lblnPsw";
            this.lblnPsw.Size = new System.Drawing.Size(67, 15);
            this.lblnPsw.TabIndex = 1;
            this.lblnPsw.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(132, 54);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(266, 23);
            this.txtUser.TabIndex = 2;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(132, 88);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(266, 23);
            this.txtPsw.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(285, 156);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(366, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormularioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 197);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblnPsw);
            this.Controls.Add(this.lblnUser);
            this.Name = "FormularioLogin";
            this.Text = "FormularioLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblnUser;
        private Label lblnPsw;
        private TextBox txtUser;
        private TextBox txtPsw;
        private Button btnIngresar;
        private Button btnSalir;
    }
}