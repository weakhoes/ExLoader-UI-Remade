using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krypted_Loader
{
    public partial class LoadingForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRect
    (
        int leftRect,
        int topRect,
        int rightRect,
        int bottomRect,
        int widthEllipse,
        int heightEllipse
        );

        public LoadingForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRect(0, 0, Width, Height, 7, 7));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LoadingProgress1.Value += 1;
            if (LoadingProgress1.Value == 50)
            {
                MLabel.Location = new Point(312, 211);
                MLabel.Text = "Loading UI...";

                MLabelSub.Location = new Point(325, 248);
                MLabelSub.Text = "Loading UI Code";
            }
            if (LoadingProgress1.Value == 90)
            {
                MLabel.Location = new Point(306, 213);
                MLabel.Text = "Loading Done! ";

                MLabelSub.Location = new Point(263, 248);
                MLabelSub.Text = "Completed Loading And Checking Files!";
                
                DataLab.Text = "Data Processed!";
                DataLab.Location = new Point(330, 419);
            }
            if (LoadingProgress1.Value == 100)
            {
                timer1.Enabled = false;

                MainForm MF = new MainForm();
                this.Hide();
                MF.ShowDialog();
                this.Close();

            }
        }
    }
}
