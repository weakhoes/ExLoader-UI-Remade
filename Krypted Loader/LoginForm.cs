using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace Krypted_Loader
{
    public partial class LoginForm : Form
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

        public LoginForm()
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

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            string usernameget = UsernameBox.Text;

            if (UsernameBox.Text == "")
            {
                LabelLogin.Location = new Point(269, 15);
                LabelLogin.Text = "Username Box Cannot Be Left Blank";
              
                await Task.Delay(1000);
                
                UsernameBox.Clear();
                PasswordBox.Clear();
            }

            if (PasswordBox.Text == "123")
            {
                LabelLogin.Location = new Point(280, 15);
                LabelLogin.Text = "Login Correct! Welcome " + usernameget;
                LabelLogin.Location = new Point(280, 15);
             
                await Task.Delay(1000);
              
                LabelLogin.Location = new Point(320, 15);
                LabelLogin.Text = "Loading... Please Wait!";
            
                await Task.Delay(1000);
             
                LoadingForm LF = new LoadingForm();
                this.Hide();
                LF.ShowDialog();
                this.Close();

            }
            else
            {
                LabelLogin.Location = new Point(277, 15);
                LabelLogin.Text = "Login Incorrect! Please Try Again...";
               
                await Task.Delay(100);
              
                UsernameBox.Clear();
                PasswordBox.Clear();
            }
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
    }
}
