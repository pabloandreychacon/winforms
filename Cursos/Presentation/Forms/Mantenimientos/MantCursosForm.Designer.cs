﻿namespace Cursos.Presentation.Forms.Mantenimientos
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
            System.Windows.Forms.Label nombreCursoLabel;
            System.Windows.Forms.Label cantidadHorasLabel1;
            System.Windows.Forms.Label cantidadEstudiantesLabel1;
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
            this.asignaProfesorBtn = new BaseControls.Derived.OkButtonNoImage();
            this.creaProfesorBtn = new BaseControls.Derived.OkButtonNoImage();
            this.asignaAusenciasBtn = new BaseControls.Derived.OkButtonNoImage();
            this.asignaEstudianteBtn = new BaseControls.Derived.OkButtonNoImage();
            this.creaEstudianteBtn = new BaseControls.Derived.OkButtonNoImage();
            this.creaHorarioBtn = new BaseControls.Derived.OkButtonNoImage();
            this.asignaHorarioBtn = new BaseControls.Derived.OkButtonNoImage();
            this.nombreCursoTextBox = new System.Windows.Forms.TextBox();
            this.cantidadHorasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cantidadEstudiantesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idCursoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            nombreCursoLabel = new System.Windows.Forms.Label();
            cantidadHorasLabel1 = new System.Windows.Forms.Label();
            cantidadEstudiantesLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingNavigator)).BeginInit();
            this.cursoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadHorasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadEstudiantesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.Location = new System.Drawing.Point(710, 35);
            this.closeButton1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.closeButton1.TabIndex = 15;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(660, 35);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnFind.TabIndex = 14;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblInfoMessage
            // 
            this.lblInfoMessage.Location = new System.Drawing.Point(51, 296);
            this.lblInfoMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(79, 240);
            activoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(52, 18);
            activoLabel.TabIndex = 4;
            activoLabel.Text = "Activo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(79, 101);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(157, 18);
            descripcionLabel.TabIndex = 18;
            descripcionLabel.Text = "Descripción y alcance:";
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(79, 42);
            idCursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(68, 18);
            idCursoLabel.TabIndex = 8;
            idCursoLabel.Text = "Id Curso:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(79, 161);
            codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(60, 18);
            codigoLabel.TabIndex = 12;
            codigoLabel.Text = "Código:";
            // 
            // nombreCursoLabel
            // 
            nombreCursoLabel.AutoSize = true;
            nombreCursoLabel.Location = new System.Drawing.Point(79, 73);
            nombreCursoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreCursoLabel.Name = "nombreCursoLabel";
            nombreCursoLabel.Size = new System.Drawing.Size(111, 18);
            nombreCursoLabel.TabIndex = 23;
            nombreCursoLabel.Text = "Nombre Curso:";
            // 
            // cantidadHorasLabel1
            // 
            cantidadHorasLabel1.AutoSize = true;
            cantidadHorasLabel1.Location = new System.Drawing.Point(79, 210);
            cantidadHorasLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cantidadHorasLabel1.Name = "cantidadHorasLabel1";
            cantidadHorasLabel1.Size = new System.Drawing.Size(115, 18);
            cantidadHorasLabel1.TabIndex = 25;
            cantidadHorasLabel1.Text = "Cantidad Horas:";
            // 
            // cantidadEstudiantesLabel1
            // 
            cantidadEstudiantesLabel1.AutoSize = true;
            cantidadEstudiantesLabel1.Location = new System.Drawing.Point(79, 182);
            cantidadEstudiantesLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cantidadEstudiantesLabel1.Name = "cantidadEstudiantesLabel1";
            cantidadEstudiantesLabel1.Size = new System.Drawing.Size(151, 18);
            cantidadEstudiantesLabel1.TabIndex = 27;
            cantidadEstudiantesLabel1.Text = "Cantidad Estudiantes:";
            // 
            // cursoBindingNavigator
            // 
            this.cursoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cursoBindingNavigator.BindingSource = this.cursoBindingSource;
            this.cursoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursoBindingNavigator.DeleteItem = null;
            this.cursoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.cursoBindingNavigator.Size = new System.Drawing.Size(778, 27);
            this.cursoBindingNavigator.TabIndex = 16;
            this.cursoBindingNavigator.Text = "bindingNavigator1";
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
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(CursosEntities.Entities.Curso);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(41, 23);
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
            // cursoBindingNavigatorSaveItem
            // 
            this.cursoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursoBindingNavigatorSaveItem.Image")));
            this.cursoBindingNavigatorSaveItem.Name = "cursoBindingNavigatorSaveItem";
            this.cursoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.cursoBindingNavigatorSaveItem.Text = "Save Data";
            this.cursoBindingNavigatorSaveItem.Click += new System.EventHandler(this.cursoBindingNavigatorSaveItem_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cursoBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(291, 236);
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(83, 19);
            this.activoCheckBox.TabIndex = 6;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(291, 96);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(365, 57);
            this.descripcionTextBox.TabIndex = 2;
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "IdCurso", true));
            this.idCursoTextBox.Enabled = false;
            this.idCursoTextBox.Location = new System.Drawing.Point(291, 39);
            this.idCursoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.ReadOnly = true;
            this.idCursoTextBox.Size = new System.Drawing.Size(84, 24);
            this.idCursoTextBox.TabIndex = 0;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(291, 156);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codigoTextBox.MaxLength = 50;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(166, 24);
            this.codigoTextBox.TabIndex = 3;
            // 
            // asignaProfesorBtn
            // 
            this.asignaProfesorBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaProfesorBtn.Location = new System.Drawing.Point(88, 335);
            this.asignaProfesorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asignaProfesorBtn.Name = "asignaProfesorBtn";
            this.asignaProfesorBtn.Size = new System.Drawing.Size(162, 31);
            this.asignaProfesorBtn.TabIndex = 7;
            this.asignaProfesorBtn.Text = "Asignar Profesor...";
            this.asignaProfesorBtn.UseVisualStyleBackColor = true;
            this.asignaProfesorBtn.Click += new System.EventHandler(this.asignaProfesorBtn_Click);
            // 
            // creaProfesorBtn
            // 
            this.creaProfesorBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creaProfesorBtn.Location = new System.Drawing.Point(88, 365);
            this.creaProfesorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creaProfesorBtn.Name = "creaProfesorBtn";
            this.creaProfesorBtn.Size = new System.Drawing.Size(162, 31);
            this.creaProfesorBtn.TabIndex = 10;
            this.creaProfesorBtn.Text = "Crear Profesor...";
            this.creaProfesorBtn.UseVisualStyleBackColor = true;
            this.creaProfesorBtn.Click += new System.EventHandler(this.creaProfesorBtn_Click);
            // 
            // asignaAusenciasBtn
            // 
            this.asignaAusenciasBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaAusenciasBtn.Location = new System.Drawing.Point(88, 400);
            this.asignaAusenciasBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asignaAusenciasBtn.Name = "asignaAusenciasBtn";
            this.asignaAusenciasBtn.Size = new System.Drawing.Size(162, 31);
            this.asignaAusenciasBtn.TabIndex = 13;
            this.asignaAusenciasBtn.Text = "Asignar Ausencias...";
            this.asignaAusenciasBtn.UseVisualStyleBackColor = true;
            this.asignaAusenciasBtn.Click += new System.EventHandler(this.asignaAusenciasBtn_Click);
            // 
            // asignaEstudianteBtn
            // 
            this.asignaEstudianteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaEstudianteBtn.Location = new System.Drawing.Point(255, 335);
            this.asignaEstudianteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asignaEstudianteBtn.Name = "asignaEstudianteBtn";
            this.asignaEstudianteBtn.Size = new System.Drawing.Size(162, 31);
            this.asignaEstudianteBtn.TabIndex = 8;
            this.asignaEstudianteBtn.Text = "Asignar Estudiantes...";
            this.asignaEstudianteBtn.UseVisualStyleBackColor = true;
            this.asignaEstudianteBtn.Click += new System.EventHandler(this.asignaEstudianteBtn_Click);
            // 
            // creaEstudianteBtn
            // 
            this.creaEstudianteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creaEstudianteBtn.Location = new System.Drawing.Point(255, 365);
            this.creaEstudianteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creaEstudianteBtn.Name = "creaEstudianteBtn";
            this.creaEstudianteBtn.Size = new System.Drawing.Size(162, 31);
            this.creaEstudianteBtn.TabIndex = 11;
            this.creaEstudianteBtn.Text = "Crear Estudiante...";
            this.creaEstudianteBtn.UseVisualStyleBackColor = true;
            this.creaEstudianteBtn.Click += new System.EventHandler(this.creaEstudianteBtn_Click);
            // 
            // creaHorarioBtn
            // 
            this.creaHorarioBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creaHorarioBtn.Location = new System.Drawing.Point(422, 365);
            this.creaHorarioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creaHorarioBtn.Name = "creaHorarioBtn";
            this.creaHorarioBtn.Size = new System.Drawing.Size(162, 31);
            this.creaHorarioBtn.TabIndex = 12;
            this.creaHorarioBtn.Text = "Crear Horario...";
            this.creaHorarioBtn.UseVisualStyleBackColor = true;
            this.creaHorarioBtn.Click += new System.EventHandler(this.creaHorarioBtn_Click);
            // 
            // asignaHorarioBtn
            // 
            this.asignaHorarioBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaHorarioBtn.Location = new System.Drawing.Point(422, 335);
            this.asignaHorarioBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asignaHorarioBtn.Name = "asignaHorarioBtn";
            this.asignaHorarioBtn.Size = new System.Drawing.Size(162, 31);
            this.asignaHorarioBtn.TabIndex = 9;
            this.asignaHorarioBtn.Text = "Asignar Horario...";
            this.asignaHorarioBtn.UseVisualStyleBackColor = true;
            this.asignaHorarioBtn.Click += new System.EventHandler(this.asignaHorarioBtn_Click);
            // 
            // nombreCursoTextBox
            // 
            this.nombreCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "NombreCurso", true));
            this.nombreCursoTextBox.Location = new System.Drawing.Point(291, 70);
            this.nombreCursoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreCursoTextBox.Name = "nombreCursoTextBox";
            this.nombreCursoTextBox.Size = new System.Drawing.Size(240, 24);
            this.nombreCursoTextBox.TabIndex = 1;
            // 
            // cantidadHorasNumericUpDown
            // 
            this.cantidadHorasNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursoBindingSource, "CantidadHoras", true));
            this.cantidadHorasNumericUpDown.Location = new System.Drawing.Point(291, 210);
            this.cantidadHorasNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cantidadHorasNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidadHorasNumericUpDown.Name = "cantidadHorasNumericUpDown";
            this.cantidadHorasNumericUpDown.Size = new System.Drawing.Size(96, 24);
            this.cantidadHorasNumericUpDown.TabIndex = 26;
            // 
            // cantidadEstudiantesNumericUpDown
            // 
            this.cantidadEstudiantesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursoBindingSource, "CantidadEstudiantes", true));
            this.cantidadEstudiantesNumericUpDown.Location = new System.Drawing.Point(291, 184);
            this.cantidadEstudiantesNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cantidadEstudiantesNumericUpDown.Name = "cantidadEstudiantesNumericUpDown";
            this.cantidadEstudiantesNumericUpDown.Size = new System.Drawing.Size(96, 24);
            this.cantidadEstudiantesNumericUpDown.TabIndex = 28;
            // 
            // aulaBindingSource
            // 
            this.aulaBindingSource.DataSource = typeof(CursosEntities.Entities.Aula);
            // 
            // MantCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(778, 447);
            this.Controls.Add(cantidadEstudiantesLabel1);
            this.Controls.Add(this.cantidadEstudiantesNumericUpDown);
            this.Controls.Add(cantidadHorasLabel1);
            this.Controls.Add(this.cantidadHorasNumericUpDown);
            this.Controls.Add(nombreCursoLabel);
            this.Controls.Add(this.nombreCursoTextBox);
            this.Controls.Add(this.creaHorarioBtn);
            this.Controls.Add(this.asignaHorarioBtn);
            this.Controls.Add(this.creaEstudianteBtn);
            this.Controls.Add(this.asignaEstudianteBtn);
            this.Controls.Add(this.asignaAusenciasBtn);
            this.Controls.Add(this.creaProfesorBtn);
            this.Controls.Add(this.asignaProfesorBtn);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idCursoLabel);
            this.Controls.Add(this.idCursoTextBox);
            this.Controls.Add(this.cursoBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MantCursosForm";
            this.OrderKeys = "Descrip";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.CursosForm_Load);
            this.Controls.SetChildIndex(this.lblInfoMessage, 0);
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
            this.Controls.SetChildIndex(this.asignaProfesorBtn, 0);
            this.Controls.SetChildIndex(this.creaProfesorBtn, 0);
            this.Controls.SetChildIndex(this.asignaAusenciasBtn, 0);
            this.Controls.SetChildIndex(this.asignaEstudianteBtn, 0);
            this.Controls.SetChildIndex(this.creaEstudianteBtn, 0);
            this.Controls.SetChildIndex(this.asignaHorarioBtn, 0);
            this.Controls.SetChildIndex(this.creaHorarioBtn, 0);
            this.Controls.SetChildIndex(this.nombreCursoTextBox, 0);
            this.Controls.SetChildIndex(nombreCursoLabel, 0);
            this.Controls.SetChildIndex(this.cantidadHorasNumericUpDown, 0);
            this.Controls.SetChildIndex(cantidadHorasLabel1, 0);
            this.Controls.SetChildIndex(this.cantidadEstudiantesNumericUpDown, 0);
            this.Controls.SetChildIndex(cantidadEstudiantesLabel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingNavigator)).EndInit();
            this.cursoBindingNavigator.ResumeLayout(false);
            this.cursoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadHorasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadEstudiantesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
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
        private BaseControls.Derived.OkButtonNoImage creaProfesorBtn;
        private BaseControls.Derived.OkButtonNoImage asignaEstudianteBtn;
        private BaseControls.Derived.OkButtonNoImage creaEstudianteBtn;
        private BaseControls.Derived.OkButtonNoImage creaHorarioBtn;
        private BaseControls.Derived.OkButtonNoImage asignaHorarioBtn;
        public BaseControls.Derived.OkButtonNoImage asignaAusenciasBtn;
        public BaseControls.Derived.OkButtonNoImage asignaProfesorBtn;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.TextBox nombreCursoTextBox;
		private System.Windows.Forms.NumericUpDown cantidadHorasNumericUpDown;
		private System.Windows.Forms.NumericUpDown cantidadEstudiantesNumericUpDown;
		private System.Windows.Forms.BindingSource aulaBindingSource;
	}
}
