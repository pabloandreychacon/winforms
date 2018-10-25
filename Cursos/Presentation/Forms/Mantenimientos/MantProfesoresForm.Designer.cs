namespace Cursos.Presentation.Forms.Mantenimientos
{
    partial class MantProfesoresForm
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
			System.Windows.Forms.Label activoLabel;
			System.Windows.Forms.Label correoLabel;
			System.Windows.Forms.Label identificacionLabel;
			System.Windows.Forms.Label idProfesorLabel;
			System.Windows.Forms.Label nombreLabel;
			System.Windows.Forms.Label phoneLabel;
			System.Windows.Forms.Label institucionLabel;
			System.Windows.Forms.Label direccionLabel;
			System.Windows.Forms.Label celularLabel;
			System.Windows.Forms.Label apellidoLabel;
			System.Windows.Forms.Label apellidoFinalLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantProfesoresForm));
			this.profesoreBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.profesoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.profesoreBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.activoCheckBox = new System.Windows.Forms.CheckBox();
			this.correoTextBox = new System.Windows.Forms.TextBox();
			this.identificacionTextBox = new System.Windows.Forms.TextBox();
			this.idProfesorTextBox = new System.Windows.Forms.TextBox();
			this.nombreTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.institucionTextBox = new System.Windows.Forms.TextBox();
			this.direccionTextBox = new System.Windows.Forms.TextBox();
			this.celularTextBox = new System.Windows.Forms.TextBox();
			this.creaCursoBtn = new BaseControls.Derived.OkButtonNoImage();
			this.asignaCursoBtn = new BaseControls.Derived.OkButtonNoImage();
			this.apellidoTextBox = new System.Windows.Forms.TextBox();
			this.apellidoFinalTextBox = new System.Windows.Forms.TextBox();
			activoLabel = new System.Windows.Forms.Label();
			correoLabel = new System.Windows.Forms.Label();
			identificacionLabel = new System.Windows.Forms.Label();
			idProfesorLabel = new System.Windows.Forms.Label();
			nombreLabel = new System.Windows.Forms.Label();
			phoneLabel = new System.Windows.Forms.Label();
			institucionLabel = new System.Windows.Forms.Label();
			direccionLabel = new System.Windows.Forms.Label();
			celularLabel = new System.Windows.Forms.Label();
			apellidoLabel = new System.Windows.Forms.Label();
			apellidoFinalLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.profesoreBindingNavigator)).BeginInit();
			this.profesoreBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.profesoreBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// closeButton1
			// 
			this.closeButton1.Location = new System.Drawing.Point(739, 47);
			this.closeButton1.TabIndex = 13;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(677, 47);
			this.btnFind.TabIndex = 12;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// activoLabel
			// 
			activoLabel.AutoSize = true;
			activoLabel.Location = new System.Drawing.Point(44, 187);
			activoLabel.Name = "activoLabel";
			activoLabel.Size = new System.Drawing.Size(66, 24);
			activoLabel.TabIndex = 4;
			activoLabel.Text = "Activo:";
			// 
			// correoLabel
			// 
			correoLabel.AutoSize = true;
			correoLabel.Location = new System.Drawing.Point(44, 220);
			correoLabel.Name = "correoLabel";
			correoLabel.Size = new System.Drawing.Size(73, 24);
			correoLabel.TabIndex = 6;
			correoLabel.Text = "Correo:";
			// 
			// identificacionLabel
			// 
			identificacionLabel.AutoSize = true;
			identificacionLabel.Location = new System.Drawing.Point(44, 254);
			identificacionLabel.Name = "identificacionLabel";
			identificacionLabel.Size = new System.Drawing.Size(124, 24);
			identificacionLabel.TabIndex = 8;
			identificacionLabel.Text = "Identificación:";
			// 
			// idProfesorLabel
			// 
			idProfesorLabel.AutoSize = true;
			idProfesorLabel.Location = new System.Drawing.Point(44, 41);
			idProfesorLabel.Name = "idProfesorLabel";
			idProfesorLabel.Size = new System.Drawing.Size(105, 24);
			idProfesorLabel.TabIndex = 10;
			idProfesorLabel.Text = "Id Profesor:";
			// 
			// nombreLabel
			// 
			nombreLabel.AutoSize = true;
			nombreLabel.Location = new System.Drawing.Point(44, 76);
			nombreLabel.Name = "nombreLabel";
			nombreLabel.Size = new System.Drawing.Size(84, 24);
			nombreLabel.TabIndex = 12;
			nombreLabel.Text = "Nombre:";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new System.Drawing.Point(44, 290);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new System.Drawing.Size(90, 24);
			phoneLabel.TabIndex = 14;
			phoneLabel.Text = "Teléfono:";
			// 
			// institucionLabel
			// 
			institucionLabel.AutoSize = true;
			institucionLabel.Location = new System.Drawing.Point(44, 358);
			institucionLabel.Name = "institucionLabel";
			institucionLabel.Size = new System.Drawing.Size(98, 24);
			institucionLabel.TabIndex = 16;
			institucionLabel.Text = "Institución:";
			// 
			// direccionLabel
			// 
			direccionLabel.AutoSize = true;
			direccionLabel.Location = new System.Drawing.Point(44, 392);
			direccionLabel.Name = "direccionLabel";
			direccionLabel.Size = new System.Drawing.Size(95, 24);
			direccionLabel.TabIndex = 18;
			direccionLabel.Text = "Dirección:";
			// 
			// celularLabel
			// 
			celularLabel.AutoSize = true;
			celularLabel.Location = new System.Drawing.Point(44, 324);
			celularLabel.Name = "celularLabel";
			celularLabel.Size = new System.Drawing.Size(74, 24);
			celularLabel.TabIndex = 20;
			celularLabel.Text = "Celular:";
			// 
			// apellidoLabel
			// 
			apellidoLabel.AutoSize = true;
			apellidoLabel.Location = new System.Drawing.Point(44, 112);
			apellidoLabel.Name = "apellidoLabel";
			apellidoLabel.Size = new System.Drawing.Size(84, 24);
			apellidoLabel.TabIndex = 24;
			apellidoLabel.Text = "Apellido:";
			// 
			// apellidoFinalLabel
			// 
			apellidoFinalLabel.AutoSize = true;
			apellidoFinalLabel.Location = new System.Drawing.Point(44, 145);
			apellidoFinalLabel.Name = "apellidoFinalLabel";
			apellidoFinalLabel.Size = new System.Drawing.Size(130, 24);
			apellidoFinalLabel.TabIndex = 26;
			apellidoFinalLabel.Text = "Apellido Final:";
			// 
			// profesoreBindingNavigator
			// 
			this.profesoreBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.profesoreBindingNavigator.BindingSource = this.profesoreBindingSource;
			this.profesoreBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.profesoreBindingNavigator.DeleteItem = null;
			this.profesoreBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.profesoreBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.profesoreBindingNavigatorSaveItem});
			this.profesoreBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.profesoreBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.profesoreBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.profesoreBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.profesoreBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.profesoreBindingNavigator.Name = "profesoreBindingNavigator";
			this.profesoreBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.profesoreBindingNavigator.Size = new System.Drawing.Size(804, 27);
			this.profesoreBindingNavigator.TabIndex = 14;
			this.profesoreBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// profesoreBindingSource
			// 
			this.profesoreBindingSource.DataSource = typeof(CursosEntities.Entities.Profesore);
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
			// profesoreBindingNavigatorSaveItem
			// 
			this.profesoreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.profesoreBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("profesoreBindingNavigatorSaveItem.Image")));
			this.profesoreBindingNavigatorSaveItem.Name = "profesoreBindingNavigatorSaveItem";
			this.profesoreBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.profesoreBindingNavigatorSaveItem.Text = "Save Data";
			this.profesoreBindingNavigatorSaveItem.Click += new System.EventHandler(this.profesoreBindingNavigatorSaveItem_Click);
			// 
			// activoCheckBox
			// 
			this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.profesoreBindingSource, "Activo", true));
			this.activoCheckBox.Location = new System.Drawing.Point(174, 182);
			this.activoCheckBox.Name = "activoCheckBox";
			this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
			this.activoCheckBox.TabIndex = 3;
			this.activoCheckBox.UseVisualStyleBackColor = true;
			// 
			// correoTextBox
			// 
			this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Correo", true));
			this.correoTextBox.Location = new System.Drawing.Point(174, 217);
			this.correoTextBox.Name = "correoTextBox";
			this.correoTextBox.Size = new System.Drawing.Size(375, 28);
			this.correoTextBox.TabIndex = 4;
			// 
			// identificacionTextBox
			// 
			this.identificacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Identificacion", true));
			this.identificacionTextBox.Location = new System.Drawing.Point(174, 251);
			this.identificacionTextBox.Name = "identificacionTextBox";
			this.identificacionTextBox.Size = new System.Drawing.Size(262, 28);
			this.identificacionTextBox.TabIndex = 5;
			// 
			// idProfesorTextBox
			// 
			this.idProfesorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "IdProfesor", true));
			this.idProfesorTextBox.Enabled = false;
			this.idProfesorTextBox.Location = new System.Drawing.Point(174, 38);
			this.idProfesorTextBox.Name = "idProfesorTextBox";
			this.idProfesorTextBox.ReadOnly = true;
			this.idProfesorTextBox.Size = new System.Drawing.Size(104, 28);
			this.idProfesorTextBox.TabIndex = 11;
			// 
			// nombreTextBox
			// 
			this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Nombre", true));
			this.nombreTextBox.Location = new System.Drawing.Point(174, 73);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(375, 28);
			this.nombreTextBox.TabIndex = 0;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Phone", true));
			this.phoneTextBox.Location = new System.Drawing.Point(174, 287);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(191, 28);
			this.phoneTextBox.TabIndex = 6;
			// 
			// institucionTextBox
			// 
			this.institucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Institucion", true));
			this.institucionTextBox.Location = new System.Drawing.Point(174, 355);
			this.institucionTextBox.Name = "institucionTextBox";
			this.institucionTextBox.Size = new System.Drawing.Size(375, 28);
			this.institucionTextBox.TabIndex = 8;
			// 
			// direccionTextBox
			// 
			this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Direccion", true));
			this.direccionTextBox.Location = new System.Drawing.Point(174, 389);
			this.direccionTextBox.Multiline = true;
			this.direccionTextBox.Name = "direccionTextBox";
			this.direccionTextBox.Size = new System.Drawing.Size(375, 88);
			this.direccionTextBox.TabIndex = 9;
			// 
			// celularTextBox
			// 
			this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Celular", true));
			this.celularTextBox.Location = new System.Drawing.Point(174, 321);
			this.celularTextBox.Name = "celularTextBox";
			this.celularTextBox.Size = new System.Drawing.Size(191, 28);
			this.celularTextBox.TabIndex = 7;
			// 
			// creaCursoBtn
			// 
			this.creaCursoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.creaCursoBtn.Location = new System.Drawing.Point(578, 226);
			this.creaCursoBtn.Name = "creaCursoBtn";
			this.creaCursoBtn.Size = new System.Drawing.Size(203, 40);
			this.creaCursoBtn.TabIndex = 11;
			this.creaCursoBtn.Text = "Crear Curso...";
			this.creaCursoBtn.UseVisualStyleBackColor = true;
			this.creaCursoBtn.Visible = false;
			this.creaCursoBtn.Click += new System.EventHandler(this.creaCursoBtn_Click);
			// 
			// asignaCursoBtn
			// 
			this.asignaCursoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.asignaCursoBtn.Location = new System.Drawing.Point(578, 187);
			this.asignaCursoBtn.Name = "asignaCursoBtn";
			this.asignaCursoBtn.Size = new System.Drawing.Size(203, 40);
			this.asignaCursoBtn.TabIndex = 10;
			this.asignaCursoBtn.Text = "Asignar Curso...";
			this.asignaCursoBtn.UseVisualStyleBackColor = true;
			this.asignaCursoBtn.Visible = false;
			this.asignaCursoBtn.Click += new System.EventHandler(this.asignaCursoBtn_Click);
			// 
			// apellidoTextBox
			// 
			this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Apellido", true));
			this.apellidoTextBox.Location = new System.Drawing.Point(174, 107);
			this.apellidoTextBox.Name = "apellidoTextBox";
			this.apellidoTextBox.Size = new System.Drawing.Size(375, 28);
			this.apellidoTextBox.TabIndex = 1;
			// 
			// apellidoFinalTextBox
			// 
			this.apellidoFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "ApellidoFinal", true));
			this.apellidoFinalTextBox.Location = new System.Drawing.Point(174, 141);
			this.apellidoFinalTextBox.Name = "apellidoFinalTextBox";
			this.apellidoFinalTextBox.Size = new System.Drawing.Size(375, 28);
			this.apellidoFinalTextBox.TabIndex = 2;
			// 
			// MantProfesoresForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.ClientSize = new System.Drawing.Size(804, 566);
			this.Controls.Add(apellidoFinalLabel);
			this.Controls.Add(this.apellidoFinalTextBox);
			this.Controls.Add(apellidoLabel);
			this.Controls.Add(this.apellidoTextBox);
			this.Controls.Add(this.creaCursoBtn);
			this.Controls.Add(this.asignaCursoBtn);
			this.Controls.Add(celularLabel);
			this.Controls.Add(this.celularTextBox);
			this.Controls.Add(direccionLabel);
			this.Controls.Add(this.direccionTextBox);
			this.Controls.Add(institucionLabel);
			this.Controls.Add(this.institucionTextBox);
			this.Controls.Add(activoLabel);
			this.Controls.Add(this.activoCheckBox);
			this.Controls.Add(correoLabel);
			this.Controls.Add(this.correoTextBox);
			this.Controls.Add(identificacionLabel);
			this.Controls.Add(this.identificacionTextBox);
			this.Controls.Add(idProfesorLabel);
			this.Controls.Add(this.idProfesorTextBox);
			this.Controls.Add(nombreLabel);
			this.Controls.Add(this.nombreTextBox);
			this.Controls.Add(phoneLabel);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(this.profesoreBindingNavigator);
			this.Name = "MantProfesoresForm";
			this.OrderKeys = "Nombre, Identific";
			this.Text = "Profesores";
			this.Load += new System.EventHandler(this.ProfesoresForm_Load);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnFind, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.profesoreBindingNavigator, 0);
			this.Controls.SetChildIndex(this.phoneTextBox, 0);
			this.Controls.SetChildIndex(phoneLabel, 0);
			this.Controls.SetChildIndex(this.nombreTextBox, 0);
			this.Controls.SetChildIndex(nombreLabel, 0);
			this.Controls.SetChildIndex(this.idProfesorTextBox, 0);
			this.Controls.SetChildIndex(idProfesorLabel, 0);
			this.Controls.SetChildIndex(this.identificacionTextBox, 0);
			this.Controls.SetChildIndex(identificacionLabel, 0);
			this.Controls.SetChildIndex(this.correoTextBox, 0);
			this.Controls.SetChildIndex(correoLabel, 0);
			this.Controls.SetChildIndex(this.activoCheckBox, 0);
			this.Controls.SetChildIndex(activoLabel, 0);
			this.Controls.SetChildIndex(this.institucionTextBox, 0);
			this.Controls.SetChildIndex(institucionLabel, 0);
			this.Controls.SetChildIndex(this.direccionTextBox, 0);
			this.Controls.SetChildIndex(direccionLabel, 0);
			this.Controls.SetChildIndex(this.celularTextBox, 0);
			this.Controls.SetChildIndex(celularLabel, 0);
			this.Controls.SetChildIndex(this.asignaCursoBtn, 0);
			this.Controls.SetChildIndex(this.creaCursoBtn, 0);
			this.Controls.SetChildIndex(this.apellidoTextBox, 0);
			this.Controls.SetChildIndex(apellidoLabel, 0);
			this.Controls.SetChildIndex(this.apellidoFinalTextBox, 0);
			this.Controls.SetChildIndex(apellidoFinalLabel, 0);
			((System.ComponentModel.ISupportInitialize)(this.profesoreBindingNavigator)).EndInit();
			this.profesoreBindingNavigator.ResumeLayout(false);
			this.profesoreBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.profesoreBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource profesoreBindingSource;
        private System.Windows.Forms.BindingNavigator profesoreBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton profesoreBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox identificacionTextBox;
        private System.Windows.Forms.TextBox idProfesorTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox institucionTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private BaseControls.Derived.OkButtonNoImage creaCursoBtn;
        public BaseControls.Derived.OkButtonNoImage asignaCursoBtn;
		private System.Windows.Forms.TextBox apellidoTextBox;
		private System.Windows.Forms.TextBox apellidoFinalTextBox;
	}
}
