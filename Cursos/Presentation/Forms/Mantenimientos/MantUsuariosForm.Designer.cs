namespace Cursos.Presentation.Forms.Mantenimientos
{
    partial class MantUsuariosForm
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
			System.Windows.Forms.Label administradorLabel;
			System.Windows.Forms.Label claveLabel;
			System.Windows.Forms.Label consultasLabel;
			System.Windows.Forms.Label idUsuarioLabel;
			System.Windows.Forms.Label mantenimientosLabel;
			System.Windows.Forms.Label nombreLabel;
			System.Windows.Forms.Label procesosLabel;
			System.Windows.Forms.Label seguridadLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantUsuariosForm));
			this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.usuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.activoCheckBox = new System.Windows.Forms.CheckBox();
			this.claveTextBox = new System.Windows.Forms.TextBox();
			this.consultasCheckBox = new System.Windows.Forms.CheckBox();
			this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
			this.mantenimientosCheckBox = new System.Windows.Forms.CheckBox();
			this.nombreTextBox = new System.Windows.Forms.TextBox();
			this.procesosCheckBox = new System.Windows.Forms.CheckBox();
			this.seguridadCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboFiltros = new BaseControls.Derived.ComboBasic();
			this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.comboBasic1 = new BaseControls.Derived.ComboBasic();
			this.comboBasic2 = new BaseControls.Derived.ComboBasic();
			activoLabel = new System.Windows.Forms.Label();
			administradorLabel = new System.Windows.Forms.Label();
			claveLabel = new System.Windows.Forms.Label();
			consultasLabel = new System.Windows.Forms.Label();
			idUsuarioLabel = new System.Windows.Forms.Label();
			mantenimientosLabel = new System.Windows.Forms.Label();
			nombreLabel = new System.Windows.Forms.Label();
			procesosLabel = new System.Windows.Forms.Label();
			seguridadLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
			this.usuarioBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// closeButton1
			// 
			this.closeButton1.Location = new System.Drawing.Point(614, 47);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(552, 47);
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// activoLabel
			// 
			activoLabel.AutoSize = true;
			activoLabel.Location = new System.Drawing.Point(57, 149);
			activoLabel.Name = "activoLabel";
			activoLabel.Size = new System.Drawing.Size(66, 24);
			activoLabel.TabIndex = 4;
			activoLabel.Text = "Activo:";
			// 
			// administradorLabel
			// 
			administradorLabel.AutoSize = true;
			administradorLabel.Location = new System.Drawing.Point(57, 184);
			administradorLabel.Name = "administradorLabel";
			administradorLabel.Size = new System.Drawing.Size(43, 24);
			administradorLabel.TabIndex = 6;
			administradorLabel.Text = "Rol:";
			// 
			// claveLabel
			// 
			claveLabel.AutoSize = true;
			claveLabel.Location = new System.Drawing.Point(58, 113);
			claveLabel.Name = "claveLabel";
			claveLabel.Size = new System.Drawing.Size(62, 24);
			claveLabel.TabIndex = 8;
			claveLabel.Text = "Clave:";
			// 
			// consultasLabel
			// 
			consultasLabel.AutoSize = true;
			consultasLabel.Location = new System.Drawing.Point(26, 32);
			consultasLabel.Name = "consultasLabel";
			consultasLabel.Size = new System.Drawing.Size(97, 24);
			consultasLabel.TabIndex = 10;
			consultasLabel.Text = "Consultas:";
			// 
			// idUsuarioLabel
			// 
			idUsuarioLabel.AutoSize = true;
			idUsuarioLabel.Enabled = false;
			idUsuarioLabel.Location = new System.Drawing.Point(58, 44);
			idUsuarioLabel.Name = "idUsuarioLabel";
			idUsuarioLabel.Size = new System.Drawing.Size(99, 24);
			idUsuarioLabel.TabIndex = 12;
			idUsuarioLabel.Text = "Id Usuario:";
			// 
			// mantenimientosLabel
			// 
			mantenimientosLabel.AutoSize = true;
			mantenimientosLabel.Location = new System.Drawing.Point(26, 60);
			mantenimientosLabel.Name = "mantenimientosLabel";
			mantenimientosLabel.Size = new System.Drawing.Size(148, 24);
			mantenimientosLabel.TabIndex = 14;
			mantenimientosLabel.Text = "Mantenimientos:";
			// 
			// nombreLabel
			// 
			nombreLabel.AutoSize = true;
			nombreLabel.Location = new System.Drawing.Point(57, 78);
			nombreLabel.Name = "nombreLabel";
			nombreLabel.Size = new System.Drawing.Size(84, 24);
			nombreLabel.TabIndex = 16;
			nombreLabel.Text = "Nombre:";
			// 
			// procesosLabel
			// 
			procesosLabel.AutoSize = true;
			procesosLabel.Location = new System.Drawing.Point(26, 88);
			procesosLabel.Name = "procesosLabel";
			procesosLabel.Size = new System.Drawing.Size(94, 24);
			procesosLabel.TabIndex = 20;
			procesosLabel.Text = "Procesos:";
			// 
			// seguridadLabel
			// 
			seguridadLabel.AutoSize = true;
			seguridadLabel.Location = new System.Drawing.Point(26, 116);
			seguridadLabel.Name = "seguridadLabel";
			seguridadLabel.Size = new System.Drawing.Size(102, 24);
			seguridadLabel.TabIndex = 21;
			seguridadLabel.Text = "Seguridad:";
			// 
			// usuarioBindingNavigator
			// 
			this.usuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
			this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.usuarioBindingNavigator.DeleteItem = null;
			this.usuarioBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuarioBindingNavigatorSaveItem});
			this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
			this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.usuarioBindingNavigator.Size = new System.Drawing.Size(679, 27);
			this.usuarioBindingNavigator.TabIndex = 3;
			this.usuarioBindingNavigator.Text = "bindingNavigator1";
			this.usuarioBindingNavigator.RefreshItems += new System.EventHandler(this.usuarioBindingNavigator_RefreshItems);
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
			// usuarioBindingSource
			// 
			this.usuarioBindingSource.DataSource = typeof(CursosEntities.Entities.Usuario);
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
			// usuarioBindingNavigatorSaveItem
			// 
			this.usuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.usuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingNavigatorSaveItem.Image")));
			this.usuarioBindingNavigatorSaveItem.Name = "usuarioBindingNavigatorSaveItem";
			this.usuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.usuarioBindingNavigatorSaveItem.Text = "Save Data";
			this.usuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingNavigatorSaveItem_Click);
			// 
			// activoCheckBox
			// 
			this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Activo", true));
			this.activoCheckBox.Location = new System.Drawing.Point(211, 144);
			this.activoCheckBox.Name = "activoCheckBox";
			this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
			this.activoCheckBox.TabIndex = 5;
			this.activoCheckBox.UseVisualStyleBackColor = true;
			// 
			// claveTextBox
			// 
			this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Clave", true));
			this.claveTextBox.Location = new System.Drawing.Point(212, 110);
			this.claveTextBox.Name = "claveTextBox";
			this.claveTextBox.PasswordChar = '*';
			this.claveTextBox.Size = new System.Drawing.Size(194, 28);
			this.claveTextBox.TabIndex = 9;
			this.claveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.claveTextBox_KeyPress);
			// 
			// consultasCheckBox
			// 
			this.consultasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Consultas", true));
			this.consultasCheckBox.Location = new System.Drawing.Point(179, 27);
			this.consultasCheckBox.Name = "consultasCheckBox";
			this.consultasCheckBox.Size = new System.Drawing.Size(104, 24);
			this.consultasCheckBox.TabIndex = 11;
			this.consultasCheckBox.UseVisualStyleBackColor = true;
			// 
			// idUsuarioTextBox
			// 
			this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "IdUsuario", true));
			this.idUsuarioTextBox.Enabled = false;
			this.idUsuarioTextBox.Location = new System.Drawing.Point(212, 41);
			this.idUsuarioTextBox.Name = "idUsuarioTextBox";
			this.idUsuarioTextBox.ReadOnly = true;
			this.idUsuarioTextBox.Size = new System.Drawing.Size(104, 28);
			this.idUsuarioTextBox.TabIndex = 13;
			// 
			// mantenimientosCheckBox
			// 
			this.mantenimientosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Mantenimientos", true));
			this.mantenimientosCheckBox.Location = new System.Drawing.Point(179, 57);
			this.mantenimientosCheckBox.Name = "mantenimientosCheckBox";
			this.mantenimientosCheckBox.Size = new System.Drawing.Size(104, 24);
			this.mantenimientosCheckBox.TabIndex = 15;
			this.mantenimientosCheckBox.UseVisualStyleBackColor = true;
			// 
			// nombreTextBox
			// 
			this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
			this.nombreTextBox.Location = new System.Drawing.Point(211, 75);
			this.nombreTextBox.Name = "nombreTextBox";
			this.nombreTextBox.Size = new System.Drawing.Size(315, 28);
			this.nombreTextBox.TabIndex = 17;
			// 
			// procesosCheckBox
			// 
			this.procesosCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Procesos", true));
			this.procesosCheckBox.Location = new System.Drawing.Point(179, 87);
			this.procesosCheckBox.Name = "procesosCheckBox";
			this.procesosCheckBox.Size = new System.Drawing.Size(104, 24);
			this.procesosCheckBox.TabIndex = 21;
			this.procesosCheckBox.UseVisualStyleBackColor = true;
			// 
			// seguridadCheckBox
			// 
			this.seguridadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Seguridad", true));
			this.seguridadCheckBox.Location = new System.Drawing.Point(179, 117);
			this.seguridadCheckBox.Name = "seguridadCheckBox";
			this.seguridadCheckBox.Size = new System.Drawing.Size(104, 24);
			this.seguridadCheckBox.TabIndex = 22;
			this.seguridadCheckBox.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(seguridadLabel);
			this.groupBox1.Controls.Add(this.procesosCheckBox);
			this.groupBox1.Controls.Add(this.seguridadCheckBox);
			this.groupBox1.Controls.Add(procesosLabel);
			this.groupBox1.Controls.Add(this.mantenimientosCheckBox);
			this.groupBox1.Controls.Add(mantenimientosLabel);
			this.groupBox1.Controls.Add(this.consultasCheckBox);
			this.groupBox1.Controls.Add(consultasLabel);
			this.groupBox1.Location = new System.Drawing.Point(62, 248);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(321, 154);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Menu";
			// 
			// cboFiltros
			// 
			this.cboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFiltros.FormattingEnabled = true;
			this.cboFiltros.Location = new System.Drawing.Point(212, 178);
			this.cboFiltros.Name = "cboFiltros";
			this.cboFiltros.Size = new System.Drawing.Size(177, 30);
			this.cboFiltros.TabIndex = 24;
			// 
			// roleBindingSource
			// 
			this.roleBindingSource.DataSource = typeof(CursosEntities.Entities.Role);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(363, 217);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 24);
			this.label1.TabIndex = 26;
			this.label1.Text = "Rol Visual:";
			// 
			// comboBasic1
			// 
			this.comboBasic1.DataSource = this.roleBindingSource;
			this.comboBasic1.DisplayMember = "Descripcion";
			this.comboBasic1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBasic1.FormattingEnabled = true;
			this.comboBasic1.Location = new System.Drawing.Point(490, 211);
			this.comboBasic1.Name = "comboBasic1";
			this.comboBasic1.Size = new System.Drawing.Size(177, 30);
			this.comboBasic1.TabIndex = 27;
			this.comboBasic1.ValueMember = "IdRole";
			// 
			// comboBasic2
			// 
			this.comboBasic2.DataSource = this.roleBindingSource;
			this.comboBasic2.DisplayMember = "Descripcion";
			this.comboBasic2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBasic2.FormattingEnabled = true;
			this.comboBasic2.Location = new System.Drawing.Point(492, 339);
			this.comboBasic2.Name = "comboBasic2";
			this.comboBasic2.Size = new System.Drawing.Size(121, 30);
			this.comboBasic2.TabIndex = 28;
			// 
			// MantUsuariosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 454);
			this.Controls.Add(this.comboBasic2);
			this.Controls.Add(this.comboBasic1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboFiltros);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(activoLabel);
			this.Controls.Add(this.activoCheckBox);
			this.Controls.Add(administradorLabel);
			this.Controls.Add(claveLabel);
			this.Controls.Add(this.claveTextBox);
			this.Controls.Add(idUsuarioLabel);
			this.Controls.Add(this.idUsuarioTextBox);
			this.Controls.Add(nombreLabel);
			this.Controls.Add(this.nombreTextBox);
			this.Controls.Add(this.usuarioBindingNavigator);
			this.Name = "MantUsuariosForm";
			this.Text = "Usuarios";
			this.Load += new System.EventHandler(this.UsuariosForm_Load);
			this.Controls.SetChildIndex(this.usuarioBindingNavigator, 0);
			this.Controls.SetChildIndex(this.nombreTextBox, 0);
			this.Controls.SetChildIndex(nombreLabel, 0);
			this.Controls.SetChildIndex(this.idUsuarioTextBox, 0);
			this.Controls.SetChildIndex(idUsuarioLabel, 0);
			this.Controls.SetChildIndex(this.claveTextBox, 0);
			this.Controls.SetChildIndex(claveLabel, 0);
			this.Controls.SetChildIndex(administradorLabel, 0);
			this.Controls.SetChildIndex(this.activoCheckBox, 0);
			this.Controls.SetChildIndex(activoLabel, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnFind, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.cboFiltros, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.comboBasic1, 0);
			this.Controls.SetChildIndex(this.comboBasic2, 0);
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
			this.usuarioBindingNavigator.ResumeLayout(false);
			this.usuarioBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.CheckBox consultasCheckBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.CheckBox mantenimientosCheckBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.CheckBox procesosCheckBox;
        private System.Windows.Forms.CheckBox seguridadCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
		private BaseControls.Derived.ComboBasic cboFiltros;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource roleBindingSource;
		private BaseControls.Derived.ComboBasic comboBasic1;
		private BaseControls.Derived.ComboBasic comboBasic2;
	}
}