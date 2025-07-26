using MineSweeper.GUI;

namespace frmMineSweeper
{
    public partial class frmMineSweeper : Form
    {
        public frmMineSweeper()
        {
            InitializeComponent();
        }

        private void frmMineSweeper_Load(object sender, EventArgs e)
        {

        }

        private void tsmiGameNew_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tsmiGameBestTimes_Click(object sender, EventArgs e)
        {
            ShowMenuStripForm(new frmBestTimes());
        }

        private void tsmiGameExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMineSweeper_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                tsmiGameNew_Click(sender, e);
        }

        private void aboutMineSweeperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMenuStripForm(new frmAboutMinesSweeper());
        }

        private void ShowMenuStripForm(Form frm)
        {
            frm.Show(this);
            frm.SetDesktopLocation(this.Location.X + 50, this.Location.Y + 140);
        }

        private void tsmiGameCustom_Click(object sender, EventArgs e)
        {
           ShowMenuStripForm(new frmCustomField());
        }
    }
}
