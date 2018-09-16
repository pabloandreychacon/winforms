namespace Cursos.Presentation.Forms.Procesos
{
    partial class ProcRemoverAusenciasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcRemoverAusenciasForm));
            this.txtIdProfesor = new BaseControls.Derived.TextBasic();
            this.txtIdCurso = new BaseControls.Derived.TextBasic();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfesor = new BaseControls.Derived.TextBasic();
            this.gvAusentes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCurso = new BaseControls.Derived.OkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new BaseControls.Derived.TextBasic();
            this.btnAsignar = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdCursoHorario = new BaseControls.Derived.TextBasic();
            ((System.ComponentModel.ISupportInitialize)(this.gvAusentes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProfesor
            // 
            this.txtIdProfesor.Enabled = false;
            this.txtIdProfesor.FormatoTexto = null;
            this.txtIdProfesor.Location = new System.Drawing.Point(151, 78);
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
            this.txtIdProfesor.TabIndex = 48;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Enabled = false;
            this.txtIdCurso.FormatoTexto = null;
            this.txtIdCurso.Location = new System.Drawing.Point(151, 35);
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
            this.txtIdCurso.Size = new System.Drawing.Size(107, 28);
            this.txtIdCurso.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Profesor:";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Enabled = false;
            this.txtProfesor.FormatoTexto = null;
            this.txtProfesor.Location = new System.Drawing.Point(348, 78);
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
            this.txtProfesor.TabIndex = 45;
            // 
            // gvAusentes
            // 
            this.gvAusentes.AllowUserToAddRows = false;
            this.gvAusentes.AllowUserToDeleteRows = false;
            this.gvAusentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAusentes.Location = new System.Drawing.Point(43, 220);
            this.gvAusentes.Name = "gvAusentes";
            this.gvAusentes.RowTemplate.Height = 24;
            this.gvAusentes.Size = new System.Drawing.Size(850, 385);
            this.gvAusentes.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ausentes:";
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCurso.Image")));
            this.btnBuscarCurso.Location = new System.Drawing.Point(826, 30);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarCurso.TabIndex = 40;
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Curso:";
            // 
            // txtCurso
            // 
            this.txtCurso.Enabled = false;
            this.txtCurso.FormatoTexto = null;
            this.txtCurso.Location = new System.Drawing.Point(264, 35);
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
            this.txtCurso.Size = new System.Drawing.Size(464, 28);
            this.txtCurso.TabIndex = 38;
            // 
            // btnAsignar
            // 
            this.btnAsignar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
            this.btnAsignar.Location = new System.Drawing.Point(376, 624);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 68);
            this.btnAsignar.TabIndex = 37;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(481, 624);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 68);
            this.closeButton1.TabIndex = 36;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(151, 123);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(326, 28);
            this.dtFecha.TabIndex = 43;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(24, 611);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 93);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remover";
            // 
            // txtIdCursoHorario
            // 
            this.txtIdCursoHorario.Enabled = false;
            this.txtIdCursoHorario.FormatoTexto = null;
            this.txtIdCursoHorario.Location = new System.Drawing.Point(734, 35);
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
            this.txtIdCursoHorario.TabIndex = 50;
            // 
            // ProcRemoverAusenciasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(942, 716);
            this.Controls.Add(this.txtIdCursoHorario);
            this.Controls.Add(this.txtIdProfesor);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.gvAusentes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcRemoverAusenciasForm";
            this.Text = "Remover Ausencias";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnAsignar, 0);
            this.Controls.SetChildIndex(this.txtCurso, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnBuscarCurso, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.gvAusentes, 0);
            this.Controls.SetChildIndex(this.dtFecha, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtProfesor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtIdCurso, 0);
            this.Controls.SetChildIndex(this.txtIdProfesor, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.txtIdCursoHorario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gvAusentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.TextBasic txtIdProfesor;
        private BaseControls.Derived.TextBasic txtIdCurso;
        private System.Windows.Forms.Label label6;
        private BaseControls.Derived.TextBasic txtProfesor;
        private System.Windows.Forms.DataGridView gvAusentes;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.OkButton btnBuscarCurso;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic txtCurso;
        private BaseControls.Derived.OkButton btnAsignar;
        private BaseControls.Derived.CloseButton closeButton1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        public BaseControls.Derived.TextBasic txtIdCursoHorario;
    }
}
