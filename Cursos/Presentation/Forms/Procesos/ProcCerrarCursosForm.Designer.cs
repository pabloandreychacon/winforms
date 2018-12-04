namespace Cursos.Presentation.Forms.Procesos
{
    partial class ProcCerrarCursosForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcCerrarCursosForm));
			this.txtIdProfesor = new BaseControls.Derived.TextBasic();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProfesor = new BaseControls.Derived.TextBasic();
			this.btnBuscaProfesor = new BaseControls.Derived.OkButton();
			this.gvCursosAsignados = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAsignar = new BaseControls.Derived.OkButton();
			this.closeButton1 = new BaseControls.Derived.CloseButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.gvCursosAsignados)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInfoMessage
			// 
			this.lblInfoMessage.Location = new System.Drawing.Point(34, 622);
			// 
			// txtIdProfesor
			// 
			this.txtIdProfesor.Enabled = false;
			this.txtIdProfesor.FormatoTexto = null;
			this.txtIdProfesor.Location = new System.Drawing.Point(121, 29);
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
			this.txtIdProfesor.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 24);
			this.label1.TabIndex = 22;
			this.label1.Text = "Profesor:";
			// 
			// txtProfesor
			// 
			this.txtProfesor.Enabled = false;
			this.txtProfesor.FormatoTexto = null;
			this.txtProfesor.Location = new System.Drawing.Point(279, 29);
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
			this.txtProfesor.TabIndex = 21;
			// 
			// btnBuscaProfesor
			// 
			this.btnBuscaProfesor.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnBuscaProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProfesor.Image")));
			this.btnBuscaProfesor.Location = new System.Drawing.Point(809, 23);
			this.btnBuscaProfesor.Name = "btnBuscaProfesor";
			this.btnBuscaProfesor.Size = new System.Drawing.Size(75, 40);
			this.btnBuscaProfesor.TabIndex = 20;
			this.btnBuscaProfesor.UseVisualStyleBackColor = true;
			this.btnBuscaProfesor.Click += new System.EventHandler(this.btnBuscaProfesor_Click);
			// 
			// gvCursosAsignados
			// 
			this.gvCursosAsignados.AllowUserToAddRows = false;
			this.gvCursosAsignados.AllowUserToDeleteRows = false;
			this.gvCursosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvCursosAsignados.Location = new System.Drawing.Point(34, 95);
			this.gvCursosAsignados.Name = "gvCursosAsignados";
			this.gvCursosAsignados.RowTemplate.Height = 24;
			this.gvCursosAsignados.Size = new System.Drawing.Size(850, 392);
			this.gvCursosAsignados.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 24);
			this.label2.TabIndex = 25;
			this.label2.Text = "Cursos asignados:";
			// 
			// btnAsignar
			// 
			this.btnAsignar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAsignar.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignar.Image")));
			this.btnAsignar.Location = new System.Drawing.Point(371, 514);
			this.btnAsignar.Name = "btnAsignar";
			this.btnAsignar.Size = new System.Drawing.Size(75, 68);
			this.btnAsignar.TabIndex = 26;
			this.btnAsignar.UseVisualStyleBackColor = true;
			this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
			// 
			// closeButton1
			// 
			this.closeButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton1.Image = ((System.Drawing.Image)(resources.GetObject("closeButton1.Image")));
			this.closeButton1.Location = new System.Drawing.Point(488, 514);
			this.closeButton1.Name = "closeButton1";
			this.closeButton1.Size = new System.Drawing.Size(75, 68);
			this.closeButton1.TabIndex = 28;
			this.closeButton1.TabStop = false;
			this.closeButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(22, 493);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(886, 113);
			this.groupBox1.TabIndex = 37;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cerrar";
			// 
			// ProcCerrarCursosForm
			// 
			this.AcceptButton = this.btnAsignar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.CancelButton = this.closeButton1;
			this.ClientSize = new System.Drawing.Size(932, 662);
			this.Controls.Add(this.btnAsignar);
			this.Controls.Add(this.closeButton1);
			this.Controls.Add(this.gvCursosAsignados);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIdProfesor);
			this.Controls.Add(this.btnBuscaProfesor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtProfesor);
			this.Controls.Add(this.groupBox1);
			this.Name = "ProcCerrarCursosForm";
			this.Text = "Cerrar Cursos";
			this.Controls.SetChildIndex(this.lblInfoMessage, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.txtProfesor, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.btnBuscaProfesor, 0);
			this.Controls.SetChildIndex(this.txtIdProfesor, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.gvCursosAsignados, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnAsignar, 0);
			((System.ComponentModel.ISupportInitialize)(this.gvCursosAsignados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private BaseControls.Derived.TextBasic txtIdProfesor;
        private BaseControls.Derived.OkButton btnBuscaProfesor;
        private System.Windows.Forms.Label label1;
        private BaseControls.Derived.TextBasic txtProfesor;
        private System.Windows.Forms.DataGridView gvCursosAsignados;
        private System.Windows.Forms.Label label2;
        private BaseControls.Derived.OkButton btnAsignar;
        private BaseControls.Derived.CloseButton closeButton1;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}
