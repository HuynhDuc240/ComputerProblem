using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Connect_Prolog;

namespace Interface1
{
    public partial class home : Form
    {
        public Connect_Prolog.ConnectProlog connect;

        public home()
        {
            InitializeComponent();
            connect = new ConnectProlog();
            string filePath1 = @"C:\Users\HuynhDuc\Desktop\ComputerProblem\Interface1\Interface1\bin\Debug\Diagnose.pl";
            connect.Load_file(filePath1);
            addCheckBoxs();
        }
        string filePath = "C:/Users/HuynhDuc/Desktop/ComputerProblem/Interface1/Interface1/bin/Debug/";
        private Dictionary<string, KeyValuePair<string, bool>> symptoms = new Dictionary<string, KeyValuePair<string, bool>>()
        {
                { "Đèn nguồn bật" , new KeyValuePair<string, bool>("led_on", false)},
                { "Quạt tản nhiệt bật", new KeyValuePair<string,bool>("fan_on", false) },
                { "Lỏng dây nguồn", new KeyValuePair<string, bool>("loose_wire", false)},
                { "Máy phát ra tiếng bip từng hồi và liên tục", new KeyValuePair<string,bool>("long_beep",false) },
                { "Không vào được hệ điều hành", new KeyValuePair<string,bool>("not_load_os", false) },
                { "Đèn ổ cứng tắt", new KeyValuePair<string, bool>("led_hard_drive_off", false) },
                { "Ổ cứng bẩn", new KeyValuePair<string, bool>("dirty_hard_drive", false) },
                { "Màn hình máy tính không hiển thị", new KeyValuePair<string, bool>("black_screen", false) },
        };

        private void addCheckBoxs()
        {
            int distanceCBox = 30;
            foreach (KeyValuePair<string, KeyValuePair<string, bool>> sym in symptoms)
            {
                CheckBox cb = new CheckBox()
                {
                    Location = new Point(100, distanceCBox),
                    Text = sym.Key,
                    AutoSize = true,
                    Font = new Font("Comic Sans MS", 15, FontStyle.Italic),
                };
                cb.CheckStateChanged += Cb_CheckStateChanged;
                distanceCBox += 40;
                panel1.Controls.Add(cb);
            }
        }

        private void Cb_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            symptoms[cb.Text] = new KeyValuePair<string, bool>(symptoms[cb.Text].Key, !symptoms[cb.Text].Value);
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
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files\swipl");
            Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + @";C:\Program Files\swipl\bin");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, KeyValuePair<string, bool>> sym in symptoms)
            {
                string value = sym.Value.Value ? "yes." : "no.";
                File.WriteAllText(filePath + sym.Value.Key, value);
            }
      
            String s = connect.Query("start(X).");
            this.txtResult.Text = s;
        }

        

    }
}
