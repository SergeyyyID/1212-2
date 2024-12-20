using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redactor
{
    public partial class Form1 : Form
    {
        private int _flTools = 0; 
        private Bitmap _buffer;  
        private Graphics _graphics;  
        private Pen _pen;    
        private Brush _brush;  
        private Point _startPoint;
        private bool _isFilled = false;

        public Form1()
        {
            InitializeComponent(); 
            Init();              
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true); 
            pictureBoxCanvas.SizeChanged += PictureBoxCanvas_SizeChanged; 
        }
        private void PictureBoxCanvas_SizeChanged(object sender, EventArgs e)
        {
            if (pictureBoxCanvas.Width <= 0 || pictureBoxCanvas.Height <= 0) return;
            _buffer = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            _graphics = Graphics.FromImage(_buffer);
            DrawBuffer();
        }
        private void Init()
        {
            
            _pen = new Pen(Color.Black, 2);  
            _brush = new SolidBrush(Color.Black); 

            
            comboBoxColor.Items.AddRange(new[] { "Black", "Red", "Green", "Blue", "Yellow", "White", "Orange" }); 
            comboBoxColor.SelectedItem = "Black"; 

           
            numericUpDownPenSize.Value = 2; 

           
            if (pictureBoxCanvas.Width <= 0 || pictureBoxCanvas.Height <= 0) return;
            _buffer = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height); 
            _graphics = Graphics.FromImage(_buffer); 
            _graphics.Clear(Color.White); 
            pictureBoxCanvas.Image = _buffer; 
            _startPoint = Point.Empty; 
            UpdateCanvas(); 
        }
        private void radioButtonTool_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton; 
            if (radioButton != null && radioButton.Checked)  
            {
                _flTools = int.Parse(radioButton.Tag.ToString()); 
            }
        }

        
        private void pictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            DrawBuffer();  
            _startPoint = e.Location;  

        }
        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)  
                return;

            _pen.Width = (float)numericUpDownPenSize.Value; 

            
            switch (_flTools)
            {
                case 1: // Карандаш
                    _graphics.SmoothingMode = SmoothingMode.None; 
                    _graphics.DrawLine(_pen, _startPoint, e.Location); 
                    _startPoint = e.Location; 
                    break;
                case 2: // Кисть
                    _graphics.SmoothingMode = SmoothingMode.AntiAlias; 

                    _graphics.FillEllipse(_brush, new Rectangle(e.X - (int)numericUpDownPenSize.Value / 2, e.Y - (int)numericUpDownPenSize.Value / 2, (int)numericUpDownPenSize.Value, (int)numericUpDownPenSize.Value));
                    break;
                case 3: // Ластик
                    _graphics.SmoothingMode = SmoothingMode.AntiAlias;
                 
                    _graphics.FillEllipse(new SolidBrush(Color.White), new Rectangle(e.X - (int)numericUpDownPenSize.Value / 2, e.Y - (int)numericUpDownPenSize.Value / 2, (int)numericUpDownPenSize.Value, (int)numericUpDownPenSize.Value));
                    break;

                case 6: // Эллипс

                    DrawBuffer(); 
                    _graphics.SmoothingMode = SmoothingMode.AntiAlias; 
                                                                       
                    if (_isFilled)
                        _graphics.FillEllipse(_brush, GetRectangle(_startPoint, e.Location));
                    else
                        _graphics.DrawEllipse(_pen, GetRectangle(_startPoint, e.Location));
                    break;

                case 7: // Прямоугольник
                    DrawBuffer(); 
                    _graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    
                    if (_isFilled)
                        _graphics.FillRectangle(_brush, GetRectangle(_startPoint, e.Location));
                    else
                        _graphics.DrawRectangle(_pen, GetRectangle(_startPoint, e.Location));
                    break;

                case 8: // Линия
                    DrawBuffer(); 
                    _graphics.SmoothingMode = SmoothingMode.None;
                    _graphics.DrawLine(_pen, _startPoint, e.Location);
                    break;

            }
            UpdateCanvas(); 
        }
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColor.SelectedItem != null) 
            {
                var selectedColor = (string)comboBoxColor.SelectedItem; 
                var color = Color.FromName(selectedColor);   
                _pen.Color = color; 
                _brush = new SolidBrush(color); 
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap Image (.bmp)|*.bmp|JPEG Image (.jpeg)|*.jpeg|PNG Image (.png)|*.png";
            openFileDialog.Title = "Load an Image File";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                try
                {
                    Bitmap loadedImage = new Bitmap(openFileDialog.FileName);

                    if (loadedImage != null)
                    {
                        _buffer = loadedImage;

                        if (pictureBoxCanvas.Width != _buffer.Width || pictureBoxCanvas.Height != _buffer.Height)
                        {
                            pictureBoxCanvas.Width = _buffer.Width;
                            pictureBoxCanvas.Height = _buffer.Height;
                        }
                        _graphics = Graphics.FromImage(_buffer);
                        pictureBoxCanvas.Image = _buffer;
                        UpdateCanvas();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_buffer == null)
            {
                MessageBox.Show("Нет изображения для сохранения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Bitmap Image (.bmp)|*.bmp|JPEG Image (.jpeg)|*.jpeg|PNG Image (.png)|*.png";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                ImageFormat imageFormat = ImageFormat.Bmp;
                string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();

                if (extension == ".jpeg" || extension == ".jpg")
                    imageFormat = ImageFormat.Jpeg;
                else if (extension == ".png")
                    imageFormat = ImageFormat.Png;

                try
                {

                    _buffer.Save(saveFileDialog.FileName, imageFormat);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        
        private void UpdateCanvas()
        {
            pictureBoxCanvas.Invalidate(); 
            pictureBoxCanvas.Update();  
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(Math.Min(p1.X, p2.X),
                                 Math.Min(p1.Y, p2.Y),  
                                 Math.Abs(p1.X - p2.X), 
                                 Math.Abs(p1.Y - p2.Y)); 
        }

        private void DrawBuffer()
        {
            if (_buffer != null)
            {
                _graphics.Clear(Color.White); 
                pictureBoxCanvas.Image = _buffer; 
            }
        }
        
        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_buffer != null)  
            {
                e.Graphics.DrawImage(_buffer, Point.Empty);
            }

        }
        
        private void checkBoxFill_CheckedChanged(object sender, EventArgs e)
        {
            _isFilled = checkBoxFill.Checked; 
        }

    }
}
