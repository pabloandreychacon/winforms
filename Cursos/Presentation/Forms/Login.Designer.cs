namespace Cursos.Presentation.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton1 = new BaseControls.Derived.ExitButton();
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.txtUser = new BaseControls.Derived.TextBasic();
            this.txtPass = new BaseControls.Derived.TextBasic();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "CURSOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Clave:";
            // 
            // exitButton1
            // 
            this.exitButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton1.Image = ((System.Drawing.Image)(resources.GetObject("exitButton1.Image")));
            this.exitButton1.Location = new System.Drawing.Point(190, 210);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(125, 82);
            this.exitButton1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.exitButton1, "Salir del sistema");
            this.exitButton1.UseVisualStyleBackColor = true;
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(28, 210);
            this.okButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(125, 82);
            this.okButton1.TabIndex = 11;
            this.toolTip1.SetToolTip(this.okButton1, "Entrar al sistema");
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // txtUser
            // 
            this.txtUser.FormatoTexto = null;
            this.txtUser.Location = new System.Drawing.Point(142, 92);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtUser.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtUser.Size = new System.Drawing.Size(164, 28);
            this.txtUser.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtUser, "Nombre del usuario");
            // 
            // txtPass
            // 
            this.txtPass.FormatoTexto = null;
            this.txtPass.Location = new System.Drawing.Point(142, 136);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPass.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPass.Size = new System.Drawing.Size(164, 28);
            this.txtPass.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtPass, "Clave del usuario");
            // 
            // Login
            // 
            this.AcceptButton = this.okButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton1;
            this.ClientSize = new System.Drawing.Size(342, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.okButton1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Login";
            this.Text = "Entrada al sistema";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.txtPass, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.Controls.SetChildIndex(this.exitButton1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.ExitButton exitButton1;
        private BaseControls.Derived.OkButton okButton1;
        private BaseControls.Derived.TextBasic txtUser;
        private BaseControls.Derived.TextBasic txtPass;
    }
}