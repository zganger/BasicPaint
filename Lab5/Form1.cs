using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab5
{
    public partial class Form1 : Form
    {
        ArrayList shapes = new ArrayList();
        bool first_or_second = false; //false means second click, draw initially
        Point firstClick;
        Point secondClick;
        string txt;
        Pen pen;
        Brush textPen;
        Brush penBrush;
        Brush presentBrush;
        int width;
        public Form1()
        {
            InitializeComponent();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            DrawPanel.Invalidate();
        }

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            first_or_second = !first_or_second;
            if(first_or_second)
            {
                firstClick.X = e.X;
                firstClick.Y = e.Y;
            }
            else
            {
                secondClick.X = e.X;
                secondClick.Y = e.Y;
            }
            //what to call?
            if(first_or_second == false)
            {
                if(lineRadio.Checked)
                {
                    shapes.Add(new line(firstClick.X, secondClick.X, firstClick.Y, secondClick.Y, pen));
                }
                else if(rectRadio.Checked)
                {
                    int tlX = getMin(firstClick.X, secondClick.X);
                    int tlY = getMin(firstClick.Y, secondClick.Y);
                    int rectWidth = Math.Abs((firstClick.X - secondClick.X));
                    int rectHeight = Math.Abs((firstClick.Y - secondClick.Y));
                    if(fill_chkbox.Checked)
                    {
                        shapes.Add(new rectangle(tlX, tlY, rectWidth, rectHeight, presentBrush));
                    }
                    if(outline_chkbox.Checked)
                    {
                        shapes.Add(new rectangle(tlX, tlY, rectWidth, rectHeight, pen));
                    }
                }
                else if(ellipseRadio.Checked)
                {
                    int tlX = getMin(firstClick.X, secondClick.X);
                    int tlY = getMin(firstClick.Y, secondClick.Y);
                    int ellWidth = Math.Abs((firstClick.X - secondClick.X));
                    int ellHeight = Math.Abs((firstClick.Y - secondClick.Y));
                    if(fill_chkbox.Checked)
                    {
                        shapes.Add(new ellipse(tlX, tlY, ellWidth, ellHeight, presentBrush));
                    }
                    if(outline_chkbox.Checked)
                    {
                        shapes.Add(new ellipse(tlX, tlY, ellWidth, ellHeight, pen));
                    }
                }
                else if(textRadio.Checked)
                {
                    int tlX = getMin(firstClick.X, secondClick.X);
                    int tlY = getMin(firstClick.Y, secondClick.Y);
                    int txtWidth = Math.Abs((firstClick.X - secondClick.X));
                    int txtHeight = Math.Abs((firstClick.Y - secondClick.Y));
                    Rectangle rect = new Rectangle(tlX, tlY, txtWidth, txtHeight);
                    shapes.Add(new text(txt, textPen, rect));
                }
            }
            DrawPanel.Invalidate();
        }
        public int getMin(int first, int second)
        {
            if (first < second) { return first; }
            else { return second; }
        }
        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach(shape s in shapes)
            {
                s.Draw(g);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapes.RemoveAt(shapes.Count - 1);
            DrawPanel.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PenColor.SelectedIndex = 0; //default listbox values
            FillColor.SelectedIndex = 0;
            PenWidth.SelectedIndex = 0;
        }

        private void PenWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            width = Int32.Parse((string)PenWidth.SelectedItem);
            pen = new Pen(penBrush, width);
            Invalidate();
        }

        private void PenColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)PenColor.SelectedItem == "Black")
            {
                penBrush = Brushes.Black;
                pen = new Pen(penBrush, width);
                textPen = Brushes.Black;
            }
            else if ((string)PenColor.SelectedItem == "Red")
            {
                penBrush = Brushes.Red;
                pen = new Pen(penBrush, width);
                textPen = Brushes.Red;
            }
            else if ((string)PenColor.SelectedItem == "Blue")
            {
                penBrush = Brushes.Blue;
                pen = new Pen(penBrush, width);
                textPen = Brushes.Blue;
            }
            else if ((string)PenColor.SelectedItem == "Green")
            {
                penBrush = Brushes.Green;
                pen = new Pen(penBrush, width);
                textPen = Brushes.Green;
            }
            Invalidate();
        }

        private void FillColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)FillColor.SelectedItem == "White")
            {
                presentBrush = Brushes.White;
            }
            else if ((string)FillColor.SelectedItem == "Black")
            {
                presentBrush = Brushes.Black;
            }
            else if ((string)FillColor.SelectedItem == "Red")
            {
                presentBrush = Brushes.Red;
            }
            else if ((string)FillColor.SelectedItem == "Blue")
            {
                presentBrush = Brushes.Blue;
            }
            else if ((string)FillColor.SelectedItem == "Green")
            {
                presentBrush = Brushes.Green;
            }
            Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txt = textBox1.Text;
        }
    }
    public partial class shape
    {
        public virtual void Draw(Graphics g){}
    }
    public partial class ellipse : shape
    {
        int tlX;
        int tlY;
        int width;
        int height;
        bool outline;
        bool fill;
        Pen pen;
        Brush brush;
        public ellipse(int in_tlX, int in_tlY, int in_width, int in_height, Pen in_pen)
        {
            tlX = in_tlX;
            tlY = in_tlY;
            width = in_width;
            height = in_height;
            pen = in_pen;
            outline = true;
        }
        public ellipse(int in_tlX, int in_tlY, int in_width, int in_height, Brush in_brush)
        {
            fill = true;
            tlX = in_tlX;
            tlY = in_tlY;
            width = in_width;
            height = in_height;
            brush = in_brush;
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            if(fill)
            {
                g.FillEllipse(brush, tlX, tlY, width, height);
            }
            if(outline)
            {
                g.DrawEllipse(pen, tlX, tlY, width, height);
            }
        }
    }
    public partial class rectangle : shape
    {
        int tlX;
        int tlY;
        int width;
        int height;
        bool outline;
        bool fill;
        Pen pen;
        Brush brush;
        public rectangle(int in_tlX, int in_tlY, int in_width, int in_height, Pen in_pen)
        {
            tlX = in_tlX;
            tlY = in_tlY;
            width = in_width;
            height = in_height;
            pen = in_pen;
            outline = true;
        }
        public rectangle(int in_tlX, int in_tlY, int in_width, int in_height, Brush in_brush)
        {
            fill = true;
            tlX = in_tlX;
            tlY = in_tlY;
            width = in_width;
            height = in_height;
            brush = in_brush;
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            if (fill)
            {
                g.FillRectangle(brush, tlX, tlY, width, height);
            }
            if (outline)
            {
                g.DrawRectangle(pen, tlX, tlY, width, height);
            }
        }
    }
    public partial class line : shape
    {
        int x1;
        int x2;
        int y1;
        int y2;
        Pen pen;
        public line(int in_x1, int in_x2, int in_y1, int in_y2, Pen in_pen)
        {
            x1 = in_x1;
            x2 = in_x2;
            y1 = in_y1;
            y2 = in_y2;
            pen = in_pen;
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
    public partial class text : shape
    {
        Rectangle rect;
        string txt;
        Brush brush;
        public text(string in_txt, Brush in_brush, Rectangle in_rect)
        {
            txt = in_txt;
            brush = in_brush;
            rect = in_rect;
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            g.DrawString(txt, new Font("Serif", 10), brush, rect);
        }
    }
}
