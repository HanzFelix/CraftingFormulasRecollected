namespace CraftingFormulasRecollected
{
    partial class ManageFormulaDialog
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
            this.productLabel = new System.Windows.Forms.Label();
            this.formulaNameTextBox = new System.Windows.Forms.TextBox();
            this.formulaNameLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.editProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.contolPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.editMaterialButton = new System.Windows.Forms.Button();
            this.removeMaterialButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.productListView = new CraftingFormulasRecollected.UserControls.ItemListView();
            this.materialListView = new CraftingFormulasRecollected.UserControls.ItemListView();
            this.contolPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(16, 16);
            this.productLabel.Margin = new System.Windows.Forms.Padding(16, 16, 4, 4);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(71, 16);
            this.productLabel.TabIndex = 5;
            this.productLabel.Text = "Product(s):";
            // 
            // formulaNameTextBox
            // 
            this.formulaNameTextBox.Location = new System.Drawing.Point(435, 40);
            this.formulaNameTextBox.Margin = new System.Windows.Forms.Padding(8, 4, 16, 4);
            this.formulaNameTextBox.Name = "formulaNameTextBox";
            this.formulaNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.formulaNameTextBox.TabIndex = 0;
            this.formulaNameTextBox.Text = "Random Formula";
            // 
            // formulaNameLabel
            // 
            this.formulaNameLabel.AutoSize = true;
            this.formulaNameLabel.Location = new System.Drawing.Point(435, 16);
            this.formulaNameLabel.Margin = new System.Windows.Forms.Padding(8, 16, 4, 4);
            this.formulaNameLabel.Name = "formulaNameLabel";
            this.formulaNameLabel.Size = new System.Drawing.Size(96, 16);
            this.formulaNameLabel.TabIndex = 4;
            this.formulaNameLabel.Text = "Formula name:";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(19, 250);
            this.materialLabel.Margin = new System.Windows.Forms.Padding(16, 8, 4, 4);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(73, 16);
            this.materialLabel.TabIndex = 13;
            this.materialLabel.Text = "Material(s):";
            // 
            // editProductButton
            // 
            this.editProductButton.AutoSize = true;
            this.editProductButton.Location = new System.Drawing.Point(263, 208);
            this.editProductButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(75, 26);
            this.editProductButton.TabIndex = 15;
            this.editProductButton.Text = "Edit";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.AutoSize = true;
            this.addProductButton.Location = new System.Drawing.Point(180, 208);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 26);
            this.addProductButton.TabIndex = 14;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(435, 98);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(8, 4, 16, 16);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(200, 368);
            this.notesTextBox.TabIndex = 1;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(435, 74);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(8, 8, 4, 4);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(46, 16);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "Notes:";
            // 
            // contolPanel
            // 
            this.contolPanel.AutoSize = true;
            this.contolPanel.Controls.Add(this.cancelButton);
            this.contolPanel.Controls.Add(this.deleteButton);
            this.contolPanel.Controls.Add(this.confirmButton);
            this.contolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contolPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.contolPanel.Location = new System.Drawing.Point(0, 488);
            this.contolPanel.Name = "contolPanel";
            this.contolPanel.Padding = new System.Windows.Forms.Padding(4);
            this.contolPanel.Size = new System.Drawing.Size(660, 42);
            this.contolPanel.TabIndex = 18;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(561, 8);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 16, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(478, 8);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 26);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.AutoSize = true;
            this.confirmButton.Location = new System.Drawing.Point(395, 8);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 26);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "S/A";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // removeProductButton
            // 
            this.removeProductButton.AutoSize = true;
            this.removeProductButton.Location = new System.Drawing.Point(344, 208);
            this.removeProductButton.Margin = new System.Windows.Forms.Padding(4, 4, 8, 8);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(75, 26);
            this.removeProductButton.TabIndex = 21;
            this.removeProductButton.Text = "Remove";
            this.removeProductButton.UseVisualStyleBackColor = true;
            this.removeProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.AutoSize = true;
            this.addMaterialButton.Location = new System.Drawing.Point(180, 442);
            this.addMaterialButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(75, 26);
            this.addMaterialButton.TabIndex = 14;
            this.addMaterialButton.Text = "Add";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.AddMaterialButton_Click);
            // 
            // editMaterialButton
            // 
            this.editMaterialButton.AutoSize = true;
            this.editMaterialButton.Location = new System.Drawing.Point(263, 442);
            this.editMaterialButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.editMaterialButton.Name = "editMaterialButton";
            this.editMaterialButton.Size = new System.Drawing.Size(75, 26);
            this.editMaterialButton.TabIndex = 15;
            this.editMaterialButton.Text = "Edit";
            this.editMaterialButton.UseVisualStyleBackColor = true;
            this.editMaterialButton.Click += new System.EventHandler(this.EditMaterialButton_Click);
            // 
            // removeMaterialButton
            // 
            this.removeMaterialButton.AutoSize = true;
            this.removeMaterialButton.Location = new System.Drawing.Point(344, 442);
            this.removeMaterialButton.Margin = new System.Windows.Forms.Padding(4, 4, 8, 8);
            this.removeMaterialButton.Name = "removeMaterialButton";
            this.removeMaterialButton.Size = new System.Drawing.Size(75, 26);
            this.removeMaterialButton.TabIndex = 21;
            this.removeMaterialButton.Text = "Remove";
            this.removeMaterialButton.UseVisualStyleBackColor = true;
            this.removeMaterialButton.Click += new System.EventHandler(this.RemoveMaterialButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.productLabel);
            this.mainPanel.Controls.Add(this.productListView);
            this.mainPanel.Controls.Add(this.addProductButton);
            this.mainPanel.Controls.Add(this.editProductButton);
            this.mainPanel.Controls.Add(this.removeProductButton);
            this.mainPanel.Controls.Add(this.materialLabel);
            this.mainPanel.Controls.Add(this.materialListView);
            this.mainPanel.Controls.Add(this.addMaterialButton);
            this.mainPanel.Controls.Add(this.editMaterialButton);
            this.mainPanel.Controls.Add(this.removeMaterialButton);
            this.mainPanel.Controls.Add(this.formulaNameLabel);
            this.mainPanel.Controls.Add(this.formulaNameTextBox);
            this.mainPanel.Controls.Add(this.notesLabel);
            this.mainPanel.Controls.Add(this.notesTextBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(660, 488);
            this.mainPanel.TabIndex = 22;
            // 
            // productListView
            // 
            this.productListView.Location = new System.Drawing.Point(16, 40);
            this.productListView.Margin = new System.Windows.Forms.Padding(16, 4, 8, 4);
            this.productListView.Name = "productListView";
            this.productListView.SelectionIndex = 0;
            this.productListView.Size = new System.Drawing.Size(403, 160);
            this.productListView.TabIndex = 19;
            this.productListView.WrapContents = false;
            // 
            // materialListView
            // 
            this.materialListView.Location = new System.Drawing.Point(19, 274);
            this.materialListView.Margin = new System.Windows.Forms.Padding(16, 4, 8, 4);
            this.materialListView.Name = "materialListView";
            this.materialListView.SelectionIndex = 0;
            this.materialListView.Size = new System.Drawing.Size(400, 160);
            this.materialListView.TabIndex = 20;
            this.materialListView.WrapContents = false;
            // 
            // ManageFormulaDialog
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(660, 530);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.contolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageFormulaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageFormulaForm";
            this.contolPanel.ResumeLayout(false);
            this.contolPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox formulaNameTextBox;
        private System.Windows.Forms.Label formulaNameLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.FlowLayoutPanel contolPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private UserControls.ItemListView productListView;
        private UserControls.ItemListView materialListView;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.Button addMaterialButton;
        private System.Windows.Forms.Button editMaterialButton;
        private System.Windows.Forms.Button removeMaterialButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel mainPanel;
    }
}