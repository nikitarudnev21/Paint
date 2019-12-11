﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace LabDrawRudnev
{
    public partial class Form1 : Form
    {
        bool drawing;
        GraphicsPath currentPath;
        Point oldlocation;
        public static Pen currentpen;
        Color historyColor;
        int colorChange;
        Image imgOriginal;
        bool trackbar = false;
        bool original = true;
        int figuri = 0;
        int locallX = 0;
        int locallY = 0;
        int locallXO = 0;
        int locallY0 = 0;
        int historyCounter; // Сохранение текущего цвета перед  использованием ластика 
        List<Image> history; // список для истории

        public Form1()
        {
            history = new List<Image>(); // инициализация списка для истории
            InitializeComponent();
            drawing = false;
            currentpen = new Pen(Color.Black);
            currentpen.Width = trackBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm AddRem = new aboutForm();
            AddRem.Owner = this;
            AddRem.ShowDialog();
        }

        private void PenToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Хотите сохранить файл перед выходом?", "Выход", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                SaveToolStripMenuItem_Click(sender, e);
      
            }
            if(dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
            Application.Exit();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            currentpen.Width = trackBar1.Value;
            trackbar = true;
            //          Form1.currentpen.Color = colorResult;
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveDig = new OpenFileDialog();
            saveDig.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            saveDig.Title = "Open an Image File";
            saveDig.FilterIndex = 1; // пнг по умолчанию

            if (saveDig.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.Load(saveDig.FileName);
               // this.AutoSize = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = imgOriginal;
            }
        }
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            OpenToolStripMenuItem_Click(sender, e);
        }

        private void ToolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            SaveToolStripMenuItem_Click(sender, e);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            history.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(733, 477);
            pictureBox1.Image = pic;
            history.Add(new Bitmap(pictureBox1.Image));

            if (pictureBox1.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?",
                    "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SaveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл");
                return;
            }

            if(e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldlocation = e.Location;
                currentPath = new GraphicsPath();
                currentpen.Color = Color.Black;
                if(Colors.colorResult.IsEmpty==false)
                {
                    currentpen.Color = Colors.colorResult;
                }
                if (Colors.colorResult.IsEmpty == true)
                {
                    currentpen.Color = Color.Black;
                }   
            }
            if(e.Button == MouseButtons.Right)
            {
                
                drawing = true;
                oldlocation = e.Location;
                currentPath = new GraphicsPath();
                currentpen.Color = Color.White;

            }
            if(trackbar)
            {
                return;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveDig = new SaveFileDialog();
            saveDig.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            saveDig.Title = "Save an Image File";
            saveDig.FilterIndex = 4; // пнг по умолчанию
            saveDig.ShowDialog();
            if(saveDig.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveDig.OpenFile();

                switch(saveDig.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs, ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs, ImageFormat.Bmp);
                        break;

                    case 3:
                        this.pictureBox1.Image.Save(fs, ImageFormat.Gif);
                        break;

                    case 4:
                        this.pictureBox1.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();

            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (Colors.colorResult.IsEmpty == false)
            {
                currentpen.Color = Colors.colorResult;
            }
            if (Colors.colorResult.IsEmpty == true)
            {
                currentpen.Color = Color.Black;
            }
            if(figuri==1)
            {

                var clr = Colors.colorResult;
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            currentPath.AddRectangle(new Rectangle(locallX, locallY, locallXO, locallY0));
            g.DrawPath(currentpen, currentPath);
            oldlocation = e.Location;
            g.Dispose();
            pictureBox1.Invalidate();
            }

            if (figuri == 2)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                currentPath.AddEllipse(locallX, locallY, locallXO, locallY0);
                g.DrawPath(currentpen, currentPath);
                oldlocation = e.Location;
                g.Dispose();
                pictureBox1.Invalidate();
            }
            if(figuri==3)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                currentPath.AddLine(locallX, locallY, locallXO, locallY0);
                g.DrawPath(currentpen, currentPath);
                oldlocation = e.Location;
                g.Dispose();
                pictureBox1.Invalidate();

            }

            //  history.RemoveRange(historyCounter + 1, history.Count - historyCounter - 1);
            history.Add(new Bitmap(pictureBox1.Image));
            if (historyCounter + 1 < 100000) historyCounter++;
            if (history.Count - 1 == 100000) history.RemoveAt(0);
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch
            {

            };
            imgOriginal = pictureBox1.Image;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {     
                if(figuri== 0)
                {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
           /*     g.Clear(Color.White);
                g.DrawImage(pictureBox1.Image, 0, 0, 733, 337);*/
                currentPath.AddLine(oldlocation, e.Location);
                g.DrawPath(currentpen, currentPath);
                oldlocation = e.Location;
                g.Dispose();
                pictureBox1.Invalidate();
                }
            }
            if(figuri!=0)
            {
                locallX = oldlocation.X;
                locallY = oldlocation.Y;
                locallX = oldlocation.X;
                locallXO = e.Location.X - oldlocation.X;
                locallY0 = e.Location.Y - oldlocation.Y;
            }
            label1.Text = e.X.ToString() + ", " + e.Y.ToString();
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            ExitToolStripMenuItem_Click(sender, e);
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (history.Count != 0 && historyCounter != 0)
            {
                pictureBox1.Image = new Bitmap(history[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(historyCounter < history.Count -1)
            {
                pictureBox1.Image = new Bitmap(history[++historyCounter]);
            }
            else MessageBox.Show("История пуста");

        }

        private void SolidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentpen.DashStyle = DashStyle.Solid;
            figuri = 0;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;

        }

        private void DotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentpen.DashStyle = DashStyle.Dot;
            figuri = 0;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void DashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentpen.DashStyle = DashStyle.DashDotDot;
            figuri = 0;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;
        }



        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

          /*  if (e.KeyChar == (char)Keys.B && e.KeyChar ==(char)Keys.X)
            {
                ExitToolStripMenuItem_Click(sender, e);
            }*/

       /*     if (e.KeyChar == (char)Keys.N)
            {
                NewToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.O)
            {
                OpenToolStripMenuItem_Click(sender, e);

            }
            if (e.KeyChar == (char)Keys.S)
            {
                SaveToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                ExitToolStripMenuItem_Click(sender, e);
            }*/

        }

        private void MenuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                NewToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.O && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                OpenToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.S && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                SaveToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Z && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                UndoToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Y && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                RedoToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.A && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                OriginalToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.F1)
            {
                AboutToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                ExitToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.O)
            {
                OriginalToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.R)
            {
                RectangleToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.C)
            {
                TriangleToolStripMenuItem_Click(sender, e);


            }
            if (e.KeyCode == Keys.L)
            {
                TriangleToolStripMenuItem1_Click(sender, e);

            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colors colors = new Colors();
            colors.Owner = this;
            colors.ShowDialog();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            NewToolStripMenuItem_Click(sender, e);
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            ColorToolStripMenuItem_Click(sender, e);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void PictureBox1_SizeChanged(object sender, EventArgs e)
        { 
        }

        private void OriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history.Clear();
            trackbar = false;
            drawing = false;
            figuri = 0;
            currentpen.Color = Color.Black;
            trackBar1.Value = 0;
            currentpen.DashStyle = DashStyle.Solid;
        }

        private void RootToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*   Graphics graphics = pictureBox1.CreateGraphics();
               graphics.DrawLine(currentpen, 200, 200, 200, 200);*/
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figuri = 0;
            resetToolStripMenuItem.Checked = true;
            rectangleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem1.Checked = false;
        }

        private void RectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figuri = 1;
            rectangleToolStripMenuItem.Checked = true;
            resetToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem1.Checked = false;
        }
        private void TriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figuri = 2;
            rectangleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = true;
            resetToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem1.Checked = false;

        }

        private void TriangleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            figuri = 3;
            rectangleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            resetToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem1.Checked = true;
        }

        Image Zoom(Image img, int size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size / 10), img.Height + (img.Height * size / 10));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Image = Zoom(imgOriginal, trackBar2.Value);
        }


    }
}
