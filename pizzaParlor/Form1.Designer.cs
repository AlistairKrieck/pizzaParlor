namespace pizzaParlor
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.slicesInput = new System.Windows.Forms.TextBox();
            this.numberOfSlicesLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Red;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(-13, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(574, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Pizza Parlor";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // slicesInput
            // 
            this.slicesInput.Location = new System.Drawing.Point(281, 106);
            this.slicesInput.Name = "slicesInput";
            this.slicesInput.Size = new System.Drawing.Size(100, 22);
            this.slicesInput.TabIndex = 1;
            this.slicesInput.TextChanged += new System.EventHandler(this.slicesInput_TextChanged);
            // 
            // numberOfSlicesLabel
            // 
            this.numberOfSlicesLabel.AutoSize = true;
            this.numberOfSlicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.numberOfSlicesLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfSlicesLabel.Location = new System.Drawing.Point(85, 103);
            this.numberOfSlicesLabel.Name = "numberOfSlicesLabel";
            this.numberOfSlicesLabel.Size = new System.Drawing.Size(179, 26);
            this.numberOfSlicesLabel.TabIndex = 2;
            this.numberOfSlicesLabel.Text = "Number of Slices";
            this.numberOfSlicesLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.subtotalLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalLabel.Location = new System.Drawing.Point(103, 305);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(92, 26);
            this.subtotalLabel.TabIndex = 4;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(148, 381);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(47, 26);
            this.taxLabel.TabIndex = 6;
            this.taxLabel.Text = "Tax";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.totalCostLabel.ForeColor = System.Drawing.Color.White;
            this.totalCostLabel.Location = new System.Drawing.Point(85, 457);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(110, 26);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "Total Cost";
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.BackColor = System.Drawing.Color.LightCoral;
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calculateButton.Location = new System.Drawing.Point(242, 200);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(89, 30);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.taxOutput.ForeColor = System.Drawing.Color.Black;
            this.taxOutput.Location = new System.Drawing.Point(216, 381);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(179, 26);
            this.taxOutput.TabIndex = 11;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.taxOutput.Click += new System.EventHandler(this.label6_Click);
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BackColor = System.Drawing.Color.White;
            this.totalCostOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.totalCostOutput.ForeColor = System.Drawing.Color.Black;
            this.totalCostOutput.Location = new System.Drawing.Point(216, 457);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(179, 26);
            this.totalCostOutput.TabIndex = 12;
            this.totalCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalCostOutput.Click += new System.EventHandler(this.label5_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.White;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.subtotalOutput.ForeColor = System.Drawing.Color.Black;
            this.subtotalOutput.Location = new System.Drawing.Point(216, 305);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(179, 26);
            this.subtotalOutput.TabIndex = 10;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subtotalOutput.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(551, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.numberOfSlicesLabel);
            this.Controls.Add(this.slicesInput);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox slicesInput;
        private System.Windows.Forms.Label numberOfSlicesLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label label1;
    }
}

