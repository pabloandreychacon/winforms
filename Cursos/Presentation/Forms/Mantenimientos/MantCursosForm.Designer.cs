namespace Cursos.Presentation.Forms.Mantenimientos
{
    partial class MantCursosForm
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idCursoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label cantidadHorasLabel;
            System.Windows.Forms.Label cantidadEstudiantesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantCursosForm));
            this.cursoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.cursoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idCursoTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.cantidadHorasTextBox = new System.Windows.Forms.TextBox();
            this.asignaProfesorBtn = new BaseControls.Derived.OkButtonNoImage();
            this.creaProfesorBtn = new BaseControls.Derived.OkButtonNoImage();
            this.asignaAusenciasBtn = new BaseControls.Derived.OkButtonNoImage();
            this.asignaEstudianteBtn = new BaseControls.Derived.OkButtonNoImage();
            this.creaEstudianteBtn = new BaseControls.Derived.OkButtonNoImage();
            this.creaHorarioBtn = new BaseControls.Derived.OkButtonNoImage();
            this.asignaHorarioBtn = new BaseControls.Derived.OkButtonNoImage();
            this.cantidadEstudiantesTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idCursoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            cantidadHorasLabel = new System.Windows.Forms.Label();
            cantidadEstudiantesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingNavigator)).BeginInit();
            this.cursoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.Location = new System.Drawing.Point(756, 45);
            this.closeButton1.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(694, 45);
            this.btnFind.TabIndex = 5;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(99, 225);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(66, 24);
            activoLabel.TabIndex = 4;
            activoLabel.Text = "Activo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(99, 89);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(115, 24);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripción:";
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(99, 55);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(85, 24);
            idCursoLabel.TabIndex = 8;
            idCursoLabel.Text = "Id Curso:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(99, 123);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(76, 24);
            codigoLabel.TabIndex = 12;
            codigoLabel.Text = "Código:";
            // 
            // cantidadHorasLabel
            // 
            cantidadHorasLabel.AutoSize = true;
            cantidadHorasLabel.Location = new System.Drawing.Point(99, 157);
            cantidadHorasLabel.Name = "cantidadHorasLabel";
            cantidadHorasLabel.Size = new System.Drawing.Size(144, 24);
            cantidadHorasLabel.TabIndex = 12;
            cantidadHorasLabel.Text = "Cantidad Horas:";
            // 
            // cantidadEstudiantesLabel
            // 
            cantidadEstudiantesLabel.AutoSize = true;
            cantidadEstudiantesLabel.Location = new System.Drawing.Point(99, 191);
            cantidadEstudiantesLabel.Name = "cantidadEstudiantesLabel";
            cantidadEstudiantesLabel.Size = new System.Drawing.Size(191, 24);
            cantidadEstudiantesLabel.TabIndex = 21;
            cantidadEstudiantesLabel.Text = "Cantidad Estudiantes:";
            // 
            // cursoBindingNavigator
            // 
            this.cursoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cursoBindingNavigator.BindingSource = this.cursoBindingSource;
            this.cursoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursoBindingNavigator.DeleteItem = null;
            this.cursoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cursoBindingNavigatorSaveItem});
            this.cursoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cursoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cursoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cursoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cursoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cursoBindingNavigator.Name = "cursoBindingNavigator";
            this.cursoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cursoBindingNavigator.Size = new System.Drawing.Size(842, 27);
            this.cursoBindingNavigator.TabIndex = 7;
            this.cursoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(CursosEntities.Entities.Curso);
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
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // cursoBindingNavigatorSaveItem
            // 
            this.cursoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursoBindingNavigatorSaveItem.Image")));
            this.cursoBindingNavigatorSaveItem.Name = "cursoBindingNavigatorSaveItem";
            this.cursoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.cursoBindingNavigatorSaveItem.Text = "Save Data";
            this.cursoBindingNavigatorSaveItem.Click += new System.EventHandler(this.cursoBindingNavigatorSaveItem_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cursoBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(364, 221);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 4;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(364, 82);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(299, 28);
            this.descripcionTextBox.TabIndex = 0;
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "IdCurso", true));
            this.idCursoTextBox.Enabled = false;
            this.idCursoTextBox.Location = new System.Drawing.Point(364, 50);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.ReadOnly = true;
            this.idCursoTextBox.Size = new System.Drawing.Size(104, 28);
            this.idCursoTextBox.TabIndex = 9;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(364, 117);
            this.codigoTextBox.MaxLength = 50;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(207, 28);
            this.codigoTextBox.TabIndex = 1;
            // 
            // cantidadHorasTextBox
            // 
            this.cantidadHorasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "CantidadHoras", true));
            this.cantidadHorasTextBox.Location = new System.Drawing.Point(364, 152);
            this.cantidadHorasTextBox.Name = "cantidadHorasTextBox";
            this.cantidadHorasTextBox.Size = new System.Drawing.Size(100, 28);
            this.cantidadHorasTextBox.TabIndex = 2;
            // 
            // asignaProfesorBtn
            // 
            this.asignaProfesorBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaProfesorBtn.Location = new System.Drawing.Point(111, 280);
            this.asignaProfesorBtn.Name = "asignaProfesorBtn";
            this.asignaProfesorBtn.Size = new System.Drawing.Size(203, 40);
            this.asignaProfesorBtn.TabIndex = 13;
            this.asignaProfesorBtn.Text = "Asignar Profesor...";
            this.asignaProfesorBtn.UseVisualStyleBackColor = true;
            this.asignaProfesorBtn.Click += new System.EventHandler(this.asignaProfesorBtn_Click);
            // 
            // creaProfesorBtn
            // 
            this.creaProfesorBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creaProfesorBtn.Location = new System.Drawing.Point(111, 319);
            this.creaProfesorBtn.Name = "creaProfesorBtn";
            this.creaProfesorBtn.Size = new System.Drawing.Size(203, 40);
            this.creaProfesorBtn.TabIndex = 14;
            this.creaProfesorBtn.Text = "Crear Profesor...";
            this.creaProfesorBtn.UseVisualStyleBackColor = true;
            this.creaProfesorBtn.Click += new System.EventHandler(this.creaProfesorBtn_Click);
            // 
            // asignaAusenciasBtn
            // 
            this.asignaAusenciasBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaAusenciasBtn.Location = new System.Drawing.Point(111, 365);
            this.asignaAusenciasBtn.Name = "asignaAusenciasBtn";
            this.asignaAusenciasBtn.Size = new System.Drawing.Size(203, 40);
            this.asignaAusenciasBtn.TabIndex = 15;
            this.asignaAusenciasBtn.Text = "Asignar Ausencias...";
            this.asignaAusenciasBtn.UseVisualStyleBackColor = true;
            this.asignaAusenciasBtn.Click += new System.EventHandler(this.asignaAusenciasBtn_Click);
            // 
            // asignaEstudianteBtn
            // 
            this.asignaEstudianteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaEstudianteBtn.Location = new System.Drawing.Point(320, 280);
            this.asignaEstudianteBtn.Name = "asignaEstudianteBtn";
            this.asignaEstudianteBtn.Size = new System.Drawing.Size(203, 40);
            this.asignaEstudianteBtn.TabIndex = 16;
            this.asignaEstudianteBtn.Text = "Asignar Estudiantes...";
            this.asignaEstudianteBtn.UseVisualStyleBackColor = true;
            this.asignaEstudianteBtn.Click += new System.EventHandler(this.asignaEstudianteBtn_Click);
            // 
            // creaEstudianteBtn
            // 
            this.creaEstudianteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creaEstudianteBtn.Location = new System.Drawing.Point(320, 319);
            this.creaEstudianteBtn.Name = "creaEstudianteBtn";
            this.creaEstudianteBtn.Size = new System.Drawing.Size(203, 40);
            this.creaEstudianteBtn.TabIndex = 17;
            this.creaEstudianteBtn.Text = "Crear Estudiante...";
            this.creaEstudianteBtn.UseVisualStyleBackColor = true;
            this.creaEstudianteBtn.Click += new System.EventHandler(this.creaEstudianteBtn_Click);
            // 
            // creaHorarioBtn
            // 
            this.creaHorarioBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creaHorarioBtn.Location = new System.Drawing.Point(529, 319);
            this.creaHorarioBtn.Name = "creaHorarioBtn";
            this.creaHorarioBtn.Size = new System.Drawing.Size(203, 40);
            this.creaHorarioBtn.TabIndex = 19;
            this.creaHorarioBtn.Text = "Crear Horario...";
            this.creaHorarioBtn.UseVisualStyleBackColor = true;
            this.creaHorarioBtn.Click += new System.EventHandler(this.creaHorarioBtn_Click);
            // 
            // asignaHorarioBtn
            // 
            this.asignaHorarioBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaHorarioBtn.Location = new System.Drawing.Point(529, 280);
            this.asignaHorarioBtn.Name = "asignaHorarioBtn";
            this.asignaHorarioBtn.Size = new System.Drawing.Size(203, 40);
            this.asignaHorarioBtn.TabIndex = 18;
            this.asignaHorarioBtn.Text = "Asignar Horario...";
            this.asignaHorarioBtn.UseVisualStyleBackColor = true;
            this.asignaHorarioBtn.Click += new System.EventHandler(this.asignaHorarioBtn_Click);
            // 
            // cantidadEstudiantesTextBox
            // 
            this.cantidadEstudiantesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "CantidadEstudiantes", true));
            this.cantidadEstudiantesTextBox.Location = new System.Drawing.Point(364, 187);
            this.cantidadEstudiantesTextBox.Name = "cantidadEstudiantesTextBox";
            this.cantidadEstudiantesTextBox.Size = new System.Drawing.Size(100, 28);
            this.cantidadEstudiantesTextBox.TabIndex = 3;
            // 
            // MantCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.ClientSize = new System.Drawing.Size(842, 429);
            this.Controls.Add(cantidadEstudiantesLabel);
            this.Controls.Add(this.cantidadEstudiantesTextBox);
            this.Controls.Add(this.creaHorarioBtn);
            this.Controls.Add(this.asignaHorarioBtn);
            this.Controls.Add(this.creaEstudianteBtn);
            this.Controls.Add(this.asignaEstudianteBtn);
            this.Controls.Add(this.asignaAusenciasBtn);
            this.Controls.Add(this.creaProfesorBtn);
            this.Controls.Add(this.asignaProfesorBtn);
            this.Controls.Add(cantidadHorasLabel);
            this.Controls.Add(this.cantidadHorasTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Controls.Add(this.cursoBindingNavigator);
            this.Name = "MantCursosForm";
            this.OrderKeys = "Descrip";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.CursosForm_Load);
            this.Controls.SetChildIndex(this.closeButton1, 0);
            this.Controls.SetChildIndex(this.btnFind, 0);
            this.Controls.SetChildIndex(this.errorContainer1, 0);
            this.Controls.SetChildIndex(this.cursoBindingNavigator, 0);
            this.Controls.SetChildIndex(this.idCursoTextBox, 0);
            this.Controls.SetChildIndex(idCursoLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.activoCheckBox, 0);
            this.Controls.SetChildIndex(activoLabel, 0);
            this.Controls.SetChildIndex(this.codigoTextBox, 0);
            this.Controls.SetChildIndex(codigoLabel, 0);
            this.Controls.SetChildIndex(this.cantidadHorasTextBox, 0);
            this.Controls.SetChildIndex(cantidadHorasLabel, 0);
            this.Controls.SetChildIndex(this.asignaProfesorBtn, 0);
            this.Controls.SetChildIndex(this.creaProfesorBtn, 0);
            this.Controls.SetChildIndex(this.asignaAusenciasBtn, 0);
            this.Controls.SetChildIndex(this.asignaEstudianteBtn, 0);
            this.Controls.SetChildIndex(this.creaEstudianteBtn, 0);
            this.Controls.SetChildIndex(this.asignaHorarioBtn, 0);
            this.Controls.SetChildIndex(this.creaHorarioBtn, 0);
            this.Controls.SetChildIndex(this.cantidadEstudiantesTextBox, 0);
            this.Controls.SetChildIndex(cantidadEstudiantesLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingNavigator)).EndInit();
            this.cursoBindingNavigator.ResumeLayout(false);
            this.cursoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.BindingNavigator cursoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cursoBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox cantidadHorasTextBox;
        private BaseControls.Derived.OkButtonNoImage creaProfesorBtn;
        private BaseControls.Derived.OkButtonNoImage asignaEstudianteBtn;
        private BaseControls.Derived.OkButtonNoImage creaEstudianteBtn;
        private BaseControls.Derived.OkButtonNoImage creaHorarioBtn;
        private BaseControls.Derived.OkButtonNoImage asignaHorarioBtn;
        public BaseControls.Derived.OkButtonNoImage asignaAusenciasBtn;
        public BaseControls.Derived.OkButtonNoImage asignaProfesorBtn;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.TextBox cantidadEstudiantesTextBox;
    }
}
