using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper.GUI
{
    public partial class frmDraggingWindow : Form
    {



        

        public frmDraggingWindow()
        {
            InitializeComponent();

        }

        //Drawing a border around the form
        private void frmDraggingWindow_Paint(object sender, PaintEventArgs e)
        {
            Pen dashedPen = new Pen(Color.Brown);
            dashedPen.DashStyle = DashStyle.Dash;
            e.Graphics.DrawRectangle(dashedPen,new Rectangle(0,0,this.Width-25,this.Height-50));
        }
    }
}
