namespace CraftingFormulasRecollected.UserControls
{
    partial class ProcessedItemListItem
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
            this.otherProductsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // otherProductsLabel
            // 
            this.otherProductsLabel.AutoSize = true;
            this.otherProductsLabel.BackColor = System.Drawing.SystemColors.Info;
            this.otherProductsLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.otherProductsLabel.Location = new System.Drawing.Point(82, 0);
            this.otherProductsLabel.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.otherProductsLabel.Name = "otherProductsLabel";
            this.otherProductsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.otherProductsLabel.Size = new System.Drawing.Size(14, 16);
            this.otherProductsLabel.TabIndex = 3;
            this.otherProductsLabel.Text = "2";
            this.otherProductsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.nameLabel.Location = new System.Drawing.Point(0, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(96, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Dikotic Carbon";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CraftingFormulasRecollected.Properties.Resources.material_cube_default;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // ProcessedItemListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.otherProductsLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ProcessedItemListItem";
            this.Size = new System.Drawing.Size(96, 112);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label otherProductsLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nameLabel;
    }
}
