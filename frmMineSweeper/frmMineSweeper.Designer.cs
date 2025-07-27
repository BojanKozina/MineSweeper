namespace frmMineSweeper
{
    partial class frmMineSweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMineSweeper));
            msMenu = new MenuStrip();
            tsmiGameMenu = new ToolStripMenuItem();
            tsmiGameNew = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiGameBeginner = new ToolStripMenuItem();
            tsmiGameIntermediate = new ToolStripMenuItem();
            tsmiGameExpert = new ToolStripMenuItem();
            tsmiGameCustom = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmiGameMarks = new ToolStripMenuItem();
            tsmiGameColor = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            tsmiGameBestTimes = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsmiGameExit = new ToolStripMenuItem();
            tsmiHelp = new ToolStripMenuItem();
            helpTopicsToolStripMenuItem = new ToolStripMenuItem();
            aboutMineSweeperToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlTitleBar = new Panel();
            pictureBox1 = new PictureBox();
            btnMinimize = new Button();
            btnResize = new Button();
            btnExit = new Button();
            msMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // msMenu
            // 
            msMenu.Items.AddRange(new ToolStripItem[] { tsmiGameMenu, tsmiHelp });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Padding = new Padding(6, 40, 0, 5);
            msMenu.Size = new Size(280, 64);
            msMenu.TabIndex = 0;
            // 
            // tsmiGameMenu
            // 
            tsmiGameMenu.DropDownItems.AddRange(new ToolStripItem[] { tsmiGameNew, toolStripSeparator1, tsmiGameBeginner, tsmiGameIntermediate, tsmiGameExpert, tsmiGameCustom, toolStripSeparator2, tsmiGameMarks, tsmiGameColor, toolStripSeparator4, tsmiGameBestTimes, toolStripSeparator3, tsmiGameExit });
            tsmiGameMenu.Name = "tsmiGameMenu";
            tsmiGameMenu.Size = new Size(50, 19);
            tsmiGameMenu.Text = "G̲ame";
            // 
            // tsmiGameNew
            // 
            tsmiGameNew.Name = "tsmiGameNew";
            tsmiGameNew.Size = new Size(170, 22);
            tsmiGameNew.Text = "N̲ew                    F2";
            tsmiGameNew.Click += tsmiGameNew_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(167, 6);
            // 
            // tsmiGameBeginner
            // 
            tsmiGameBeginner.Checked = true;
            tsmiGameBeginner.CheckOnClick = true;
            tsmiGameBeginner.CheckState = CheckState.Checked;
            tsmiGameBeginner.Name = "tsmiGameBeginner";
            tsmiGameBeginner.Size = new Size(170, 22);
            tsmiGameBeginner.Text = "B̲eginner";
            // 
            // tsmiGameIntermediate
            // 
            tsmiGameIntermediate.CheckOnClick = true;
            tsmiGameIntermediate.Name = "tsmiGameIntermediate";
            tsmiGameIntermediate.Size = new Size(170, 22);
            tsmiGameIntermediate.Text = "I̲ntermediate";
            // 
            // tsmiGameExpert
            // 
            tsmiGameExpert.CheckOnClick = true;
            tsmiGameExpert.Name = "tsmiGameExpert";
            tsmiGameExpert.Size = new Size(170, 22);
            tsmiGameExpert.Text = "E̲xpert";
            // 
            // tsmiGameCustom
            // 
            tsmiGameCustom.CheckOnClick = true;
            tsmiGameCustom.Name = "tsmiGameCustom";
            tsmiGameCustom.Size = new Size(170, 22);
            tsmiGameCustom.Text = "C̲ustom...";
            tsmiGameCustom.Click += tsmiGameCustom_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(167, 6);
            // 
            // tsmiGameMarks
            // 
            tsmiGameMarks.Checked = true;
            tsmiGameMarks.CheckOnClick = true;
            tsmiGameMarks.CheckState = CheckState.Checked;
            tsmiGameMarks.Name = "tsmiGameMarks";
            tsmiGameMarks.Size = new Size(170, 22);
            tsmiGameMarks.Text = "M̲arks (?)";
            // 
            // tsmiGameColor
            // 
            tsmiGameColor.Checked = true;
            tsmiGameColor.CheckOnClick = true;
            tsmiGameColor.CheckState = CheckState.Checked;
            tsmiGameColor.Name = "tsmiGameColor";
            tsmiGameColor.Size = new Size(170, 22);
            tsmiGameColor.Text = "Color";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(167, 6);
            // 
            // tsmiGameBestTimes
            // 
            tsmiGameBestTimes.Name = "tsmiGameBestTimes";
            tsmiGameBestTimes.Size = new Size(170, 22);
            tsmiGameBestTimes.Text = "Best T̲imes";
            tsmiGameBestTimes.Click += tsmiGameBestTimes_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(167, 6);
            // 
            // tsmiGameExit
            // 
            tsmiGameExit.Name = "tsmiGameExit";
            tsmiGameExit.Size = new Size(170, 22);
            tsmiGameExit.Text = "Ex̲it";
            tsmiGameExit.Click += tsmiGameExit_Click;
            // 
            // tsmiHelp
            // 
            tsmiHelp.DropDownItems.AddRange(new ToolStripItem[] { helpTopicsToolStripMenuItem, aboutMineSweeperToolStripMenuItem });
            tsmiHelp.Name = "tsmiHelp";
            tsmiHelp.Size = new Size(44, 19);
            tsmiHelp.Text = "H̲elp";
            // 
            // helpTopicsToolStripMenuItem
            // 
            helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
            helpTopicsToolStripMenuItem.Size = new Size(181, 22);
            helpTopicsToolStripMenuItem.Text = "H̲elp Topics";
            // 
            // aboutMineSweeperToolStripMenuItem
            // 
            aboutMineSweeperToolStripMenuItem.Name = "aboutMineSweeperToolStripMenuItem";
            aboutMineSweeperToolStripMenuItem.Size = new Size(181, 22);
            aboutMineSweeperToolStripMenuItem.Text = "A̲bout MineSweeper";
            aboutMineSweeperToolStripMenuItem.Click += aboutMineSweeperToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.DarkBlue;
            pnlTitleBar.Controls.Add(pictureBox1);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnResize);
            pnlTitleBar.Controls.Add(btnExit);
            pnlTitleBar.Location = new Point(4, 3);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(272, 27);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            pnlTitleBar.MouseUp += pnlTitleBar_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 18);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = MineSweeper.GUI.Properties.Resources.MinimizeButton_DefaultState;
            btnMinimize.Location = new Point(213, 6);
            btnMinimize.Margin = new Padding(0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(16, 16);
            btnMinimize.TabIndex = 4;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.MouseDown += btnMinimize_MouseDown;
            btnMinimize.MouseUp += btnMinimize_MouseUp;
            // 
            // btnResize
            // 
            btnResize.BackColor = Color.Transparent;
            btnResize.Enabled = false;
            btnResize.FlatAppearance.BorderSize = 0;
            btnResize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnResize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnResize.FlatStyle = FlatStyle.Flat;
            btnResize.Image = MineSweeper.GUI.Properties.Resources.ResizeButton_DisabledState;
            btnResize.Location = new Point(230, 6);
            btnResize.Margin = new Padding(0);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(16, 16);
            btnResize.TabIndex = 3;
            btnResize.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = MineSweeper.GUI.Properties.Resources.ExitButtot_DefaultState;
            btnExit.Location = new Point(250, 6);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(16, 16);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.MouseDown += btnExit_MouseDown;
            btnExit.MouseUp += btnExit_MouseUp;
            // 
            // frmMineSweeper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(280, 412);
            Controls.Add(pnlTitleBar);
            Controls.Add(msMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msMenu;
            Name = "frmMineSweeper";
            Text = "MineSweeper";
            Load += frmMineSweeper_Load;
            KeyUp += frmMineSweeper_KeyUp;
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMenu;
        private ToolStripMenuItem tsmiGameMenu;
        private ToolStripMenuItem tsmiHelp;
        private ToolStripMenuItem tsmiGameNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiGameBeginner;
        private ToolStripMenuItem tsmiGameIntermediate;
        private ToolStripMenuItem tsmiGameExpert;
        private ToolStripMenuItem tsmiGameCustom;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmiGameMarks;
        private ToolStripMenuItem tsmiGameColor;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsmiGameBestTimes;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tsmiGameExit;
        private ToolStripMenuItem helpTopicsToolStripMenuItem;
        private ToolStripMenuItem aboutMineSweeperToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Panel pnlTitleBar;
        private Button btnExit;
        private Button btnResize;
        private Button btnMinimize;
        private PictureBox pictureBox1;
    }
}
