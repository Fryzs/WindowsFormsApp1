namespace WindowsFormsApp1
{
    partial class Main
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
            this.BrandButton = new System.Windows.Forms.Button();
            this.СountryButton = new System.Windows.Forms.Button();
            this.Upper_materialButton = new System.Windows.Forms.Button();
            this.Sole_materialButton = new System.Windows.Forms.Button();
            this.Target_audienceButton = new System.Windows.Forms.Button();
            this.Shoe_catalogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrandButton
            // 
            this.BrandButton.Location = new System.Drawing.Point(39, 319);
            this.BrandButton.Name = "BrandButton";
            this.BrandButton.Size = new System.Drawing.Size(75, 23);
            this.BrandButton.TabIndex = 0;
            this.BrandButton.Text = "Бренд";
            this.BrandButton.UseVisualStyleBackColor = true;
            this.BrandButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // СountryButton
            // 
            this.СountryButton.Location = new System.Drawing.Point(159, 319);
            this.СountryButton.Name = "СountryButton";
            this.СountryButton.Size = new System.Drawing.Size(75, 23);
            this.СountryButton.TabIndex = 1;
            this.СountryButton.Text = "Країна";
            this.СountryButton.UseVisualStyleBackColor = true;
            this.СountryButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Upper_materialButton
            // 
            this.Upper_materialButton.Location = new System.Drawing.Point(267, 319);
            this.Upper_materialButton.Name = "Upper_materialButton";
            this.Upper_materialButton.Size = new System.Drawing.Size(102, 23);
            this.Upper_materialButton.TabIndex = 2;
            this.Upper_materialButton.Text = "Матеріал верха";
            this.Upper_materialButton.UseVisualStyleBackColor = true;
            this.Upper_materialButton.Click += new System.EventHandler(this.Upper_materialButton_Click);
            // 
            // Sole_materialButton
            // 
            this.Sole_materialButton.Location = new System.Drawing.Point(387, 319);
            this.Sole_materialButton.Name = "Sole_materialButton";
            this.Sole_materialButton.Size = new System.Drawing.Size(112, 23);
            this.Sole_materialButton.TabIndex = 3;
            this.Sole_materialButton.Text = "Матеріал підошви";
            this.Sole_materialButton.UseVisualStyleBackColor = true;
            this.Sole_materialButton.Click += new System.EventHandler(this.Sole_materialButton_Click);
            // 
            // Target_audienceButton
            // 
            this.Target_audienceButton.Location = new System.Drawing.Point(517, 319);
            this.Target_audienceButton.Name = "Target_audienceButton";
            this.Target_audienceButton.Size = new System.Drawing.Size(113, 23);
            this.Target_audienceButton.TabIndex = 4;
            this.Target_audienceButton.Text = "Цільова аудиторія";
            this.Target_audienceButton.UseVisualStyleBackColor = true;
            this.Target_audienceButton.Click += new System.EventHandler(this.Target_audienceButton_Click);
            // 
            // Shoe_catalogButton
            // 
            this.Shoe_catalogButton.Location = new System.Drawing.Point(667, 319);
            this.Shoe_catalogButton.Name = "Shoe_catalogButton";
            this.Shoe_catalogButton.Size = new System.Drawing.Size(75, 23);
            this.Shoe_catalogButton.TabIndex = 5;
            this.Shoe_catalogButton.Text = "Каталог взуття";
            this.Shoe_catalogButton.UseVisualStyleBackColor = true;
            this.Shoe_catalogButton.Click += new System.EventHandler(this.Shoe_catalogButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Shoe_catalogButton);
            this.Controls.Add(this.Target_audienceButton);
            this.Controls.Add(this.Sole_materialButton);
            this.Controls.Add(this.Upper_materialButton);
            this.Controls.Add(this.СountryButton);
            this.Controls.Add(this.BrandButton);
            this.Name = "Main";
            this.Text = "Головна";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrandButton;
        private System.Windows.Forms.Button СountryButton;
        private System.Windows.Forms.Button Upper_materialButton;
        private System.Windows.Forms.Button Sole_materialButton;
        private System.Windows.Forms.Button Target_audienceButton;
        private System.Windows.Forms.Button Shoe_catalogButton;
    }
}