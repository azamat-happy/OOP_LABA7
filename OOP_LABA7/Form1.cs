using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LABA_6_1
{
    public partial class Form1 : Form
    {
        //int index = 0;
        int choosen_shape;
        Point paintBoxStart;
        Point paintBoxEnd;
        int pictureboxWidth, pictureboxHeight, countOfSelected;
        Storage<BaseClass> storage;
        OpenFileDialog ofd;
        SaveFileDialog sfd;
        public Form1()
        {
            InitializeComponent();
            pictureboxWidth = pictureBox1.Width;
            pictureboxHeight = pictureBox1.Height;
            paintBoxStart = new Point(0, 0);
            paintBoxEnd = new Point(pictureboxWidth, pictureboxHeight);
            storage = new Storage<BaseClass>();

            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
        }
        private void UnSelect(int k)
        {
            for (int i = storage.Size() - 1; i >= 0; i--)
            {
                if (i != k)
                    storage[i].setselect(false);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = storage.Size() - 1; i >= 0; i--)
                {
                    if (storage[i].getselect() == true)
                    {
                        storage.pop(i);
                        //index--;
                    }
                }
                pictureBox1.Invalidate();
            }

            if (e.KeyCode == Keys.D1)
            {
                //если выбран круг
                choosen_shape = 1;
                label1.BackColor = Color.GreenYellow;
                label2.BackColor = Color.Empty;
                label3.BackColor = Color.Empty;
                label4.BackColor = Color.Empty;
            }

            if (e.KeyCode == Keys.D2)
            {
                //если выбран квадрат
                choosen_shape = 2;
                label1.BackColor = Color.Empty;
                label2.BackColor = Color.GreenYellow;
                label3.BackColor = Color.Empty;
                label4.BackColor = Color.Empty;
            }
            if (e.KeyCode == Keys.D3)
            {
                //если выбран отрезок
                choosen_shape = 3;
                label1.BackColor = Color.Empty;
                label2.BackColor = Color.Empty;
                label3.BackColor = Color.GreenYellow;
                label4.BackColor = Color.Empty;
            }
            if (e.KeyCode == Keys.D4)
            {
                //если выбран треугольник
                choosen_shape = 4;
                label1.BackColor = Color.Empty;
                label2.BackColor = Color.Empty;
                label3.BackColor = Color.Empty;
                label4.BackColor = Color.GreenYellow;
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = storage.Size() - 1; i >= 0; i--)
                {
                    if (storage[i].getselect() == true)
                    {
                        storage[i].move(-1, 0, paintBoxStart, paintBoxEnd);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                for (int i = storage.Size() - 1; i >= 0; i--)
                {
                    if (storage[i].getselect() == true)
                    {
                        storage[i].move(1, 0, paintBoxStart, paintBoxEnd);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                for (int i = storage.Size() - 1; i >= 0; i--)
                {
                    if (storage[i].getselect() == true)
                    {
                        storage[i].move(0, -1, paintBoxStart, paintBoxEnd);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int i = storage.Size() - 1; i >= 0; i--)
                {
                    if (storage[i].getselect() == true)
                    {
                        storage[i].move(0, 1, paintBoxStart, paintBoxEnd);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.Oemplus)
            {
                for (int i = storage.Size() - 1; i >= 0; i--)
                {
                    if (storage[i].getselect() == true)
                    {
                        storage[i].resize(1, paintBoxStart, paintBoxEnd);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.OemMinus)
            {
                for (int i = storage.Size() - 1; i >= 0; i--)
                {
                    if (storage[i].getselect() == true)
                    {
                        storage[i].resize(-1, paintBoxStart, paintBoxEnd);
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.G)
            {
                for (int i = 0; i < storage.Size(); i++)
                {
                    if (storage[i].getselect())
                    {
                        storage[i].colorselect("Green");
                        pictureBox1.Invalidate();
                    }
                }
            }

            if (e.KeyCode == Keys.Y)
            {
                for (int i = 0; i < storage.Size(); i++)
                {
                    if (storage[i].getselect())
                    {
                        storage[i].colorselect("Yellow");
                        pictureBox1.Invalidate();
                    }
                }
            }

            if (e.KeyCode == Keys.L)
            {
                for (int i = 0; i < storage.Size(); i++)
                {
                    if (storage[i].getselect())
                    {
                        storage[i].colorselect("LightSeaGreen");
                        pictureBox1.Invalidate();
                    }
                }
            }

            if (e.KeyCode == Keys.O)
            {
                for (int i = 0; i < storage.Size(); i++)
                {
                    if (storage[i].getselect())
                    {
                        storage[i].colorselect("Orange");
                        pictureBox1.Invalidate();
                    }
                }
            }
            if (e.KeyCode == Keys.X)                                            //группировка
            {
                int v = 0;
                for (int i = 0; i < storage.Size(); i++)
                    if (storage[i].getselect())
                        v++;

                if (storage.Size() != 0 && v > 1)
                {
                    Group group = new Group(paintBoxEnd.X, paintBoxEnd.Y);
                    for (int i = storage.Size() - 1; i >= 0; i--)
                    {
                        if (storage[i].getselect())
                        {
                            group.add(storage[i]);
                            storage.pop(i);
                        }
                    }
                    storage.push_back(group);
                    storage[storage.Size()-1].setselect(true);
                }   
                pictureBox1.Invalidate();
            }

            if (e.KeyCode == Keys.Z)                                           //разгруппировка
            {
                if (storage.Size() != 0)
                {
                    for (int i = storage.Size() - 1; i >= 0; i--)
                    {
                        if (storage[i].getselect() && storage[i].isgroup())
                        //if (storage[i].isgroup())
                        {
                            Group group = (Group)storage[i];

                            for (int j = group.GetCount() - 1; j >= 0; j--)
                            {
                                storage.push_back(group.GetAndDel(j));
                                storage[storage.Size() - 1].setselect(true);
                            }

                            storage.pop(i);
                        }
                    }

                    //storage[storage.Size() - 1].setselect(true);
                }
                pictureBox1.Invalidate();
            }
            if (e.KeyCode == Keys.U)
            {
                for (int i = storage.Size() - 1; i >= 0; i--)
                    storage.pop(i);
            }

            if (e.KeyCode == Keys.S)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(sfd.FileName, FileMode.Create);

                    StreamWriter stream = new StreamWriter(file);

                    stream.WriteLine(storage.Size());
                    for (int i = 0; i < storage.Size(); i++)
                        storage[i].save(stream);
                    stream.Close();
                    file.Close();
                }
            }

            if (e.KeyCode == Keys.L)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(ofd.FileName, FileMode.Open);

                    StreamReader stream = new StreamReader(file);

                    AbstractFactory factory = new MyFactory();

                    int h = Convert.ToInt32(stream.ReadLine());

                    for (int i = 0; i < h; i++)
                    {
                        string t = stream.ReadLine();
                        BaseClass tmp = factory.createBase(t, paintBoxEnd.X, paintBoxEnd.Y);
                        storage.push_back(tmp);
                        if (storage[i] != null)
                            storage[i].load(stream, factory);
                    }
                    stream.Close();
                    file.Close();
                }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs coordination = (MouseEventArgs)e;
            for (int i = storage.Size() - 1; i >= 0; i--)
            {
                if ((storage[i].CheckIfObjectUnderCoordination(coordination.Location) && (Control.ModifierKeys & Keys.Shift) == Keys.Shift))
                {
                   
                    storage[i].setselect(true);
                    pictureBox1.Invalidate();
                    return;
                }
                else if ((storage[i].CheckIfObjectUnderCoordination(coordination.Location)))
                {
                    UnSelect(i);
                    storage[i].setselect(true);
                    pictureBox1.Invalidate();
                    return;
                }
            }
            //если выбранная фигура - круг
            if (choosen_shape == 1)
            {
                CCircle circle = new CCircle(coordination.Location);
                circle.setselect(true);
                storage.push_back(circle);
                UnSelect(storage.Size()-1);
                //index++;

            }
            //если выбранная фигура - квадрат
            if (choosen_shape == 2)
            {
                Square square = new Square(coordination.Location);
                square.setselect(true);
                storage.push_back(square);
                UnSelect(storage.Size()-1);
                //index++;

            }
            //если выбранная фигура - отрезок
            if (choosen_shape == 3)
            {
                Section Line = new Section(coordination.Location);
                Line.setselect(true);
                storage.push_back(Line);
                UnSelect(storage.Size()-1);
                //index++;

            }
            //если выбранная фигура - треугольник
            if (choosen_shape == 4)
            {
                Triangle Triangle = new Triangle(coordination.Location);
                Triangle.setselect(true);
                storage.push_back(Triangle);
                UnSelect(storage.Size()-1);
                //index++;

            }
            //panel3.Invalidate();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            countOfSelected = 0;
            lb_ObjectCounter.Text = storage.Size().ToString();
            for (int i = 0; i < storage.Size(); i++)
            {
                storage[i].draw(gr);
                if (storage[i].getselect())
                {
                    storage[i].drawframe(gr);
                    countOfSelected++;
                }
            }
            lb_ChoosedObject.Text = countOfSelected.ToString();

        }
    }
}
