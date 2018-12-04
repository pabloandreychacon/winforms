namespace Cursos.Presentation.Forms.Procesos
{
    partial class ProcAsignacionCursosForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcAsignacionCursosForm));
			this.closeButton1 = new BaseControls.Derived.CloseButton();
			this.btnAsignar = new BaseControls.Derived.OkButton();
			this.txtProfesor = new BaseControls.Derived.TextBasic();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuscaProfesor = new BaseControls.Derived.OkButton();
			this.label2 = new System.Windows.Forms.Label();
			this.gvCursosAsignados = new System.Windows.Forms.DataGridView();
			this.chkActivo = new System.Windows.Forms.CheckBox();
			this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAusencias = new BaseControls.Derived.TextBasic();
			this.btnEliminar = new BaseControls.Derived.OkButton();
			this.txtIdProfesor = new BaseControls.Derived.TextBasic();
			this.txtIdCursoHorario = new BaseControls.Derived.TextBasic();
			this.btnBuscaCurso = new BaseControls.Derived.OkButton();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCurso = new BaseControls.Derived.TextBasic();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtIdCurso = new BaseControls.Derived.TextBasic();
			((System.ComponentModel.ISupportInitialize)(this.gvCursosAsignados)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblInfoMessage
			// 
			this.lblInfoMessage.Location = new System.Drawing.Point(12, 709);
			// 
			// closeButton1
			// 
			this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
			this.closeButton1.Location = new System.Drawing.Point(524, 608);
			this.closeButton1.Name = "closeButton1";
			this.closeButton1.Size = new System.Drawing.Size(75, 68);
			this.closeButton1.TabIndex = 9;
			this.closeButton1.TabStop = false;
			this.closeButton1.UseVisualStyleBackColor = true;
			// 
			// btnAsignar
			// 
			this.btnAsignar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
			this.btnAsignar.Location = new System.Drawing.Point(299, 125);
			this.btnAsignar.Name = "btnAsignar";
			this.btnAsignar.Size = new System.Drawing.Size(75, 68);
			this.btnAsignar.TabIndex = 7;
			this.btnAsignar.UseVisualStyleBackColor = true;
			this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
			// 
			// txtProfesor
			// 
			this.txtProfesor.Enabled = false;
			this.txtProfesor.FormatoTexto = null;
			this.txtProfesor.Location = new System.Drawing.Point(274, 31);
			this.txtProfesor.Name = "txtProfesor";
			this.txtProfesor.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtProfesor.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.txtProfesor.ReadOnly = true;
			this.txtProfesor.Size = new System.Drawing.Size(524, 28);
			this.txtProfesor.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Profesor:";
			// 
			// btnBuscaProfesor
			// 
			this.btnBuscaProfesor.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnBuscaProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProfesor.Image")));
			this.btnBuscaProfesor.Location = new System.Drawing.Point(804, 25);
			this.btnBuscaProfesor.Name = "btnBuscaProfesor";
			this.btnBuscaProfesor.Size = new System.Drawing.Size(75, 40);
			this.btnBuscaProfesor.TabIndex = 0;
			this.btnBuscaProfesor.UseVisualStyleBackColor = true;
			this.btnBuscaProfesor.Click += new System.EventHandler(this.btnBuscaProfesor_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Cursos asignados:";
			// 
			// gvCursosAsignados
			// 
			this.gvCursosAsignados.AllowUserToAddRows = false;
			this.gvCursosAsignados.AllowUserToDeleteRows = false;
			this.gvCursosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvCursosAsignados.Location = new System.Drawing.Point(29, 95);
			this.gvCursosAsignados.Name = "gvCursosAsignados";
			this.gvCursosAsignados.ReadOnly = true;
			this.gvCursosAsignados.RowTemplate.Height = 24;
			this.gvCursosAsignados.Size = new System.Drawing.Size(850, 382);
			this.gvCursosAsignados.TabIndex = 1;
			// 
			// chkActivo
			// 
			this.chkActivo.AutoCheck = false;
			this.chkActivo.AutoSize = true;
			this.chkActivo.Checked = true;
			this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkActivo.Location = new System.Drawing.Point(29, 561);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Size = new System.Drawing.Size(83, 28);
			this.chkActivo.TabIndex = 3;
			this.chkActivo.Text = "Activo";
			this.chkActivo.UseVisualStyleBackColor = true;
			// 
			// dtFechaInicio
			// 
			this.dtFechaInicio.Location = new System.Drawing.Point(198, 561);
			this.dtFechaInicio.Name = "dtFechaInicio";
			this.dtFechaInicio.Size = new System.Drawing.Size(200, 28);
			this.dtFechaInicio.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(135, 563);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 24);
			this.label3.TabIndex = 10;
			this.label3.Text = "Inicio:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(404, 563);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 24);
			this.label4.TabIndex = 12;
			this.label4.Text = "Final:";
			// 
			// dtFechaFinal
			// 
			this.dtFechaFinal.Location = new System.Drawing.Point(466, 561);
			this.dtFechaFinal.Name = "dtFechaFinal";
			this.dtFechaFinal.Size = new System.Drawing.Size(200, 28);
			this.dtFechaFinal.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(672, 563);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "Ausencias:";
			// 
			// txtAusencias
			// 
			this.txtAusencias.FormatoTexto = null;
			this.txtAusencias.Location = new System.Drawing.Point(779, 559);
			this.txtAusencias.Name = "txtAusencias";
			this.txtAusencias.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtAusencias.RangoSuperior = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.txtAusencias.Size = new System.Drawing.Size(100, 28);
			this.txtAusencias.TabIndex = 6;
			this.txtAusencias.TipoTexto = BaseControls.Derived.TextBasic.FormatTypes.Entero;
			// 
			// btnEliminar
			// 
			this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.Location = new System.Drawing.Point(420, 608);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 68);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Visible = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// txtIdProfesor
			// 
			this.txtIdProfesor.Enabled = false;
			this.txtIdProfesor.FormatoTexto = null;
			this.txtIdProfesor.Location = new System.Drawing.Point(116, 31);
			this.txtIdProfesor.Name = "txtIdProfesor";
			this.txtIdProfesor.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtIdProfesor.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.txtIdProfesor.ReadOnly = true;
			this.txtIdProfesor.Size = new System.Drawing.Size(152, 28);
			this.txtIdProfesor.TabIndex = 19;
			// 
			// txtIdCursoHorario
			// 
			this.txtIdCursoHorario.Enabled = false;
			this.txtIdCursoHorario.FormatoTexto = null;
			this.txtIdCursoHorario.Location = new System.Drawing.Point(700, 29);
			this.txtIdCursoHorario.Name = "txtIdCursoHorario";
			this.txtIdCursoHorario.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtIdCursoHorario.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.txtIdCursoHorario.ReadOnly = true;
			this.txtIdCursoHorario.Size = new System.Drawing.Size(86, 28);
			this.txtIdCursoHorario.TabIndex = 24;
			// 
			// btnBuscaCurso
			// 
			this.btnBuscaCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnBuscaCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCurso.Image")));
			this.btnBuscaCurso.Location = new System.Drawing.Point(804, 506);
			this.btnBuscaCurso.Name = "btnBuscaCurso";
			this.btnBuscaCurso.Size = new System.Drawing.Size(75, 40);
			this.btnBuscaCurso.TabIndex = 2;
			this.btnBuscaCurso.UseVisualStyleBackColor = true;
			this.btnBuscaCurso.Click += new System.EventHandler(this.btnBuscaCurso_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 515);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 24);
			this.label6.TabIndex = 22;
			this.label6.Text = "Curso:";
			// 
			// txtCurso
			// 
			this.txtCurso.Enabled = false;
			this.txtCurso.FormatoTexto = null;
			this.txtCurso.Location = new System.Drawing.Point(198, 512);
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
			this.txtCurso.Size = new System.Drawing.Size(508, 28);
			this.txtCurso.TabIndex = 21;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtIdCurso);
			this.groupBox1.Controls.Add(this.txtIdCursoHorario);
			this.groupBox1.Controls.Add(this.btnAsignar);
			this.groupBox1.Location = new System.Drawing.Point(12, 483);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(886, 211);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Asignar";
			// 
			// txtIdCurso
			// 
			this.txtIdCurso.Enabled = false;
			this.txtIdCurso.FormatoTexto = null;
			this.txtIdCurso.Location = new System.Drawing.Point(86, 29);
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
			this.txtIdCurso.ReadOnly = true;
			this.txtIdCurso.Size = new System.Drawing.Size(96, 28);
			this.txtIdCurso.TabIndex = 26;
			// 
			// ProcAsignacionCursosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.CancelButton = this.closeButton1;
			this.ClientSize = new System.Drawing.Size(910, 756);
			this.Controls.Add(this.btnBuscaCurso);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCurso);
			this.Controls.Add(this.txtIdProfesor);
			this.Controls.Add(this.txtAusencias);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtFechaFinal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtFechaInicio);
			this.Controls.Add(this.chkActivo);
			this.Controls.Add(this.gvCursosAsignados);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBuscaProfesor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtProfesor);
			this.Controls.Add(this.closeButton1);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.groupBox1);
			this.Name = "ProcAsignacionCursosForm";
			this.Text = "Asignación de Cursos";
			this.Load += new System.EventHandler(this.AsignacionCursosForm_Load);
			this.Controls.SetChildIndex(this.lblInfoMessage, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.btnEliminar, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.txtProfesor, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.btnBuscaProfesor, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.gvCursosAsignados, 0);
			this.Controls.SetChildIndex(this.chkActivo, 0);
			this.Controls.SetChildIndex(this.dtFechaInicio, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.dtFechaFinal, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.txtAusencias, 0);
			this.Controls.SetChildIndex(this.txtIdProfesor, 0);
			this.Controls.SetChildIndex(this.txtCurso, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.btnBuscaCurso, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.gvCursosAsignados)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton btnAsignar;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.OkButton btnBuscaProfesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvCursosAsignados;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label label5;
        private BaseControls.Derived.TextBasic txtAusencias;
        private BaseControls.Derived.OkButton btnEliminar;
        private BaseControls.Derived.OkButton btnBuscaCurso;
        private System.Windows.Forms.Label label6;
        public BaseControls.Derived.TextBasic txtIdCursoHorario;
        public BaseControls.Derived.TextBasic txtCurso;
        public BaseControls.Derived.TextBasic txtProfesor;
        public BaseControls.Derived.TextBasic txtIdProfesor;
        private System.Windows.Forms.GroupBox groupBox1;
        public BaseControls.Derived.TextBasic txtIdCurso;
    }
}
