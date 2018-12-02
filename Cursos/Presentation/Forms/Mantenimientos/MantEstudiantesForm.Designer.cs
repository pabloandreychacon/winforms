namespace Cursos.Presentation.Forms.Mantenimientos
{
    partial class MantEstudiantesForm
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
			System.Windows.Forms.Label correoLabel;
			System.Windows.Forms.Label fechaIngresoLabel;
			System.Windows.Forms.Label identificacionLabel;
			System.Windows.Forms.Label idEstudianteLabel;
			System.Windows.Forms.Label nombreLabel;
			System.Windows.Forms.Label telefonoLabel;
			System.Windows.Forms.Label activoLabel;
			System.Windows.Forms.Label fechaNacimientoLabel;
			System.Windows.Forms.Label direccionLabel;
			System.Windows.Forms.Label apellidoLabel;
			System.Windows.Forms.Label apellidoFinalLabel;
			System.Windows.Forms.Label celularLabel2;
			System.Windows.Forms.Label edadLabel1;
			System.Windows.Forms.Label tipoIdLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantEstudiantesForm));
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			this.estudianteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.estudianteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.correoTextBox = new System.Windows.Forms.TextBox();
			this.fechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.idEstudianteTextBox = new System.Windows.Forms.TextBox();
			this.nombreTextBox = new System.Windows.Forms.TextBox();
			this.activoCheckBox = new System.Windows.Forms.CheckBox();
			this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.direccionTextBox = new System.Windows.Forms.TextBox();
			this.creaCursoBtn = new BaseControls.Derived.OkButtonNoImage();
			this.asignaCursoBtn = new BaseControls.Derived.OkButtonNoImage();
			this.apellidoTextBox = new System.Windows.Forms.TextBox();
			this.apellidoFinalTextBox = new System.Windows.Forms.TextBox();
			this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.edadNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.tipoIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tipoIdComboBasic = new BaseControls.Derived.ComboBasic();
			this.identificacionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.comboBasic1 = new BaseControls.Derived.ComboBasic();
			this.comboBasic2 = new BaseControls.Derived.ComboBasic();
			this.comboBasic3 = new BaseControls.Derived.ComboBasic();
			correoLabel = new System.Windows.Forms.Label();
			fechaIngresoLabel = new System.Windows.Forms.Label();
			identificacionLabel = new System.Windows.Forms.Label();
			idEstudianteLabel = new System.Windows.Forms.Label();
			nombreLabel = new System.Windows.Forms.Label();
			telefonoLabel = new System.Windows.Forms.Label();
			activoLabel = new System.Windows.Forms.Label();
			fechaNacimientoLabel = new System.Windows.Forms.Label();
			direccionLabel = new System.Windows.Forms.Label();
			apellidoLabel = new System.Windows.Forms.Label();
			apellidoFinalLabel = new System.Windows.Forms.Label();
			celularLabel2 = new System.Windows.Forms.Label();
			edadLabel1 = new System.Windows.Forms.Label();
			tipoIdLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.estudianteBindingNavigator)).BeginInit();
			this.estudianteBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.edadNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoIdBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// closeButton1
			// 
			this.closeButton1.Location = new System.Drawing.Point(1089, 47);
			this.closeButton1.TabIndex = 17;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(1027, 47);
			this.btnFind.TabIndex = 16;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// errorContainer1
			// 
			this.errorContainer1.Location = new System.Drawing.Point(0, 196);
			// 
			// lblInfoMessage
			// 
			this.lblInfoMessage.Location = new System.Drawing.Point(48, 589);
			// 
			// correoLabel
			// 
			correoLabel.AutoSize = true;
			correoLabel.Location = new System.Drawing.Point(44, 176);
			correoLabel.Name = "correoLabel";
			correoLabel.Size = new System.Drawing.Size(73, 24);
			correoLabel.TabIndex = 6;
			correoLabel.Text = "Correo:";
			// 
			// fechaIngresoLabel
			// 
			fechaIngresoLabel.AutoSize = true;
			fechaIngresoLabel.Location = new System.Drawing.Point(44, 209);
			fechaIngresoLabel.Name = "fechaIngresoLabel";
			fechaIngresoLabel.Size = new System.Drawing.Size(137, 24);
			fechaIngresoLabel.TabIndex = 8;
			fechaIngresoLabel.Text = "Fecha Ingreso:";
			// 
			// identificacionLabel
			// 
			identificacionLabel.AutoSize = true;
			identificacionLabel.Location = new System.Drawing.Point(354, 243);
			identificacionLabel.Name = "identificacionLabel";
			identificacionLabel.Size = new System.Drawing.Size(124, 24);
			identificacionLabel.TabIndex = 10;
			identificacionLabel.Text = "Identificación:";
			// 
			// idEstudianteLabel
			// 
			idEstudianteLabel.AutoSize = true;
			idEstudianteLabel.Location = new System.Drawing.Point(44, 48);
			idEstudianteLabel.Name = "idEstudianteLabel";
			idEstudianteLabel.Size = new System.Drawing.Size(123, 24);
			idEstudianteLabel.TabIndex = 12;
			idEstudianteLabel.Text = "Id Estudiante:";
			// 
			// nombreLabel
			// 
			nombreLabel.AutoSize = true;
			nombreLabel.Location = new System.Drawing.Point(44, 81);
			nombreLabel.Name = "nombreLabel";
			nombreLabel.Size = new System.Drawing.Size(84, 24);
			nombreLabel.TabIndex = 14;
			nombreLabel.Text = "Nombre:";
			// 
			// telefonoLabel
			// 
			telefonoLabel.AutoSize = true;
			telefonoLabel.Location = new System.Drawing.Point(44, 308);
			telefonoLabel.Name = "telefonoLabel";
			telefonoLabel.Size = new System.Drawing.Size(90, 24);
			telefonoLabel.TabIndex = 16;
			telefonoLabel.Text = "Teléfono:";
			// 
			// activoLabel
			// 
			activoLabel.AutoSize = true;
			activoLabel.Location = new System.Drawing.Point(44, 374);
			activoLabel.Name = "activoLabel";
			activoLabel.Size = new System.Drawing.Size(66, 24);
			activoLabel.TabIndex = 17;
			activoLabel.Text = "Activo:";
			// 
			// fechaNacimientoLabel
			// 
			fechaNacimientoLabel.AutoSize = true;
			fechaNacimientoLabel.Location = new System.Drawing.Point(44, 407);
			fechaNacimientoLabel.Name = "fechaNacimientoLabel";
			fechaNacimientoLabel.Size = new System.Drawing.Size(169, 24);
			fechaNacimientoLabel.TabIndex = 18;
			fechaNacimientoLabel.Text = "Fecha Nacimiento:";
			// 
			// direccionLabel
			// 
			direccionLabel.AutoSize = true;
			direccionLabel.Location = new System.Drawing.Point(44, 450);
			direccionLabel.Name = "direccionLabel";
			direccionLabel.Size = new System.Drawing.Size(95, 24);
			direccionLabel.TabIndex = 13;
			direccionLabel.Text = "Dirección:";
			// 
			// apellidoLabel
			// 
			apellidoLabel.AutoSize = true;
			apellidoLabel.Location = new System.Drawing.Point(44, 114);
			apellidoLabel.Name = "apellidoLabel";
			apellidoLabel.Size = new System.Drawing.Size(84, 24);
			apellidoLabel.TabIndex = 28;
			apellidoLabel.Text = "Apellido:";
			// 
			// apellidoFinalLabel
			// 
			apellidoFinalLabel.AutoSize = true;
			apellidoFinalLabel.Location = new System.Drawing.Point(44, 146);
			apellidoFinalLabel.Name = "apellidoFinalLabel";
			apellidoFinalLabel.Size = new System.Drawing.Size(130, 24);
			apellidoFinalLabel.TabIndex = 30;
			apellidoFinalLabel.Text = "Apellido Final:";
			// 
			// celularLabel2
			// 
			celularLabel2.AutoSize = true;
			celularLabel2.Location = new System.Drawing.Point(44, 340);
			celularLabel2.Name = "celularLabel2";
			celularLabel2.Size = new System.Drawing.Size(74, 24);
			celularLabel2.TabIndex = 36;
			celularLabel2.Text = "Celular:";
			// 
			// edadLabel1
			// 
			edadLabel1.AutoSize = true;
			edadLabel1.Location = new System.Drawing.Point(44, 277);
			edadLabel1.Name = "edadLabel1";
			edadLabel1.Size = new System.Drawing.Size(60, 24);
			edadLabel1.TabIndex = 37;
			edadLabel1.Text = "Edad:";
			// 
			// tipoIdLabel
			// 
			tipoIdLabel.AutoSize = true;
			tipoIdLabel.Location = new System.Drawing.Point(45, 244);
			tipoIdLabel.Name = "tipoIdLabel";
			tipoIdLabel.Size = new System.Drawing.Size(73, 24);
			tipoIdLabel.TabIndex = 40;
			tipoIdLabel.Text = "Tipo Id:";
			// 
			// estudianteBindingNavigator
			// 
			this.estudianteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.estudianteBindingNavigator.BindingSource = this.estudianteBindingSource;
			this.estudianteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.estudianteBindingNavigator.DeleteItem = null;
			this.estudianteBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.estudianteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estudianteBindingNavigatorSaveItem});
			this.estudianteBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.estudianteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.estudianteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.estudianteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.estudianteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.estudianteBindingNavigator.Name = "estudianteBindingNavigator";
			this.estudianteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.estudianteBindingNavigator.Size = new System.Drawing.Size(1154, 27);
			this.estudianteBindingNavigator.TabIndex = 18;
			this.estudianteBindingNavigator.Text = "bindingNavigator1";
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
			// estudianteBindingSource
			// 
			this.estudianteBindingSource.DataSource = typeof(CursosEntities.Entities.Estudiante);
			this.estudianteBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.estudianteBindingSource_BindingComplete);
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
			// estudianteBindingNavigatorSaveItem
			// 
			this.estudianteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.estudianteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estudianteBindingNavigatorSaveItem.Image")));
			this.estudianteBindingNavigatorSaveItem.Name = "estudianteBindingNavigatorSaveItem";
			this.estudianteBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.estudianteBindingNavigatorSaveItem.Text = "Save Data";
			this.estudianteBindingNavigatorSaveItem.Click += new System.EventHandler(this.estudianteBindingNavigatorSaveItem_Click);
			// 
			// correoTextBox
			// 
			this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Correo", true));
			this.correoTextBox.Location = new System.Drawing.Point(215, 174);
			this.correoTextBox.Name = "correoTextBox";
			this.correoTextBox.Size = new System.Drawing.Size(302, 28);
			this.correoTextBox.TabIndex = 4;
			// 
			// fechaIngresoDateTimePicker
			// 
			this.fechaIngresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estudianteBindingSource, "FechaIngreso", true));
			this.fechaIngresoDateTimePicker.Location = new System.Drawing.Point(215, 208);
			this.fechaIngresoDateTimePicker.Name = "fechaIngresoDateTimePicker";
			this.fechaIngresoDateTimePicker.Size = new System.Drawing.Size(200, 28);
			this.fechaIngresoDateTimePicker.TabIndex = 5;
			// 
			// idEstudianteTextBox
			// 
			this.idEstudianteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "IdEstudiante", true));
			this.idEstudianteTextBox.Enabled = false;
			this.idEstudianteTextBox.Location = new System.Drawing.Point(215, 44);
			this.idEstudianteTextBox.Name = "idEstudianteTextBox";
			this.idEstudianteTextBox.ReadOnly = true;
			this.idEstudianteTextBox.Size = new System.Drawing.Size(200, 28);
			this.idEstudianteTextBox.TabIndex = 0;
			// 
			// nombreTextBox
			// 
			this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Nombre", true));
			this.nombreTextBox.Location = new System.Drawing.Point(215, 78);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(302, 28);
			this.nombreTextBox.TabIndex = 1;
			// 
			// activoCheckBox
			// 
			this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.estudianteBindingSource, "Activo", true));
			this.activoCheckBox.Location = new System.Drawing.Point(215, 386);
			this.activoCheckBox.Name = "activoCheckBox";
			this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
			this.activoCheckBox.TabIndex = 11;
			this.activoCheckBox.UseVisualStyleBackColor = true;
			// 
			// fechaNacimientoDateTimePicker
			// 
			this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estudianteBindingSource, "FechaNacimiento", true));
			this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(215, 416);
			this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
			this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 28);
			this.fechaNacimientoDateTimePicker.TabIndex = 12;
			// 
			// direccionTextBox
			// 
			this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Direccion", true));
			this.direccionTextBox.Location = new System.Drawing.Point(215, 514);
			this.direccionTextBox.Multiline = true;
			this.direccionTextBox.Name = "direccionTextBox";
			this.direccionTextBox.Size = new System.Drawing.Size(504, 71);
			this.direccionTextBox.TabIndex = 13;
			// 
			// creaCursoBtn
			// 
			this.creaCursoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.creaCursoBtn.Location = new System.Drawing.Point(566, 77);
			this.creaCursoBtn.Name = "creaCursoBtn";
			this.creaCursoBtn.Size = new System.Drawing.Size(203, 40);
			this.creaCursoBtn.TabIndex = 15;
			this.creaCursoBtn.Text = "Crear Curso...";
			this.creaCursoBtn.UseVisualStyleBackColor = true;
			this.creaCursoBtn.Visible = false;
			this.creaCursoBtn.Click += new System.EventHandler(this.creaCursoBtn_Click);
			// 
			// asignaCursoBtn
			// 
			this.asignaCursoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.asignaCursoBtn.Location = new System.Drawing.Point(566, 38);
			this.asignaCursoBtn.Name = "asignaCursoBtn";
			this.asignaCursoBtn.Size = new System.Drawing.Size(203, 40);
			this.asignaCursoBtn.TabIndex = 14;
			this.asignaCursoBtn.Text = "Asignar Curso...";
			this.asignaCursoBtn.UseVisualStyleBackColor = true;
			this.asignaCursoBtn.Visible = false;
			this.asignaCursoBtn.Click += new System.EventHandler(this.asignaCursoBtn_Click);
			// 
			// apellidoTextBox
			// 
			this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Apellido", true));
			this.apellidoTextBox.Location = new System.Drawing.Point(215, 110);
			this.apellidoTextBox.Name = "apellidoTextBox";
			this.apellidoTextBox.Size = new System.Drawing.Size(302, 28);
			this.apellidoTextBox.TabIndex = 2;
			// 
			// apellidoFinalTextBox
			// 
			this.apellidoFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "ApellidoFinal", true));
			this.apellidoFinalTextBox.Location = new System.Drawing.Point(215, 142);
			this.apellidoFinalTextBox.Name = "apellidoFinalTextBox";
			this.apellidoFinalTextBox.Size = new System.Drawing.Size(302, 28);
			this.apellidoFinalTextBox.TabIndex = 3;
			// 
			// celularMaskedTextBox
			// 
			this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Celular", true));
			this.celularMaskedTextBox.Location = new System.Drawing.Point(215, 343);
			this.celularMaskedTextBox.Mask = "0000-0000";
			this.celularMaskedTextBox.Name = "celularMaskedTextBox";
			this.celularMaskedTextBox.Size = new System.Drawing.Size(183, 28);
			this.celularMaskedTextBox.TabIndex = 10;
			// 
			// edadNumericUpDown
			// 
			this.edadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estudianteBindingSource, "Edad", true));
			this.edadNumericUpDown.Location = new System.Drawing.Point(215, 277);
			this.edadNumericUpDown.Name = "edadNumericUpDown";
			this.edadNumericUpDown.Size = new System.Drawing.Size(120, 28);
			this.edadNumericUpDown.TabIndex = 8;
			// 
			// telefonoMaskedTextBox
			// 
			this.telefonoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Telefono", true));
			this.telefonoMaskedTextBox.Location = new System.Drawing.Point(215, 311);
			this.telefonoMaskedTextBox.Mask = "0000-0000";
			this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
			this.telefonoMaskedTextBox.Size = new System.Drawing.Size(183, 28);
			this.telefonoMaskedTextBox.TabIndex = 9;
			// 
			// tipoIdBindingSource
			// 
			this.tipoIdBindingSource.DataSource = typeof(CursosEntities.Entities.TipoId);
			// 
			// tipoIdComboBasic
			// 
			this.tipoIdComboBasic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "TipoId", true));
			this.tipoIdComboBasic.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estudianteBindingSource, "IdTipoId", true));
			this.tipoIdComboBasic.DataSource = this.tipoIdBindingSource;
			this.tipoIdComboBasic.DisplayMember = "Descripcion";
			this.tipoIdComboBasic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tipoIdComboBasic.FormattingEnabled = true;
			this.tipoIdComboBasic.Location = new System.Drawing.Point(215, 242);
			this.tipoIdComboBasic.Name = "tipoIdComboBasic";
			this.tipoIdComboBasic.Size = new System.Drawing.Size(121, 30);
			this.tipoIdComboBasic.TabIndex = 6;
			this.tipoIdComboBasic.ValueMember = "IdTipoId";
			this.tipoIdComboBasic.SelectedIndexChanged += new System.EventHandler(this.tipoIdComboBasic_SelectedIndexChanged);
			// 
			// identificacionMaskedTextBox
			// 
			this.identificacionMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Identificacion", true));
			this.identificacionMaskedTextBox.Location = new System.Drawing.Point(525, 244);
			this.identificacionMaskedTextBox.Name = "identificacionMaskedTextBox";
			this.identificacionMaskedTextBox.Size = new System.Drawing.Size(255, 28);
			this.identificacionMaskedTextBox.TabIndex = 7;
			// 
			// comboBasic1
			// 
			this.comboBasic1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "TipoId", true));
			this.comboBasic1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estudianteBindingSource, "IdTipoId", true));
			this.comboBasic1.DataSource = this.tipoIdBindingSource;
			this.comboBasic1.DisplayMember = "Descripcion";
			this.comboBasic1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBasic1.FormattingEnabled = true;
			this.comboBasic1.Location = new System.Drawing.Point(215, 475);
			this.comboBasic1.Name = "comboBasic1";
			this.comboBasic1.Size = new System.Drawing.Size(121, 30);
			this.comboBasic1.TabIndex = 41;
			this.comboBasic1.ValueMember = "IdTipoId";
			// 
			// comboBasic2
			// 
			this.comboBasic2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "TipoId", true));
			this.comboBasic2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estudianteBindingSource, "IdTipoId", true));
			this.comboBasic2.DataSource = this.tipoIdBindingSource;
			this.comboBasic2.DisplayMember = "Descripcion";
			this.comboBasic2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBasic2.FormattingEnabled = true;
			this.comboBasic2.Location = new System.Drawing.Point(469, 475);
			this.comboBasic2.Name = "comboBasic2";
			this.comboBasic2.Size = new System.Drawing.Size(121, 30);
			this.comboBasic2.TabIndex = 42;
			this.comboBasic2.ValueMember = "IdTipoId";
			// 
			// comboBasic3
			// 
			this.comboBasic3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "TipoId", true));
			this.comboBasic3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estudianteBindingSource, "IdTipoId", true));
			this.comboBasic3.DataSource = this.tipoIdBindingSource;
			this.comboBasic3.DisplayMember = "Descripcion";
			this.comboBasic3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBasic3.FormattingEnabled = true;
			this.comboBasic3.Location = new System.Drawing.Point(342, 475);
			this.comboBasic3.Name = "comboBasic3";
			this.comboBasic3.Size = new System.Drawing.Size(121, 30);
			this.comboBasic3.TabIndex = 43;
			this.comboBasic3.ValueMember = "IdTipoId";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(211, 448);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(92, 24);
			label1.TabIndex = 44;
			label1.Text = "Provincia:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(338, 448);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(75, 24);
			label2.TabIndex = 45;
			label2.Text = "Cantón:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(465, 448);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(70, 24);
			label3.TabIndex = 46;
			label3.Text = "Distrito:";
			// 
			// MantEstudiantesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.ClientSize = new System.Drawing.Size(1154, 641);
			this.Controls.Add(label3);
			this.Controls.Add(label2);
			this.Controls.Add(label1);
			this.Controls.Add(this.comboBasic3);
			this.Controls.Add(this.comboBasic2);
			this.Controls.Add(this.comboBasic1);
			this.Controls.Add(this.identificacionMaskedTextBox);
			this.Controls.Add(tipoIdLabel);
			this.Controls.Add(this.tipoIdComboBasic);
			this.Controls.Add(this.telefonoMaskedTextBox);
			this.Controls.Add(edadLabel1);
			this.Controls.Add(this.edadNumericUpDown);
			this.Controls.Add(celularLabel2);
			this.Controls.Add(this.celularMaskedTextBox);
			this.Controls.Add(apellidoFinalLabel);
			this.Controls.Add(this.apellidoFinalTextBox);
			this.Controls.Add(apellidoLabel);
			this.Controls.Add(this.apellidoTextBox);
			this.Controls.Add(this.creaCursoBtn);
			this.Controls.Add(this.asignaCursoBtn);
			this.Controls.Add(direccionLabel);
			this.Controls.Add(this.direccionTextBox);
			this.Controls.Add(fechaNacimientoLabel);
			this.Controls.Add(this.fechaNacimientoDateTimePicker);
			this.Controls.Add(activoLabel);
			this.Controls.Add(this.activoCheckBox);
			this.Controls.Add(correoLabel);
			this.Controls.Add(this.correoTextBox);
			this.Controls.Add(fechaIngresoLabel);
			this.Controls.Add(this.fechaIngresoDateTimePicker);
			this.Controls.Add(identificacionLabel);
			this.Controls.Add(idEstudianteLabel);
			this.Controls.Add(this.idEstudianteTextBox);
			this.Controls.Add(nombreLabel);
			this.Controls.Add(this.nombreTextBox);
			this.Controls.Add(telefonoLabel);
			this.Controls.Add(this.estudianteBindingNavigator);
			this.Name = "MantEstudiantesForm";
			this.OrderKeys = "Nombre, Identific";
			this.Text = "Estudiantes";
			this.Load += new System.EventHandler(this.EstudiantesForm_Load);
			this.Controls.SetChildIndex(this.lblInfoMessage, 0);
			this.Controls.SetChildIndex(this.estudianteBindingNavigator, 0);
			this.Controls.SetChildIndex(telefonoLabel, 0);
			this.Controls.SetChildIndex(this.nombreTextBox, 0);
			this.Controls.SetChildIndex(nombreLabel, 0);
			this.Controls.SetChildIndex(this.idEstudianteTextBox, 0);
			this.Controls.SetChildIndex(idEstudianteLabel, 0);
			this.Controls.SetChildIndex(identificacionLabel, 0);
			this.Controls.SetChildIndex(this.fechaIngresoDateTimePicker, 0);
			this.Controls.SetChildIndex(fechaIngresoLabel, 0);
			this.Controls.SetChildIndex(this.correoTextBox, 0);
			this.Controls.SetChildIndex(correoLabel, 0);
			this.Controls.SetChildIndex(this.activoCheckBox, 0);
			this.Controls.SetChildIndex(activoLabel, 0);
			this.Controls.SetChildIndex(this.fechaNacimientoDateTimePicker, 0);
			this.Controls.SetChildIndex(fechaNacimientoLabel, 0);
			this.Controls.SetChildIndex(this.direccionTextBox, 0);
			this.Controls.SetChildIndex(direccionLabel, 0);
			this.Controls.SetChildIndex(this.asignaCursoBtn, 0);
			this.Controls.SetChildIndex(this.creaCursoBtn, 0);
			this.Controls.SetChildIndex(this.apellidoTextBox, 0);
			this.Controls.SetChildIndex(apellidoLabel, 0);
			this.Controls.SetChildIndex(this.apellidoFinalTextBox, 0);
			this.Controls.SetChildIndex(apellidoFinalLabel, 0);
			this.Controls.SetChildIndex(this.celularMaskedTextBox, 0);
			this.Controls.SetChildIndex(celularLabel2, 0);
			this.Controls.SetChildIndex(this.edadNumericUpDown, 0);
			this.Controls.SetChildIndex(edadLabel1, 0);
			this.Controls.SetChildIndex(this.telefonoMaskedTextBox, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnFind, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.tipoIdComboBasic, 0);
			this.Controls.SetChildIndex(tipoIdLabel, 0);
			this.Controls.SetChildIndex(this.identificacionMaskedTextBox, 0);
			this.Controls.SetChildIndex(this.comboBasic1, 0);
			this.Controls.SetChildIndex(this.comboBasic2, 0);
			this.Controls.SetChildIndex(this.comboBasic3, 0);
			this.Controls.SetChildIndex(label1, 0);
			this.Controls.SetChildIndex(label2, 0);
			this.Controls.SetChildIndex(label3, 0);
			((System.ComponentModel.ISupportInitialize)(this.estudianteBindingNavigator)).EndInit();
			this.estudianteBindingNavigator.ResumeLayout(false);
			this.estudianteBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.edadNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tipoIdBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private System.Windows.Forms.BindingNavigator estudianteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estudianteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.DateTimePicker fechaIngresoDateTimePicker;
        private System.Windows.Forms.TextBox idEstudianteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox direccionTextBox;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private BaseControls.Derived.OkButtonNoImage creaCursoBtn;
        public BaseControls.Derived.OkButtonNoImage asignaCursoBtn;
		private System.Windows.Forms.TextBox apellidoTextBox;
		private System.Windows.Forms.TextBox apellidoFinalTextBox;
		private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
		private System.Windows.Forms.NumericUpDown edadNumericUpDown;
		private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
		private System.Windows.Forms.BindingSource tipoIdBindingSource;
		private BaseControls.Derived.ComboBasic tipoIdComboBasic;
		private System.Windows.Forms.MaskedTextBox identificacionMaskedTextBox;
		private BaseControls.Derived.ComboBasic comboBasic1;
		private BaseControls.Derived.ComboBasic comboBasic2;
		private BaseControls.Derived.ComboBasic comboBasic3;
	}
}
