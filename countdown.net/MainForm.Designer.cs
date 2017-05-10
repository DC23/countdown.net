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
            this.buttonPreset4 = new System.Windows.Forms.Button();
            this.buttonPreset3 = new System.Windows.Forms.Button();
            this.buttonPreset2 = new System.Windows.Forms.Button();
            this.buttonPreset1 = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.currentPracticeItem = new System.Windows.Forms.RichTextBox();
            this.practiceSessionGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practiceSessionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.uptimeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTimer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.currentPracticeItem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.practiceSessionGrid, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 657);
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
            this.panel1.Size = new System.Drawing.Size(378, 105);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 54);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // currentPracticeItem
            // 
            this.currentPracticeItem.BackColor = System.Drawing.Color.SteelBlue;
            this.currentPracticeItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPracticeItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentPracticeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPracticeItem.Location = new System.Drawing.Point(0, 185);
            this.currentPracticeItem.Margin = new System.Windows.Forms.Padding(0);
            this.currentPracticeItem.Name = "currentPracticeItem";
            this.currentPracticeItem.ReadOnly = true;
            this.currentPracticeItem.Size = new System.Drawing.Size(384, 428);
            this.currentPracticeItem.TabIndex = 4;
            this.currentPracticeItem.Text = "Aaron Shearer #27\n60 - 120 bpm\nWatch my left hand on the third bar";
            // 
            // practiceSessionGrid
            // 
            this.practiceSessionGrid.AllowUserToAddRows = false;
            this.practiceSessionGrid.AllowUserToDeleteRows = false;
            this.practiceSessionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.practiceSessionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.practiceSessionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.category,
            this.tempo,
            this.notes,
            this.time});
            this.practiceSessionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.practiceSessionGrid.Location = new System.Drawing.Point(387, 3);
            this.practiceSessionGrid.MultiSelect = false;
            this.practiceSessionGrid.Name = "practiceSessionGrid";
            this.practiceSessionGrid.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.practiceSessionGrid, 4);
            this.practiceSessionGrid.Size = new System.Drawing.Size(661, 651);
            this.practiceSessionGrid.TabIndex = 5;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // tempo
            // 
            this.tempo.HeaderText = "Tempo";
            this.tempo.Name = "tempo";
            this.tempo.ReadOnly = true;
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Location = new System.Drawing.Point(3, 644);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(35, 13);
            this.uptimeLabel.TabIndex = 13;
            this.uptimeLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1051, 657);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 195);
            this.Name = "MainForm";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "countdown.net";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.practiceSessionGrid)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Label uptimeLabel;
    }
}

