using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimitiveLibrary1;
namespace Laba1
{
    public partial class Form1 : Form
    {
        public class Part
        {
            public string PartName { get; set; }
            public int PartId { get; set; }
        }

        public static int redcolor { get; set; }
        public static int greencolor { get; set; }
        public static int bluecolor { get; set; }
        private int i = -1, k = -1, kcircle = -1, kline = -1, krectangle = -1;

        private Circle circle;
        private Line line;
        private MyRectangle rectangle;

        private List<Part> list = new List<Part>();
        private List<Circle> circles = new List<Circle>();
        private List<Line> lines = new List<Line>();
        private List<MyRectangle> rectangles = new List<MyRectangle>();

        private Circle[] arrcircles = new Circle[10];
        private Line[] arrlines = new Line[10];
        private MyRectangle[] arrrectangles = new MyRectangle[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void rndLine_Click(object sender, EventArgs e)
        {
            line = new Line();
            line.Show(pictureBox1);
            ListAddLine();
            EnableFunc();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            line = new Line(Convert.ToInt16(numericUpDown6.Value), Convert.ToInt16(numericUpDown7.Value), Convert.ToInt16(numericUpDown8.Value), Convert.ToInt16(numericUpDown9.Value), true, redcolor, greencolor, bluecolor);
            line.Show(pictureBox1);
            ListAddLine();
            EnableFunc();
        }

        private void rndRectangle_Click(object sender, EventArgs e)
        {
            rectangle = new MyRectangle();
            rectangle.Show(pictureBox1);
            ListAddRectangle();
            EnableFunc();
        }
        private void Rectangle_Click(object sender, EventArgs e)
        {
            rectangle = new MyRectangle(Convert.ToInt16(numericUpDown10.Value), Convert.ToInt16(numericUpDown11.Value), Convert.ToInt16(numericUpDown12.Value), Convert.ToInt16(numericUpDown13.Value), true, redcolor, greencolor, bluecolor);
            rectangle.Show(pictureBox1);
            ListAddRectangle();
            EnableFunc();
        }
        private void rndCircle_Click(object sender, EventArgs e)
        {
            circle = new Circle();
            circle.Show(pictureBox1);
            ListAddCircle();
            EnableFunc();
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            circle = new Circle(Convert.ToInt16(numericUpDown3.Value), Convert.ToInt16(numericUpDown4.Value), Convert.ToInt16(numericUpDown5.Value), true, redcolor, greencolor, bluecolor);
            circle.Show(pictureBox1);
            ListAddCircle();
            EnableFunc();
        }

        private void ListAddCircle()
        {
            kcircle++;
            circles.Add(circle);
            list.Add(new Part() { PartName = "circle", PartId = kcircle });
            i++;
            comboBox1.Items.Add(i + ". Circle(" + kcircle + ")");
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Circle(" + kcircle + ")");
            comboBox2.SelectedIndex = i;
            comboBox3.Items.Add(i + ". Circle(" + kcircle + ")");
            comboBox3.SelectedIndex = i;
        }
        public void ListAddLine()
        {
            kline++;
            lines.Add(line);
            list.Add(new Part() { PartName = "line", PartId = kline });
            i++;
            comboBox1.Items.Add(i + ". Line(" + kline + ")");
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Line(" + kline + ")");
            comboBox2.SelectedIndex = i;
            comboBox3.Items.Add(i + ". Line(" + kline + ")");
            comboBox3.SelectedIndex = i;
        }
        private void ListAddRectangle()
        {
            krectangle++;
            rectangles.Add(rectangle);
            list.Add(new Part() { PartName = "rectangle", PartId = krectangle });
            i++;
            comboBox1.Items.Add(i + ". Rectangle(" + krectangle + ")");
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Rectangle(" + krectangle + ")");
            comboBox2.SelectedIndex = i;
            comboBox3.Items.Add(i + ". Rectangle(" + krectangle + ")");
            comboBox3.SelectedIndex = i;
        }
        private void EnableFunc()
        {
            groupBoxMoving.Enabled = true;
            groupBoxVisibility.Enabled = true;
        }

        private void UpDate()
        {
            pictureBox1.Image = null;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].PartName == "circle")
                {
                    circles[list[i].PartId].Show(pictureBox1);
                }
                else
                {
                    if (list[i].PartName == "line")
                    {
                        lines[list[i].PartId].Show(pictureBox1);
                    }
                    else
                    {
                        if (list[i].PartName == "rectangle")
                        {
                            rectangles[list[i].PartId].Show(pictureBox1);
                        }
                    }
                }
            }
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            k = comboBox1.SelectedIndex;
            if (list[k].PartName == "circle")
            {
                circles[list[k].PartId].Move(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
            }
            else
            {
                if (list[k].PartName == "line")
                {
                    lines[list[k].PartId].Move(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
                }
                else
                {
                    if (list[k].PartName == "rectangle")
                    {
                        rectangles[list[k].PartId].Move(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
                    }
                }
            }
            UpDate();
        }

        private void btnVisibility_Click(object sender, EventArgs e)
        {
            k = comboBox2.SelectedIndex;
            if (list[k].PartName == "circle")
            {
                circles[list[k].PartId].Visibility();
            }
            else
            {
                if (list[k].PartName == "rectangle")
                {
                    rectangles[list[k].PartId].Visibility();
                }
                else
                {
                    if (list[k].PartName == "line")
                    {
                        lines[list[k].PartId].Visibility();
                    }
                }
            }
            UpDate();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                UpDate();
                if (comboBox1.Items.Count == 0)
                {
                    groupBoxMoving.Enabled = false;
                    groupBoxVisibility.Enabled = false;
                }
                else
                {
                    groupBoxMoving.Enabled = true;
                    groupBoxVisibility.Enabled = true;
                }
                btnSelect.Visible = true;
                btnState.Visible = true;
                label14.Visible = true;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                arrUpDate();
                groupBoxMoving.Enabled = false;
                groupBoxVisibility.Enabled = false;
                btnSelect.Visible = false;
                btnState.Visible = false;
                label14.Visible = false;
            }
            if (tabControl1.SelectedIndex == 2)
            {
                UpDate();
                if (comboBox3.Items.Count != 0)
                {
                    btnChangeRadius.Enabled = true;
                    comboBox3.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    numericUpDown16.Enabled = true;
                    numericUpDown17.Enabled = true;
                    numericUpDown18.Enabled = true;
                    numericUpDown19.Enabled = true;
                }
                else
                {
                    comboBox3.Enabled = false;
                    btnChangeRadius.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    numericUpDown16.Enabled = false;
                    numericUpDown17.Enabled = false;
                    numericUpDown18.Enabled = false;
                    numericUpDown19.Enabled = false;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Form2 colorForm = new Form2();
            colorForm.ShowDialog();
            btnState.BackColor = Color.FromArgb(redcolor, greencolor, bluecolor);
        }

        private void arrCirc_Click(object sender, EventArgs e)
        {
            radioCircle.Enabled = true;
            for (int j = 0; j < 10; j++)
            {
                arrcircles[j] = new Circle();
                arrcircles[j].Show(pictureBox1);
            }
            arrUpDate();
        }

        private void arrLine_Click(object sender, EventArgs e)
        {
            radioLine.Enabled = true;
            for (int m = 0; m < 10; m++)
            {
                arrlines[m] = new Line();
                arrlines[m].Show(pictureBox1);

            }
            arrUpDate();
        }
        private void arrRect_Click(object sender, EventArgs e)
        {
            radioRectangle.Enabled = true;
            for (int n = 0; n < 10; n++)
            {
                arrrectangles[n] = new MyRectangle();
                arrrectangles[n].Show(pictureBox1);
            }
            arrUpDate();
        }

        private void arrUpDate()
        {
            pictureBox1.Image = null;
            for (int p = 0; p < 10; p++)
            {
                if (arrcircles[p] != null)
                    arrcircles[p].Show(pictureBox1);
                if (arrlines[p] != null)
                    arrlines[p].Show(pictureBox1);
                if (arrrectangles[p] != null)
                    arrrectangles[p].Show(pictureBox1);
            }
        }

        private void btnArrMove_Click(object sender, EventArgs e)
        {
            if (radioCircle.Checked == true)
            {
                for (int ci = 0; ci < 10; ci++)
                {
                    arrcircles[ci].Move(Convert.ToInt16(numericUpDown14.Value), Convert.ToInt16(numericUpDown15.Value));
                }
            }
            else if (radioLine.Checked == true)
            {
                for (int li = 0; li < 10; li++)
                {
                    arrlines[li].Move(Convert.ToInt16(numericUpDown14.Value), Convert.ToInt16(numericUpDown15.Value));
                }
            }
            else if (radioRectangle.Checked == true)
            {
                for (int ri = 0; ri < 10; ri++)
                {
                    arrrectangles[ri].Move(Convert.ToInt16(numericUpDown14.Value), Convert.ToInt16(numericUpDown15.Value));
                }
            }
            else
                MessageBox.Show("Ошибка, сначала создайте и выберите какой-нибудь тип фигур");
            arrUpDate();
        }

        private void btnArrVisibility_Click(object sender, EventArgs e)
        {
            if (radioCircle.Checked == true)
            {
                for (int ci = 0; ci < 10; ci++)
                {
                    arrcircles[ci].Visibility();
                }
            }
            else if (radioLine.Checked == true)
            {
                for (int li = 0; li < 10; li++)
                {
                    arrlines[li].Visibility();
                }
            }
            else if (radioRectangle.Checked == true)
            {
                for (int ri = 0; ri < 10; ri++)
                {
                    arrrectangles[ri].Visibility();
                }
            }
            else
                MessageBox.Show("Ошибка, сначала создайте и выберите какой-нибудь тип фигур");
            arrUpDate();
        }
        private void btnArrMoveRandom_Click(object sender, EventArgs e)
        {
            if (radioCircle.Checked == true)
            {
                for (int ci = 0; ci < 10; ci++)
                {
                    arrcircles[ci].RandomMove();
                }
            }
            else if (radioLine.Checked == true)
            {
                for (int li = 0; li < 10; li++)
                {
                    arrlines[li].RandomMove();
                }
            }
            else if (radioRectangle.Checked == true)
            {
                for (int ri = 0; ri < 10; ri++)
                {
                    arrrectangles[ri].RandomMove();
                }
            }
            else
                MessageBox.Show("Ошибка, сначала создайте и выберите какой-нибудь тип фигур");
            arrUpDate();
        }

        private void btnChangeRadius_Click(object sender, EventArgs e)
        {
            k = comboBox3.SelectedIndex;
            if (list[k].PartName == "circle")
            {
                circles[list[k].PartId] = new Circle(circles[list[k].PartId].x, circles[list[k].PartId].y, Convert.ToInt16(numericUpDown16.Value), true, circles[list[k].PartId].redcolor, circles[list[k].PartId].greencolor, circles[list[k].PartId].bluecolor);
                UpDate();
            }
            else
                MessageBox.Show("Ошибка, чтобы использовать эту кнопку, выберите окружность");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            k = comboBox3.SelectedIndex;
            if (list[k].PartName == "line")
            {
                double X1, Y1, X2, Y2, XC, YC;
                XC = (Convert.ToDouble(lines[list[k].PartId].x2) + Convert.ToDouble(lines[list[k].PartId].x1)) / 2;
                YC = (Convert.ToDouble(lines[list[k].PartId].y2) + Convert.ToDouble(lines[list[k].PartId].y1)) / 2;
                X1 = ((lines[list[k].PartId].x1 - XC) * Math.Cos(Convert.ToDouble(numericUpDown17.Value)*Math.PI / 180.0) - (lines[list[k].PartId].y1 - YC) * Math.Sin(Convert.ToDouble(numericUpDown17.Value) * Math.PI / 180.0) + XC);
                Y1 = ((lines[list[k].PartId].x1 - XC) * Math.Sin(Convert.ToDouble(numericUpDown17.Value) * Math.PI / 180.0) + (lines[list[k].PartId].y1 - YC) * Math.Cos(Convert.ToDouble(numericUpDown17.Value) * Math.PI / 180.0) + YC);
                X2 = ((lines[list[k].PartId].x2 - XC) * Math.Cos(Convert.ToDouble(numericUpDown17.Value) * Math.PI / 180.0) - (lines[list[k].PartId].y2 - YC) * Math.Sin(Convert.ToDouble(numericUpDown17.Value) * Math.PI / 180.0) + XC);
                Y2 = ((lines[list[k].PartId].x2 - XC) * Math.Sin(Convert.ToDouble(numericUpDown17.Value) * Math.PI / 180.0) + (lines[list[k].PartId].y2 - YC) * Math.Cos(Convert.ToDouble(numericUpDown17.Value) * Math.PI / 180.0) + YC);
                lines[list[k].PartId] = new Line(Convert.ToInt16(X1), Convert.ToInt16(Y1), Convert.ToInt16(X2), Convert.ToInt16(Y2), true, lines[list[k].PartId].redcolor, lines[list[k].PartId].greencolor, lines[list[k].PartId].bluecolor);
                UpDate();
            }
            else
                MessageBox.Show("Ошибка, чтобы использовать эту кнопку, выберите отрезок");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            k = comboBox3.SelectedIndex;
            if (list[k].PartName == "rectangle")
            {
                rectangles[list[k].PartId] = new MyRectangle(rectangles[list[k].PartId].x, rectangles[list[k].PartId].y, Convert.ToInt16(numericUpDown18.Value), Convert.ToInt16(numericUpDown19.Value), true, rectangles[list[k].PartId].redcolor, rectangles[list[k].PartId].greencolor, rectangles[list[k].PartId].bluecolor);
                UpDate();
            }
            else
                MessageBox.Show("Ошибка, чтобы использовать эту кнопку, выберите прямоугольник");
        }
        private void btnRandomMove_Click(object sender, EventArgs e)
        {
            k = comboBox1.SelectedIndex;
            if (list[k].PartName == "circle")
            {
                circles[list[k].PartId].RandomMove();
            }
            else
            {
                if (list[k].PartName == "line")
                {
                    lines[list[k].PartId].RandomMove();
                }
                else
                {
                    if (list[k].PartName == "rectangle")
                    {
                        rectangles[list[k].PartId].RandomMove();
                    }
                }
            }
            UpDate();
        }
    }
}
