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
        public Form1()
        {
            InitializeComponent();
        }

        public class Part
        {
            public string PartName { get; set; }
            public int PartId { get; set; }
        }

        public static int redcolor = 0, greencolor = 0, bluecolor = 0;

        private int i = -1, k = -1, kcircle = -1, ksquare = -1, kellipse = -1, krectangle = -1, krhombus = -1;

        private List<Part> list = new List<Part>();
        private List<Circle> circlelist = new List<Circle>();
        private List<Square> squarelist = new List<Square>();
        private List<Ellipse> ellipselist = new List<Ellipse>();
        private List<MyReсtangle> rectanglelist = new List<MyReсtangle>();
        private List<Rhombus> rhombuslist = new List<Rhombus>();

        private Circle circle;
        private Square square;
        private Ellipse ellipse;
        private MyReсtangle rectangle;
        private Rhombus rhombus;

        private void UpDate()
        {
            pictureBox1.Image = null;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].PartName == "circle")
                {
                    circlelist[list[i].PartId].Show(pictureBox1);
                }
                else
                {
                    if (list[i].PartName == "square")
                    {
                        squarelist[list[i].PartId].Show(pictureBox1);
                    }
                    else
                    {
                        if (list[i].PartName == "ellipse")
                        {
                            ellipselist[list[i].PartId].Show(pictureBox1);
                        }
                        else
                        {
                            if (list[i].PartName == "rectangle")
                            {
                                rectanglelist[list[i].PartId].Show(pictureBox1);
                            }
                            else
                            {
                                if (list[i].PartName == "rhombus")
                                {
                                    rhombuslist[list[i].PartId].Show(pictureBox1);
                                }
                            }
                        }
                    }

                }
            }
        }

        private void EnableFunc()
        {
            if (button6.Enabled == false)
            {
                button6.Enabled = true;
                comboBox1.Enabled = true;
                button7.Enabled = true;
                comboBox2.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }

        private void EnableFunc1()
        {
            if (button15.Enabled == false)
            {
                button15.Enabled = true;
                comboBox3.Enabled = true;
            }
        }

        private void ListAddCircle()
        {
            kcircle++;
            circlelist.Add(circle);
            list.Add(new Part() { PartName = "circle", PartId = kcircle });
            i++;
            comboBox1.Items.Add(i + ". Circle(" + kcircle + ") R=" + circle.redcolor + " G=" + circle.greencolor + " B=" + circle.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Circle(" + kcircle + ")  R=" + circle.redcolor + " G=" + circle.greencolor + " B=" + circle.bluecolor);
            comboBox2.SelectedIndex = i;
        }
        private void ListAddSquare()
        {
            ksquare++;
            squarelist.Add(square);
            list.Add(new Part() { PartName = "square", PartId = ksquare });
            i++;
            comboBox1.Items.Add(i + ". Square(" + ksquare + ") R=" + square.redcolor + " G=" + square.greencolor + " B=" + square.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Square(" + ksquare + ")  R=" + square.redcolor + " G=" + square.greencolor + " B=" + square.bluecolor);
            comboBox2.SelectedIndex = i;
        }

        private void ListAddEllipse()
        {
            kellipse++;
            ellipselist.Add(ellipse);
            list.Add(new Part() { PartName = "ellipse", PartId = kellipse });
            i++;
            comboBox1.Items.Add(i + ". Ellipse(" + kellipse + ") R=" + ellipse.redcolor + " G=" + ellipse.greencolor + " B=" + ellipse.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Ellipse(" + kellipse + ")  R=" + ellipse.redcolor + " G=" + ellipse.greencolor + " B=" + ellipse.bluecolor);
            comboBox2.SelectedIndex = i;
            comboBox3.Items.Add(kellipse + ". Ellipse(" + kellipse + ") R=" + ellipse.redcolor + " G=" + ellipse.greencolor + " B=" + ellipse.bluecolor);
            comboBox3.SelectedIndex = kellipse;
        }

        private void ListAddRectangle()
        {
            krectangle++;
            rectanglelist.Add(rectangle);
            list.Add(new Part() { PartName = "rectangle", PartId = krectangle });
            i++;
            comboBox1.Items.Add(i + ". Rectangle(" + krectangle + ") R=" + rectangle.redcolor + " G=" + rectangle.greencolor + " B=" + rectangle.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Rectangle(" + krectangle + ")  R=" + rectangle.redcolor + " G=" + rectangle.greencolor + " B=" + rectangle.bluecolor);
            comboBox2.SelectedIndex = i;
        }
        private void ListAddRhombus()
        {
            krhombus++;
            rhombuslist.Add(rhombus);
            list.Add(new Part() { PartName = "rhombus", PartId = krhombus });
            i++;
            comboBox1.Items.Add(i + ". Rhombus(" + krhombus + ") R=" + rhombus.redcolor + " G=" + rhombus.greencolor + " B=" + rhombus.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Rhombus(" + krhombus + ")  R=" + rhombus.redcolor + " G=" + rhombus.greencolor + " B=" + rhombus.bluecolor);
            comboBox2.SelectedIndex = i;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            circle = new Circle(Convert.ToInt16(numericUpDown3.Value), Convert.ToInt16(numericUpDown4.Value), Convert.ToInt16(numericUpDown5.Value), true, redcolor, greencolor, bluecolor);
            circle.Show(pictureBox1);
            ListAddCircle();
            EnableFunc();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            square = new Square(Convert.ToInt16(numericUpDown12.Value), Convert.ToInt16(numericUpDown13.Value), Convert.ToInt16(numericUpDown14.Value), true, redcolor, greencolor, bluecolor);
            square.Show(pictureBox1);
            ListAddSquare();
            EnableFunc();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            k = comboBox3.SelectedIndex;
            ellipselist[k].Rotate();
            UpDate();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 colorsel = new Form2(this);
            colorsel.ShowDialog();
            button5.BackColor = Color.FromArgb(redcolor, greencolor, bluecolor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rhombus = new Rhombus(Convert.ToInt16(numericUpDown6.Value), Convert.ToInt16(numericUpDown7.Value), Convert.ToInt16(numericUpDown8.Value), Convert.ToInt16(numericUpDown9.Value), true, redcolor, greencolor, bluecolor);
            rhombus.Show(pictureBox1);
            ListAddRhombus();
            EnableFunc();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rhombus = new Rhombus();
            rhombus.Show(pictureBox1);
            ListAddRhombus();
            EnableFunc();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            k = comboBox1.SelectedIndex;
            ShowHide(k);
            UpDate();
            MoveFigure(k);
        }
        private void ShowHide(int k)
        {
            if (list[k].PartName == "circle")
            {
                circlelist[list[k].PartId].Visibility();
            }
            else
            {
                if (list[k].PartName == "square")
                {
                    squarelist[list[k].PartId].Visibility();
                }
                else
                {
                    if (list[k].PartName == "ellipse")
                    {
                        ellipselist[list[k].PartId].Visibility();
                    }
                    else
                    {
                        if (list[k].PartName == "rectangle")
                        {
                            rectanglelist[list[k].PartId].Visibility();
                        }
                        else
                        {
                            if (list[k].PartName == "rhombus")
                            {
                                rhombuslist[list[k].PartId].Visibility();
                            }
                        }
                    }
                }

            }
        }
        private void MoveFigure(int k)
        {
            if (list[k].PartName == "circle")
            {
                circlelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
            }
            else
            {
                if (list[k].PartName == "circle")
                {
                    circlelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
                }
                else
                {
                    if (list[k].PartName == "square")
                    {
                        squarelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
                    }
                    else
                    {
                        if (list[k].PartName == "ellipse")
                        {
                            ellipselist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
                        }
                        else
                        {
                            if (list[k].PartName == "rectangle")
                            {
                                rectanglelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
                            }
                            else
                            {
                                if (list[k].PartName == "rhombus")
                                {
                                    rhombuslist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), pictureBox1);
                                }
                            }
                        }
                    }

                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            k = comboBox2.SelectedIndex;
            ShowHide(k);
            UpDate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            circle = new Circle();
            circle.Show(pictureBox1);
            ListAddCircle();
            EnableFunc();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            square = new Square();
            square.Show(pictureBox1);
            ListAddSquare();
            EnableFunc();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ellipse = new Ellipse(Convert.ToInt16(numericUpDown16.Value), Convert.ToInt16(numericUpDown17.Value), Convert.ToInt16(numericUpDown18.Value), Convert.ToInt16(numericUpDown19.Value), true, redcolor, greencolor, bluecolor);
            ellipse.Show(pictureBox1);
            ListAddEllipse();
            EnableFunc();
            EnableFunc1();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ellipse = new Ellipse();
            ellipse.Show(pictureBox1);
            ListAddEllipse();
            EnableFunc();
            EnableFunc1();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            rectangle = new MyReсtangle(Convert.ToInt16(numericUpDown20.Value), Convert.ToInt16(numericUpDown21.Value), Convert.ToInt16(numericUpDown22.Value), Convert.ToInt16(numericUpDown23.Value), true, redcolor, greencolor, bluecolor);
            rectangle.Show(pictureBox1);
            ListAddRectangle();
            EnableFunc();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            rectangle = new MyReсtangle();
            rectangle.Show(pictureBox1);
            ListAddRectangle();
            EnableFunc();
        }
    }
}
