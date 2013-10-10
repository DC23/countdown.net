namespace CountdownTimer
{
    partial class Timer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonPresetOne = new System.Windows.Forms.Button();
            this.buttonPresetTwo = new System.Windows.Forms.Button();
            this.buttonPresetThree = new System.Windows.Forms.Button();
            this.buttonPresetFour = new System.Windows.Forms.Button();
            this.radioButtonTimer = new System.Windows.Forms.RadioButton();
            this.radioButtonStopwatch = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.timerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.61062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.38938F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 226);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerLabel.Font = new System.Drawing.Font("Nina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(3, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(378, 84);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "00:00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonStopwatch);
            this.panel1.Controls.Add(this.radioButtonTimer);
            this.panel1.Controls.Add(this.buttonPresetFour);
            this.panel1.Controls.Add(this.buttonPresetThree);
            this.panel1.Controls.Add(this.buttonPresetTwo);
            this.panel1.Controls.Add(this.buttonPresetOne);
            this.panel1.Controls.Add(this.buttonSet);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonStartPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 136);
            this.panel1.TabIndex = 3;
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Location = new System.Drawing.Point(70, 6);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(75, 23);
            this.buttonStartPause.TabIndex = 0;
            this.buttonStartPause.Text = "Start";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(152, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(234, 6);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 2;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonPresetOne
            // 
            this.buttonPresetOne.Location = new System.Drawing.Point(29, 38);
            this.buttonPresetOne.Name = "buttonPresetOne";
            this.buttonPresetOne.Size = new System.Drawing.Size(75, 23);
            this.buttonPresetOne.TabIndex = 3;
            this.buttonPresetOne.Text = "1:05";
            this.buttonPresetOne.UseVisualStyleBackColor = true;
            this.buttonPresetOne.Click += new System.EventHandler(this.buttonPresetOne_Click);
            // 
            // buttonPresetTwo
            // 
            this.buttonPresetTwo.Location = new System.Drawing.Point(111, 38);
            this.buttonPresetTwo.Name = "buttonPresetTwo";
            this.buttonPresetTwo.Size = new System.Drawing.Size(75, 23);
            this.buttonPresetTwo.TabIndex = 4;
            this.buttonPresetTwo.Text = "3:00";
            this.buttonPresetTwo.UseVisualStyleBackColor = true;
            this.buttonPresetTwo.Click += new System.EventHandler(this.buttonPresetTwo_Click);
            // 
            // buttonPresetThree
            // 
            this.buttonPresetThree.Location = new System.Drawing.Point(193, 38);
            this.buttonPresetThree.Name = "buttonPresetThree";
            this.buttonPresetThree.Size = new System.Drawing.Size(75, 23);
            this.buttonPresetThree.TabIndex = 5;
            this.buttonPresetThree.Text = "5:00";
            this.buttonPresetThree.UseVisualStyleBackColor = true;
            this.buttonPresetThree.Click += new System.EventHandler(this.buttonPresetThree_Click);
            // 
            // buttonPresetFour
            // 
            this.buttonPresetFour.Location = new System.Drawing.Point(275, 38);
            this.buttonPresetFour.Name = "buttonPresetFour";
            this.buttonPresetFour.Size = new System.Drawing.Size(75, 23);
            this.buttonPresetFour.TabIndex = 6;
            this.buttonPresetFour.Text = "10:00";
            this.buttonPresetFour.UseVisualStyleBackColor = true;
            this.buttonPresetFour.Click += new System.EventHandler(this.buttonPresetFour_Click);
            // 
            // radioButtonTimer
            // 
            this.radioButtonTimer.AutoSize = true;
            this.radioButtonTimer.Location = new System.Drawing.Point(29, 77);
            this.radioButtonTimer.Name = "radioButtonTimer";
            this.radioButtonTimer.Size = new System.Drawing.Size(51, 17);
            this.radioButtonTimer.TabIndex = 7;
            this.radioButtonTimer.TabStop = true;
            this.radioButtonTimer.Text = "Timer";
            this.radioButtonTimer.UseVisualStyleBackColor = true;
            this.radioButtonTimer.CheckedChanged += new System.EventHandler(this.radioButtonTimer_CheckedChanged);
            // 
            // radioButtonStopwatch
            // 
            this.radioButtonStopwatch.AutoSize = true;
            this.radioButtonStopwatch.Location = new System.Drawing.Point(94, 77);
            this.radioButtonStopwatch.Name = "radioButtonStopwatch";
            this.radioButtonStopwatch.Size = new System.Drawing.Size(76, 17);
            this.radioButtonStopwatch.TabIndex = 8;
            this.radioButtonStopwatch.TabStop = true;
            this.radioButtonStopwatch.Text = "Stopwatch";
            this.radioButtonStopwatch.UseVisualStyleBackColor = true;
            this.radioButtonStopwatch.CheckedChanged += new System.EventHandler(this.radioButtonStopwatch_CheckedChanged);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 226);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 173);
            this.Name = "Timer";
            this.Text = "DC\'s Timer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Button buttonPresetFour;
        private System.Windows.Forms.Button buttonPresetThree;
        private System.Windows.Forms.Button buttonPresetTwo;
        private System.Windows.Forms.Button buttonPresetOne;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.RadioButton radioButtonStopwatch;
        private System.Windows.Forms.RadioButton radioButtonTimer;

    }
}

