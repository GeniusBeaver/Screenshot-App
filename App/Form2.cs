using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private Rectangle _rectangle;
        private Form1 _form1;
        private Bitmap _screenBitmap;

        private Point _startPoint;
        private Point _endPoint;
        private Rectangle _selectionRectangle;
        public Form2()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.BackColor = Color.DarkGray;

            // Обработка событий мыши на PictureBox
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);

            CaptureScreen();
        }

        bool isDragging = false;
        Point startPt;
        Point currentPt;

        private void Form2_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void CaptureScreen()
        {
            // Sleep(2000);
            _screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics graphics = Graphics.FromImage(_screenBitmap))
            {
                graphics.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);
            }
            pictureBox1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            pictureBox1.Image = _screenBitmap;
        }

        public Form1 Form1
        {
            set { _form1 = value; }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            if (_screenBitmap != null)
            {
                e.Graphics.DrawImage(_screenBitmap, 0, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = e.Location;

            _selectionRectangle.Location = e.Location;
            _selectionRectangle.Size = new Size();

            isDragging = true;
            startPt = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                currentPt = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _endPoint.X = e.X;
            _endPoint.Y = e.Y;

            _selectionRectangle = new Rectangle(Math.Min(_startPoint.X, _endPoint.X),
                                                    Math.Min(_startPoint.Y, _endPoint.Y),
                                                    Math.Abs(_startPoint.X - _endPoint.X),
                                                    Math.Abs(_startPoint.Y - _endPoint.Y));
            _form1.SetCoord(_selectionRectangle, _startPoint, _endPoint);

            isDragging = false;
            pictureBox1.Invalidate();

            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isDragging)
            {
                int x = Math.Min(startPt.X, currentPt.X);
                int y = Math.Min(startPt.Y, currentPt.Y);
                int width = Math.Abs(startPt.X - currentPt.X);
                int height = Math.Abs(startPt.Y - currentPt.Y);

                Rectangle rect = new Rectangle(x, y, width, height);
                e.Graphics.DrawRectangle(Pens.White, rect);
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e) { }
        private void Form2_MouseUp(object sender, MouseEventArgs e) { }
        private void Form2_MouseMove(object sender, MouseEventArgs e) { }
    }
}
