namespace CountdownTimer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPreset8 = new System.Windows.Forms.Button();
            this.buttonPreset7 = new System.Windows.Forms.Button();
            this.buttonPreset6 = new System.Windows.Forms.Button();
            this.buttonPreset5 = new System.Windows.Forms.Button();
            this.radioButtonStopwatch = new System.Windows.Forms.RadioButton();
            this.radioButtonTimer = new System.Windows.Forms.RadioButton();
            this.buttonPreset4 = new System.Windows.Forms.Button();
            this.buttonPreset3 = new System.Windows.Forms.Button();
            this.buttonPreset2 = new System.Windows.Forms.Button();
            this.buttonPreset1 = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomodoroModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popupDingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioDingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelTimer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.65101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.34899F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 200);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimer.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(3, 0);
            this.labelTimer.MaximumSize = new System.Drawing.Size(378, 74);
            this.labelTimer.MinimumSize = new System.Drawing.Size(378, 74);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(378, 74);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonPreset8);
            this.panel1.Controls.Add(this.buttonPreset7);
            this.panel1.Controls.Add(this.buttonPreset6);
            this.panel1.Controls.Add(this.buttonPreset5);
            this.panel1.Controls.Add(this.radioButtonStopwatch);
            this.panel1.Controls.Add(this.radioButtonTimer);
            this.panel1.Controls.Add(this.buttonPreset4);
            this.panel1.Controls.Add(this.buttonPreset3);
            this.panel1.Controls.Add(this.buttonPreset2);
            this.panel1.Controls.Add(this.buttonPreset1);
            this.panel1.Controls.Add(this.buttonSet);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonStartPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 79);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 105);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(378, 105);
            this.panel1.TabIndex = 3;
            // 
            // buttonPreset8
            // 
            this.buttonPreset8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset8.FlatAppearance.BorderSize = 0;
            this.buttonPreset8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset8.Location = new System.Drawing.Point(275, 67);
            this.buttonPreset8.Name = "buttonPreset8";
            this.buttonPreset8.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset8.TabIndex = 12;
            this.buttonPreset8.Text = "four";
            this.buttonPreset8.UseVisualStyleBackColor = false;
            this.buttonPreset8.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonPreset7
            // 
            this.buttonPreset7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset7.FlatAppearance.BorderSize = 0;
            this.buttonPreset7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset7.Location = new System.Drawing.Point(193, 67);
            this.buttonPreset7.Name = "buttonPreset7";
            this.buttonPreset7.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset7.TabIndex = 11;
            this.buttonPreset7.Text = "three";
            this.buttonPreset7.UseVisualStyleBackColor = false;
            this.buttonPreset7.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonPreset6
            // 
            this.buttonPreset6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset6.FlatAppearance.BorderSize = 0;
            this.buttonPreset6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset6.Location = new System.Drawing.Point(111, 67);
            this.buttonPreset6.Name = "buttonPreset6";
            this.buttonPreset6.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset6.TabIndex = 10;
            this.buttonPreset6.Text = "two";
            this.buttonPreset6.UseVisualStyleBackColor = false;
            this.buttonPreset6.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonPreset5
            // 
            this.buttonPreset5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset5.FlatAppearance.BorderSize = 0;
            this.buttonPreset5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset5.Location = new System.Drawing.Point(29, 67);
            this.buttonPreset5.Name = "buttonPreset5";
            this.buttonPreset5.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset5.TabIndex = 9;
            this.buttonPreset5.Text = "one";
            this.buttonPreset5.UseVisualStyleBackColor = false;
            this.buttonPreset5.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // radioButtonStopwatch
            // 
            this.radioButtonStopwatch.AutoSize = true;
            this.radioButtonStopwatch.Enabled = false;
            this.radioButtonStopwatch.Location = new System.Drawing.Point(94, 115);
            this.radioButtonStopwatch.Name = "radioButtonStopwatch";
            this.radioButtonStopwatch.Size = new System.Drawing.Size(76, 17);
            this.radioButtonStopwatch.TabIndex = 8;
            this.radioButtonStopwatch.Text = "Stopwatch";
            this.radioButtonStopwatch.UseVisualStyleBackColor = true;
            this.radioButtonStopwatch.Visible = false;
            this.radioButtonStopwatch.CheckedChanged += new System.EventHandler(this.radioButtonStopwatch_CheckedChanged);
            // 
            // radioButtonTimer
            // 
            this.radioButtonTimer.AutoSize = true;
            this.radioButtonTimer.Checked = true;
            this.radioButtonTimer.Location = new System.Drawing.Point(29, 115);
            this.radioButtonTimer.Name = "radioButtonTimer";
            this.radioButtonTimer.Size = new System.Drawing.Size(51, 17);
            this.radioButtonTimer.TabIndex = 7;
            this.radioButtonTimer.TabStop = true;
            this.radioButtonTimer.Text = "Timer";
            this.radioButtonTimer.UseVisualStyleBackColor = true;
            this.radioButtonTimer.Visible = false;
            this.radioButtonTimer.CheckedChanged += new System.EventHandler(this.radioButtonTimer_CheckedChanged);
            // 
            // buttonPreset4
            // 
            this.buttonPreset4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset4.FlatAppearance.BorderSize = 0;
            this.buttonPreset4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset4.Location = new System.Drawing.Point(275, 38);
            this.buttonPreset4.Name = "buttonPreset4";
            this.buttonPreset4.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset4.TabIndex = 6;
            this.buttonPreset4.Text = "four";
            this.buttonPreset4.UseVisualStyleBackColor = false;
            this.buttonPreset4.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonPreset3
            // 
            this.buttonPreset3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset3.FlatAppearance.BorderSize = 0;
            this.buttonPreset3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset3.Location = new System.Drawing.Point(193, 38);
            this.buttonPreset3.Name = "buttonPreset3";
            this.buttonPreset3.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset3.TabIndex = 5;
            this.buttonPreset3.Text = "three";
            this.buttonPreset3.UseVisualStyleBackColor = false;
            this.buttonPreset3.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonPreset2
            // 
            this.buttonPreset2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset2.FlatAppearance.BorderSize = 0;
            this.buttonPreset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset2.Location = new System.Drawing.Point(111, 38);
            this.buttonPreset2.Name = "buttonPreset2";
            this.buttonPreset2.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset2.TabIndex = 4;
            this.buttonPreset2.Text = "two";
            this.buttonPreset2.UseVisualStyleBackColor = false;
            this.buttonPreset2.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonPreset1
            // 
            this.buttonPreset1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset1.FlatAppearance.BorderSize = 0;
            this.buttonPreset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset1.Location = new System.Drawing.Point(29, 38);
            this.buttonPreset1.Name = "buttonPreset1";
            this.buttonPreset1.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset1.TabIndex = 3;
            this.buttonPreset1.Text = "one";
            this.buttonPreset1.UseVisualStyleBackColor = false;
            this.buttonPreset1.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSet.FlatAppearance.BorderSize = 0;
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet.Location = new System.Drawing.Point(234, 6);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 2;
            this.buttonSet.Text = "Se&t";
            this.buttonSet.UseVisualStyleBackColor = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Location = new System.Drawing.Point(152, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStartPause.FlatAppearance.BorderSize = 0;
            this.buttonStartPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartPause.Location = new System.Drawing.Point(70, 6);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(75, 23);
            this.buttonStartPause.TabIndex = 0;
            this.buttonStartPause.Text = "&Start";
            this.buttonStartPause.UseVisualStyleBackColor = false;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 21);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.pomodoroModeToolStripMenuItem,
            this.popupDingToolStripMenuItem,
            this.audioDingToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 120);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // pomodoroModeToolStripMenuItem
            // 
            this.pomodoroModeToolStripMenuItem.Name = "pomodoroModeToolStripMenuItem";
            this.pomodoroModeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pomodoroModeToolStripMenuItem.Text = "&Pomodoro Mode";
            this.pomodoroModeToolStripMenuItem.Click += new System.EventHandler(this.pomodoroModeToolStripMenuItem_Click);
            // 
            // popupDingToolStripMenuItem
            // 
            this.popupDingToolStripMenuItem.Name = "popupDingToolStripMenuItem";
            this.popupDingToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.popupDingToolStripMenuItem.Text = "Popup &Ding";
            this.popupDingToolStripMenuItem.Click += new System.EventHandler(this.popupDingToolStripMenuItem_Click);
            // 
            // audioDingToolStripMenuItem
            // 
            this.audioDingToolStripMenuItem.Name = "audioDingToolStripMenuItem";
            this.audioDingToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.audioDingToolStripMenuItem.Text = "&Audio Ding";
            this.audioDingToolStripMenuItem.Click += new System.EventHandler(this.audioDingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(384, 200);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 195);
            this.Name = "MainForm";
            this.Opacity = 0.85D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "countdown.net";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Button buttonPreset4;
        private System.Windows.Forms.Button buttonPreset3;
        private System.Windows.Forms.Button buttonPreset2;
        private System.Windows.Forms.Button buttonPreset1;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.RadioButton radioButtonStopwatch;
        private System.Windows.Forms.RadioButton radioButtonTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomodoroModeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem popupDingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioDingToolStripMenuItem;
        private System.Windows.Forms.Button buttonPreset8;
        private System.Windows.Forms.Button buttonPreset7;
        private System.Windows.Forms.Button buttonPreset6;
        private System.Windows.Forms.Button buttonPreset5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

