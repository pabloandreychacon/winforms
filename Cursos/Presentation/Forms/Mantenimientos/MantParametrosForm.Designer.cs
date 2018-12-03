namespace Cursos.Presentation.Forms.Mantenimientos
{
    partial class MantParametrosForm
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
			System.Windows.Forms.Label nombreLabel;
			System.Windows.Forms.Label direccionLabel;
			System.Windows.Forms.Label cedulaLabel;
			System.Windows.Forms.Label rutaLogoLabel;
			System.Windows.Forms.Label telefonoLabel;
			System.Windows.Forms.Label rutaSistemaLabel;
			System.Windows.Forms.Label portCorreoLabel;
			System.Windows.Forms.Label displayNameCorreoLabel;
			System.Windows.Forms.Label fromCorreoLabel;
			System.Windows.Forms.Label hostCorreoLabel;
			System.Windows.Forms.Label passwordCorreoLabel;
			System.Windows.Forms.Label timeOutCorreoLabel;
			System.Windows.Forms.Label userNameCorreoLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantParametrosForm));
			this.parametrosGeneralBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.parametrosGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.parametrosGeneralBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.nombreTextBox = new System.Windows.Forms.TextBox();
			this.direccionTextBox = new System.Windows.Forms.TextBox();
			this.cedulaTextBox = new System.Windows.Forms.TextBox();
			this.rutaLogoTextBox = new System.Windows.Forms.TextBox();
			this.telefonoTextBox = new System.Windows.Forms.TextBox();
			this.saveLogoBtn = new BaseControls.Derived.OkButton();
			this.logoPb = new System.Windows.Forms.PictureBox();
			this.rutaSistemaTextBox = new System.Windows.Forms.TextBox();
			this.saveRutaBtn = new BaseControls.Derived.OkButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.userNameCorreoTextBox = new System.Windows.Forms.TextBox();
			this.timeOutCorreoTextBox = new System.Windows.Forms.TextBox();
			this.passwordCorreoTextBox = new System.Windows.Forms.TextBox();
			this.hostCorreoTextBox = new System.Windows.Forms.TextBox();
			this.fromCorreoTextBox = new System.Windows.Forms.TextBox();
			this.displayNameCorreoTextBox = new System.Windows.Forms.TextBox();
			this.portCorreoTextBox = new System.Windows.Forms.TextBox();
			nombreLabel = new System.Windows.Forms.Label();
			direccionLabel = new System.Windows.Forms.Label();
			cedulaLabel = new System.Windows.Forms.Label();
			rutaLogoLabel = new System.Windows.Forms.Label();
			telefonoLabel = new System.Windows.Forms.Label();
			rutaSistemaLabel = new System.Windows.Forms.Label();
			portCorreoLabel = new System.Windows.Forms.Label();
			displayNameCorreoLabel = new System.Windows.Forms.Label();
			fromCorreoLabel = new System.Windows.Forms.Label();
			hostCorreoLabel = new System.Windows.Forms.Label();
			passwordCorreoLabel = new System.Windows.Forms.Label();
			timeOutCorreoLabel = new System.Windows.Forms.Label();
			userNameCorreoLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.parametrosGeneralBindingNavigator)).BeginInit();
			this.parametrosGeneralBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.parametrosGeneralBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// closeButton1
			// 
			this.closeButton1.Location = new System.Drawing.Point(765, 47);
			this.closeButton1.TabIndex = 10;
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(703, 47);
			this.btnFind.TabIndex = 9;
			// 
			// lblInfoMessage
			// 
			this.lblInfoMessage.Location = new System.Drawing.Point(53, 688);
			// 
			// nombreLabel
			// 
			nombreLabel.AutoSize = true;
			nombreLabel.Location = new System.Drawing.Point(49, 50);
			nombreLabel.Name = "nombreLabel";
			nombreLabel.Size = new System.Drawing.Size(84, 24);
			nombreLabel.TabIndex = 7;
			nombreLabel.Text = "Nombre:";
			// 
			// direccionLabel
			// 
			direccionLabel.AutoSize = true;
			direccionLabel.Location = new System.Drawing.Point(49, 88);
			direccionLabel.Name = "direccionLabel";
			direccionLabel.Size = new System.Drawing.Size(95, 24);
			direccionLabel.TabIndex = 8;
			direccionLabel.Text = "Dirección:";
			// 
			// cedulaLabel
			// 
			cedulaLabel.AutoSize = true;
			cedulaLabel.Location = new System.Drawing.Point(49, 216);
			cedulaLabel.Name = "cedulaLabel";
			cedulaLabel.Size = new System.Drawing.Size(75, 24);
			cedulaLabel.TabIndex = 12;
			cedulaLabel.Text = "Cédula:";
			// 
			// rutaLogoLabel
			// 
			rutaLogoLabel.AutoSize = true;
			rutaLogoLabel.Location = new System.Drawing.Point(49, 144);
			rutaLogoLabel.Name = "rutaLogoLabel";
			rutaLogoLabel.Size = new System.Drawing.Size(101, 24);
			rutaLogoLabel.TabIndex = 14;
			rutaLogoLabel.Text = "Ruta Logo:";
			// 
			// telefonoLabel
			// 
			telefonoLabel.AutoSize = true;
			telefonoLabel.Location = new System.Drawing.Point(49, 250);
			telefonoLabel.Name = "telefonoLabel";
			telefonoLabel.Size = new System.Drawing.Size(90, 24);
			telefonoLabel.TabIndex = 16;
			telefonoLabel.Text = "Teléfono:";
			// 
			// rutaSistemaLabel
			// 
			rutaSistemaLabel.AutoSize = true;
			rutaSistemaLabel.Location = new System.Drawing.Point(49, 279);
			rutaSistemaLabel.Name = "rutaSistemaLabel";
			rutaSistemaLabel.Size = new System.Drawing.Size(124, 24);
			rutaSistemaLabel.TabIndex = 20;
			rutaSistemaLabel.Text = "Ruta Sistema:";
			// 
			// portCorreoLabel
			// 
			portCorreoLabel.AutoSize = true;
			portCorreoLabel.Location = new System.Drawing.Point(16, 54);
			portCorreoLabel.Name = "portCorreoLabel";
			portCorreoLabel.Size = new System.Drawing.Size(111, 24);
			portCorreoLabel.TabIndex = 0;
			portCorreoLabel.Text = "Port Correo:";
			portCorreoLabel.Click += new System.EventHandler(this.portCorreoLabel_Click);
			// 
			// displayNameCorreoLabel
			// 
			displayNameCorreoLabel.AutoSize = true;
			displayNameCorreoLabel.Location = new System.Drawing.Point(16, 160);
			displayNameCorreoLabel.Name = "displayNameCorreoLabel";
			displayNameCorreoLabel.Size = new System.Drawing.Size(194, 24);
			displayNameCorreoLabel.TabIndex = 2;
			displayNameCorreoLabel.Text = "Display Name Correo:";
			// 
			// fromCorreoLabel
			// 
			fromCorreoLabel.AutoSize = true;
			fromCorreoLabel.Location = new System.Drawing.Point(16, 123);
			fromCorreoLabel.Name = "fromCorreoLabel";
			fromCorreoLabel.Size = new System.Drawing.Size(123, 24);
			fromCorreoLabel.TabIndex = 4;
			fromCorreoLabel.Text = "From Correo:";
			// 
			// hostCorreoLabel
			// 
			hostCorreoLabel.AutoSize = true;
			hostCorreoLabel.Location = new System.Drawing.Point(16, 195);
			hostCorreoLabel.Name = "hostCorreoLabel";
			hostCorreoLabel.Size = new System.Drawing.Size(116, 24);
			hostCorreoLabel.TabIndex = 6;
			hostCorreoLabel.Text = "Host Correo:";
			// 
			// passwordCorreoLabel
			// 
			passwordCorreoLabel.AutoSize = true;
			passwordCorreoLabel.Location = new System.Drawing.Point(16, 262);
			passwordCorreoLabel.Name = "passwordCorreoLabel";
			passwordCorreoLabel.Size = new System.Drawing.Size(160, 24);
			passwordCorreoLabel.TabIndex = 8;
			passwordCorreoLabel.Text = "Password Correo:";
			// 
			// timeOutCorreoLabel
			// 
			timeOutCorreoLabel.AutoSize = true;
			timeOutCorreoLabel.Location = new System.Drawing.Point(16, 88);
			timeOutCorreoLabel.Name = "timeOutCorreoLabel";
			timeOutCorreoLabel.Size = new System.Drawing.Size(156, 24);
			timeOutCorreoLabel.TabIndex = 12;
			timeOutCorreoLabel.Text = "Time Out Correo:";
			// 
			// userNameCorreoLabel
			// 
			userNameCorreoLabel.AutoSize = true;
			userNameCorreoLabel.Location = new System.Drawing.Point(16, 228);
			userNameCorreoLabel.Name = "userNameCorreoLabel";
			userNameCorreoLabel.Size = new System.Drawing.Size(173, 24);
			userNameCorreoLabel.TabIndex = 14;
			userNameCorreoLabel.Text = "User Name Correo:";
			// 
			// parametrosGeneralBindingNavigator
			// 
			this.parametrosGeneralBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.parametrosGeneralBindingNavigator.BindingSource = this.parametrosGeneralBindingSource;
			this.parametrosGeneralBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.parametrosGeneralBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.parametrosGeneralBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.parametrosGeneralBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.parametrosGeneralBindingNavigatorSaveItem});
			this.parametrosGeneralBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.parametrosGeneralBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.parametrosGeneralBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.parametrosGeneralBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.parametrosGeneralBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.parametrosGeneralBindingNavigator.Name = "parametrosGeneralBindingNavigator";
			this.parametrosGeneralBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.parametrosGeneralBindingNavigator.Size = new System.Drawing.Size(855, 27);
			this.parametrosGeneralBindingNavigator.TabIndex = 11;
			this.parametrosGeneralBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Enabled = false;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// parametrosGeneralBindingSource
			// 
			this.parametrosGeneralBindingSource.DataSource = typeof(CursosEntities.Entities.Parametro);
			this.parametrosGeneralBindingSource.PositionChanged += new System.EventHandler(this.parametrosGeneralBindingSource_PositionChanged);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Enabled = false;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorDeleteItem.Text = "Delete";
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
			// parametrosGeneralBindingNavigatorSaveItem
			// 
			this.parametrosGeneralBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.parametrosGeneralBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("parametrosGeneralBindingNavigatorSaveItem.Image")));
			this.parametrosGeneralBindingNavigatorSaveItem.Name = "parametrosGeneralBindingNavigatorSaveItem";
			this.parametrosGeneralBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.parametrosGeneralBindingNavigatorSaveItem.Text = "Save Data";
			this.parametrosGeneralBindingNavigatorSaveItem.Click += new System.EventHandler(this.parametrosGeneralBindingNavigatorSaveItem_Click);
			// 
			// nombreTextBox
			// 
			this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "Nombre", true));
			this.nombreTextBox.Location = new System.Drawing.Point(201, 47);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(453, 28);
			this.nombreTextBox.TabIndex = 0;
			// 
			// direccionTextBox
			// 
			this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "Direccion", true));
			this.direccionTextBox.Location = new System.Drawing.Point(201, 81);
			this.direccionTextBox.Multiline = true;
			this.direccionTextBox.Name = "direccionTextBox";
			this.direccionTextBox.Size = new System.Drawing.Size(453, 54);
			this.direccionTextBox.TabIndex = 1;
			// 
			// cedulaTextBox
			// 
			this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "Cedula", true));
			this.cedulaTextBox.Location = new System.Drawing.Point(201, 212);
			this.cedulaTextBox.Name = "cedulaTextBox";
			this.cedulaTextBox.Size = new System.Drawing.Size(235, 28);
			this.cedulaTextBox.TabIndex = 4;
			// 
			// rutaLogoTextBox
			// 
			this.rutaLogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "RutaLogo", true));
			this.rutaLogoTextBox.Enabled = false;
			this.rutaLogoTextBox.Location = new System.Drawing.Point(201, 140);
			this.rutaLogoTextBox.Multiline = true;
			this.rutaLogoTextBox.Name = "rutaLogoTextBox";
			this.rutaLogoTextBox.ReadOnly = true;
			this.rutaLogoTextBox.Size = new System.Drawing.Size(452, 66);
			this.rutaLogoTextBox.TabIndex = 2;
			// 
			// telefonoTextBox
			// 
			this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "Telefono", true));
			this.telefonoTextBox.Location = new System.Drawing.Point(201, 246);
			this.telefonoTextBox.Name = "telefonoTextBox";
			this.telefonoTextBox.Size = new System.Drawing.Size(235, 28);
			this.telefonoTextBox.TabIndex = 5;
			// 
			// saveLogoBtn
			// 
			this.saveLogoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveLogoBtn.BackgroundImage")));
			this.saveLogoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.saveLogoBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveLogoBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveLogoBtn.Image")));
			this.saveLogoBtn.Location = new System.Drawing.Point(685, 246);
			this.saveLogoBtn.Name = "saveLogoBtn";
			this.saveLogoBtn.Size = new System.Drawing.Size(125, 43);
			this.saveLogoBtn.TabIndex = 3;
			this.saveLogoBtn.UseVisualStyleBackColor = true;
			this.saveLogoBtn.Click += new System.EventHandler(this.saveLogoBtn_Click);
			// 
			// logoPb
			// 
			this.logoPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.logoPb.Location = new System.Drawing.Point(685, 123);
			this.logoPb.Name = "logoPb";
			this.logoPb.Size = new System.Drawing.Size(126, 130);
			this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPb.TabIndex = 19;
			this.logoPb.TabStop = false;
			// 
			// rutaSistemaTextBox
			// 
			this.rutaSistemaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "RutaSistema", true));
			this.rutaSistemaTextBox.Enabled = false;
			this.rutaSistemaTextBox.Location = new System.Drawing.Point(201, 279);
			this.rutaSistemaTextBox.Multiline = true;
			this.rutaSistemaTextBox.Name = "rutaSistemaTextBox";
			this.rutaSistemaTextBox.ReadOnly = true;
			this.rutaSistemaTextBox.Size = new System.Drawing.Size(394, 66);
			this.rutaSistemaTextBox.TabIndex = 6;
			// 
			// saveRutaBtn
			// 
			this.saveRutaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveRutaBtn.BackgroundImage")));
			this.saveRutaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.saveRutaBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveRutaBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveRutaBtn.Image")));
			this.saveRutaBtn.Location = new System.Drawing.Point(601, 279);
			this.saveRutaBtn.Name = "saveRutaBtn";
			this.saveRutaBtn.Size = new System.Drawing.Size(46, 28);
			this.saveRutaBtn.TabIndex = 7;
			this.saveRutaBtn.UseVisualStyleBackColor = true;
			this.saveRutaBtn.Click += new System.EventHandler(this.saveRutaBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(userNameCorreoLabel);
			this.groupBox1.Controls.Add(this.userNameCorreoTextBox);
			this.groupBox1.Controls.Add(timeOutCorreoLabel);
			this.groupBox1.Controls.Add(this.timeOutCorreoTextBox);
			this.groupBox1.Controls.Add(passwordCorreoLabel);
			this.groupBox1.Controls.Add(this.passwordCorreoTextBox);
			this.groupBox1.Controls.Add(hostCorreoLabel);
			this.groupBox1.Controls.Add(this.hostCorreoTextBox);
			this.groupBox1.Controls.Add(fromCorreoLabel);
			this.groupBox1.Controls.Add(this.fromCorreoTextBox);
			this.groupBox1.Controls.Add(displayNameCorreoLabel);
			this.groupBox1.Controls.Add(this.displayNameCorreoTextBox);
			this.groupBox1.Controls.Add(portCorreoLabel);
			this.groupBox1.Controls.Add(this.portCorreoTextBox);
			this.groupBox1.Location = new System.Drawing.Point(53, 351);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(757, 297);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Correo";
			// 
			// userNameCorreoTextBox
			// 
			this.userNameCorreoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "UserNameCorreo", true));
			this.userNameCorreoTextBox.Location = new System.Drawing.Point(233, 225);
			this.userNameCorreoTextBox.Name = "userNameCorreoTextBox";
			this.userNameCorreoTextBox.Size = new System.Drawing.Size(361, 28);
			this.userNameCorreoTextBox.TabIndex = 5;
			// 
			// timeOutCorreoTextBox
			// 
			this.timeOutCorreoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "TimeOutCorreo", true));
			this.timeOutCorreoTextBox.Location = new System.Drawing.Point(233, 88);
			this.timeOutCorreoTextBox.Name = "timeOutCorreoTextBox";
			this.timeOutCorreoTextBox.Size = new System.Drawing.Size(100, 28);
			this.timeOutCorreoTextBox.TabIndex = 1;
			// 
			// passwordCorreoTextBox
			// 
			this.passwordCorreoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "PasswordCorreo", true));
			this.passwordCorreoTextBox.Location = new System.Drawing.Point(233, 259);
			this.passwordCorreoTextBox.Name = "passwordCorreoTextBox";
			this.passwordCorreoTextBox.PasswordChar = '*';
			this.passwordCorreoTextBox.Size = new System.Drawing.Size(361, 28);
			this.passwordCorreoTextBox.TabIndex = 6;
			this.passwordCorreoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordCorreoTextBox_KeyPress);
			// 
			// hostCorreoTextBox
			// 
			this.hostCorreoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "HostCorreo", true));
			this.hostCorreoTextBox.Location = new System.Drawing.Point(233, 192);
			this.hostCorreoTextBox.Name = "hostCorreoTextBox";
			this.hostCorreoTextBox.Size = new System.Drawing.Size(361, 28);
			this.hostCorreoTextBox.TabIndex = 4;
			// 
			// fromCorreoTextBox
			// 
			this.fromCorreoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "FromCorreo", true));
			this.fromCorreoTextBox.Location = new System.Drawing.Point(233, 123);
			this.fromCorreoTextBox.Name = "fromCorreoTextBox";
			this.fromCorreoTextBox.Size = new System.Drawing.Size(361, 28);
			this.fromCorreoTextBox.TabIndex = 2;
			// 
			// displayNameCorreoTextBox
			// 
			this.displayNameCorreoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "DisplayNameCorreo", true));
			this.displayNameCorreoTextBox.Location = new System.Drawing.Point(233, 157);
			this.displayNameCorreoTextBox.Name = "displayNameCorreoTextBox";
			this.displayNameCorreoTextBox.Size = new System.Drawing.Size(361, 28);
			this.displayNameCorreoTextBox.TabIndex = 3;
			// 
			// portCorreoTextBox
			// 
			this.portCorreoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parametrosGeneralBindingSource, "PortCorreo", true));
			this.portCorreoTextBox.Location = new System.Drawing.Point(233, 54);
			this.portCorreoTextBox.Name = "portCorreoTextBox";
			this.portCorreoTextBox.Size = new System.Drawing.Size(100, 28);
			this.portCorreoTextBox.TabIndex = 0;
			// 
			// MantParametrosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.ClientSize = new System.Drawing.Size(855, 772);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.saveRutaBtn);
			this.Controls.Add(rutaSistemaLabel);
			this.Controls.Add(this.rutaSistemaTextBox);
			this.Controls.Add(this.logoPb);
			this.Controls.Add(this.saveLogoBtn);
			this.Controls.Add(telefonoLabel);
			this.Controls.Add(this.telefonoTextBox);
			this.Controls.Add(rutaLogoLabel);
			this.Controls.Add(this.rutaLogoTextBox);
			this.Controls.Add(cedulaLabel);
			this.Controls.Add(this.cedulaTextBox);
			this.Controls.Add(direccionLabel);
			this.Controls.Add(this.direccionTextBox);
			this.Controls.Add(nombreLabel);
			this.Controls.Add(this.nombreTextBox);
			this.Controls.Add(this.parametrosGeneralBindingNavigator);
			this.Name = "MantParametrosForm";
			this.Text = "Parámetros";
			this.Load += new System.EventHandler(this.ParametrosForm_Load);
			this.Controls.SetChildIndex(this.lblInfoMessage, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnFind, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.parametrosGeneralBindingNavigator, 0);
			this.Controls.SetChildIndex(this.nombreTextBox, 0);
			this.Controls.SetChildIndex(nombreLabel, 0);
			this.Controls.SetChildIndex(this.direccionTextBox, 0);
			this.Controls.SetChildIndex(direccionLabel, 0);
			this.Controls.SetChildIndex(this.cedulaTextBox, 0);
			this.Controls.SetChildIndex(cedulaLabel, 0);
			this.Controls.SetChildIndex(this.rutaLogoTextBox, 0);
			this.Controls.SetChildIndex(rutaLogoLabel, 0);
			this.Controls.SetChildIndex(this.telefonoTextBox, 0);
			this.Controls.SetChildIndex(telefonoLabel, 0);
			this.Controls.SetChildIndex(this.saveLogoBtn, 0);
			this.Controls.SetChildIndex(this.logoPb, 0);
			this.Controls.SetChildIndex(this.rutaSistemaTextBox, 0);
			this.Controls.SetChildIndex(rutaSistemaLabel, 0);
			this.Controls.SetChildIndex(this.saveRutaBtn, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			((System.ComponentModel.ISupportInitialize)(this.parametrosGeneralBindingNavigator)).EndInit();
			this.parametrosGeneralBindingNavigator.ResumeLayout(false);
			this.parametrosGeneralBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.parametrosGeneralBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource parametrosGeneralBindingSource;
        private System.Windows.Forms.BindingNavigator parametrosGeneralBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton parametrosGeneralBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox rutaLogoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private BaseControls.Derived.OkButton saveLogoBtn;
        private System.Windows.Forms.PictureBox logoPb;
        private System.Windows.Forms.TextBox rutaSistemaTextBox;
        private BaseControls.Derived.OkButton saveRutaBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userNameCorreoTextBox;
        private System.Windows.Forms.TextBox timeOutCorreoTextBox;
        private System.Windows.Forms.TextBox passwordCorreoTextBox;
        private System.Windows.Forms.TextBox hostCorreoTextBox;
        private System.Windows.Forms.TextBox fromCorreoTextBox;
        private System.Windows.Forms.TextBox displayNameCorreoTextBox;
        private System.Windows.Forms.TextBox portCorreoTextBox;
    }
}
