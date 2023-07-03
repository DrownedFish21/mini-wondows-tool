namespace Desktop_Tool
{
    partial class FrmMain
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
            StateCtrlBtn = new Button();
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            delete = new ToolStripMenuItem();
            openFileRode = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // StateCtrlBtn
            // 
            StateCtrlBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            StateCtrlBtn.Cursor = Cursors.Hand;
            StateCtrlBtn.Location = new Point(-1, -1);
            StateCtrlBtn.Name = "StateCtrlBtn";
            StateCtrlBtn.Size = new Size(26, 901);
            StateCtrlBtn.TabIndex = 0;
            StateCtrlBtn.Text = "》";
            StateCtrlBtn.UseVisualStyleBackColor = true;
            StateCtrlBtn.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(31, -5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(637, 905);
            listBox1.TabIndex = 1;
            listBox1.MouseClick += listBox1_MouseClick;
            listBox1.DragDrop += listBox1_DragDrop;
            listBox1.DragEnter += listBox1_DragEnter;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.LightGray;
            contextMenuStrip1.BackgroundImageLayout = ImageLayout.None;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { delete, openFileRode });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(124, 48);
            // 
            // delete
            // 
            delete.Name = "delete";
            delete.Size = new Size(123, 22);
            delete.Text = "删除";
            delete.Click += delete_Click;
            // 
            // openFileRode
            // 
            openFileRode.Name = "openFileRode";
            openFileRode.Size = new Size(123, 22);
            openFileRode.Text = "打开文件位置";
            openFileRode.Click += openFileRode_Click;
            // 
            // FrmMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(680, 900);
            ControlBox = false;
            Controls.Add(listBox1);
            Controls.Add(StateCtrlBtn);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1300, 100);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Opacity = 0.4D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "FrmMain";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button StateCtrlBtn;
        private ListBox listBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem delete;
        private ToolStripMenuItem openFileRode;
    }
}