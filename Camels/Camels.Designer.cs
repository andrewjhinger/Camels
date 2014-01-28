namespace Camels
{
    partial class Camels
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
            this.waterAmountProgressBar = new System.Windows.Forms.ProgressBar();
            this.waterAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.waterLabel = new System.Windows.Forms.Label();
            this.waterAmountLabel = new System.Windows.Forms.Label();
            this.addWaterButton = new System.Windows.Forms.Button();
            this.removeWaterButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.waterAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // waterAmountProgressBar
            // 
            this.waterAmountProgressBar.Location = new System.Drawing.Point(12, 64);
            this.waterAmountProgressBar.Name = "waterAmountProgressBar";
            this.waterAmountProgressBar.Size = new System.Drawing.Size(268, 23);
            this.waterAmountProgressBar.TabIndex = 0;
            // 
            // waterAmountNumericUpDown
            // 
            this.waterAmountNumericUpDown.Location = new System.Drawing.Point(158, 38);
            this.waterAmountNumericUpDown.Name = "waterAmountNumericUpDown";
            this.waterAmountNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.waterAmountNumericUpDown.TabIndex = 1;
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.Location = new System.Drawing.Point(12, 40);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(110, 13);
            this.waterLabel.TabIndex = 2;
            this.waterLabel.Text = "Camel Water Amount:";
            // 
            // waterAmountLabel
            // 
            this.waterAmountLabel.AutoSize = true;
            this.waterAmountLabel.Location = new System.Drawing.Point(128, 40);
            this.waterAmountLabel.Name = "waterAmountLabel";
            this.waterAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.waterAmountLabel.TabIndex = 3;
            this.waterAmountLabel.Text = "0";
            // 
            // addWaterButton
            // 
            this.addWaterButton.Location = new System.Drawing.Point(223, 35);
            this.addWaterButton.Name = "addWaterButton";
            this.addWaterButton.Size = new System.Drawing.Size(18, 23);
            this.addWaterButton.TabIndex = 4;
            this.addWaterButton.Text = "+";
            this.addWaterButton.UseVisualStyleBackColor = true;
            this.addWaterButton.Click += new System.EventHandler(this.addWaterButton_Click);
            // 
            // removeWaterButton
            // 
            this.removeWaterButton.Location = new System.Drawing.Point(247, 35);
            this.removeWaterButton.Name = "removeWaterButton";
            this.removeWaterButton.Size = new System.Drawing.Size(20, 23);
            this.removeWaterButton.TabIndex = 5;
            this.removeWaterButton.Text = "-";
            this.removeWaterButton.UseVisualStyleBackColor = true;
            this.removeWaterButton.Click += new System.EventHandler(this.removeWaterButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(105, 128);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Camels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 273);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeWaterButton);
            this.Controls.Add(this.addWaterButton);
            this.Controls.Add(this.waterAmountLabel);
            this.Controls.Add(this.waterLabel);
            this.Controls.Add(this.waterAmountNumericUpDown);
            this.Controls.Add(this.waterAmountProgressBar);
            this.Name = "Camels";
            this.Text = "Camels";
            this.Load += new System.EventHandler(this.Camels_Load);
            this.Shown += new System.EventHandler(this.Camels_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.waterAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar waterAmountProgressBar;
        private System.Windows.Forms.NumericUpDown waterAmountNumericUpDown;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label waterAmountLabel;
        private System.Windows.Forms.Button addWaterButton;
        private System.Windows.Forms.Button removeWaterButton;
        private System.Windows.Forms.Button exitButton;
    }
}

