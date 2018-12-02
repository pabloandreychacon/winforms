namespace Cursos.Presentation.Forms.Mantenimientos
{
	partial class MantTiposIdsForm
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
			System.Windows.Forms.Label idTipoIdLabel;
			System.Windows.Forms.Label maskLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantTiposIdsForm));
			this.tipoIdBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.tipoIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.tipoIdBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.descripcionTextBox = new System.Windows.Forms.TextBox();
			this.idTipoIdTextBox = new System.Windows.Forms.TextBox();
			this.maskTextBox = new System.Windows.Forms.TextBox();
			descripcionLabel = new System.Windows.Forms.Label();
			idTipoIdLabel = new System.Windows.Forms.Label();
			maskLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tipoIdBindingNavigator)).BeginInit();
			this.tipoIdBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tipoIdBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// closeButton1
			// 
			this.closeButton1.Location = new System.Drawing.Point(446, 47);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(384, 47);
			// 
			// descripcionLabel
			// 
			descripcionLabel.AutoSize = true;
			descripcionLabel.Location = new System.Drawing.Point(41, 84);
			descripcionLabel.Name = "descripcionLabel";
			descripcionLabel.Size = new System.Drawing.Size(115, 24);
			descripcionLabel.TabIndex = 4;
			descripcionLabel.Text = "Descripcion:";
			// 
			// idTipoIdLabel
			// 
			idTipoIdLabel.AutoSize = true;
			idTipoIdLabel.Enabled = false;
			idTipoIdLabel.Location = new System.Drawing.Point(41, 50);
			idTipoIdLabel.Name = "idTipoIdLabel";
			idTipoIdLabel.Size = new System.Drawing.Size(93, 24);
			idTipoIdLabel.TabIndex = 6;
			idTipoIdLabel.Text = "Id Tipo Id:";
			// 
			// maskLabel
			// 
			maskLabel.AutoSize = true;
			maskLabel.Location = new System.Drawing.Point(41, 118);
			maskLabel.Name = "maskLabel";
			maskLabel.Size = new System.Drawing.Size(86, 24);
			maskLabel.TabIndex = 8;
			maskLabel.Text = "Máscara:";
			// 
			// tipoIdBindingNavigator
			// 
			this.tipoIdBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.tipoIdBindingNavigator.BindingSource = this.tipoIdBindingSource;
			this.tipoIdBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.tipoIdBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.tipoIdBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tipoIdBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tipoIdBindingNavigatorSaveItem});
			this.tipoIdBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.tipoIdBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.tipoIdBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.tipoIdBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.tipoIdBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.tipoIdBindingNavigator.Name = "tipoIdBindingNavigator";
			this.tipoIdBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.tipoIdBindingNavigator.Size = new System.Drawing.Size(511, 27);
			this.tipoIdBindingNavigator.TabIndex = 3;
			this.tipoIdBindingNavigator.Text = "bindingNavigator1";
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
			// tipoIdBindingSource
			// 
			this.tipoIdBindingSource.DataSource = typeof(CursosEntities.Entities.TipoId);
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
			// tipoIdBindingNavigatorSaveItem
			// 
			this.tipoIdBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tipoIdBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoIdBindingNavigatorSaveItem.Image")));
			this.tipoIdBindingNavigatorSaveItem.Name = "tipoIdBindingNavigatorSaveItem";
			this.tipoIdBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
			this.tipoIdBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoIdBindingSource, "Descripcion", true));
			this.descripcionTextBox.Location = new System.Drawing.Point(162, 81);
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(189, 28);
			this.descripcionTextBox.TabIndex = 5;
			// 
			// idTipoIdTextBox
			// 
			this.idTipoIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoIdBindingSource, "IdTipoId", true));
			this.idTipoIdTextBox.Location = new System.Drawing.Point(162, 47);
			this.idTipoIdTextBox.Name = "idTipoIdTextBox";
			this.idTipoIdTextBox.ReadOnly = true;
			this.idTipoIdTextBox.Size = new System.Drawing.Size(100, 28);
			this.idTipoIdTextBox.TabIndex = 7;
			// 
			// maskTextBox
			// 
			this.maskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoIdBindingSource, "Mask", true));
			this.maskTextBox.Location = new System.Drawing.Point(162, 115);
			this.maskTextBox.Name = "maskTextBox";
			this.maskTextBox.Size = new System.Drawing.Size(189, 28);
			this.maskTextBox.TabIndex = 9;
			// 
			// MantTiposIdsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.ClientSize = new System.Drawing.Size(511, 183);
			this.Controls.Add(descripcionLabel);
			this.Controls.Add(this.descripcionTextBox);
			this.Controls.Add(idTipoIdLabel);
			this.Controls.Add(this.idTipoIdTextBox);
			this.Controls.Add(maskLabel);
			this.Controls.Add(this.maskTextBox);
			this.Controls.Add(this.tipoIdBindingNavigator);
			this.Name = "MantTiposIdsForm";
			this.Load += new System.EventHandler(this.MantTiposIdsForm_Load);
			this.Controls.SetChildIndex(this.closeButton1, 0);
			this.Controls.SetChildIndex(this.btnFind, 0);
			this.Controls.SetChildIndex(this.errorContainer1, 0);
			this.Controls.SetChildIndex(this.tipoIdBindingNavigator, 0);
			this.Controls.SetChildIndex(this.maskTextBox, 0);
			this.Controls.SetChildIndex(maskLabel, 0);
			this.Controls.SetChildIndex(this.idTipoIdTextBox, 0);
			this.Controls.SetChildIndex(idTipoIdLabel, 0);
			this.Controls.SetChildIndex(this.descripcionTextBox, 0);
			this.Controls.SetChildIndex(descripcionLabel, 0);
			((System.ComponentModel.ISupportInitialize)(this.tipoIdBindingNavigator)).EndInit();
			this.tipoIdBindingNavigator.ResumeLayout(false);
			this.tipoIdBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tipoIdBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource tipoIdBindingSource;
		private System.Windows.Forms.BindingNavigator tipoIdBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton tipoIdBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox descripcionTextBox;
		private System.Windows.Forms.TextBox idTipoIdTextBox;
		private System.Windows.Forms.TextBox maskTextBox;
	}
}
