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
            msMenu.SuspendLayout();
            SuspendLayout();
            // 
            // msMenu
            // 
            msMenu.Items.AddRange(new ToolStripItem[] { tsmiGameMenu, tsmiHelp });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(303, 24);
            msMenu.TabIndex = 0;
            // 
            // tsmiGameMenu
            // 
            tsmiGameMenu.DropDownItems.AddRange(new ToolStripItem[] { tsmiGameNew, toolStripSeparator1, tsmiGameBeginner, tsmiGameIntermediate, tsmiGameExpert, tsmiGameCustom, toolStripSeparator2, tsmiGameMarks, tsmiGameColor, toolStripSeparator4, tsmiGameBestTimes, toolStripSeparator3, tsmiGameExit });
            tsmiGameMenu.Name = "tsmiGameMenu";
            tsmiGameMenu.Size = new Size(50, 20);
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
            tsmiHelp.Size = new Size(44, 20);
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
            // frmMineSweeper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 432);
            Controls.Add(msMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msMenu;
            Name = "frmMineSweeper";
            Text = "MineSweeper";
            Load += frmMineSweeper_Load;
            KeyUp += frmMineSweeper_KeyUp;
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
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
    }
}
