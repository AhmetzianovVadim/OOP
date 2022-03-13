using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewOOP_Lab4;

namespace NewOOP_Lab7Library
{
    public partial class Form1 : Form
    {
        private int i = -1, j = -1, p;
        private string currentFigure;
        private MyArray myArray;
        private LinkedList linkedList;

        private Circle circle;
        private Ellipse ellipse;
        private Square square;
        private MyReсtangle rectangle;
        private Rhombus rhombus;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button5.Enabled = true;
            if (radioButton1.Checked == true)
            {
                if (myArray == null)
                    myArray = new MyArray();
                else MessageBox.Show("Array уже существует");
            }
            else if (radioButton2.Checked)
                if (linkedList == null)
                    linkedList = new LinkedList();
                else MessageBox.Show("List уже существует");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (myArray != null)
                {
                    myArray.Delete();
                    myArray = null;
                    comboBox1.SelectedIndex = -1;
                    comboBox1.Items.Clear();
                    comboBox1.Enabled = false;
                    i = -1;
                    pictureBox1.Image = null;
                }
                else MessageBox.Show("Array уже удалён, либо не создан");
            }
            else if (radioButton2.Checked == true)
            {
                if (linkedList != null)
                {
                    linkedList.Clear();
                    linkedList = null;
                    comboBox2.SelectedIndex = -1;
                    comboBox2.Items.Clear();
                    comboBox2.Enabled = false;
                    j = -1;
                    pictureBox1.Image = null;
                }
                else MessageBox.Show("List уже удалён, либо не создан");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (myArray != null)
                {
                    groupBox3.Enabled = true;
                    comboBox1.Enabled = true;
                    AddFigure();
                    i++;
                    comboBox1.Items.Add(i + "." + currentFigure + " array");
                    comboBox1.SelectedIndex = i;
                }
                else MessageBox.Show("Убедитесь, что Array создан");
            }
            else if (radioButton2.Checked)
            {
                if (linkedList != null)
                {
                    groupBox3.Enabled = true;
                    comboBox2.Enabled = true;
                    AddFigure();
                    j++;
                    comboBox2.Items.Add(j + "." + currentFigure + " list");
                    comboBox2.SelectedIndex = j;
                }
                else MessageBox.Show("Убедитесь, что List создан");
            }
        }
        private void AddFigure()
        {
            Random randomint = new Random(); 
            p = randomint.Next(0, 5);
            switch (p)
            {
                case 0:
                    circle = new Circle();
                    circle.Visibility();
                    currentFigure = "circle";
                    ListAddFigure(circle);
                    break;
                case 1:
                    ellipse = new Ellipse();
                    ListAddFigure(ellipse);
                    ellipse.Visibility();
                    currentFigure = "ellipse";
                    break;
                case 2:
                    square = new Square();
                    ListAddFigure(square);
                    square.Visibility();
                    currentFigure = "square";
                    break;
                case 3:
                    rectangle = new MyReсtangle();
                    ListAddFigure(rectangle);
                    rectangle.Visibility();
                    currentFigure = "rectangle";
                    break;
                case 4:
                    rhombus = new Rhombus();
                    ListAddFigure(rhombus);
                    rhombus.Visibility();
                    currentFigure = "rhombus";
                    break;
            
            }
        }
        private void ListAddFigure(Figure figure)
        {
            if (radioButton1.Checked == true)
                myArray.Add(figure);
            if (radioButton2.Checked == true)
                linkedList.Add(figure);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                if (myArray != null)
                {
                    ShowHide();
                    UpDate();
                }
                else MessageBox.Show("Убедитесь, что MyArray создан");
            else if (radioButton2.Checked)
                if (linkedList != null)
                {
                    ShowHide();
                    UpDate();
                }
                else MessageBox.Show("Убедитесь, что LinkedList создан");
        }
        private void ShowHide()
        { 
            if (radioButton1.Checked == true)
                foreach (Figure figure in myArray)
                    figure.Visibility();
            if (radioButton2.Checked == true )
                foreach (Figure figure1 in linkedList)
                    figure1.Visibility();
        }
        public void UpDate() 
        {
            pictureBox1.Image = null;
            if (radioButton1.Checked == true)
                foreach (Figure figure in myArray)
                    figure.Show(pictureBox1);
            else if (radioButton2.Checked)
                foreach (Figure figure1 in linkedList)
                    figure1.Show(pictureBox1);
            
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                if (myArray != null)
                {
                    ShowHide();
                    MoveFigure(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
                    UpDate();
                }
                else MessageBox.Show("Убедитесь, что Array создан");
            else if (radioButton2.Checked)
                if (linkedList != null)
                {
                    ShowHide();
                    MoveFigure(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
                    UpDate();
                }
                else MessageBox.Show("Убедитесь что LinkedList создан");
        }
        private void MoveFigure(int x, int y, PictureBox pictureBox1)
        {
            if (radioButton1.Checked)
                foreach (Figure figure in myArray)
                    figure.MoveTo(x, y, pictureBox1);
            else if (radioButton2.Checked)
                foreach (Figure figure1 in linkedList)
                    figure1.MoveTo(x, y, pictureBox1);
        }
    }
}
