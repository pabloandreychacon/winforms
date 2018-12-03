namespace Cursos.Presentation.Forms.Mantenimientos
{
    partial class MantHorariosForm
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
			System.Windows.Forms.Label descripcionLabel;
			System.Windows.Forms.Label idHorarioLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantHorariosForm));
			this.horarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.horarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.descripcionTextBox = new System.Windows.Forms.TextBox();
			this.idHorarioTextBox = new System.Windows.Forms.TextBox();
			this.creaCursoBtn = new BaseControls.Derived.OkButtonNoImage();
			this.asignaCursoBtn = new BaseControls.Derived.OkButtonNoImage();
			descripcionLabel = new System.Windows.Forms.Label();
			idHorarioLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.horarioBindingNavigator)).BeginInit();
			this.horarioBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// closeButton1
			// 
			this.closeButton1.Location = new System.Drawing.Point(565, 47);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(503, 47);
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// lblInfoMessage
			// 
			this.lblInfoMessage.Location = new System.Drawing.Point(68, 185);
			// 
			// descripcionLabel
			// 
			descripcionLabel.AutoSize = true;
			descripcionLabel.Location = new System.Drawing.Point(64, 125);
			descripcionLabel.Name = "descripcionLabel";
			descripcionLabel.Size = new System.Drawing.Size(115, 24);
			descripcionLabel.TabIndex = 4;
			descripcionLabel.Text = "Descripción:";
			// 
			// idHorarioLabel
			// 
			idHorarioLabel.AutoSize = true;
			idHorarioLabel.Location = new System.Drawing.Point(64, 91);
			idHorarioLabel.Name = "idHorarioLabel";
			idHorarioLabel.Size = new System.Drawing.Size(97, 24);
			idHorarioLabel.TabIndex = 6;
			idHorarioLabel.Text = "Id Horario:";
			// 
			// horarioBindingNavigator
			// 
			this.horarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.horarioBindingNavigator.BindingSource = this.horarioBindingSource;
			this.horarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.horarioBindingNavigator.DeleteItem = null;
			this.horarioBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.horarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.horarioBindingNavigatorSaveItem});
			this.horarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.horarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.horarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.horarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.horarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.horarioBindingNavigator.Name = "horarioBindingNavigator";
			this.horarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.horarioBindingNavigator.Size = new System.Drawing.Size(630, 27);
			this.horarioBindingNavigator.TabIndex = 3;
			this.horarioBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// horarioBindingSource
			// 
			this.horarioBindingSource.DataSource = typeof(CursosEntities.Entities.Horario);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
			// 
			// horarioBindingNavigatorSaveItem
			// 
			this.horarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.horarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("horarioBindingNavigatorSaveItem.Image")));
			this.horarioBindingNavigatorSaveItem.Name = "horarioBindingNavigatorSaveItem";
			this.horarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.horarioBindingNavigatorSaveItem.Text = "Save Data";
			this.horarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.horarioBindingNavigatorSaveItem_Click);
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horarioBindingSource, "Descripcion", true));
			this.descripcionTextBox.Location = new System.Drawing.Point(185, 122);
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(272, 28);
			this.descripcionTextBox.TabIndex = 5;
			// 
			// idHorarioTextBox
			// 
			this.idHorarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horarioBindingSource, "IdHorario", true));
			this.idHorarioTextBox.Enabled = false;
			this.idHorarioTextBox.Location = new System.Drawing.Point(185, 88);
			this.idHorarioTextBox.Name = "idHorarioTextBox";
			this.idHorarioTextBox.ReadOnly = true;
			this.idHorarioTextBox.Size = new System.Drawing.Size(100, 28);
			this.idHorarioTextBox.TabIndex = 7;
			// 
			// creaCursoBtn
			// 
			this.creaCursoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.creaCursoBtn.Location = new System.Drawing.Point(68, 285);
			this.creaCursoBtn.Name = "creaCursoBtn";
			this.creaCursoBtn.Size = new System.Drawing.Size(203, 40);
			this.creaCursoBtn.TabIndex = 16;
			this.creaCursoBtn.Text = "Crear Curso...";
			this.creaCursoBtn.UseVisualStyleBackColor = true;
			this.creaCursoBtn.Visible = false;
			this.creaCursoBtn.Click += new System.EventHandler(this.creaCursoBtn_Click);
			// 
			// asignaCursoBtn
			// 
			this.asignaCursoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.asignaCursoBtn.Location = new System.Drawing.Point(68, 239);
			this.asignaCursoBtn.Name = "asignaCursoBtn";
			this.asignaCursoBtn.Size = new System.Drawing.Size(203, 40);
			this.asignaCursoBtn.TabIndex = 15;
			this.asignaCursoBtn.Text = "Asignar Curso...";
			this.asignaCursoBtn.UseVisualStyleBackColor = true;
			this.asignaCursoBtn.Visible = false;
			this.asignaCursoBtn.Click += new System.EventHandler(this.asignaCursoBtn_Click);
			// 
			// MantHorariosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 356);
			this.Controls.Add(this.creaCursoBtn);
			this.Controls.Add(this.asignaCursoBtn);
			this.Controls.Add(descripcionLabel);
			this.Controls.Add(this.descripcionTextBox);
			this.Controls.Add(idHorarioLabel);
			this.Controls.Add(this.idHorarioTextBox);
			this.Controls.Add(this.horarioBindingNavigator);
			this.Name = "MantHorariosForm";
			this.Text = "Horarios";
			this.Load += new System.EventHandler(this.HorariosForm_Load);
			this.Controls.SetChildIndex(this.lblInfoMessage, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnFind, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.horarioBindingNavigator, 0);
			this.Controls.SetChildIndex(this.idHorarioTextBox, 0);
			this.Controls.SetChildIndex(idHorarioLabel, 0);
			this.Controls.SetChildIndex(this.descripcionTextBox, 0);
			this.Controls.SetChildIndex(descripcionLabel, 0);
			this.Controls.SetChildIndex(this.asignaCursoBtn, 0);
			this.Controls.SetChildIndex(this.creaCursoBtn, 0);
			((System.ComponentModel.ISupportInitialize)(this.horarioBindingNavigator)).EndInit();
			this.horarioBindingNavigator.ResumeLayout(false);
			this.horarioBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource horarioBindingSource;
        private System.Windows.Forms.BindingNavigator horarioBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton horarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idHorarioTextBox;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private BaseControls.Derived.OkButtonNoImage creaCursoBtn;
        public BaseControls.Derived.OkButtonNoImage asignaCursoBtn;
    }
}