using MineSweeper.GUI;
using MineSweeper.GUI.Properties;

namespace frmMineSweeper
{
    public partial class frmMineSweeper : Form
    {
        private int xOffset;
        private int yOffset;
        private bool dragged = false;
        frmDraggingWindow draggingWindow = new frmDraggingWindow();


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

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draggingWindow.Show();
                xOffset = e.X;
                yOffset = e.Y;
                dragged = true;
            }

        }


        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragged = false;
            this.Location = new Point(draggingWindow.Location.X, draggingWindow.Location.Y);
            draggingWindow.Hide();
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragged == true)
            {
                int newLocationX = e.X - xOffset;
                int newLocationY = e.Y - yOffset;


                draggingWindow.Location = new Point(this.Location.X + newLocationX, this.Location.Y + newLocationY);

            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn != null)
            {

            }
            Application.Exit();
        }

        private void btnExit_MouseDown(object sender, MouseEventArgs e)
        {

            changeButtonState(sender, e, true);
        }

        private void btnExit_MouseUp(object sender, MouseEventArgs e)
        {
            changeButtonState(sender, e, false);
        }

        private void btnMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            changeButtonState(sender, e, true);
        }

        private void btnMinimize_MouseUp(object sender, MouseEventArgs e)
        {
            changeButtonState(sender, e, false);
        }

        private void changeButtonState(object sender, MouseEventArgs e, bool mouseDown)
        {

            var btn = sender as Button;

            if (btn != null && e.Button == MouseButtons.Left && mouseDown)
            {


                switch (btn.Name)
                {

                    case "btnExit":
                        btnExit.Image = new Bitmap(Resources.ExitButton_PressedState);
                        break;
                    case "btnMinimize":
                        btnMinimize.Image=new Bitmap(Resources.MinimizeButton_PressedState);
                        break;
                    default:
                        break;
                }

            }
            else if (btn != null && e.Button == MouseButtons.Left && !mouseDown)
            {
                switch (btn.Name)
                {

                    case "btnExit":
                        btnExit.Image = new Bitmap(Resources.ExitButtot_DefaultState);
                        Application.Exit();
                        break;
                    case "btnMinimize":
                        btnMinimize.Image=new Bitmap(Resources.MinimizeButton_DefaultState);
                        this.WindowState=FormWindowState.Minimized;
                        break;
                    default:
                        break;
                }
            }











        }

      
    }








}
