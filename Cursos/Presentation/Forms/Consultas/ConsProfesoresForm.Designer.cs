namespace Cursos.Presentation.Forms.Consultas
{
    partial class ConsProfesoresForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsProfesoresForm));
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.btnConsultar = new BaseControls.Derived.OkButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chkActivos = new System.Windows.Forms.CheckBox();
            this.chkInactivos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContiene = new BaseControls.Derived.TextBasic();
            this.cboFiltros = new BaseControls.Derived.ComboBasic();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(326, 153);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 68);
            this.closeButton1.TabIndex = 24;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(218, 153);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 68);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chkActivos
            // 
            this.chkActivos.AutoSize = true;
            this.chkActivos.Checked = true;
            this.chkActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivos.Location = new System.Drawing.Point(19, 95);
            this.chkActivos.Name = "chkActivos";
            this.chkActivos.Size = new System.Drawing.Size(92, 28);
            this.chkActivos.TabIndex = 37;
            this.chkActivos.Text = "Activos";
            this.chkActivos.UseVisualStyleBackColor = true;
            // 
            // chkInactivos
            // 
            this.chkInactivos.AutoSize = true;
            this.chkInactivos.Checked = true;
            this.chkInactivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInactivos.Location = new System.Drawing.Point(137, 95);
            this.chkInactivos.Name = "chkInactivos";
            this.chkInactivos.Size = new System.Drawing.Size(104, 28);
            this.chkInactivos.TabIndex = 38;
            this.chkInactivos.Text = "Inactivos";
            this.chkInactivos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Contiene:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Donde:";
            // 
            // txtContiene
            // 
            this.txtContiene.FormatoTexto = null;
            this.txtContiene.Location = new System.Drawing.Point(376, 37);
            this.txtContiene.Name = "txtContiene";
            this.txtContiene.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtContiene.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtContiene.Size = new System.Drawing.Size(231, 28);
            this.txtContiene.TabIndex = 36;
            // 
            // cboFiltros
            // 
            this.cboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltros.FormattingEnabled = true;
            this.cboFiltros.Location = new System.Drawing.Point(99, 37);
            this.cboFiltros.Name = "cboFiltros";
            this.cboFiltros.Size = new System.Drawing.Size(177, 30);
            this.cboFiltros.TabIndex = 35;
            // 
            // ConsProfesoresForm
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(619, 258);
            this.Controls.Add(this.chkActivos);
            this.Controls.Add(this.chkInactivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContiene);
            this.Controls.Add(this.cboFiltros);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.btnConsultar);
            this.Name = "ConsProfesoresForm";
            this.Text = "Listado Profesores";
            this.Load += new System.EventHandler(this.ProfesoresForm_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.cboFiltros, 0);
            this.Controls.SetChildIndex(this.txtContiene, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.chkInactivos, 0);
            this.Controls.SetChildIndex(this.chkActivos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton btnConsultar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox chkActivos;
        private System.Windows.Forms.CheckBox chkInactivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic txtContiene;
        private BaseControls.Derived.ComboBasic cboFiltros;
    }
}