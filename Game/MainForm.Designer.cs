namespace Game
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelForCheckRowCol = new System.Windows.Forms.Panel();
            this.textBoxColums = new System.Windows.Forms.TextBox();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.checkBoxDefine = new System.Windows.Forms.CheckBox();
            this.panelSpeed = new System.Windows.Forms.Panel();
            this.radioButtonFast = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonSlow = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelForCheckRowCol.SuspendLayout();
            this.panelSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(726, 330);
            this.splitContainer.SplitterDistance = 496;
            this.splitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panelForCheckRowCol, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelSpeed, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonStart, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.87879F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.24242F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.57576F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(226, 330);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panelForCheckRowCol
            // 
            this.panelForCheckRowCol.Controls.Add(this.textBoxColums);
            this.panelForCheckRowCol.Controls.Add(this.textBoxRows);
            this.panelForCheckRowCol.Controls.Add(this.label2);
            this.panelForCheckRowCol.Controls.Add(this.labelRows);
            this.panelForCheckRowCol.Controls.Add(this.checkBoxDefine);
            this.panelForCheckRowCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForCheckRowCol.Location = new System.Drawing.Point(3, 3);
            this.panelForCheckRowCol.Name = "panelForCheckRowCol";
            this.panelForCheckRowCol.Size = new System.Drawing.Size(220, 119);
            this.panelForCheckRowCol.TabIndex = 0;
            // 
            // textBoxColums
            // 
            this.textBoxColums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxColums.Location = new System.Drawing.Point(78, 78);
            this.textBoxColums.Name = "textBoxColums";
            this.textBoxColums.Size = new System.Drawing.Size(52, 26);
            this.textBoxColums.TabIndex = 4;
            this.textBoxColums.Text = "5";
            this.textBoxColums.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRows
            // 
            this.textBoxRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRows.Location = new System.Drawing.Point(78, 45);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(52, 26);
            this.textBoxRows.TabIndex = 3;
            this.textBoxRows.Text = "5";
            this.textBoxRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colums";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRows.Location = new System.Drawing.Point(4, 48);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(49, 20);
            this.labelRows.TabIndex = 1;
            this.labelRows.Text = "Rows";
            // 
            // checkBoxDefine
            // 
            this.checkBoxDefine.AutoSize = true;
            this.checkBoxDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDefine.Location = new System.Drawing.Point(4, 10);
            this.checkBoxDefine.Name = "checkBoxDefine";
            this.checkBoxDefine.Size = new System.Drawing.Size(206, 21);
            this.checkBoxDefine.TabIndex = 0;
            this.checkBoxDefine.Text = "Define Rows and Colums";
            this.checkBoxDefine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDefine.UseVisualStyleBackColor = true;
            this.checkBoxDefine.CheckedChanged += new System.EventHandler(this.State);
            this.checkBoxDefine.CheckStateChanged += new System.EventHandler(this.State);
            // 
            // panelSpeed
            // 
            this.panelSpeed.Controls.Add(this.radioButtonFast);
            this.panelSpeed.Controls.Add(this.radioButtonNormal);
            this.panelSpeed.Controls.Add(this.radioButtonSlow);
            this.panelSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSpeed.Location = new System.Drawing.Point(3, 128);
            this.panelSpeed.Name = "panelSpeed";
            this.panelSpeed.Size = new System.Drawing.Size(220, 140);
            this.panelSpeed.TabIndex = 1;
            // 
            // radioButtonFast
            // 
            this.radioButtonFast.AutoSize = true;
            this.radioButtonFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFast.Location = new System.Drawing.Point(32, 73);
            this.radioButtonFast.Name = "radioButtonFast";
            this.radioButtonFast.Size = new System.Drawing.Size(63, 24);
            this.radioButtonFast.TabIndex = 2;
            this.radioButtonFast.Text = "Fast";
            this.radioButtonFast.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNormal.Location = new System.Drawing.Point(32, 42);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(83, 24);
            this.radioButtonNormal.TabIndex = 1;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonSlow
            // 
            this.radioButtonSlow.AutoSize = true;
            this.radioButtonSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSlow.Location = new System.Drawing.Point(32, 12);
            this.radioButtonSlow.Name = "radioButtonSlow";
            this.radioButtonSlow.Size = new System.Drawing.Size(65, 24);
            this.radioButtonSlow.TabIndex = 0;
            this.radioButtonSlow.Text = "Slow";
            this.radioButtonSlow.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(3, 274);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(220, 53);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.TickTock);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 330);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelForCheckRowCol.ResumeLayout(false);
            this.panelForCheckRowCol.PerformLayout();
            this.panelSpeed.ResumeLayout(false);
            this.panelSpeed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelForCheckRowCol;
        private System.Windows.Forms.TextBox textBoxColums;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.CheckBox checkBoxDefine;
        private System.Windows.Forms.Panel panelSpeed;
        private System.Windows.Forms.RadioButton radioButtonFast;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonSlow;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerTime;
    }
}

