namespace Cursos.Presentation.Forms.Consultas
{
    partial class ConsAusenciasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsAusenciasForm));
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.txtIdEstudiante = new BaseControls.Derived.TextBasic();
            this.txtIdCurso = new BaseControls.Derived.TextBasic();
            this.btnConsultar = new BaseControls.Derived.OkButton();
            this.btnBuscarEstudiante = new BaseControls.Derived.OkButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstudiante = new BaseControls.Derived.TextBasic();
            this.btnBuscarCurso = new BaseControls.Derived.OkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new BaseControls.Derived.TextBasic();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboHorario = new BaseControls.Derived.ComboBasic();
            this.cboProfesor = new BaseControls.Derived.ComboBasic();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(352, 190);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 68);
            this.closeButton1.TabIndex = 7;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.FormatoTexto = null;
            this.txtIdEstudiante.Location = new System.Drawing.Point(113, 132);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdEstudiante.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtIdEstudiante.Size = new System.Drawing.Size(103, 28);
            this.txtIdEstudiante.TabIndex = 5;
            this.txtIdEstudiante.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdEstudiante_Validating);
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.FormatoTexto = null;
            this.txtIdCurso.Location = new System.Drawing.Point(113, 25);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdCurso.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtIdCurso.Size = new System.Drawing.Size(103, 28);
            this.txtIdCurso.TabIndex = 1;
            this.txtIdCurso.Leave += new System.EventHandler(this.txtIdCurso_Leave);
            this.txtIdCurso.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdCurso_Validating);
            // 
            // btnConsultar
            // 
            this.btnConsultar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(260, 190);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 68);
            this.btnConsultar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnConsultar, "Ejecutar reporte");
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEstudiante.Image")));
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(599, 126);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarEstudiante.TabIndex = 4;
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Estudiante:";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Enabled = false;
            this.txtEstudiante.FormatoTexto = null;
            this.txtEstudiante.Location = new System.Drawing.Point(222, 132);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtEstudiante.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtEstudiante.ReadOnly = true;
            this.txtEstudiante.Size = new System.Drawing.Size(360, 28);
            this.txtEstudiante.TabIndex = 31;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCurso.Image")));
            this.btnBuscarCurso.Location = new System.Drawing.Point(599, 19);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarCurso.TabIndex = 0;
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Enabled = false;
            this.txtCurso.FormatoTexto = null;
            this.txtCurso.Location = new System.Drawing.Point(222, 25);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCurso.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(360, 28);
            this.txtCurso.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Horario:";
            // 
            // cboHorario
            // 
            this.cboHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHorario.FormattingEnabled = true;
            this.cboHorario.Location = new System.Drawing.Point(113, 59);
            this.cboHorario.Name = "cboHorario";
            this.cboHorario.Size = new System.Drawing.Size(469, 30);
            this.cboHorario.TabIndex = 2;
            this.cboHorario.SelectedIndexChanged += new System.EventHandler(this.cboHorario_SelectedIndexChanged);
            // 
            // cboProfesor
            // 
            this.cboProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Location = new System.Drawing.Point(113, 95);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(469, 30);
            this.cboProfesor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Profesor:";
            // 
            // ConsAusenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(686, 274);
            this.Controls.Add(this.cboProfesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdEstudiante);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.closeButton1);
            this.Name = "ConsAusenciasForm";
            this.Text = "Listado de ausencias";
            this.Load += new System.EventHandler(this.AusenciasReportForm_Load);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.txtCurso, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnBuscarCurso, 0);
            this.Controls.SetChildIndex(this.txtEstudiante, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnBuscarEstudiante, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.txtIdCurso, 0);
            this.Controls.SetChildIndex(this.txtIdEstudiante, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cboHorario, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cboProfesor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.TextBasic txtIdEstudiante;
        private BaseControls.Derived.TextBasic txtIdCurso;
        private BaseControls.Derived.OkButton btnConsultar;
        private BaseControls.Derived.OkButton btnBuscarEstudiante;
        private System.Windows.Forms.Label label3;
        private BaseControls.Derived.TextBasic txtEstudiante;
        private BaseControls.Derived.OkButton btnBuscarCurso;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic txtCurso;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.ComboBasic cboHorario;
        private BaseControls.Derived.ComboBasic cboProfesor;
        private System.Windows.Forms.Label label4;
    }
}
