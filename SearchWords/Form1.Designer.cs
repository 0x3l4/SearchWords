namespace SearchWords
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            wordsTb = new TextBox();
            checkedListBox1 = new CheckedListBox();
            findModeLb = new Label();
            addWordBtn = new Button();
            wordsCb = new ComboBox();
            findBtn = new Button();
            wordPatternLb = new Label();
            wordPatternTb = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(wordsTb);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(checkedListBox1);
            splitContainer1.Panel2.Controls.Add(findModeLb);
            splitContainer1.Panel2.Controls.Add(addWordBtn);
            splitContainer1.Panel2.Controls.Add(wordsCb);
            splitContainer1.Panel2.Controls.Add(findBtn);
            splitContainer1.Panel2.Controls.Add(wordPatternLb);
            splitContainer1.Panel2.Controls.Add(wordPatternTb);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 506;
            splitContainer1.TabIndex = 1;
            // 
            // wordsTb
            // 
            wordsTb.BackColor = SystemColors.Control;
            wordsTb.Dock = DockStyle.Fill;
            wordsTb.Location = new Point(0, 0);
            wordsTb.Multiline = true;
            wordsTb.Name = "wordsTb";
            wordsTb.ScrollBars = ScrollBars.Vertical;
            wordsTb.Size = new Size(506, 450);
            wordsTb.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.White;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.ImeMode = ImeMode.On;
            checkedListBox1.Location = new Point(22, 36);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 7;
            // 
            // findModeLb
            // 
            findModeLb.AutoSize = true;
            findModeLb.ForeColor = SystemColors.ControlText;
            findModeLb.Location = new Point(19, 7);
            findModeLb.Name = "findModeLb";
            findModeLb.Size = new Size(109, 20);
            findModeLb.TabIndex = 6;
            findModeLb.Text = "Режим поиска";
            // 
            // addWordBtn
            // 
            addWordBtn.Location = new Point(176, 227);
            addWordBtn.Name = "addWordBtn";
            addWordBtn.Size = new Size(101, 29);
            addWordBtn.TabIndex = 4;
            addWordBtn.Text = "Добавить";
            addWordBtn.UseVisualStyleBackColor = true;
            addWordBtn.Click += addNewWordBtn_Click;
            // 
            // wordsCb
            // 
            wordsCb.BackColor = Color.White;
            wordsCb.FormattingEnabled = true;
            wordsCb.Location = new Point(19, 228);
            wordsCb.Name = "wordsCb";
            wordsCb.Size = new Size(151, 28);
            wordsCb.TabIndex = 0;
            wordsCb.SelectedIndexChanged += wordsCb_SelectedIndexChanged;
            // 
            // findBtn
            // 
            findBtn.Location = new Point(176, 193);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(101, 29);
            findBtn.TabIndex = 3;
            findBtn.Text = "Найти";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findWords_Click;
            // 
            // wordPatternLb
            // 
            wordPatternLb.AutoSize = true;
            wordPatternLb.ForeColor = Color.Black;
            wordPatternLb.Location = new Point(18, 172);
            wordPatternLb.Name = "wordPatternLb";
            wordPatternLb.Size = new Size(110, 20);
            wordPatternLb.TabIndex = 2;
            wordPatternLb.Text = "Паттерн слова";
            // 
            // wordPatternTb
            // 
            wordPatternTb.BackColor = Color.White;
            wordPatternTb.ForeColor = Color.Black;
            wordPatternTb.Location = new Point(18, 195);
            wordPatternTb.Name = "wordPatternTb";
            wordPatternTb.Size = new Size(152, 27);
            wordPatternTb.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Найти слово";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private ContextMenuStrip contextMenuStrip1;
        private Label wordPatternLb;
        private TextBox wordPatternTb;
        private Button findBtn;
        private Button addWordBtn;
        private ComboBox wordsCb;
        private TextBox wordsTb;
        private Label findModeLb;
        private CheckedListBox checkedListBox1;
    }
}
