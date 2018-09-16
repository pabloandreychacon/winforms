namespace Cursos.Presentation.Forms.Procesos
{
    partial class ProcAusenciasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcAusenciasForm));
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.gvEstudiantes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCurso = new BaseControls.Derived.OkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new BaseControls.Derived.TextBasic();
            this.btnAsignar = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfesor = new BaseControls.Derived.TextBasic();
            this.txtIdProfesor = new BaseControls.Derived.TextBasic();
            this.txtIdCurso = new BaseControls.Derived.TextBasic();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdCursoHorario = new BaseControls.Derived.TextBasic();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha:";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(136, 559);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(326, 28);
            this.dtFecha.TabIndex = 24;
            // 
            // gvEstudiantes
            // 
            this.gvEstudiantes.AllowUserToAddRows = false;
            this.gvEstudiantes.AllowUserToDeleteRows = false;
            this.gvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEstudiantes.Location = new System.Drawing.Point(54, 149);
            this.gvEstudiantes.Name = "gvEstudiantes";
            this.gvEstudiantes.RowTemplate.Height = 24;
            this.gvEstudiantes.Size = new System.Drawing.Size(850, 359);
            this.gvEstudiantes.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Estudiantes:";
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCurso.Image")));
            this.btnBuscarCurso.Location = new System.Drawing.Point(829, 22);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarCurso.TabIndex = 20;
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Enabled = false;
            this.txtCurso.FormatoTexto = null;
            this.txtCurso.Location = new System.Drawing.Point(289, 27);
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
            this.txtCurso.Size = new System.Drawing.Size(443, 28);
            this.txtCurso.TabIndex = 18;
            // 
            // btnAsignar
            // 
            this.btnAsignar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
            this.btnAsignar.Location = new System.Drawing.Point(387, 616);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 68);
            this.btnAsignar.TabIndex = 17;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(492, 616);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 68);
            this.closeButton1.TabIndex = 16;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Profesor:";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Enabled = false;
            this.txtProfesor.FormatoTexto = null;
            this.txtProfesor.Location = new System.Drawing.Point(359, 70);
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
            this.txtProfesor.Size = new System.Drawing.Size(464, 28);
            this.txtProfesor.TabIndex = 31;
            // 
            // txtIdProfesor
            // 
            this.txtIdProfesor.Enabled = false;
            this.txtIdProfesor.FormatoTexto = null;
            this.txtIdProfesor.Location = new System.Drawing.Point(162, 70);
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
            this.txtIdProfesor.Size = new System.Drawing.Size(191, 28);
            this.txtIdProfesor.TabIndex = 35;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Enabled = false;
            this.txtIdCurso.FormatoTexto = null;
            this.txtIdCurso.Location = new System.Drawing.Point(162, 27);
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
            this.txtIdCurso.Size = new System.Drawing.Size(121, 28);
            this.txtIdCurso.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(35, 526);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 173);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar";
            // 
            // txtIdCursoHorario
            // 
            this.txtIdCursoHorario.Enabled = false;
            this.txtIdCursoHorario.FormatoTexto = null;
            this.txtIdCursoHorario.Location = new System.Drawing.Point(737, 27);
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
            this.txtIdCursoHorario.TabIndex = 37;
            // 
            // ProcAusenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(955, 706);
            this.Controls.Add(this.txtIdCursoHorario);
            this.Controls.Add(this.txtIdProfesor);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.gvEstudiantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcAusenciasForm";
            this.Text = "Ausencias";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnAsignar, 0);
            this.Controls.SetChildIndex(this.txtCurso, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnBuscarCurso, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.gvEstudiantes, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtProfesor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtIdCurso, 0);
            this.Controls.SetChildIndex(this.txtIdProfesor, 0);
            this.Controls.SetChildIndex(this.txtIdCursoHorario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.DataGridView gvEstudiantes;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.OkButton btnBuscarCurso;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.OkButton btnAsignar;
        private BaseControls.Derived.CloseButton closeButton1;
        private System.Windows.Forms.Label label6;
        public BaseControls.Derived.TextBasic txtCurso;
        public BaseControls.Derived.TextBasic txtIdCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        public BaseControls.Derived.TextBasic txtIdCursoHorario;
        public BaseControls.Derived.TextBasic txtProfesor;
        public BaseControls.Derived.TextBasic txtIdProfesor;
    }
}
