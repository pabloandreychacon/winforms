namespace Cursos.Presentation.Forms.Procesos
{
    partial class ProcTransferenciaEstudiantesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcTransferenciaEstudiantesForm));
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCursoOrigen = new BaseControls.Derived.OkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionCursoOrigen = new BaseControls.Derived.TextBasic();
            this.btnTransferir = new BaseControls.Derived.OkButton();
            this.closeButton1 = new BaseControls.Derived.CloseButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCursoDestino = new BaseControls.Derived.OkButton();
            this.txtDescripcionCursoDestino = new BaseControls.Derived.TextBasic();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCursoOrigen = new BaseControls.Derived.TextBasic();
            this.txtIdCursoDestino = new BaseControls.Derived.TextBasic();
            this.lstOrigen = new System.Windows.Forms.ListBox();
            this.lstDestino = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdCursoHorarioOrigen = new BaseControls.Derived.TextBasic();
            this.txtCursoHorarrioDestino = new BaseControls.Derived.TextBasic();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Curso:";
            // 
            // btnBuscarCursoOrigen
            // 
            this.btnBuscarCursoOrigen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscarCursoOrigen.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCursoOrigen.Image")));
            this.btnBuscarCursoOrigen.Location = new System.Drawing.Point(407, 22);
            this.btnBuscarCursoOrigen.Name = "btnBuscarCursoOrigen";
            this.btnBuscarCursoOrigen.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarCursoOrigen.TabIndex = 20;
            this.btnBuscarCursoOrigen.UseVisualStyleBackColor = true;
            this.btnBuscarCursoOrigen.Click += new System.EventHandler(this.btnBuscarCursoOrigen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Estudiantes:";
            // 
            // txtDescripcionCursoOrigen
            // 
            this.txtDescripcionCursoOrigen.Enabled = false;
            this.txtDescripcionCursoOrigen.FormatoTexto = null;
            this.txtDescripcionCursoOrigen.Location = new System.Drawing.Point(117, 27);
            this.txtDescripcionCursoOrigen.Name = "txtDescripcionCursoOrigen";
            this.txtDescripcionCursoOrigen.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDescripcionCursoOrigen.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtDescripcionCursoOrigen.ReadOnly = true;
            this.txtDescripcionCursoOrigen.Size = new System.Drawing.Size(273, 28);
            this.txtDescripcionCursoOrigen.TabIndex = 18;
            // 
            // btnTransferir
            // 
            this.btnTransferir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTransferir.Image = ((System.Drawing.Image)(resources.GetObject("btnTransferir.Image")));
            this.btnTransferir.Location = new System.Drawing.Point(389, 37);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 68);
            this.btnTransferir.TabIndex = 17;
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.lstOrigen_DoubleClick);
            // 
            // closeButton1
            // 
            this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
            this.closeButton1.Location = new System.Drawing.Point(470, 37);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(75, 68);
            this.closeButton1.TabIndex = 16;
            this.closeButton1.TabStop = false;
            this.closeButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Curso:";
            // 
            // btnBuscarCursoDestino
            // 
            this.btnBuscarCursoDestino.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBuscarCursoDestino.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCursoDestino.Image")));
            this.btnBuscarCursoDestino.Location = new System.Drawing.Point(871, 26);
            this.btnBuscarCursoDestino.Name = "btnBuscarCursoDestino";
            this.btnBuscarCursoDestino.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarCursoDestino.TabIndex = 32;
            this.btnBuscarCursoDestino.UseVisualStyleBackColor = true;
            this.btnBuscarCursoDestino.Click += new System.EventHandler(this.btnBuscarCursoDestino_Click);
            // 
            // txtDescripcionCursoDestino
            // 
            this.txtDescripcionCursoDestino.Enabled = false;
            this.txtDescripcionCursoDestino.FormatoTexto = null;
            this.txtDescripcionCursoDestino.Location = new System.Drawing.Point(581, 31);
            this.txtDescripcionCursoDestino.Name = "txtDescripcionCursoDestino";
            this.txtDescripcionCursoDestino.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDescripcionCursoDestino.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtDescripcionCursoDestino.ReadOnly = true;
            this.txtDescripcionCursoDestino.Size = new System.Drawing.Size(273, 28);
            this.txtDescripcionCursoDestino.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Estudiantes:";
            // 
            // txtIdCursoOrigen
            // 
            this.txtIdCursoOrigen.Enabled = false;
            this.txtIdCursoOrigen.FormatoTexto = null;
            this.txtIdCursoOrigen.Location = new System.Drawing.Point(117, 61);
            this.txtIdCursoOrigen.Name = "txtIdCursoOrigen";
            this.txtIdCursoOrigen.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdCursoOrigen.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtIdCursoOrigen.ReadOnly = true;
            this.txtIdCursoOrigen.Size = new System.Drawing.Size(120, 28);
            this.txtIdCursoOrigen.TabIndex = 37;
            // 
            // txtIdCursoDestino
            // 
            this.txtIdCursoDestino.Enabled = false;
            this.txtIdCursoDestino.FormatoTexto = null;
            this.txtIdCursoDestino.Location = new System.Drawing.Point(581, 65);
            this.txtIdCursoDestino.Name = "txtIdCursoDestino";
            this.txtIdCursoDestino.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdCursoDestino.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtIdCursoDestino.ReadOnly = true;
            this.txtIdCursoDestino.Size = new System.Drawing.Size(120, 28);
            this.txtIdCursoDestino.TabIndex = 38;
            // 
            // lstOrigen
            // 
            this.lstOrigen.FormattingEnabled = true;
            this.lstOrigen.ItemHeight = 22;
            this.lstOrigen.Location = new System.Drawing.Point(41, 135);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstOrigen.Size = new System.Drawing.Size(441, 400);
            this.lstOrigen.TabIndex = 39;
            this.lstOrigen.DoubleClick += new System.EventHandler(this.lstOrigen_DoubleClick);
            // 
            // lstDestino
            // 
            this.lstDestino.FormattingEnabled = true;
            this.lstDestino.ItemHeight = 22;
            this.lstDestino.Location = new System.Drawing.Point(505, 135);
            this.lstDestino.Name = "lstDestino";
            this.lstDestino.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDestino.Size = new System.Drawing.Size(441, 400);
            this.lstDestino.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTransferir);
            this.groupBox1.Controls.Add(this.closeButton1);
            this.groupBox1.Location = new System.Drawing.Point(27, 541);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 142);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transferir";
            // 
            // txtIdCursoHorarioOrigen
            // 
            this.txtIdCursoHorarioOrigen.Enabled = false;
            this.txtIdCursoHorarioOrigen.FormatoTexto = null;
            this.txtIdCursoHorarioOrigen.Location = new System.Drawing.Point(258, 61);
            this.txtIdCursoHorarioOrigen.Name = "txtIdCursoHorarioOrigen";
            this.txtIdCursoHorarioOrigen.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIdCursoHorarioOrigen.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtIdCursoHorarioOrigen.ReadOnly = true;
            this.txtIdCursoHorarioOrigen.Size = new System.Drawing.Size(132, 28);
            this.txtIdCursoHorarioOrigen.TabIndex = 42;
            // 
            // txtCursoHorarrioDestino
            // 
            this.txtCursoHorarrioDestino.Enabled = false;
            this.txtCursoHorarrioDestino.FormatoTexto = null;
            this.txtCursoHorarrioDestino.Location = new System.Drawing.Point(722, 65);
            this.txtCursoHorarrioDestino.Name = "txtCursoHorarrioDestino";
            this.txtCursoHorarrioDestino.RangoInferior = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtCursoHorarrioDestino.RangoSuperior = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtCursoHorarrioDestino.ReadOnly = true;
            this.txtCursoHorarrioDestino.Size = new System.Drawing.Size(132, 28);
            this.txtCursoHorarrioDestino.TabIndex = 43;
            // 
            // ProcTransferenciaEstudiantesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.CancelButton = this.closeButton1;
            this.ClientSize = new System.Drawing.Size(987, 695);
            this.Controls.Add(this.txtCursoHorarrioDestino);
            this.Controls.Add(this.txtIdCursoHorarioOrigen);
            this.Controls.Add(this.lstDestino);
            this.Controls.Add(this.lstOrigen);
            this.Controls.Add(this.txtIdCursoDestino);
            this.Controls.Add(this.txtIdCursoOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarCursoDestino);
            this.Controls.Add(this.txtDescripcionCursoDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarCursoOrigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionCursoOrigen);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcTransferenciaEstudiantesForm";
            this.Text = "Transferencia de estudiantes";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.txtDescripcionCursoOrigen, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnBuscarCursoOrigen, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescripcionCursoDestino, 0);
            this.Controls.SetChildIndex(this.btnBuscarCursoDestino, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtIdCursoOrigen, 0);
            this.Controls.SetChildIndex(this.txtIdCursoDestino, 0);
            this.Controls.SetChildIndex(this.lstOrigen, 0);
            this.Controls.SetChildIndex(this.lstDestino, 0);
            this.Controls.SetChildIndex(this.txtIdCursoHorarioOrigen, 0);
            this.Controls.SetChildIndex(this.txtCursoHorarrioDestino, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.OkButton btnBuscarCursoOrigen;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic txtDescripcionCursoOrigen;
        private BaseControls.Derived.OkButton btnTransferir;
        private BaseControls.Derived.CloseButton closeButton1;
        private System.Windows.Forms.Label label6;
        private BaseControls.Derived.OkButton btnBuscarCursoDestino;
        private BaseControls.Derived.TextBasic txtDescripcionCursoDestino;
        private System.Windows.Forms.Label label7;
        private BaseControls.Derived.TextBasic txtIdCursoOrigen;
        private BaseControls.Derived.TextBasic txtIdCursoDestino;
        private System.Windows.Forms.ListBox lstOrigen;
        private System.Windows.Forms.ListBox lstDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        public BaseControls.Derived.TextBasic txtIdCursoHorarioOrigen;
        public BaseControls.Derived.TextBasic txtCursoHorarrioDestino;
    }
}
