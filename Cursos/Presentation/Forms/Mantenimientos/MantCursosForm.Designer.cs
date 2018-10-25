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
			System.Windows.Forms.Label nombreCursoLabel;
			System.Windows.Forms.Label cantidadHorasLabel1;
			System.Windows.Forms.Label cantidadEstudiantesLabel1;
			System.Windows.Forms.Label idAulaLabel;
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
			this.tipoIdComboBasic = new BaseControls.Derived.ComboBasic();
			activoLabel = new System.Windows.Forms.Label();
			descripcionLabel = new System.Windows.Forms.Label();
			idCursoLabel = new System.Windows.Forms.Label();
			codigoLabel = new System.Windows.Forms.Label();
			nombreCursoLabel = new System.Windows.Forms.Label();
			cantidadHorasLabel1 = new System.Windows.Forms.Label();
			cantidadEstudiantesLabel1 = new System.Windows.Forms.Label();
			idAulaLabel = new System.Windows.Forms.Label();
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
			this.closeButton1.Location = new System.Drawing.Point(887, 45);
			this.closeButton1.TabIndex = 15;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(825, 45);
			this.btnFind.TabIndex = 14;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// activoLabel
			// 
			activoLabel.AutoSize = true;
			activoLabel.Location = new System.Drawing.Point(99, 310);
			activoLabel.Name = "activoLabel";
			activoLabel.Size = new System.Drawing.Size(66, 24);
			activoLabel.TabIndex = 4;
			activoLabel.Text = "Activo:";
			// 
			// descripcionLabel
			// 
			descripcionLabel.AutoSize = true;
			descripcionLabel.Location = new System.Drawing.Point(99, 131);
			descripcionLabel.Name = "descripcionLabel";
			descripcionLabel.Size = new System.Drawing.Size(200, 24);
			descripcionLabel.TabIndex = 18;
			descripcionLabel.Text = "Descripción y alcance:";
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
			codigoLabel.Location = new System.Drawing.Point(99, 208);
			codigoLabel.Name = "codigoLabel";
			codigoLabel.Size = new System.Drawing.Size(76, 24);
			codigoLabel.TabIndex = 12;
			codigoLabel.Text = "Código:";
			// 
			// nombreCursoLabel
			// 
			nombreCursoLabel.AutoSize = true;
			nombreCursoLabel.Location = new System.Drawing.Point(99, 95);
			nombreCursoLabel.Name = "nombreCursoLabel";
			nombreCursoLabel.Size = new System.Drawing.Size(139, 24);
			nombreCursoLabel.TabIndex = 23;
			nombreCursoLabel.Text = "Nombre Curso:";
			// 
			// cantidadHorasLabel1
			// 
			cantidadHorasLabel1.AutoSize = true;
			cantidadHorasLabel1.Location = new System.Drawing.Point(99, 272);
			cantidadHorasLabel1.Name = "cantidadHorasLabel1";
			cantidadHorasLabel1.Size = new System.Drawing.Size(144, 24);
			cantidadHorasLabel1.TabIndex = 25;
			cantidadHorasLabel1.Text = "Cantidad Horas:";
			// 
			// cantidadEstudiantesLabel1
			// 
			cantidadEstudiantesLabel1.AutoSize = true;
			cantidadEstudiantesLabel1.Location = new System.Drawing.Point(99, 235);
			cantidadEstudiantesLabel1.Name = "cantidadEstudiantesLabel1";
			cantidadEstudiantesLabel1.Size = new System.Drawing.Size(191, 24);
			cantidadEstudiantesLabel1.TabIndex = 27;
			cantidadEstudiantesLabel1.Text = "Cantidad Estudiantes:";
			// 
			// idAulaLabel
			// 
			idAulaLabel.AutoSize = true;
			idAulaLabel.Location = new System.Drawing.Point(99, 342);
			idAulaLabel.Name = "idAulaLabel";
			idAulaLabel.Size = new System.Drawing.Size(53, 24);
			idAulaLabel.TabIndex = 28;
			idAulaLabel.Text = "Aula:";
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
			this.cursoBindingNavigator.Size = new System.Drawing.Size(973, 27);
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
			this.activoCheckBox.Location = new System.Drawing.Point(364, 306);
			this.activoCheckBox.Name = "activoCheckBox";
			this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
			this.activoCheckBox.TabIndex = 6;
			this.activoCheckBox.UseVisualStyleBackColor = true;
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Descripcion", true));
			this.descripcionTextBox.Location = new System.Drawing.Point(364, 124);
			this.descripcionTextBox.Multiline = true;
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(455, 72);
			this.descripcionTextBox.TabIndex = 2;
			// 
			// idCursoTextBox
			// 
			this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "IdCurso", true));
			this.idCursoTextBox.Enabled = false;
			this.idCursoTextBox.Location = new System.Drawing.Point(364, 50);
			this.idCursoTextBox.Name = "idCursoTextBox";
			this.idCursoTextBox.ReadOnly = true;
			this.idCursoTextBox.Size = new System.Drawing.Size(104, 28);
			this.idCursoTextBox.TabIndex = 0;
			// 
			// codigoTextBox
			// 
			this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "Codigo", true));
			this.codigoTextBox.Location = new System.Drawing.Point(364, 202);
			this.codigoTextBox.MaxLength = 50;
			this.codigoTextBox.Name = "codigoTextBox";
			this.codigoTextBox.Size = new System.Drawing.Size(207, 28);
			this.codigoTextBox.TabIndex = 3;
			// 
			// asignaProfesorBtn
			// 
			this.asignaProfesorBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.asignaProfesorBtn.Location = new System.Drawing.Point(110, 433);
			this.asignaProfesorBtn.Name = "asignaProfesorBtn";
			this.asignaProfesorBtn.Size = new System.Drawing.Size(203, 40);
			this.asignaProfesorBtn.TabIndex = 7;
			this.asignaProfesorBtn.Text = "Asignar Profesor...";
			this.asignaProfesorBtn.UseVisualStyleBackColor = true;
			this.asignaProfesorBtn.Visible = false;
			this.asignaProfesorBtn.Click += new System.EventHandler(this.asignaProfesorBtn_Click);
			// 
			// creaProfesorBtn
			// 
			this.creaProfesorBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.creaProfesorBtn.Location = new System.Drawing.Point(110, 472);
			this.creaProfesorBtn.Name = "creaProfesorBtn";
			this.creaProfesorBtn.Size = new System.Drawing.Size(203, 40);
			this.creaProfesorBtn.TabIndex = 10;
			this.creaProfesorBtn.Text = "Crear Profesor...";
			this.creaProfesorBtn.UseVisualStyleBackColor = true;
			this.creaProfesorBtn.Visible = false;
			this.creaProfesorBtn.Click += new System.EventHandler(this.creaProfesorBtn_Click);
			// 
			// asignaAusenciasBtn
			// 
			this.asignaAusenciasBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.asignaAusenciasBtn.Location = new System.Drawing.Point(110, 518);
			this.asignaAusenciasBtn.Name = "asignaAusenciasBtn";
			this.asignaAusenciasBtn.Size = new System.Drawing.Size(203, 40);
			this.asignaAusenciasBtn.TabIndex = 13;
			this.asignaAusenciasBtn.Text = "Asignar Ausencias...";
			this.asignaAusenciasBtn.UseVisualStyleBackColor = true;
			this.asignaAusenciasBtn.Visible = false;
			this.asignaAusenciasBtn.Click += new System.EventHandler(this.asignaAusenciasBtn_Click);
			// 
			// asignaEstudianteBtn
			// 
			this.asignaEstudianteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.asignaEstudianteBtn.Location = new System.Drawing.Point(319, 433);
			this.asignaEstudianteBtn.Name = "asignaEstudianteBtn";
			this.asignaEstudianteBtn.Size = new System.Drawing.Size(203, 40);
			this.asignaEstudianteBtn.TabIndex = 8;
			this.asignaEstudianteBtn.Text = "Asignar Estudiantes...";
			this.asignaEstudianteBtn.UseVisualStyleBackColor = true;
			this.asignaEstudianteBtn.Visible = false;
			this.asignaEstudianteBtn.Click += new System.EventHandler(this.asignaEstudianteBtn_Click);
			// 
			// creaEstudianteBtn
			// 
			this.creaEstudianteBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.creaEstudianteBtn.Location = new System.Drawing.Point(319, 472);
			this.creaEstudianteBtn.Name = "creaEstudianteBtn";
			this.creaEstudianteBtn.Size = new System.Drawing.Size(203, 40);
			this.creaEstudianteBtn.TabIndex = 11;
			this.creaEstudianteBtn.Text = "Crear Estudiante...";
			this.creaEstudianteBtn.UseVisualStyleBackColor = true;
			this.creaEstudianteBtn.Visible = false;
			this.creaEstudianteBtn.Click += new System.EventHandler(this.creaEstudianteBtn_Click);
			// 
			// creaHorarioBtn
			// 
			this.creaHorarioBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.creaHorarioBtn.Location = new System.Drawing.Point(528, 472);
			this.creaHorarioBtn.Name = "creaHorarioBtn";
			this.creaHorarioBtn.Size = new System.Drawing.Size(203, 40);
			this.creaHorarioBtn.TabIndex = 12;
			this.creaHorarioBtn.Text = "Crear Horario...";
			this.creaHorarioBtn.UseVisualStyleBackColor = true;
			this.creaHorarioBtn.Visible = false;
			this.creaHorarioBtn.Click += new System.EventHandler(this.creaHorarioBtn_Click);
			// 
			// asignaHorarioBtn
			// 
			this.asignaHorarioBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.asignaHorarioBtn.Location = new System.Drawing.Point(528, 433);
			this.asignaHorarioBtn.Name = "asignaHorarioBtn";
			this.asignaHorarioBtn.Size = new System.Drawing.Size(203, 40);
			this.asignaHorarioBtn.TabIndex = 9;
			this.asignaHorarioBtn.Text = "Asignar Horario...";
			this.asignaHorarioBtn.UseVisualStyleBackColor = true;
			this.asignaHorarioBtn.Visible = false;
			this.asignaHorarioBtn.Click += new System.EventHandler(this.asignaHorarioBtn_Click);
			// 
			// nombreCursoTextBox
			// 
			this.nombreCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursoBindingSource, "NombreCurso", true));
			this.nombreCursoTextBox.Location = new System.Drawing.Point(364, 90);
			this.nombreCursoTextBox.Name = "nombreCursoTextBox";
			this.nombreCursoTextBox.Size = new System.Drawing.Size(299, 28);
			this.nombreCursoTextBox.TabIndex = 1;
			// 
			// cantidadHorasNumericUpDown
			// 
			this.cantidadHorasNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursoBindingSource, "CantidadHoras", true));
			this.cantidadHorasNumericUpDown.Location = new System.Drawing.Point(364, 272);
			this.cantidadHorasNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.cantidadHorasNumericUpDown.Name = "cantidadHorasNumericUpDown";
			this.cantidadHorasNumericUpDown.Size = new System.Drawing.Size(120, 28);
			this.cantidadHorasNumericUpDown.TabIndex = 26;
			// 
			// cantidadEstudiantesNumericUpDown
			// 
			this.cantidadEstudiantesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cursoBindingSource, "CantidadEstudiantes", true));
			this.cantidadEstudiantesNumericUpDown.Location = new System.Drawing.Point(364, 238);
			this.cantidadEstudiantesNumericUpDown.Name = "cantidadEstudiantesNumericUpDown";
			this.cantidadEstudiantesNumericUpDown.Size = new System.Drawing.Size(120, 28);
			this.cantidadEstudiantesNumericUpDown.TabIndex = 28;
			// 
			// aulaBindingSource
			// 
			this.aulaBindingSource.DataSource = typeof(CursosEntities.Entities.Aula);
			// 
			// tipoIdComboBasic
			// 
			this.tipoIdComboBasic.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cursoBindingSource, "IdAula", true));
			this.tipoIdComboBasic.DataSource = this.aulaBindingSource;
			this.tipoIdComboBasic.DisplayMember = "Descripcion";
			this.tipoIdComboBasic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tipoIdComboBasic.FormattingEnabled = true;
			this.tipoIdComboBasic.Location = new System.Drawing.Point(363, 336);
			this.tipoIdComboBasic.Name = "tipoIdComboBasic";
			this.tipoIdComboBasic.Size = new System.Drawing.Size(208, 30);
			this.tipoIdComboBasic.TabIndex = 29;
			this.tipoIdComboBasic.ValueMember = "IdAula";
			// 
			// MantCursosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.ClientSize = new System.Drawing.Size(973, 578);
			this.Controls.Add(this.tipoIdComboBasic);
			this.Controls.Add(idAulaLabel);
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
			this.Controls.SetChildIndex(idAulaLabel, 0);
			this.Controls.SetChildIndex(this.tipoIdComboBasic, 0);
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
		private BaseControls.Derived.ComboBasic tipoIdComboBasic;
	}
}
