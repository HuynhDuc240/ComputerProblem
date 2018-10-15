using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace Interface1
{
    public partial class home : Form
    {

        ConnectProlog connect;
        public home()
        {
            InitializeComponent();
            connect = new ConnectProlog();
        }
        private string resultQuery;
        private FlowLayoutPanel flp = new FlowLayoutPanel()
        {
            Location = new Point(100, 100),
        };
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void option1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Prolog file|*.pl";
            op.ShowDialog();
            String FilePath = op.FileName;
            connect.Load_file(FilePath);
            MessageBox.Show("Load file success !");
            this.startButton.Enabled = true;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            resultQuery = connect.Query("reason(X).");
            Thread.Sleep(500);
            //Controls.Add(flp);
            label1.Text = resultQuery;
            //this.Controls.Remove(startButton);
        }
    }
}
