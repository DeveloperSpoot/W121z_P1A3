namespace W121z_P1A3
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tip1CheckBox = new System.Windows.Forms.CheckBox();
            this.tip2CheckBox = new System.Windows.Forms.CheckBox();
            this.tip3CheckBox = new System.Windows.Forms.CheckBox();
            this.tip4CheckBox = new System.Windows.Forms.CheckBox();
            this.tip5CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tip1CheckBox
            // 
            this.tip1CheckBox.AutoSize = true;
            this.tip1CheckBox.Location = new System.Drawing.Point(6, 25);
            this.tip1CheckBox.Name = "tip1CheckBox";
            this.tip1CheckBox.Size = new System.Drawing.Size(180, 23);
            this.tip1CheckBox.TabIndex = 0;
            this.tip1CheckBox.Text = "Will Avoid Procastination";
            this.tip1CheckBox.UseVisualStyleBackColor = true;
            // 
            // tip2CheckBox
            // 
            this.tip2CheckBox.AutoSize = true;
            this.tip2CheckBox.Location = new System.Drawing.Point(257, 25);
            this.tip2CheckBox.Name = "tip2CheckBox";
            this.tip2CheckBox.Size = new System.Drawing.Size(124, 23);
            this.tip2CheckBox.TabIndex = 1;
            this.tip2CheckBox.Text = "Will Take Breaks";
            this.tip2CheckBox.UseVisualStyleBackColor = true;
            // 
            // tip3CheckBox
            // 
            this.tip3CheckBox.AutoSize = true;
            this.tip3CheckBox.Location = new System.Drawing.Point(452, 25);
            this.tip3CheckBox.Name = "tip3CheckBox";
            this.tip3CheckBox.Size = new System.Drawing.Size(107, 23);
            this.tip3CheckBox.TabIndex = 2;
            this.tip3CheckBox.Text = "Will Be Social";
            this.tip3CheckBox.UseVisualStyleBackColor = true;
            // 
            // tip4CheckBox
            // 
            this.tip4CheckBox.AutoSize = true;
            this.tip4CheckBox.Location = new System.Drawing.Point(6, 54);
            this.tip4CheckBox.Name = "tip4CheckBox";
            this.tip4CheckBox.Size = new System.Drawing.Size(142, 23);
            this.tip4CheckBox.TabIndex = 3;
            this.tip4CheckBox.Text = "Will Ask Questions";
            this.tip4CheckBox.UseVisualStyleBackColor = true;
            // 
            // tip5CheckBox
            // 
            this.tip5CheckBox.AutoSize = true;
            this.tip5CheckBox.Location = new System.Drawing.Point(257, 54);
            this.tip5CheckBox.Name = "tip5CheckBox";
            this.tip5CheckBox.Size = new System.Drawing.Size(148, 23);
            this.tip5CheckBox.TabIndex = 4;
            this.tip5CheckBox.Text = "Will Use A Calandar";
            this.tip5CheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outcomeLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(111, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outcome";
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outcomeLabel.Location = new System.Drawing.Point(6, 22);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(553, 69);
            this.outcomeLabel.TabIndex = 0;
            this.outcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(111, 230);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(245, 31);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tomato;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitButton.Location = new System.Drawing.Point(431, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(245, 31);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tip1CheckBox);
            this.groupBox2.Controls.Add(this.tip2CheckBox);
            this.groupBox2.Controls.Add(this.tip3CheckBox);
            this.groupBox2.Controls.Add(this.tip4CheckBox);
            this.groupBox2.Controls.Add(this.tip5CheckBox);
            this.groupBox2.Location = new System.Drawing.Point(111, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select all the things you will do:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Successful College Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox tip1CheckBox;
        private CheckBox tip2CheckBox;
        private CheckBox tip3CheckBox;
        private CheckBox tip4CheckBox;
        private CheckBox tip5CheckBox;
        private GroupBox groupBox1;
        private Label outcomeLabel;
        private Button checkButton;
        private Button exitButton;
        private GroupBox groupBox2;
    }
}