namespace CraftingFormulasRecollected
{
    partial class SelectItemDialog
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
            this.itemListView = new CraftingFormulasRecollected.UserControls.ItemListView();
            this.contolPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.mainForm = new System.Windows.Forms.Panel();
            this.quantityAddTenButton = new System.Windows.Forms.Button();
            this.quantitySubTenButton = new System.Windows.Forms.Button();
            this.quantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contolPanel.SuspendLayout();
            this.mainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // itemListView
            // 
            this.itemListView.Location = new System.Drawing.Point(16, 40);
            this.itemListView.Margin = new System.Windows.Forms.Padding(16, 4, 16, 8);
            this.itemListView.Name = "itemListView";
            this.itemListView.SelectionIndex = 0;
            this.itemListView.Size = new System.Drawing.Size(386, 232);
            this.itemListView.TabIndex = 0;
            this.itemListView.WrapContents = true;
            // 
            // contolPanel
            // 
            this.contolPanel.AutoSize = true;
            this.contolPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contolPanel.Controls.Add(this.cancelButton);
            this.contolPanel.Controls.Add(this.confirmButton);
            this.contolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contolPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.contolPanel.Location = new System.Drawing.Point(0, 333);
            this.contolPanel.Name = "contolPanel";
            this.contolPanel.Padding = new System.Windows.Forms.Padding(4);
            this.contolPanel.Size = new System.Drawing.Size(418, 42);
            this.contolPanel.TabIndex = 19;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(319, 8);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 16, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.AutoSize = true;
            this.confirmButton.Location = new System.Drawing.Point(236, 8);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 26);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "S/A";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // mainForm
            // 
            this.mainForm.Controls.Add(this.quantityAddTenButton);
            this.mainForm.Controls.Add(this.quantitySubTenButton);
            this.mainForm.Controls.Add(this.quantityNumeric);
            this.mainForm.Controls.Add(this.label2);
            this.mainForm.Controls.Add(this.label1);
            this.mainForm.Controls.Add(this.itemListView);
            this.mainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainForm.Location = new System.Drawing.Point(0, 0);
            this.mainForm.Name = "mainForm";
            this.mainForm.Size = new System.Drawing.Size(418, 333);
            this.mainForm.TabIndex = 20;
            // 
            // quantityAddTenButton
            // 
            this.quantityAddTenButton.AutoSize = true;
            this.quantityAddTenButton.Location = new System.Drawing.Point(286, 285);
            this.quantityAddTenButton.Margin = new System.Windows.Forms.Padding(4, 8, 8, 4);
            this.quantityAddTenButton.Name = "quantityAddTenButton";
            this.quantityAddTenButton.Size = new System.Drawing.Size(38, 26);
            this.quantityAddTenButton.TabIndex = 33;
            this.quantityAddTenButton.Text = "+10";
            this.quantityAddTenButton.UseVisualStyleBackColor = true;
            this.quantityAddTenButton.Click += new System.EventHandler(this.quantityAddTenButton_Click);
            // 
            // quantitySubTenButton
            // 
            this.quantitySubTenButton.AutoSize = true;
            this.quantitySubTenButton.Location = new System.Drawing.Point(240, 285);
            this.quantitySubTenButton.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.quantitySubTenButton.Name = "quantitySubTenButton";
            this.quantitySubTenButton.Size = new System.Drawing.Size(38, 26);
            this.quantitySubTenButton.TabIndex = 32;
            this.quantitySubTenButton.Text = "-10";
            this.quantitySubTenButton.UseVisualStyleBackColor = true;
            this.quantitySubTenButton.Click += new System.EventHandler(this.quantitySubTenButton_Click);
            // 
            // quantityNumeric
            // 
            this.quantityNumeric.Location = new System.Drawing.Point(82, 288);
            this.quantityNumeric.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.quantityNumeric.Maximum = new decimal(new int[] {
            1999999999,
            0,
            0,
            0});
            this.quantityNumeric.Name = "quantityNumeric";
            this.quantityNumeric.Size = new System.Drawing.Size(150, 22);
            this.quantityNumeric.TabIndex = 25;
            this.quantityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(16, 8, 4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(16, 16, 4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item:";
            // 
            // SelectItemDialog
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(418, 375);
            this.Controls.Add(this.mainForm);
            this.Controls.Add(this.contolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectItemDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Item";
            this.contolPanel.ResumeLayout(false);
            this.contolPanel.PerformLayout();
            this.mainForm.ResumeLayout(false);
            this.mainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ItemListView itemListView;
        private System.Windows.Forms.FlowLayoutPanel contolPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel mainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown quantityNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button quantityAddTenButton;
        private System.Windows.Forms.Button quantitySubTenButton;
    }
}