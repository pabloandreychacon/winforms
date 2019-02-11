namespace Cursos.Presentation.Forms.Seguridad
{
    partial class SeguRespaldosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeguRespaldosForm));
            this.okButton1 = new BaseControls.Derived.OkButton();
            this.txtPath = new BaseControls.Derived.TextBasic();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton2 = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConexion = new BaseControls.Derived.TextBasic();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfoMessage
            // 
            this.lblInfoMessage.Location = new System.Drawing.Point(59, 467);
            // 
            // okButton1
            // 
            this.okButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton1.Image = ((System.Drawing.Image)(resources.GetObject("okButton1.Image")));
            this.okButton1.Location = new System.Drawing.Point(133, 173);
            this.okButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okButton1.Name = "okButton1";
            this.okButton1.Size = new System.Drawing.Size(60, 51);
            this.okButton1.TabIndex = 1;
            this.okButton1.UseVisualStyleBackColor = true;
            this.okButton1.Click += new System.EventHandler(this.okButton1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.FormatoTexto = null;
            this.txtPath.Location = new System.Drawing.Point(75, 107);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta:";
            // 
            // okButton2
            // 
            this.okButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton2.Image = ((System.Drawing.Image)(resources.GetObject("okButton2.Image")));
            this.okButton2.Location = new System.Drawing.Point(332, 107);
            this.okButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okButton2.Name = "okButton2";
            this.okButton2.Size = new System.Drawing.Size(60, 51);
            this.okButton2.TabIndex = 0;
            this.okButton2.UseVisualStyleBackColor = true;
            this.okButton2.Click += new System.EventHandler(this.okButton2_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(212, 173);
            this.closeButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(60, 51);
            this.closeButton1.TabIndex = 2;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conexión:";
            // 
            // txtConexion
            // 
            this.txtConexion.FormatoTexto = null;
            this.txtConexion.Location = new System.Drawing.Point(10, 29);
            this.txtConexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtConexion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "El usuario con el que seconecta a la base de datos, debe tener permisos para hace" +
    "r respaldos.";
            // 
            // SeguRespaldosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(418, 312);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConexion);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.okButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.okButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeguRespaldosForm";
            this.Text = "Respaldos";
            this.Load += new System.EventHandler(this.RespaldosForm_Load);
            this.Controls.SetChildIndex(this.lblInfoMessage, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.okButton1, 0);
            this.Controls.SetChildIndex(this.txtPath, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.okButton2, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.txtConexion, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.OkButton okButton1;
        private BaseControls.Derived.TextBasic txtPath;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.OkButton okButton2;
        private BaseControls.Derived.CloseButton closeButton1;
        private System.Windows.Forms.Label label2;
        public BaseControls.Derived.TextBasic txtConexion;
        private System.Windows.Forms.Label label3;
    }
}
