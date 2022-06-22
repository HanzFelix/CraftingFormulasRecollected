namespace CraftingFormulasRecollected
{
    partial class CraftDialog
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.productLabel = new System.Windows.Forms.Label();
            this.productListView = new CraftingFormulasRecollected.UserControls.ItemListView();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialListView = new CraftingFormulasRecollected.UserControls.ItemListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.minValueLabel = new System.Windows.Forms.Label();
            this.maxValueLabel = new System.Windows.Forms.Label();
            this.craftQuantityTrackBar = new System.Windows.Forms.TrackBar();
            this.subTenButton = new System.Windows.Forms.Button();
            this.addOneButton = new System.Windows.Forms.Button();
            this.currentValueLabel = new System.Windows.Forms.Label();
            this.subOneButton = new System.Windows.Forms.Button();
            this.addTenButton = new System.Windows.Forms.Button();
            this.contolPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.craftButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.craftQuantityTrackBar)).BeginInit();
            this.contolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.productLabel);
            this.mainPanel.Controls.Add(this.productListView);
            this.mainPanel.Controls.Add(this.materialLabel);
            this.mainPanel.Controls.Add(this.materialListView);
            this.mainPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainPanel.Controls.Add(this.subTenButton);
            this.mainPanel.Controls.Add(this.addOneButton);
            this.mainPanel.Controls.Add(this.currentValueLabel);
            this.mainPanel.Controls.Add(this.subOneButton);
            this.mainPanel.Controls.Add(this.addTenButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(434, 523);
            this.mainPanel.TabIndex = 24;
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
            // productListView
            // 
            this.productListView.Location = new System.Drawing.Point(16, 40);
            this.productListView.Margin = new System.Windows.Forms.Padding(16, 4, 16, 8);
            this.productListView.Name = "productListView";
            this.productListView.SelectionIndex = 0;
            this.productListView.Size = new System.Drawing.Size(403, 160);
            this.productListView.TabIndex = 19;
            this.productListView.WrapContents = false;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(19, 216);
            this.materialLabel.Margin = new System.Windows.Forms.Padding(16, 8, 4, 4);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(73, 16);
            this.materialLabel.TabIndex = 13;
            this.materialLabel.Text = "Material(s):";
            // 
            // materialListView
            // 
            this.materialListView.Location = new System.Drawing.Point(19, 240);
            this.materialListView.Margin = new System.Windows.Forms.Padding(16, 4, 16, 4);
            this.materialListView.Name = "materialListView";
            this.materialListView.SelectionIndex = 0;
            this.materialListView.Size = new System.Drawing.Size(400, 159);
            this.materialListView.TabIndex = 20;
            this.materialListView.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.minValueLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maxValueLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.craftQuantityTrackBar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 411);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 62);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // minValueLabel
            // 
            this.minValueLabel.AutoSize = true;
            this.minValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minValueLabel.Location = new System.Drawing.Point(3, 0);
            this.minValueLabel.Name = "minValueLabel";
            this.minValueLabel.Size = new System.Drawing.Size(61, 62);
            this.minValueLabel.TabIndex = 0;
            this.minValueLabel.Text = "minvalue";
            this.minValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxValueLabel
            // 
            this.maxValueLabel.AutoSize = true;
            this.maxValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxValueLabel.Location = new System.Drawing.Point(335, 0);
            this.maxValueLabel.Name = "maxValueLabel";
            this.maxValueLabel.Size = new System.Drawing.Size(65, 62);
            this.maxValueLabel.TabIndex = 1;
            this.maxValueLabel.Text = "maxvalue";
            this.maxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // craftQuantityTrackBar
            // 
            this.craftQuantityTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.craftQuantityTrackBar.Location = new System.Drawing.Point(70, 3);
            this.craftQuantityTrackBar.Name = "craftQuantityTrackBar";
            this.craftQuantityTrackBar.Size = new System.Drawing.Size(259, 56);
            this.craftQuantityTrackBar.TabIndex = 21;
            this.craftQuantityTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.craftQuantityTrackBar.ValueChanged += new System.EventHandler(this.CraftQuantityTrackBar_ValueChanged);
            // 
            // subTenButton
            // 
            this.subTenButton.AutoSize = true;
            this.subTenButton.Location = new System.Drawing.Point(16, 481);
            this.subTenButton.Margin = new System.Windows.Forms.Padding(16, 4, 4, 8);
            this.subTenButton.Name = "subTenButton";
            this.subTenButton.Size = new System.Drawing.Size(50, 26);
            this.subTenButton.TabIndex = 22;
            this.subTenButton.Text = "-10";
            this.subTenButton.UseVisualStyleBackColor = true;
            this.subTenButton.Click += new System.EventHandler(this.SubTenButton_Click);
            // 
            // addOneButton
            // 
            this.addOneButton.AutoSize = true;
            this.addOneButton.Location = new System.Drawing.Point(312, 481);
            this.addOneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.addOneButton.Name = "addOneButton";
            this.addOneButton.Size = new System.Drawing.Size(50, 26);
            this.addOneButton.TabIndex = 25;
            this.addOneButton.Text = "+1";
            this.addOneButton.UseVisualStyleBackColor = true;
            this.addOneButton.Click += new System.EventHandler(this.AddOneButton_Click);
            // 
            // currentValueLabel
            // 
            this.currentValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentValueLabel.Location = new System.Drawing.Point(131, 484);
            this.currentValueLabel.Name = "currentValueLabel";
            this.currentValueLabel.Size = new System.Drawing.Size(174, 20);
            this.currentValueLabel.TabIndex = 27;
            this.currentValueLabel.Text = "currentValue";
            this.currentValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // subOneButton
            // 
            this.subOneButton.AutoSize = true;
            this.subOneButton.Location = new System.Drawing.Point(74, 481);
            this.subOneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.subOneButton.Name = "subOneButton";
            this.subOneButton.Size = new System.Drawing.Size(50, 26);
            this.subOneButton.TabIndex = 24;
            this.subOneButton.Text = "-1";
            this.subOneButton.UseVisualStyleBackColor = true;
            this.subOneButton.Click += new System.EventHandler(this.SubOneButton_Click);
            // 
            // addTenButton
            // 
            this.addTenButton.AutoSize = true;
            this.addTenButton.Location = new System.Drawing.Point(370, 481);
            this.addTenButton.Margin = new System.Windows.Forms.Padding(4, 4, 16, 8);
            this.addTenButton.Name = "addTenButton";
            this.addTenButton.Size = new System.Drawing.Size(50, 26);
            this.addTenButton.TabIndex = 26;
            this.addTenButton.Text = "+10";
            this.addTenButton.UseVisualStyleBackColor = true;
            this.addTenButton.Click += new System.EventHandler(this.AddTenButton_Click);
            // 
            // contolPanel
            // 
            this.contolPanel.AutoSize = true;
            this.contolPanel.Controls.Add(this.cancelButton);
            this.contolPanel.Controls.Add(this.craftButton);
            this.contolPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contolPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.contolPanel.Location = new System.Drawing.Point(0, 523);
            this.contolPanel.Name = "contolPanel";
            this.contolPanel.Padding = new System.Windows.Forms.Padding(4);
            this.contolPanel.Size = new System.Drawing.Size(434, 42);
            this.contolPanel.TabIndex = 23;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(335, 8);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 16, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // craftButton
            // 
            this.craftButton.AutoSize = true;
            this.craftButton.Location = new System.Drawing.Point(252, 8);
            this.craftButton.Margin = new System.Windows.Forms.Padding(4);
            this.craftButton.Name = "craftButton";
            this.craftButton.Size = new System.Drawing.Size(75, 26);
            this.craftButton.TabIndex = 2;
            this.craftButton.Text = "Craft";
            this.craftButton.UseVisualStyleBackColor = true;
            this.craftButton.Click += new System.EventHandler(this.CraftButton_Click);
            // 
            // CraftDialog
            // 
            this.AcceptButton = this.craftButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(434, 565);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.contolPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CraftDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CraftDialog";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.craftQuantityTrackBar)).EndInit();
            this.contolPanel.ResumeLayout(false);
            this.contolPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label productLabel;
        private UserControls.ItemListView productListView;
        private System.Windows.Forms.Label materialLabel;
        private UserControls.ItemListView materialListView;
        private System.Windows.Forms.FlowLayoutPanel contolPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button craftButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label minValueLabel;
        private System.Windows.Forms.Label maxValueLabel;
        private System.Windows.Forms.TrackBar craftQuantityTrackBar;
        private System.Windows.Forms.Button subTenButton;
        private System.Windows.Forms.Button addTenButton;
        private System.Windows.Forms.Button addOneButton;
        private System.Windows.Forms.Button subOneButton;
        private System.Windows.Forms.Label currentValueLabel;
    }
}