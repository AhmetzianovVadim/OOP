using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab4
{
    public partial class Form1 : Form
    {
        Figure[] figures;
        private int p;

        private Circle circle;
        private Ellipse ellipse;
        private MyReсtangle rectangle;
        private Rhombus rhombus;
        private Square square;

        private Random randomint = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            figures = new Figure[10];
            button4.Enabled = false;
            pictureBox1.Image = null;
            for (int i = 0; i < 10; i++)
            {
                p = randomint.Next(0, 5);
                switch (p)
                {
                    case 0:
                        ellipse = new Ellipse();
                        ellipse.Show(pictureBox1);
                        figures[i] = ellipse;
                        button4.Enabled = true;
                        break;
                    case 1:
                        circle = new Circle();
                        circle.Show(pictureBox1);
                        figures[i] = circle;
                        break;
                    case 2:
                        rectangle = new MyReсtangle();
                        rectangle.Show(pictureBox1);
                        figures[i] = rectangle;
                        break;
                    case 3:
                        rhombus = new Rhombus();
                        rhombus.Show(pictureBox1);
                        figures[i] = rhombus;
                        break;
                    case 4:
                        square = new Square();
                        square.Show(pictureBox1);
                        figures[i] = square;
                        break;
                }
                System.Threading.Thread.Sleep(10);
            }
            EnableFunc();
        }
        private void EnableFunc()
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;
            checkBox10.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true)
            {
                ShowHide(2);
                UpDate();
            }
            else
            {
                MessageBox.Show("Нужно выбрать тип фигур!");
            }
        }
        private void ShowHide(int v)
        {
            if (v == 1)
            {
                foreach (Figure figure in figures)
                {
                    if (checkBox6.Checked == true)
                    {
                        if (figure is Circle)
                        {
                            if ((figure is Ellipse) == false)
                            {
                                figure.Visibility();
                            }
                        }
                    }
                    if (checkBox7.Checked == true)
                    {
                        if (figure is Ellipse)
                        {
                            figure.Visibility();
                        }
                    }
                    if (checkBox8.Checked == true)
                    {
                        if (figure is Square)
                        {
                            if ((figure is MyReсtangle) == false && (figure is Rhombus) == false)
                            {
                                figure.Visibility();
                            }
                        }
                    }
                    if (checkBox9.Checked == true)
                    {
                        if (figure is MyReсtangle)
                        {
                            figure.Visibility();
                        }
                    }
                    if (checkBox10.Checked == true)
                    {
                        if (figure is Rhombus)
                        {
                            figure.Visibility();
                        }
                    }
                }
            }
            if (v == 2)
            {
                foreach (Figure figure in figures)
                {
                    if (checkBox1.Checked == true)
                    {
                        if (figure is Circle)
                        {
                            if ((figure is Ellipse) == false)
                            {
                                figure.Visibility();
                            }
                        }
                    }
                    if (checkBox2.Checked == true)
                    {
                        if (figure is Ellipse)
                        {
                            figure.Visibility();
                        }
                    }
                    if (checkBox3.Checked == true)
                    {
                        if (figure is Square)
                        {
                            if ((figure is MyReсtangle) == false && (figure is Rhombus) == false)
                            {
                                figure.Visibility();
                            }
                        }
                    }
                    if (checkBox4.Checked == true)
                    {
                        if (figure is MyReсtangle)
                        {
                            figure.Visibility();
                        }
                    }
                    if (checkBox5.Checked == true)
                    {
                        if (figure is Rhombus)
                        {
                            figure.Visibility();
                        }
                    }
                }
            }
            if (v == 3)
            {
                foreach (Figure figure in figures)
                {
                    if (figure is Circle)
                    {
                        if ((figure is Ellipse) == false)
                        {
                            figure.Visibility();
                        }
                    }
                    if (figure is Ellipse)
                    {
                        figure.Visibility();
                    }
                    if (figure is Square)
                    {
                        if ((figure is MyReсtangle) == false && (figure is Rhombus) == false)
                        {
                            figure.Visibility();
                        }
                    }
                    if (figure is MyReсtangle)
                    {
                        figure.Visibility();
                    }
                    if (figure is Rhombus)
                    {
                        figure.Visibility();
                    }
                }
            }
        }
        private void MoveFigure(int dx, int dy, PictureBox pictureBox1)
        {
            foreach (Figure figure in figures)
            {
                if (checkBox6.Checked == true)
                {
                    if (figure is Circle)
                    {
                        if ((figure is Ellipse) == false)
                        {
                            figure.MoveTo(dx, dy, pictureBox1);
                        }
                    }
                }
                if (checkBox7.Checked == true)
                {
                    if (figure is Ellipse)
                    {
                        figure.MoveTo(dx, dy, pictureBox1);
                    }
                }
                if (checkBox8.Checked == true)
                {
                    if (figure is Square)
                    {
                        if ((figure is MyReсtangle) == false && (figure is Rhombus) == false)
                        {
                            figure.MoveTo(dx, dy, pictureBox1);
                        }
                    }
                }
                if (checkBox9.Checked == true)
                {
                    if (figure is MyReсtangle)
                    {
                        figure.MoveTo(dx, dy, pictureBox1);
                    }
                }
                if (checkBox10.Checked == true)
                {
                    if (figure is Rhombus)
                    {
                        figure.MoveTo(dx, dy, pictureBox1);
                    }
                }

            }
        }
        private void UpDate()
        {
            pictureBox1.Image = null;
            for (int j = 0; j < figures.Length; j++)
            {
                figures[j].Show(pictureBox1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true || checkBox9.Checked == true || checkBox10.Checked == true)
            {
                ShowHide(1);
                MoveFigure(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
                UpDate();
            }
            else 
            {
                MessageBox.Show("Нужно выбрать тип фигур!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Figure figure in figures)
            {
                if (figure is Ellipse)
                {
                    (figure as Ellipse).Rotate();   
                    UpDate();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            figures = null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (figures != null)
            {
                foreach (Figure figure in figures)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            UpDate();
                            figure.MoveTo(-10, 0, pictureBox1);
                            figure.Visibility();
                            break;
                        case Keys.D:
                            UpDate();
                            figure.MoveTo(10, 0, pictureBox1);
                            figure.Visibility();
                            break;
                        case Keys.S:
                            UpDate();
                            figure.MoveTo(0, 10, pictureBox1);
                            figure.Visibility();
                            break;
                        case Keys.W:
                            UpDate();
                            figure.MoveTo(0, -10, pictureBox1);
                            figure.Visibility();
                            break;
                    }
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (figures != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    foreach (Figure figure in figures)
                    {
                        figure.x = 0;
                        figure.y = 0;
                        figure.MoveTo(e.X, e.Y, pictureBox1);
                        figure.Visibility();
                        UpDate();
                    }
                }
            }
        }
    }
}
