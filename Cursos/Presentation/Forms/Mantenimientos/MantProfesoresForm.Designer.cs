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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
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
            this.idProfesorTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.institucionTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.creaCursoBtn = new BaseControls.Derived.OkButtonNoImage();
            this.asignaCursoBtn = new BaseControls.Derived.OkButtonNoImage();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoFinalTextBox = new System.Windows.Forms.TextBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distritosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.identificacionMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cboListaProvincias = new System.Windows.Forms.ComboBox();
            this.cboListaCantones = new System.Windows.Forms.ComboBox();
            this.cboListaDistritos = new System.Windows.Forms.ComboBox();
            this.cboProvincias = new System.Windows.Forms.ComboBox();
            this.cboCantones = new System.Windows.Forms.ComboBox();
            this.cboDistritos = new System.Windows.Forms.ComboBox();
            this.cboTiposIds = new System.Windows.Forms.ComboBox();
            this.tipoIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profesoreBindingNavigator)).BeginInit();
            this.profesoreBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.Location = new System.Drawing.Point(1005, 47);
            this.closeButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton1.TabIndex = 13;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(944, 47);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.TabIndex = 12;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblInfoMessage
            // 
            this.lblInfoMessage.Location = new System.Drawing.Point(48, 664);
            this.lblInfoMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(44, 186);
            activoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(66, 24);
            activoLabel.TabIndex = 4;
            activoLabel.Text = "Activo:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(44, 220);
            correoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(73, 24);
            correoLabel.TabIndex = 6;
            correoLabel.Text = "Correo:";
            // 
            // identificacionLabel
            // 
            identificacionLabel.AutoSize = true;
            identificacionLabel.Location = new System.Drawing.Point(44, 254);
            identificacionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            identificacionLabel.Name = "identificacionLabel";
            identificacionLabel.Size = new System.Drawing.Size(124, 24);
            identificacionLabel.TabIndex = 8;
            identificacionLabel.Text = "Identificación:";
            // 
            // idProfesorLabel
            // 
            idProfesorLabel.AutoSize = true;
            idProfesorLabel.Location = new System.Drawing.Point(44, 41);
            idProfesorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idProfesorLabel.Name = "idProfesorLabel";
            idProfesorLabel.Size = new System.Drawing.Size(105, 24);
            idProfesorLabel.TabIndex = 10;
            idProfesorLabel.Text = "Id Profesor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(44, 76);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(84, 24);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(44, 290);
            phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(90, 24);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Teléfono:";
            // 
            // institucionLabel
            // 
            institucionLabel.AutoSize = true;
            institucionLabel.Location = new System.Drawing.Point(44, 358);
            institucionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            institucionLabel.Name = "institucionLabel";
            institucionLabel.Size = new System.Drawing.Size(98, 24);
            institucionLabel.TabIndex = 16;
            institucionLabel.Text = "Institución:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(44, 392);
            direccionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(95, 24);
            direccionLabel.TabIndex = 18;
            direccionLabel.Text = "Dirección:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(44, 324);
            celularLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(74, 24);
            celularLabel.TabIndex = 20;
            celularLabel.Text = "Celular:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(44, 113);
            apellidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(84, 24);
            apellidoLabel.TabIndex = 24;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoFinalLabel
            // 
            apellidoFinalLabel.AutoSize = true;
            apellidoFinalLabel.Location = new System.Drawing.Point(44, 145);
            apellidoFinalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            apellidoFinalLabel.Name = "apellidoFinalLabel";
            apellidoFinalLabel.Size = new System.Drawing.Size(130, 24);
            apellidoFinalLabel.TabIndex = 26;
            apellidoFinalLabel.Text = "Apellido Final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(448, 396);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 24);
            label3.TabIndex = 53;
            label3.Text = "Distrito:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(310, 396);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 24);
            label2.TabIndex = 52;
            label2.Text = "Cantón:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(169, 396);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 24);
            label1.TabIndex = 51;
            label1.Text = "Provincia:";
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
            this.profesoreBindingNavigator.Size = new System.Drawing.Size(1070, 27);
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
            this.profesoreBindingSource.PositionChanged += new System.EventHandler(this.profesoreBindingSource_PositionChanged);
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
            this.activoCheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 25);
            this.activoCheckBox.TabIndex = 3;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(174, 217);
            this.correoTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(375, 28);
            this.correoTextBox.TabIndex = 4;
            // 
            // idProfesorTextBox
            // 
            this.idProfesorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "IdProfesor", true));
            this.idProfesorTextBox.Enabled = false;
            this.idProfesorTextBox.Location = new System.Drawing.Point(174, 38);
            this.idProfesorTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idProfesorTextBox.Name = "idProfesorTextBox";
            this.idProfesorTextBox.ReadOnly = true;
            this.idProfesorTextBox.Size = new System.Drawing.Size(104, 28);
            this.idProfesorTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(174, 72);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(375, 28);
            this.nombreTextBox.TabIndex = 0;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(174, 287);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(192, 28);
            this.phoneTextBox.TabIndex = 6;
            // 
            // institucionTextBox
            // 
            this.institucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Institucion", true));
            this.institucionTextBox.Location = new System.Drawing.Point(174, 355);
            this.institucionTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.institucionTextBox.Name = "institucionTextBox";
            this.institucionTextBox.Size = new System.Drawing.Size(375, 28);
            this.institucionTextBox.TabIndex = 8;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(174, 321);
            this.celularTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(192, 28);
            this.celularTextBox.TabIndex = 7;
            // 
            // creaCursoBtn
            // 
            this.creaCursoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.creaCursoBtn.Location = new System.Drawing.Point(578, 226);
            this.creaCursoBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.creaCursoBtn.Name = "creaCursoBtn";
            this.creaCursoBtn.Size = new System.Drawing.Size(202, 40);
            this.creaCursoBtn.TabIndex = 11;
            this.creaCursoBtn.Text = "Crear Curso...";
            this.creaCursoBtn.UseVisualStyleBackColor = true;
            this.creaCursoBtn.Visible = false;
            this.creaCursoBtn.Click += new System.EventHandler(this.creaCursoBtn_Click);
            // 
            // asignaCursoBtn
            // 
            this.asignaCursoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.asignaCursoBtn.Location = new System.Drawing.Point(578, 186);
            this.asignaCursoBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.asignaCursoBtn.Name = "asignaCursoBtn";
            this.asignaCursoBtn.Size = new System.Drawing.Size(202, 40);
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
            this.apellidoTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(375, 28);
            this.apellidoTextBox.TabIndex = 1;
            // 
            // apellidoFinalTextBox
            // 
            this.apellidoFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "ApellidoFinal", true));
            this.apellidoFinalTextBox.Location = new System.Drawing.Point(174, 141);
            this.apellidoFinalTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.apellidoFinalTextBox.Name = "apellidoFinalTextBox";
            this.apellidoFinalTextBox.Size = new System.Drawing.Size(375, 28);
            this.apellidoFinalTextBox.TabIndex = 2;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataSource = typeof(CursosEntities.Entities.Provincia);
            // 
            // cantonesBindingSource
            // 
            this.cantonesBindingSource.DataSource = typeof(CursosEntities.Entities.Cantone);
            // 
            // distritosBindingSource
            // 
            this.distritosBindingSource.DataSource = typeof(CursosEntities.Entities.Distrito);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(174, 462);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(462, 84);
            this.direccionTextBox.TabIndex = 47;
            // 
            // identificacionMaskedTextBox
            // 
            this.identificacionMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesoreBindingSource, "Identificacion", true));
            this.identificacionMaskedTextBox.Location = new System.Drawing.Point(332, 252);
            this.identificacionMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.identificacionMaskedTextBox.Name = "identificacionMaskedTextBox";
            this.identificacionMaskedTextBox.Size = new System.Drawing.Size(216, 28);
            this.identificacionMaskedTextBox.TabIndex = 54;
            // 
            // cboListaProvincias
            // 
            this.cboListaProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaProvincias.FormattingEnabled = true;
            this.cboListaProvincias.Location = new System.Drawing.Point(719, 422);
            this.cboListaProvincias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboListaProvincias.Name = "cboListaProvincias";
            this.cboListaProvincias.Size = new System.Drawing.Size(150, 30);
            this.cboListaProvincias.TabIndex = 69;
            this.cboListaProvincias.SelectedIndexChanged += new System.EventHandler(this.cboListaProvincias_SelectedIndexChanged);
            // 
            // cboListaCantones
            // 
            this.cboListaCantones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaCantones.FormattingEnabled = true;
            this.cboListaCantones.Location = new System.Drawing.Point(719, 462);
            this.cboListaCantones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboListaCantones.Name = "cboListaCantones";
            this.cboListaCantones.Size = new System.Drawing.Size(150, 30);
            this.cboListaCantones.TabIndex = 68;
            this.cboListaCantones.SelectedIndexChanged += new System.EventHandler(this.cboListaCantones_SelectedIndexChanged);
            // 
            // cboListaDistritos
            // 
            this.cboListaDistritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaDistritos.FormattingEnabled = true;
            this.cboListaDistritos.Location = new System.Drawing.Point(719, 501);
            this.cboListaDistritos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboListaDistritos.Name = "cboListaDistritos";
            this.cboListaDistritos.Size = new System.Drawing.Size(150, 30);
            this.cboListaDistritos.TabIndex = 67;
            // 
            // cboProvincias
            // 
            this.cboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboProvincias.Enabled = false;
            this.cboProvincias.FormattingEnabled = true;
            this.cboProvincias.Location = new System.Drawing.Point(172, 423);
            this.cboProvincias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProvincias.Name = "cboProvincias";
            this.cboProvincias.Size = new System.Drawing.Size(133, 31);
            this.cboProvincias.TabIndex = 66;
            // 
            // cboCantones
            // 
            this.cboCantones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboCantones.Enabled = false;
            this.cboCantones.FormattingEnabled = true;
            this.cboCantones.Location = new System.Drawing.Point(314, 423);
            this.cboCantones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCantones.Name = "cboCantones";
            this.cboCantones.Size = new System.Drawing.Size(129, 31);
            this.cboCantones.TabIndex = 65;
            // 
            // cboDistritos
            // 
            this.cboDistritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboDistritos.Enabled = false;
            this.cboDistritos.FormattingEnabled = true;
            this.cboDistritos.Location = new System.Drawing.Point(451, 423);
            this.cboDistritos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDistritos.Name = "cboDistritos";
            this.cboDistritos.Size = new System.Drawing.Size(150, 31);
            this.cboDistritos.TabIndex = 64;
            // 
            // cboTiposIds
            // 
            this.cboTiposIds.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.profesoreBindingSource, "IdTipoId", true));
            this.cboTiposIds.DataSource = this.tipoIdBindingSource;
            this.cboTiposIds.DisplayMember = "Descripcion";
            this.cboTiposIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiposIds.FormattingEnabled = true;
            this.cboTiposIds.Location = new System.Drawing.Point(174, 252);
            this.cboTiposIds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTiposIds.Name = "cboTiposIds";
            this.cboTiposIds.Size = new System.Drawing.Size(150, 30);
            this.cboTiposIds.TabIndex = 70;
            this.cboTiposIds.ValueMember = "IdTipoId";
            this.cboTiposIds.SelectedIndexChanged += new System.EventHandler(this.cboTiposIds_SelectedIndexChanged);
            // 
            // tipoIdBindingSource
            // 
            this.tipoIdBindingSource.DataSource = typeof(CursosEntities.Entities.TipoId);
            // 
            // MantProfesoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.ClientSize = new System.Drawing.Size(1070, 717);
            this.Controls.Add(this.cboTiposIds);
            this.Controls.Add(this.cboListaProvincias);
            this.Controls.Add(this.cboListaCantones);
            this.Controls.Add(this.cboListaDistritos);
            this.Controls.Add(this.cboProvincias);
            this.Controls.Add(this.cboCantones);
            this.Controls.Add(this.cboDistritos);
            this.Controls.Add(this.identificacionMaskedTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(apellidoFinalLabel);
            this.Controls.Add(this.apellidoFinalTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.creaCursoBtn);
            this.Controls.Add(this.asignaCursoBtn);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(institucionLabel);
            this.Controls.Add(this.institucionTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(identificacionLabel);
            this.Controls.Add(idProfesorLabel);
            this.Controls.Add(this.idProfesorTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.profesoreBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "MantProfesoresForm";
            this.OrderKeys = "Nombre, Identific";
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.ProfesoresForm_Load);
            this.Controls.SetChildIndex(this.lblInfoMessage, 0);
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
            this.Controls.SetChildIndex(identificacionLabel, 0);
            this.Controls.SetChildIndex(this.correoTextBox, 0);
            this.Controls.SetChildIndex(correoLabel, 0);
            this.Controls.SetChildIndex(this.activoCheckBox, 0);
            this.Controls.SetChildIndex(activoLabel, 0);
            this.Controls.SetChildIndex(this.institucionTextBox, 0);
            this.Controls.SetChildIndex(institucionLabel, 0);
            this.Controls.SetChildIndex(direccionLabel, 0);
            this.Controls.SetChildIndex(this.celularTextBox, 0);
            this.Controls.SetChildIndex(celularLabel, 0);
            this.Controls.SetChildIndex(this.asignaCursoBtn, 0);
            this.Controls.SetChildIndex(this.creaCursoBtn, 0);
            this.Controls.SetChildIndex(this.apellidoTextBox, 0);
            this.Controls.SetChildIndex(apellidoLabel, 0);
            this.Controls.SetChildIndex(this.apellidoFinalTextBox, 0);
            this.Controls.SetChildIndex(apellidoFinalLabel, 0);
            this.Controls.SetChildIndex(this.direccionTextBox, 0);
            this.Controls.SetChildIndex(label1, 0);
            this.Controls.SetChildIndex(label2, 0);
            this.Controls.SetChildIndex(label3, 0);
            this.Controls.SetChildIndex(this.identificacionMaskedTextBox, 0);
            this.Controls.SetChildIndex(this.cboDistritos, 0);
            this.Controls.SetChildIndex(this.cboCantones, 0);
            this.Controls.SetChildIndex(this.cboProvincias, 0);
            this.Controls.SetChildIndex(this.cboListaDistritos, 0);
            this.Controls.SetChildIndex(this.cboListaCantones, 0);
            this.Controls.SetChildIndex(this.cboListaProvincias, 0);
            this.Controls.SetChildIndex(this.cboTiposIds, 0);
            ((System.ComponentModel.ISupportInitialize)(this.profesoreBindingNavigator)).EndInit();
            this.profesoreBindingNavigator.ResumeLayout(false);
            this.profesoreBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox idProfesorTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox institucionTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private BaseControls.Derived.OkButtonNoImage creaCursoBtn;
        public BaseControls.Derived.OkButtonNoImage asignaCursoBtn;
		private System.Windows.Forms.TextBox apellidoTextBox;
		private System.Windows.Forms.TextBox apellidoFinalTextBox;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private System.Windows.Forms.BindingSource cantonesBindingSource;
        private System.Windows.Forms.BindingSource distritosBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.MaskedTextBox identificacionMaskedTextBox;
        private System.Windows.Forms.ComboBox cboListaProvincias;
        private System.Windows.Forms.ComboBox cboListaCantones;
        private System.Windows.Forms.ComboBox cboListaDistritos;
        private System.Windows.Forms.ComboBox cboProvincias;
        private System.Windows.Forms.ComboBox cboCantones;
        private System.Windows.Forms.ComboBox cboDistritos;
        private System.Windows.Forms.ComboBox cboTiposIds;
        private System.Windows.Forms.BindingSource tipoIdBindingSource;
    }
}
