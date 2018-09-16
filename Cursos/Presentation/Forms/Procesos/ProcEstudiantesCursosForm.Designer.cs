namespace Cursos.Presentation.Forms.Procesos
{
    partial class ProcEstudiantesCursosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcEstudiantesCursosForm));
            this.btnEliminar = new BaseControls.Derived.OkButton();
            this.gvEstudiantes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCurso = new BaseControls.Derived.OkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new BaseControls.Derived.TextBasic();
            this.btnAsignar = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.txtIdCurso = new BaseControls.Derived.TextBasic();
            this.txtIdEstudiante = new BaseControls.Derived.TextBasic();
            this.btnBuscarEstudiante = new BaseControls.Derived.OkButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstudiante = new BaseControls.Derived.TextBasic();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdCursoHorario = new BaseControls.Derived.TextBasic();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(422, 619);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 68);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gvEstudiantes
            // 
            this.gvEstudiantes.AllowUserToAddRows = false;
            this.gvEstudiantes.AllowUserToDeleteRows = false;
            this.gvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEstudiantes.Location = new System.Drawing.Point(34, 95);
            this.gvEstudiantes.Name = "gvEstudiantes";
            this.gvEstudiantes.ReadOnly = true;
            this.gvEstudiantes.RowTemplate.Height = 24;
            this.gvEstudiantes.Size = new System.Drawing.Size(850, 424);
            this.gvEstudiantes.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Estudiantes del curso:";
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCurso.Image")));
            this.btnBuscarCurso.Location = new System.Drawing.Point(809, 15);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarCurso.TabIndex = 20;
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Enabled = false;
            this.txtCurso.FormatoTexto = null;
            this.txtCurso.Location = new System.Drawing.Point(226, 21);
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
            this.txtCurso.Size = new System.Drawing.Size(474, 28);
            this.txtCurso.TabIndex = 18;
            // 
            // btnAsignar
            // 
            this.btnAsignar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
            this.btnAsignar.Location = new System.Drawing.Point(317, 619);
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
            this.closeButton1.Location = new System.Drawing.Point(524, 619);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 68);
            this.closeButton1.TabIndex = 16;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Enabled = false;
            this.txtIdCurso.FormatoTexto = null;
            this.txtIdCurso.Location = new System.Drawing.Point(96, 21);
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
            this.txtIdCurso.Size = new System.Drawing.Size(124, 28);
            this.txtIdCurso.TabIndex = 34;
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.Enabled = false;
            this.txtIdEstudiante.FormatoTexto = null;
            this.txtIdEstudiante.Location = new System.Drawing.Point(169, 566);
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
            this.txtIdEstudiante.ReadOnly = true;
            this.txtIdEstudiante.Size = new System.Drawing.Size(157, 28);
            this.txtIdEstudiante.TabIndex = 39;
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEstudiante.Image")));
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(809, 560);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarEstudiante.TabIndex = 38;
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Estudiante:";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Enabled = false;
            this.txtEstudiante.FormatoTexto = null;
            this.txtEstudiante.Location = new System.Drawing.Point(344, 566);
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
            this.txtEstudiante.Size = new System.Drawing.Size(448, 28);
            this.txtEstudiante.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 169);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar";
            // 
            // txtIdCursoHorario
            // 
            this.txtIdCursoHorario.Enabled = false;
            this.txtIdCursoHorario.FormatoTexto = null;
            this.txtIdCursoHorario.Location = new System.Drawing.Point(706, 21);
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
            this.txtIdCursoHorario.TabIndex = 41;
            // 
            // ProcEstudiantesCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(916, 706);
            this.Controls.Add(this.txtIdCursoHorario);
            this.Controls.Add(this.txtIdEstudiante);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gvEstudiantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcEstudiantesCursosForm";
            this.Text = "Estudiantes y Cursos";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnAsignar, 0);
            this.Controls.SetChildIndex(this.txtCurso, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnBuscarCurso, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.gvEstudiantes, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.txtIdCurso, 0);
            this.Controls.SetChildIndex(this.txtEstudiante, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnBuscarEstudiante, 0);
            this.Controls.SetChildIndex(this.txtIdEstudiante, 0);
            this.Controls.SetChildIndex(this.txtIdCursoHorario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.OkButton btnEliminar;
        private System.Windows.Forms.DataGridView gvEstudiantes;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.OkButton btnBuscarCurso;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.OkButton btnAsignar;
        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton btnBuscarEstudiante;
        private System.Windows.Forms.Label label3;
        public BaseControls.Derived.TextBasic txtCurso;
        public BaseControls.Derived.TextBasic txtIdCurso;
        public BaseControls.Derived.TextBasic txtIdEstudiante;
        public BaseControls.Derived.TextBasic txtEstudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        public BaseControls.Derived.TextBasic txtIdCursoHorario;
    }
}
