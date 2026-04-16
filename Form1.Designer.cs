namespace FileCompare
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            lvwLeftDir = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel2 = new Panel();
            txtLeftDir = new TextBox();
            btnLeftDir = new Button();
            panel1 = new Panel();
            lblAppName = new Label();
            btnCopyFromLeft = new Button();
            panel7 = new Panel();
            lvwRightDir = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panel6 = new Panel();
            txtRightDir = new TextBox();
            btnRightDir = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel7);
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(1023, 525);
            splitContainer1.SplitterDistance = 507;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvwLeftDir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(507, 363);
            panel3.TabIndex = 2;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(12, 6);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(482, 345);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            lvwLeftDir.DrawColumnHeader += lvwLeftDir_DrawColumnHeader;
            lvwLeftDir.DrawItem += lvwLeftDir_DrawItem;
            lvwLeftDir.DrawSubItem += lvwLeftDir_DrawSubItem;
            lvwLeftDir.SelectedIndexChanged += lvwLeftDir_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "이름";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "크기";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "수정일";
            columnHeader3.Width = 160;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtLeftDir);
            panel2.Controls.Add(btnLeftDir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 80);
            panel2.TabIndex = 1;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Location = new Point(30, 33);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(337, 31);
            txtLeftDir.TabIndex = 3;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeftDir.Location = new Point(382, 30);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(112, 34);
            btnLeftDir.TabIndex = 2;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAppName);
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 82);
            panel1.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.Olive;
            lblAppName.Location = new Point(30, 18);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(262, 57);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "File Compare";
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCopyFromLeft.Location = new Point(382, 41);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(112, 34);
            btnCopyFromLeft.TabIndex = 0;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(lvwRightDir);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 162);
            panel7.Name = "panel7";
            panel7.Size = new Size(512, 363);
            panel7.TabIndex = 3;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwRightDir.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            lvwRightDir.FullRowSelect = true;
            lvwRightDir.GridLines = true;
            lvwRightDir.Location = new Point(14, 6);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(482, 345);
            lvwRightDir.TabIndex = 1;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.View = View.Details;
            lvwRightDir.DrawColumnHeader += lvwRightDir_DrawColumnHeader;
            lvwRightDir.DrawItem += lvwRightDir_DrawItem;
            lvwRightDir.DrawSubItem += lvwRightDir_DrawSubItem;
            lvwRightDir.SelectedIndexChanged += lvwRightDir_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "이름";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "크기";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "수정일";
            columnHeader6.Width = 160;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtRightDir);
            panel6.Controls.Add(btnRightDir);
            panel6.Controls.Add(panel5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 82);
            panel6.Name = "panel6";
            panel6.Size = new Size(512, 80);
            panel6.TabIndex = 2;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Location = new Point(27, 32);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(337, 31);
            txtRightDir.TabIndex = 4;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRightDir.Location = new Point(384, 30);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(112, 34);
            btnRightDir.TabIndex = 3;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(522, 348);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCopyFromRight);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(512, 82);
            panel4.TabIndex = 0;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCopyFromRight.Location = new Point(27, 41);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(112, 34);
            btnCopyFromRight.TabIndex = 1;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1023, 525);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "File Compare v1.0";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private ListView lvwLeftDir;
        private TextBox txtLeftDir;
        private Button btnLeftDir;
        private Label lblAppName;
        private Button btnCopyFromLeft;
        private Panel panel7;
        private ListView lvwRightDir;
        private TextBox txtRightDir;
        private Button btnRightDir;
        private Button btnCopyFromRight;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}
