namespace Cursos.Presentation.Forms.Mantenimientos
{
	partial class MantAulasForm
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
			System.Windows.Forms.Label accesibilidadLabel;
			System.Windows.Forms.Label codigoLabel;
			System.Windows.Forms.Label descripcionLabel;
			System.Windows.Forms.Label disponibleLabel;
			System.Windows.Forms.Label idAulaLabel;
			System.Windows.Forms.Label ubicacionLabel;
			System.Windows.Forms.Label capacidadLabel1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantAulasForm));
			this.aulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.aulaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
			this.aulaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.accesibilidadCheckBox = new System.Windows.Forms.CheckBox();
			this.codigoTextBox = new System.Windows.Forms.TextBox();
			this.descripcionTextBox = new System.Windows.Forms.TextBox();
			this.disponibleCheckBox = new System.Windows.Forms.CheckBox();
			this.idAulaTextBox = new System.Windows.Forms.TextBox();
			this.ubicacionTextBox = new System.Windows.Forms.TextBox();
			this.capacidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
			accesibilidadLabel = new System.Windows.Forms.Label();
			codigoLabel = new System.Windows.Forms.Label();
			descripcionLabel = new System.Windows.Forms.Label();
			disponibleLabel = new System.Windows.Forms.Label();
			idAulaLabel = new System.Windows.Forms.Label();
			ubicacionLabel = new System.Windows.Forms.Label();
			capacidadLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.aulaBindingNavigator)).BeginInit();
			this.aulaBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.capacidadNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// closeButton1
			// 
			this.closeButton1.Location = new System.Drawing.Point(717, 47);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(655, 47);
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// lblInfoMessage
			// 
			this.lblInfoMessage.Location = new System.Drawing.Point(25, 398);
			// 
			// accesibilidadLabel
			// 
			accesibilidadLabel.AutoSize = true;
			accesibilidadLabel.Location = new System.Drawing.Point(41, 79);
			accesibilidadLabel.Name = "accesibilidadLabel";
			accesibilidadLabel.Size = new System.Drawing.Size(127, 24);
			accesibilidadLabel.TabIndex = 5;
			accesibilidadLabel.Text = "Accesibilidad:";
			// 
			// codigoLabel
			// 
			codigoLabel.AutoSize = true;
			codigoLabel.Location = new System.Drawing.Point(41, 146);
			codigoLabel.Name = "codigoLabel";
			codigoLabel.Size = new System.Drawing.Size(76, 24);
			codigoLabel.TabIndex = 9;
			codigoLabel.Text = "Codigo:";
			// 
			// descripcionLabel
			// 
			descripcionLabel.AutoSize = true;
			descripcionLabel.Location = new System.Drawing.Point(41, 180);
			descripcionLabel.Name = "descripcionLabel";
			descripcionLabel.Size = new System.Drawing.Size(115, 24);
			descripcionLabel.TabIndex = 11;
			descripcionLabel.Text = "Descripcion:";
			// 
			// disponibleLabel
			// 
			disponibleLabel.AutoSize = true;
			disponibleLabel.Location = new System.Drawing.Point(41, 255);
			disponibleLabel.Name = "disponibleLabel";
			disponibleLabel.Size = new System.Drawing.Size(104, 24);
			disponibleLabel.TabIndex = 13;
			disponibleLabel.Text = "Disponible:";
			// 
			// idAulaLabel
			// 
			idAulaLabel.AutoSize = true;
			idAulaLabel.Location = new System.Drawing.Point(41, 43);
			idAulaLabel.Name = "idAulaLabel";
			idAulaLabel.Size = new System.Drawing.Size(73, 24);
			idAulaLabel.TabIndex = 15;
			idAulaLabel.Text = "Id Aula:";
			// 
			// ubicacionLabel
			// 
			ubicacionLabel.AutoSize = true;
			ubicacionLabel.Location = new System.Drawing.Point(41, 283);
			ubicacionLabel.Name = "ubicacionLabel";
			ubicacionLabel.Size = new System.Drawing.Size(99, 24);
			ubicacionLabel.TabIndex = 17;
			ubicacionLabel.Text = "Ubicacion:";
			// 
			// capacidadLabel1
			// 
			capacidadLabel1.AutoSize = true;
			capacidadLabel1.Location = new System.Drawing.Point(40, 109);
			capacidadLabel1.Name = "capacidadLabel1";
			capacidadLabel1.Size = new System.Drawing.Size(105, 24);
			capacidadLabel1.TabIndex = 19;
			capacidadLabel1.Text = "Capacidad:";
			// 
			// aulaBindingSource
			// 
			this.aulaBindingSource.DataSource = typeof(CursosEntities.Entities.Aula);
			// 
			// aulaBindingNavigator
			// 
			this.aulaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.aulaBindingNavigator.BindingSource = this.aulaBindingSource;
			this.aulaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.aulaBindingNavigator.DeleteItem = null;
			this.aulaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.aulaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aulaBindingNavigatorSaveItem});
			this.aulaBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.aulaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.aulaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.aulaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.aulaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.aulaBindingNavigator.Name = "aulaBindingNavigator";
			this.aulaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.aulaBindingNavigator.Size = new System.Drawing.Size(800, 27);
			this.aulaBindingNavigator.TabIndex = 3;
			this.aulaBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
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
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
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
			// aulaBindingNavigatorSaveItem
			// 
			this.aulaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aulaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aulaBindingNavigatorSaveItem.Image")));
			this.aulaBindingNavigatorSaveItem.Name = "aulaBindingNavigatorSaveItem";
			this.aulaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.aulaBindingNavigatorSaveItem.Text = "Save Data";
			this.aulaBindingNavigatorSaveItem.Click += new System.EventHandler(this.aulaBindingNavigatorSaveItem_Click);
			// 
			// accesibilidadCheckBox
			// 
			this.accesibilidadCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.aulaBindingSource, "Accesibilidad", true));
			this.accesibilidadCheckBox.Location = new System.Drawing.Point(174, 74);
			this.accesibilidadCheckBox.Name = "accesibilidadCheckBox";
			this.accesibilidadCheckBox.Size = new System.Drawing.Size(104, 24);
			this.accesibilidadCheckBox.TabIndex = 6;
			this.accesibilidadCheckBox.UseVisualStyleBackColor = true;
			// 
			// codigoTextBox
			// 
			this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "Codigo", true));
			this.codigoTextBox.Location = new System.Drawing.Point(174, 143);
			this.codigoTextBox.Name = "codigoTextBox";
			this.codigoTextBox.Size = new System.Drawing.Size(104, 28);
			this.codigoTextBox.TabIndex = 10;
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "Descripcion", true));
			this.descripcionTextBox.Location = new System.Drawing.Point(174, 177);
			this.descripcionTextBox.Multiline = true;
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(240, 74);
			this.descripcionTextBox.TabIndex = 12;
			// 
			// disponibleCheckBox
			// 
			this.disponibleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.aulaBindingSource, "Disponible", true));
			this.disponibleCheckBox.Location = new System.Drawing.Point(174, 250);
			this.disponibleCheckBox.Name = "disponibleCheckBox";
			this.disponibleCheckBox.Size = new System.Drawing.Size(104, 24);
			this.disponibleCheckBox.TabIndex = 14;
			this.disponibleCheckBox.UseVisualStyleBackColor = true;
			// 
			// idAulaTextBox
			// 
			this.idAulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "IdAula", true));
			this.idAulaTextBox.Location = new System.Drawing.Point(174, 40);
			this.idAulaTextBox.Name = "idAulaTextBox";
			this.idAulaTextBox.ReadOnly = true;
			this.idAulaTextBox.Size = new System.Drawing.Size(104, 28);
			this.idAulaTextBox.TabIndex = 16;
			// 
			// ubicacionTextBox
			// 
			this.ubicacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aulaBindingSource, "Ubicacion", true));
			this.ubicacionTextBox.Location = new System.Drawing.Point(174, 280);
			this.ubicacionTextBox.Multiline = true;
			this.ubicacionTextBox.Name = "ubicacionTextBox";
			this.ubicacionTextBox.Size = new System.Drawing.Size(240, 73);
			this.ubicacionTextBox.TabIndex = 18;
			// 
			// capacidadNumericUpDown
			// 
			this.capacidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aulaBindingSource, "Capacidad", true));
			this.capacidadNumericUpDown.Location = new System.Drawing.Point(174, 107);
			this.capacidadNumericUpDown.Name = "capacidadNumericUpDown";
			this.capacidadNumericUpDown.Size = new System.Drawing.Size(120, 28);
			this.capacidadNumericUpDown.TabIndex = 20;
			// 
			// MantAulasForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(capacidadLabel1);
			this.Controls.Add(this.capacidadNumericUpDown);
			this.Controls.Add(accesibilidadLabel);
			this.Controls.Add(this.accesibilidadCheckBox);
			this.Controls.Add(codigoLabel);
			this.Controls.Add(this.codigoTextBox);
			this.Controls.Add(descripcionLabel);
			this.Controls.Add(this.descripcionTextBox);
			this.Controls.Add(disponibleLabel);
			this.Controls.Add(this.disponibleCheckBox);
			this.Controls.Add(idAulaLabel);
			this.Controls.Add(this.idAulaTextBox);
			this.Controls.Add(ubicacionLabel);
			this.Controls.Add(this.ubicacionTextBox);
			this.Controls.Add(this.aulaBindingNavigator);
			this.Name = "MantAulasForm";
			this.Text = "Aulas";
			this.Load += new System.EventHandler(this.MantAulasForm_Load);
			this.Controls.SetChildIndex(this.lblInfoMessage, 0);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnFind, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.aulaBindingNavigator, 0);
			this.Controls.SetChildIndex(this.ubicacionTextBox, 0);
			this.Controls.SetChildIndex(ubicacionLabel, 0);
			this.Controls.SetChildIndex(this.idAulaTextBox, 0);
			this.Controls.SetChildIndex(idAulaLabel, 0);
			this.Controls.SetChildIndex(this.disponibleCheckBox, 0);
			this.Controls.SetChildIndex(disponibleLabel, 0);
			this.Controls.SetChildIndex(this.descripcionTextBox, 0);
			this.Controls.SetChildIndex(descripcionLabel, 0);
			this.Controls.SetChildIndex(this.codigoTextBox, 0);
			this.Controls.SetChildIndex(codigoLabel, 0);
			this.Controls.SetChildIndex(this.accesibilidadCheckBox, 0);
			this.Controls.SetChildIndex(accesibilidadLabel, 0);
			this.Controls.SetChildIndex(this.capacidadNumericUpDown, 0);
			this.Controls.SetChildIndex(capacidadLabel1, 0);
			((System.ComponentModel.ISupportInitialize)(this.aulaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.aulaBindingNavigator)).EndInit();
			this.aulaBindingNavigator.ResumeLayout(false);
			this.aulaBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.capacidadNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource aulaBindingSource;
		private System.Windows.Forms.BindingNavigator aulaBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton aulaBindingNavigatorSaveItem;
		private System.Windows.Forms.CheckBox accesibilidadCheckBox;
		private System.Windows.Forms.TextBox codigoTextBox;
		private System.Windows.Forms.TextBox descripcionTextBox;
		private System.Windows.Forms.CheckBox disponibleCheckBox;
		private System.Windows.Forms.TextBox idAulaTextBox;
		private System.Windows.Forms.TextBox ubicacionTextBox;
		private System.Windows.Forms.NumericUpDown capacidadNumericUpDown;
	}
}