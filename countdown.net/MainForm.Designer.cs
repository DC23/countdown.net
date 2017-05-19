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
            this.buttonInc10Secs = new System.Windows.Forms.Button();
            this.buttonDec10Secs = new System.Windows.Forms.Button();
            this.buttonIncMinute = new System.Windows.Forms.Button();
            this.buttonDecMinute = new System.Windows.Forms.Button();
            this.buttonPreset8 = new System.Windows.Forms.Button();
            this.buttonPreset7 = new System.Windows.Forms.Button();
            this.buttonPreset6 = new System.Windows.Forms.Button();
            this.buttonPreset5 = new System.Windows.Forms.Button();
            this.buttonPreset4 = new System.Windows.Forms.Button();
            this.buttonPreset3 = new System.Windows.Forms.Button();
            this.buttonPreset2 = new System.Windows.Forms.Button();
            this.buttonPreset1 = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.practiceSessionGrid = new System.Windows.Forms.DataGridView();
            this.currentPracticeItem = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sequenceTimeSpinner = new System.Windows.Forms.NumericUpDown();
            this.buttonPomodoroSequence = new System.Windows.Forms.Button();
            this.buttonLoadSession = new System.Windows.Forms.Button();
            this.buttonGenerateSession = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practiceSessionGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTimeSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelTimer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.practiceSessionGrid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentPracticeItem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uptimeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 579);
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
            this.labelTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonInc10Secs);
            this.panel1.Controls.Add(this.buttonDec10Secs);
            this.panel1.Controls.Add(this.buttonIncMinute);
            this.panel1.Controls.Add(this.buttonDecMinute);
            this.panel1.Controls.Add(this.buttonPreset8);
            this.panel1.Controls.Add(this.buttonPreset7);
            this.panel1.Controls.Add(this.buttonPreset6);
            this.panel1.Controls.Add(this.buttonPreset5);
            this.panel1.Controls.Add(this.buttonPreset4);
            this.panel1.Controls.Add(this.buttonPreset3);
            this.panel1.Controls.Add(this.buttonPreset2);
            this.panel1.Controls.Add(this.buttonPreset1);
            this.panel1.Controls.Add(this.buttonSet);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonStartPause);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 118);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // buttonInc10Secs
            // 
            this.buttonInc10Secs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonInc10Secs.FlatAppearance.BorderSize = 0;
            this.buttonInc10Secs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInc10Secs.Location = new System.Drawing.Point(111, 35);
            this.buttonInc10Secs.Name = "buttonInc10Secs";
            this.buttonInc10Secs.Size = new System.Drawing.Size(75, 23);
            this.buttonInc10Secs.TabIndex = 16;
            this.buttonInc10Secs.Text = "+10 sec";
            this.buttonInc10Secs.UseVisualStyleBackColor = false;
            this.buttonInc10Secs.Click += new System.EventHandler(this.buttonInc10Secs_Click);
            // 
            // buttonDec10Secs
            // 
            this.buttonDec10Secs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDec10Secs.FlatAppearance.BorderSize = 0;
            this.buttonDec10Secs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDec10Secs.Location = new System.Drawing.Point(30, 35);
            this.buttonDec10Secs.Name = "buttonDec10Secs";
            this.buttonDec10Secs.Size = new System.Drawing.Size(75, 23);
            this.buttonDec10Secs.TabIndex = 15;
            this.buttonDec10Secs.Text = "-10 sec";
            this.buttonDec10Secs.UseVisualStyleBackColor = false;
            this.buttonDec10Secs.Click += new System.EventHandler(this.buttonDec10Secs_Click);
            // 
            // buttonIncMinute
            // 
            this.buttonIncMinute.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonIncMinute.FlatAppearance.BorderSize = 0;
            this.buttonIncMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIncMinute.Location = new System.Drawing.Point(275, 35);
            this.buttonIncMinute.Name = "buttonIncMinute";
            this.buttonIncMinute.Size = new System.Drawing.Size(75, 23);
            this.buttonIncMinute.TabIndex = 14;
            this.buttonIncMinute.Text = "+1 min";
            this.buttonIncMinute.UseVisualStyleBackColor = false;
            this.buttonIncMinute.Click += new System.EventHandler(this.buttonIncMinute_Click);
            // 
            // buttonDecMinute
            // 
            this.buttonDecMinute.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDecMinute.FlatAppearance.BorderSize = 0;
            this.buttonDecMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecMinute.Location = new System.Drawing.Point(193, 35);
            this.buttonDecMinute.Name = "buttonDecMinute";
            this.buttonDecMinute.Size = new System.Drawing.Size(75, 23);
            this.buttonDecMinute.TabIndex = 13;
            this.buttonDecMinute.Text = "-1 min";
            this.buttonDecMinute.UseVisualStyleBackColor = false;
            this.buttonDecMinute.Click += new System.EventHandler(this.buttonDecMinute_Click);
            // 
            // buttonPreset8
            // 
            this.buttonPreset8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset8.FlatAppearance.BorderSize = 0;
            this.buttonPreset8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset8.Location = new System.Drawing.Point(275, 92);
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
            this.buttonPreset7.Location = new System.Drawing.Point(193, 92);
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
            this.buttonPreset6.Location = new System.Drawing.Point(111, 92);
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
            this.buttonPreset5.Location = new System.Drawing.Point(30, 92);
            this.buttonPreset5.Name = "buttonPreset5";
            this.buttonPreset5.Size = new System.Drawing.Size(75, 23);
            this.buttonPreset5.TabIndex = 9;
            this.buttonPreset5.Text = "one";
            this.buttonPreset5.UseVisualStyleBackColor = false;
            this.buttonPreset5.Click += new System.EventHandler(this.buttonPreset_Click);
            // 
            // buttonPreset4
            // 
            this.buttonPreset4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPreset4.FlatAppearance.BorderSize = 0;
            this.buttonPreset4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreset4.Location = new System.Drawing.Point(275, 63);
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
            this.buttonPreset3.Location = new System.Drawing.Point(193, 63);
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
            this.buttonPreset2.Location = new System.Drawing.Point(111, 63);
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
            this.buttonPreset1.Location = new System.Drawing.Point(30, 63);
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
            // practiceSessionGrid
            // 
            this.practiceSessionGrid.AllowUserToAddRows = false;
            this.practiceSessionGrid.AllowUserToDeleteRows = false;
            this.practiceSessionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.practiceSessionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.practiceSessionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.practiceSessionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.practiceSessionGrid.Location = new System.Drawing.Point(403, 3);
            this.practiceSessionGrid.MultiSelect = false;
            this.practiceSessionGrid.Name = "practiceSessionGrid";
            this.practiceSessionGrid.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.practiceSessionGrid, 3);
            this.practiceSessionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.practiceSessionGrid.Size = new System.Drawing.Size(663, 538);
            this.practiceSessionGrid.TabIndex = 5;
            this.practiceSessionGrid.SelectionChanged += new System.EventHandler(this.practiceSessionGrid_SelectionChanged);
            // 
            // currentPracticeItem
            // 
            this.currentPracticeItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.currentPracticeItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPracticeItem.ContextMenuStrip = this.contextMenuStrip1;
            this.currentPracticeItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.currentPracticeItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentPracticeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPracticeItem.Location = new System.Drawing.Point(8, 206);
            this.currentPracticeItem.Margin = new System.Windows.Forms.Padding(8);
            this.currentPracticeItem.Name = "currentPracticeItem";
            this.currentPracticeItem.ReadOnly = true;
            this.currentPracticeItem.Size = new System.Drawing.Size(384, 330);
            this.currentPracticeItem.TabIndex = 4;
            this.currentPracticeItem.Text = "";
            this.currentPracticeItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 54);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "P&roperties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uptimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptimeLabel.Location = new System.Drawing.Point(0, 544);
            this.uptimeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(400, 35);
            this.uptimeLabel.TabIndex = 13;
            this.uptimeLabel.Text = "Uptime: 1:23";
            this.uptimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uptimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sequenceTimeSpinner);
            this.panel2.Controls.Add(this.buttonPomodoroSequence);
            this.panel2.Controls.Add(this.buttonLoadSession);
            this.panel2.Controls.Add(this.buttonGenerateSession);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(403, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 29);
            this.panel2.TabIndex = 14;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // sequenceTimeSpinner
            // 
            this.sequenceTimeSpinner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sequenceTimeSpinner.Location = new System.Drawing.Point(3, 6);
            this.sequenceTimeSpinner.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.sequenceTimeSpinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sequenceTimeSpinner.Name = "sequenceTimeSpinner";
            this.sequenceTimeSpinner.Size = new System.Drawing.Size(69, 16);
            this.sequenceTimeSpinner.TabIndex = 3;
            this.sequenceTimeSpinner.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.sequenceTimeSpinner.ValueChanged += new System.EventHandler(this.sequenceTimeSpinner_ValueChanged);
            this.sequenceTimeSpinner.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sequenceTimeSpinner_KeyUp);
            // 
            // buttonPomodoroSequence
            // 
            this.buttonPomodoroSequence.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPomodoroSequence.FlatAppearance.BorderSize = 0;
            this.buttonPomodoroSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPomodoroSequence.Location = new System.Drawing.Point(238, 3);
            this.buttonPomodoroSequence.Name = "buttonPomodoroSequence";
            this.buttonPomodoroSequence.Size = new System.Drawing.Size(75, 23);
            this.buttonPomodoroSequence.TabIndex = 2;
            this.buttonPomodoroSequence.Text = "&Pomodoro";
            this.buttonPomodoroSequence.UseVisualStyleBackColor = false;
            this.buttonPomodoroSequence.Click += new System.EventHandler(this.buttonPomodoroSequence_Click);
            // 
            // buttonLoadSession
            // 
            this.buttonLoadSession.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLoadSession.FlatAppearance.BorderSize = 0;
            this.buttonLoadSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadSession.Location = new System.Drawing.Point(157, 3);
            this.buttonLoadSession.Name = "buttonLoadSession";
            this.buttonLoadSession.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadSession.TabIndex = 1;
            this.buttonLoadSession.Text = "&Load";
            this.buttonLoadSession.UseVisualStyleBackColor = false;
            this.buttonLoadSession.Click += new System.EventHandler(this.buttonLoadSession_Click);
            // 
            // buttonGenerateSession
            // 
            this.buttonGenerateSession.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGenerateSession.FlatAppearance.BorderSize = 0;
            this.buttonGenerateSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateSession.Location = new System.Drawing.Point(75, 3);
            this.buttonGenerateSession.Name = "buttonGenerateSession";
            this.buttonGenerateSession.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateSession.TabIndex = 0;
            this.buttonGenerateSession.Text = "&Generate";
            this.buttonGenerateSession.UseVisualStyleBackColor = false;
            this.buttonGenerateSession.Click += new System.EventHandler(this.buttonGenerateSession_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1069, 579);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 240);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "countdown.net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.practiceSessionGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sequenceTimeSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonPreset8;
        private System.Windows.Forms.Button buttonPreset7;
        private System.Windows.Forms.Button buttonPreset6;
        private System.Windows.Forms.Button buttonPreset5;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox currentPracticeItem;
        private System.Windows.Forms.DataGridView practiceSessionGrid;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.Button buttonIncMinute;
        private System.Windows.Forms.Button buttonDecMinute;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLoadSession;
        private System.Windows.Forms.Button buttonGenerateSession;
        private System.Windows.Forms.Button buttonInc10Secs;
        private System.Windows.Forms.Button buttonDec10Secs;
        private System.Windows.Forms.Button buttonPomodoroSequence;
        private System.Windows.Forms.NumericUpDown sequenceTimeSpinner;
    }
}

