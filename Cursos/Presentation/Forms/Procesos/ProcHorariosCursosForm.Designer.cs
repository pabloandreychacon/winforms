namespace Cursos.Presentation.Forms.Procesos
{
    partial class ProcHorariosCursosForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcHorariosCursosForm));
			this.txtIdHorario = new BaseControls.Derived.TextBasic();
			this.label6 = new System.Windows.Forms.Label();
			this.txtHorario = new BaseControls.Derived.TextBasic();
			this.gvHorariosAsignados = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuscaHorario = new BaseControls.Derived.OkButton();
			this.btnAsignar = new BaseControls.Derived.OkButton();
			this.closeButton1 = new BaseControls.Derived.CloseButton();
			this.btnEliminar = new BaseControls.Derived.OkButton();
			this.btnBuscaCurso = new BaseControls.Derived.OkButton();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdCurso = new BaseControls.Derived.TextBasic();
			this.txtCurso = new BaseControls.Derived.TextBasic();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtIdAula = new BaseControls.Derived.TextBasic();
			this.cboDayOfWeek = new BaseControls.Derived.ComboBasic();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBuscaAula = new BaseControls.Derived.OkButton();
			this.txtAula = new BaseControls.Derived.TextBasic();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gvHorariosAsignados)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblInfoMessage
			// 
			this.lblInfoMessage.Location = new System.Drawing.Point(30, 715);
			// 
			// txtIdHorario
			// 
			this.txtIdHorario.Enabled = false;
			this.txtIdHorario.FormatoTexto = null;
			this.txtIdHorario.Location = new System.Drawing.Point(105, 27);
			this.txtIdHorario.Name = "txtIdHorario";
			this.txtIdHorario.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtIdHorario.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.txtIdHorario.ReadOnly = true;
			this.txtIdHorario.Size = new System.Drawing.Size(152, 28);
			this.txtIdHorario.TabIndex = 44;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 24);
			this.label6.TabIndex = 43;
			this.label6.Text = "Aula:";
			// 
			// txtHorario
			// 
			this.txtHorario.Enabled = false;
			this.txtHorario.FormatoTexto = null;
			this.txtHorario.Location = new System.Drawing.Point(263, 27);
			this.txtHorario.Name = "txtHorario";
			this.txtHorario.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtHorario.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.txtHorario.ReadOnly = true;
			this.txtHorario.Size = new System.Drawing.Size(524, 28);
			this.txtHorario.TabIndex = 42;
			// 
			// gvHorariosAsignados
			// 
			this.gvHorariosAsignados.AllowUserToAddRows = false;
			this.gvHorariosAsignados.AllowUserToDeleteRows = false;
			this.gvHorariosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvHorariosAsignados.Location = new System.Drawing.Point(51, 95);
			this.gvHorariosAsignados.Name = "gvHorariosAsignados";
			this.gvHorariosAsignados.ReadOnly = true;
			this.gvHorariosAsignados.RowTemplate.Height = 24;
			this.gvHorariosAsignados.Size = new System.Drawing.Size(850, 377);
			this.gvHorariosAsignados.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(177, 24);
			this.label2.TabIndex = 34;
			this.label2.Text = "Horarios asignados:";
			// 
			// btnBuscaHorario
			// 
			this.btnBuscaHorario.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnBuscaHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaHorario.Image")));
			this.btnBuscaHorario.Location = new System.Drawing.Point(793, 21);
			this.btnBuscaHorario.Name = "btnBuscaHorario";
			this.btnBuscaHorario.Size = new System.Drawing.Size(75, 40);
			this.btnBuscaHorario.TabIndex = 27;
			this.btnBuscaHorario.UseVisualStyleBackColor = true;
			this.btnBuscaHorario.Click += new System.EventHandler(this.btnBuscaHorario_Click);
			// 
			// btnAsignar
			// 
			this.btnAsignar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
			this.btnAsignar.Location = new System.Drawing.Point(336, 619);
			this.btnAsignar.Name = "btnAsignar";
			this.btnAsignar.Size = new System.Drawing.Size(75, 68);
			this.btnAsignar.TabIndex = 35;
			this.btnAsignar.UseVisualStyleBackColor = true;
			this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
			// 
			// closeButton1
			// 
			this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
			this.closeButton1.Location = new System.Drawing.Point(546, 619);
			this.closeButton1.Name = "closeButton1";
			this.closeButton1.Size = new System.Drawing.Size(75, 68);
			this.closeButton1.TabIndex = 37;
			this.closeButton1.TabStop = false;
			this.closeButton1.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.Location = new System.Drawing.Point(442, 619);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 68);
			this.btnEliminar.TabIndex = 36;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnBuscaCurso
			// 
			this.btnBuscaCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnBuscaCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCurso.Image")));
			this.btnBuscaCurso.Location = new System.Drawing.Point(826, 20);
			this.btnBuscaCurso.Name = "btnBuscaCurso";
			this.btnBuscaCurso.Size = new System.Drawing.Size(75, 40);
			this.btnBuscaCurso.TabIndex = 45;
			this.btnBuscaCurso.UseVisualStyleBackColor = true;
			this.btnBuscaCurso.Click += new System.EventHandler(this.btnBuscaCurso_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 24);
			this.label1.TabIndex = 47;
			this.label1.Text = "Curso:";
			// 
			// txtIdCurso
			// 
			this.txtIdCurso.Enabled = false;
			this.txtIdCurso.FormatoTexto = null;
			this.txtIdCurso.Location = new System.Drawing.Point(139, 26);
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
			this.txtIdCurso.Size = new System.Drawing.Size(191, 28);
			this.txtIdCurso.TabIndex = 49;
			// 
			// txtCurso
			// 
			this.txtCurso.Enabled = false;
			this.txtCurso.FormatoTexto = null;
			this.txtCurso.Location = new System.Drawing.Point(336, 26);
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
			this.txtCurso.TabIndex = 48;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtIdAula);
			this.groupBox1.Controls.Add(this.cboDayOfWeek);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnBuscaAula);
			this.groupBox1.Controls.Add(this.txtAula);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtHorario);
			this.groupBox1.Controls.Add(this.btnBuscaHorario);
			this.groupBox1.Controls.Add(this.txtIdHorario);
			this.groupBox1.Location = new System.Drawing.Point(30, 478);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(886, 233);
			this.groupBox1.TabIndex = 50;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Asignar";
			// 
			// txtIdAula
			// 
			this.txtIdAula.Enabled = false;
			this.txtIdAula.FormatoTexto = null;
			this.txtIdAula.Location = new System.Drawing.Point(105, 73);
			this.txtIdAula.Name = "txtIdAula";
			this.txtIdAula.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtIdAula.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.txtIdAula.ReadOnly = true;
			this.txtIdAula.Size = new System.Drawing.Size(152, 28);
			this.txtIdAula.TabIndex = 58;
			// 
			// cboDayOfWeek
			// 
			this.cboDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDayOfWeek.FormattingEnabled = true;
			this.cboDayOfWeek.Location = new System.Drawing.Point(105, 118);
			this.cboDayOfWeek.Name = "cboDayOfWeek";
			this.cboDayOfWeek.Size = new System.Drawing.Size(152, 30);
			this.cboDayOfWeek.TabIndex = 52;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(448, -88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 24);
			this.label4.TabIndex = 52;
			this.label4.Text = "Días:";
			// 
			// btnBuscaAula
			// 
			this.btnBuscaAula.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnBuscaAula.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaAula.Image")));
			this.btnBuscaAula.Location = new System.Drawing.Point(793, 67);
			this.btnBuscaAula.Name = "btnBuscaAula";
			this.btnBuscaAula.Size = new System.Drawing.Size(75, 40);
			this.btnBuscaAula.TabIndex = 55;
			this.btnBuscaAula.UseVisualStyleBackColor = true;
			this.btnBuscaAula.Click += new System.EventHandler(this.btnBuscaAula_Click);
			// 
			// txtAula
			// 
			this.txtAula.Enabled = false;
			this.txtAula.FormatoTexto = null;
			this.txtAula.Location = new System.Drawing.Point(263, 73);
			this.txtAula.Name = "txtAula";
			this.txtAula.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txtAula.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.txtAula.ReadOnly = true;
			this.txtAula.Size = new System.Drawing.Size(524, 28);
			this.txtAula.TabIndex = 56;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 24);
			this.label3.TabIndex = 51;
			this.label3.Text = "Día:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 24);
			this.label7.TabIndex = 57;
			this.label7.Text = "Horario:";
			// 
			// ProcHorariosCursosForm
			// 
			this.AcceptButton = this.btnAsignar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton1;
			this.ClientSize = new System.Drawing.Size(953, 755);
			this.Controls.Add(this.txtIdCurso);
			this.Controls.Add(this.txtCurso);
			this.Controls.Add(this.btnBuscaCurso);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gvHorariosAsignados);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAsignar);
			this.Controls.Add(this.closeButton1);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.groupBox1);
			this.Name = "ProcHorariosCursosForm";
			this.Text = "Horarios Cursos";
			this.Load += new System.EventHandler(this.ProcHorariosCursosForm_Load);
			this.Controls.SetChildIndex(this.lblInfoMessage, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.btnEliminar, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnAsignar, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.gvHorariosAsignados, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.btnBuscaCurso, 0);
			this.Controls.SetChildIndex(this.txtCurso, 0);
			this.Controls.SetChildIndex(this.txtIdCurso, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			((System.ComponentModel.ISupportInitialize)(this.gvHorariosAsignados)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.OkButton btnBuscaHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvHorariosAsignados;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.OkButton btnAsignar;
        private BaseControls.Derived.CloseButton closeButton1;
        private BaseControls.Derived.OkButton btnEliminar;
        private BaseControls.Derived.OkButton btnBuscaCurso;
        private System.Windows.Forms.Label label1;
        public BaseControls.Derived.TextBasic txtIdCurso;
        public BaseControls.Derived.TextBasic txtCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        public BaseControls.Derived.TextBasic txtIdHorario;
        public BaseControls.Derived.TextBasic txtHorario;
		private System.Windows.Forms.Label label3;
		private BaseControls.Derived.ComboBasic cboDayOfWeek;
		private System.Windows.Forms.Label label4;
		public BaseControls.Derived.TextBasic txtIdAula;
		private BaseControls.Derived.OkButton btnBuscaAula;
		private System.Windows.Forms.Label label7;
		public BaseControls.Derived.TextBasic txtAula;
	}
}