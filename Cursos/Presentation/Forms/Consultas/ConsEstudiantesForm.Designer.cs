namespace Cursos.Presentation.Forms.Consultas
{
    partial class ConsEstudiantesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsEstudiantesForm));
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.btnConsultar = new BaseControls.Derived.OkButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboFiltros = new BaseControls.Derived.ComboBasic();
            this.txtContiene = new BaseControls.Derived.TextBasic();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkInactivos = new System.Windows.Forms.CheckBox();
            this.chkActivos = new System.Windows.Forms.CheckBox();
            this.numEdadInicial = new System.Windows.Forms.NumericUpDown();
            this.numEdadFinal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(338, 207);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 68);
            this.closeButton1.TabIndex = 7;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(230, 207);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 68);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboFiltros
            // 
            this.cboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltros.FormattingEnabled = true;
            this.cboFiltros.Location = new System.Drawing.Point(111, 32);
            this.cboFiltros.Name = "cboFiltros";
            this.cboFiltros.Size = new System.Drawing.Size(177, 30);
            this.cboFiltros.TabIndex = 0;
            // 
            // txtContiene
            // 
            this.txtContiene.FormatoTexto = null;
            this.txtContiene.Location = new System.Drawing.Point(388, 32);
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
            this.txtContiene.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Donde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Contiene:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Edad entre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "y";
            // 
            // chkInactivos
            // 
            this.chkInactivos.AutoSize = true;
            this.chkInactivos.Checked = true;
            this.chkInactivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInactivos.Location = new System.Drawing.Point(148, 139);
            this.chkInactivos.Name = "chkInactivos";
            this.chkInactivos.Size = new System.Drawing.Size(104, 28);
            this.chkInactivos.TabIndex = 5;
            this.chkInactivos.Text = "Inactivos";
            this.chkInactivos.UseVisualStyleBackColor = true;
            // 
            // chkActivos
            // 
            this.chkActivos.AutoSize = true;
            this.chkActivos.Checked = true;
            this.chkActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivos.Location = new System.Drawing.Point(30, 139);
            this.chkActivos.Name = "chkActivos";
            this.chkActivos.Size = new System.Drawing.Size(92, 28);
            this.chkActivos.TabIndex = 4;
            this.chkActivos.Text = "Activos";
            this.chkActivos.UseVisualStyleBackColor = true;
            // 
            // numEdadInicial
            // 
            this.numEdadInicial.Location = new System.Drawing.Point(144, 83);
            this.numEdadInicial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEdadInicial.Name = "numEdadInicial";
            this.numEdadInicial.Size = new System.Drawing.Size(81, 28);
            this.numEdadInicial.TabIndex = 33;
            this.numEdadInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numEdadFinal
            // 
            this.numEdadFinal.Location = new System.Drawing.Point(258, 83);
            this.numEdadFinal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEdadFinal.Name = "numEdadFinal";
            this.numEdadFinal.Size = new System.Drawing.Size(85, 28);
            this.numEdadFinal.TabIndex = 34;
            this.numEdadFinal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ConsEstudiantesForm
            // 
            this.AcceptButton = this.btnConsultar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(642, 320);
            this.Controls.Add(this.numEdadFinal);
            this.Controls.Add(this.numEdadInicial);
            this.Controls.Add(this.chkActivos);
            this.Controls.Add(this.chkInactivos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContiene);
            this.Controls.Add(this.cboFiltros);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.btnConsultar);
            this.Name = "ConsEstudiantesForm";
            this.Text = "Listado Estudiantes";
            this.Load += new System.EventHandler(this.EstudiantesForm_Load);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.cboFiltros, 0);
            this.Controls.SetChildIndex(this.txtContiene, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.chkInactivos, 0);
            this.Controls.SetChildIndex(this.chkActivos, 0);
            this.Controls.SetChildIndex(this.numEdadInicial, 0);
            this.Controls.SetChildIndex(this.numEdadFinal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdadFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton btnConsultar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BaseControls.Derived.ComboBasic cboFiltros;
        private BaseControls.Derived.TextBasic txtContiene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkInactivos;
        private System.Windows.Forms.CheckBox chkActivos;
        private System.Windows.Forms.NumericUpDown numEdadInicial;
        private System.Windows.Forms.NumericUpDown numEdadFinal;
    }
}
