namespace CraftingFormulasRecollected
{
    partial class ManageItemDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageItemDialog));
            this.contolPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.clearImageButton = new System.Windows.Forms.Button();
            this.stockAddTenButton = new System.Windows.Forms.Button();
            this.stockSubTenButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemPreview = new CraftingFormulasRecollected.ItemListItem();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.stockNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.formulaNameLabel = new System.Windows.Forms.Label();
            this.contolPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // contolPanel
            // 
            this.contolPanel.AutoSize = true;
            this.contolPanel.Controls.Add(this.cancelButton);
            this.contolPanel.Controls.Add(this.deleteButton);
            this.contolPanel.Controls.Add(this.confirmButton);
            this.contolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contolPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.contolPanel.Location = new System.Drawing.Point(0, 370);
            this.contolPanel.Name = "contolPanel";
            this.contolPanel.Padding = new System.Windows.Forms.Padding(4);
            this.contolPanel.Size = new System.Drawing.Size(375, 42);
            this.contolPanel.TabIndex = 19;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(276, 8);
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
            this.deleteButton.Location = new System.Drawing.Point(193, 8);
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
            this.confirmButton.Location = new System.Drawing.Point(110, 8);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 26);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "S/A";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.clearImageButton);
            this.mainPanel.Controls.Add(this.stockAddTenButton);
            this.mainPanel.Controls.Add(this.stockSubTenButton);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.notesLabel);
            this.mainPanel.Controls.Add(this.notesTextBox);
            this.mainPanel.Controls.Add(this.browseImageButton);
            this.mainPanel.Controls.Add(this.imageLabel);
            this.mainPanel.Controls.Add(this.itemNameTextBox);
            this.mainPanel.Controls.Add(this.stockNumeric);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.formulaNameLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(375, 370);
            this.mainPanel.TabIndex = 21;
            // 
            // clearImageButton
            // 
            this.clearImageButton.AutoSize = true;
            this.clearImageButton.Location = new System.Drawing.Point(155, 141);
            this.clearImageButton.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(49, 26);
            this.clearImageButton.TabIndex = 32;
            this.clearImageButton.Text = "Clear";
            this.clearImageButton.UseVisualStyleBackColor = true;
            this.clearImageButton.Click += new System.EventHandler(this.ClearImageButton_Click);
            // 
            // stockAddTenButton
            // 
            this.stockAddTenButton.AutoSize = true;
            this.stockAddTenButton.Location = new System.Drawing.Point(169, 95);
            this.stockAddTenButton.Margin = new System.Windows.Forms.Padding(4, 8, 8, 4);
            this.stockAddTenButton.Name = "stockAddTenButton";
            this.stockAddTenButton.Size = new System.Drawing.Size(38, 26);
            this.stockAddTenButton.TabIndex = 31;
            this.stockAddTenButton.Text = "+10";
            this.stockAddTenButton.UseVisualStyleBackColor = true;
            this.stockAddTenButton.Click += new System.EventHandler(this.stockAddTenButton_Click);
            // 
            // stockSubTenButton
            // 
            this.stockSubTenButton.AutoSize = true;
            this.stockSubTenButton.Location = new System.Drawing.Point(123, 95);
            this.stockSubTenButton.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.stockSubTenButton.Name = "stockSubTenButton";
            this.stockSubTenButton.Size = new System.Drawing.Size(38, 26);
            this.stockSubTenButton.TabIndex = 30;
            this.stockSubTenButton.Text = "-10";
            this.stockSubTenButton.UseVisualStyleBackColor = true;
            this.stockSubTenButton.Click += new System.EventHandler(this.stockSubTenButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.itemPreview);
            this.panel1.Location = new System.Drawing.Point(223, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 16, 16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 152);
            this.panel1.TabIndex = 29;
            // 
            // itemPreview
            // 
            this.itemPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.itemPreview.Checked = false;
            this.itemPreview.Image = ((System.Drawing.Image)(resources.GetObject("itemPreview.Image")));
            this.itemPreview.ItemInfo = "546";
            this.itemPreview.ItemName = "Polymorphic Carbon";
            this.itemPreview.Location = new System.Drawing.Point(16, 16);
            this.itemPreview.Margin = new System.Windows.Forms.Padding(16);
            this.itemPreview.Name = "itemPreview";
            this.itemPreview.Padding = new System.Windows.Forms.Padding(4);
            this.itemPreview.Size = new System.Drawing.Size(104, 120);
            this.itemPreview.State = CraftingFormulasRecollected.ItemState.Normal;
            this.itemPreview.TabIndex = 20;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(16, 181);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(16, 8, 4, 4);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(46, 16);
            this.notesLabel.TabIndex = 28;
            this.notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(17, 205);
            this.notesTextBox.Margin = new System.Windows.Forms.Padding(16, 4, 16, 16);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(342, 146);
            this.notesTextBox.TabIndex = 27;
            // 
            // browseImageButton
            // 
            this.browseImageButton.AutoSize = true;
            this.browseImageButton.Location = new System.Drawing.Point(72, 141);
            this.browseImageButton.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(75, 26);
            this.browseImageButton.TabIndex = 26;
            this.browseImageButton.Text = "Browse...";
            this.browseImageButton.UseVisualStyleBackColor = true;
            this.browseImageButton.Click += new System.EventHandler(this.BrowseImageButton_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(16, 144);
            this.imageLabel.Margin = new System.Windows.Forms.Padding(16, 16, 4, 4);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(48, 16);
            this.imageLabel.TabIndex = 25;
            this.imageLabel.Text = "Image:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(17, 40);
            this.itemNameTextBox.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(190, 22);
            this.itemNameTextBox.TabIndex = 24;
            this.itemNameTextBox.Text = "Random Formula";
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.ItemNameTextBox_TextChanged);
            // 
            // stockNumeric
            // 
            this.stockNumeric.Location = new System.Drawing.Point(17, 98);
            this.stockNumeric.Margin = new System.Windows.Forms.Padding(16, 4, 4, 8);
            this.stockNumeric.Maximum = new decimal(new int[] {
            1999999999,
            0,
            0,
            0});
            this.stockNumeric.Name = "stockNumeric";
            this.stockNumeric.Size = new System.Drawing.Size(98, 22);
            this.stockNumeric.TabIndex = 23;
            this.stockNumeric.Value = new decimal(new int[] {
            1999999999,
            0,
            0,
            0});
            this.stockNumeric.ValueChanged += new System.EventHandler(this.stockNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(16, 8, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Stock:";
            // 
            // formulaNameLabel
            // 
            this.formulaNameLabel.AutoSize = true;
            this.formulaNameLabel.Location = new System.Drawing.Point(17, 16);
            this.formulaNameLabel.Margin = new System.Windows.Forms.Padding(8, 16, 4, 4);
            this.formulaNameLabel.Name = "formulaNameLabel";
            this.formulaNameLabel.Size = new System.Drawing.Size(47, 16);
            this.formulaNameLabel.TabIndex = 21;
            this.formulaNameLabel.Text = "Name:";
            // 
            // ManageItemDialog
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(375, 412);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.contolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageItemDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageItemForm";
            this.contolPanel.ResumeLayout(false);
            this.contolPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contolPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.NumericUpDown stockNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label formulaNameLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Panel panel1;
        private ItemListItem itemPreview;
        private System.Windows.Forms.Button stockAddTenButton;
        private System.Windows.Forms.Button stockSubTenButton;
        private System.Windows.Forms.Button clearImageButton;
    }
}