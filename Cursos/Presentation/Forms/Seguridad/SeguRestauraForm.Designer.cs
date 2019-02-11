namespace Cursos.Presentation.Forms.Seguridad
{
    partial class SeguRestauraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeguRestauraForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtConexion = new BaseControls.Derived.TextBasic();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.buscaRespaldoBtn = new BaseControls.Derived.OkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new BaseControls.Derived.TextBasic();
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfoMessage
            // 
            this.lblInfoMessage.Location = new System.Drawing.Point(59, 475);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Conexión:";
            // 
            // txtConexion
            // 
            this.txtConexion.FormatoTexto = null;
            this.txtConexion.Location = new System.Drawing.Point(10, 25);
            this.txtConexion.Margin = new System.Windows.Forms.Padding(2);
            this.txtConexion.Multiline = true;
            this.txtConexion.Name = "txtConexion";
            this.txtConexion.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtConexion.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtConexion.Size = new System.Drawing.Size(401, 57);
            this.txtConexion.TabIndex = 13;
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(212, 249);
            this.closeButton1.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(60, 51);
            this.closeButton1.TabIndex = 10;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // buscaRespaldoBtn
            // 
            this.buscaRespaldoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buscaRespaldoBtn.Image = ((System.Drawing.Image)(resources.GetObject("buscaRespaldoBtn.Image")));
            this.buscaRespaldoBtn.Location = new System.Drawing.Point(333, 104);
            this.buscaRespaldoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.buscaRespaldoBtn.Name = "buscaRespaldoBtn";
            this.buscaRespaldoBtn.Size = new System.Drawing.Size(60, 51);
            this.buscaRespaldoBtn.TabIndex = 8;
            this.buscaRespaldoBtn.UseVisualStyleBackColor = true;
            this.buscaRespaldoBtn.Click += new System.EventHandler(this.buscaRespaldoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ruta:";
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.FormatoTexto = null;
            this.txtPath.Location = new System.Drawing.Point(76, 104);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPath.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(241, 52);
            this.txtPath.TabIndex = 11;
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(133, 249);
            this.okButton1.Margin = new System.Windows.Forms.Padding(2);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(60, 51);
            this.okButton1.TabIndex = 9;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 44);
            this.label3.TabIndex = 15;
            this.label3.Text = "El usuario con el que seconecta a la base de datos, debe tener permisos para recu" +
    "perar respaldos.";
            // 
            // SeguRestauraForm
            // 
            this.AcceptButton = this.okButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(422, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConexion);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.buscaRespaldoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.okButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeguRestauraForm";
            this.Text = "Restaurar respaldo";
            this.Load += new System.EventHandler(this.SeguRestauraForm_Load);
            this.Controls.SetChildIndex(this.lblInfoMessage, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.Controls.SetChildIndex(this.txtPath, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buscaRespaldoBtn, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.txtConexion, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public BaseControls.Derived.TextBasic txtConexion;
        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton buscaRespaldoBtn;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic txtPath;
        private BaseControls.Derived.OkButton okButton1;
        private System.Windows.Forms.Label label3;
    }
}
