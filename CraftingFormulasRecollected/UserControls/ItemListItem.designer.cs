namespace CraftingFormulasRecollected
{
    partial class ItemListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.infoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.itemImage = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.SystemColors.Info;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoLabel.Location = new System.Drawing.Point(72, 4);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.infoLabel.Size = new System.Drawing.Size(28, 16);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "546";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoLabel.Click += new System.EventHandler(this.FormulaListItem_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.nameLabel.Location = new System.Drawing.Point(4, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(96, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Polymorphic Carbon";
            this.nameLabel.Click += new System.EventHandler(this.FormulaListItem_Click);
            // 
            // itemImage
            // 
            this.itemImage.BackgroundImage = global::CraftingFormulasRecollected.Properties.Resources.item_empty;
            this.itemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.itemImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemImage.Location = new System.Drawing.Point(4, 4);
            this.itemImage.Margin = new System.Windows.Forms.Padding(0);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(96, 96);
            this.itemImage.TabIndex = 2;
            this.itemImage.TabStop = false;
            this.itemImage.Click += new System.EventHandler(this.ItemImage_Click);
            // 
            // ItemListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.itemImage);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ItemListItem";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(104, 122);
            this.Click += new System.EventHandler(this.FormulaListItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox itemImage;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
