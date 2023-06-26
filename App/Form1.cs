using Microsoft.VisualBasic.Devices;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Rectangle _selectionRectangle;

        int clock = 1500;
        int ursa = 1;
        int zader = 2000;

        private NotifyIcon noti;
        private string initialpath = @"C:\Users\Pico\Desktop\screens";

        public Form1()
        {
            InitializeComponent();

            // Создание и добавление иконки в трей
            noti = new NotifyIcon();
            noti.Icon = SystemIcons.Application;
            noti.Text = "Keyboard Screenshot App";
            noti.Visible = true;
            textBox1.Text = "C:\\Users\\Pico\\Desktop\\screens";
            textBox2.Text = "1";
            textBox3.Text = "1";

        }

        public void SetCoord(Rectangle selectionRectangle, Point start, Point end)
        {
            _selectionRectangle = selectionRectangle;
        }

        private async void Screen_time()
        {
            await Task.Run(() =>
            {
                int i = 0;
                if (ursa != 1)
                {
                    Thread.Sleep(3000);
                }

                while (i != ursa)
                {
                    Thread.Sleep(clock);
                    string fileName = DateTime.Now.ToString("yyyyMMddTHHmmss") + ".png";
                    string filePath = Path.Combine(initialpath, fileName);
                    Bitmap screenShot = new Bitmap(_selectionRectangle.Width, _selectionRectangle.Height);
                    Graphics screenShotGraphics = Graphics.FromImage(screenShot);
                    screenShotGraphics.CopyFromScreen(_selectionRectangle.Location, Point.Empty, _selectionRectangle.Size);
                    // Сохранить скриншот в файл
                    screenShot.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                    ++i;
                }

            });
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                clock = Convert.ToInt32(textBox2.Text) * 1000;
            }

            if (textBox3.Text != "")
            {
                ursa = Convert.ToInt32(textBox3.Text);
            }

            if (textBox4.Text != "")
            {
                zader = Convert.ToInt32(textBox4.Text);
            }

            Screen_time();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Form1 = this;
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var path = dialog.SelectedPath;
                    initialpath = path;
                    textBox1.Text = initialpath;
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}