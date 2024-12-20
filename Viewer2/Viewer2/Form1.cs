using System;
using System.Windows.Forms;
using System.IO;

namespace Viewer2
{
    public partial class Form1 : Form
    {
        private const string FileName = "listbox_data.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.Title = "Сохранить список в файл";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    if (listBoxData.Items.Count == 0)
                    {
                        MessageBox.Show("Список пуст. Ничего не сохранено.");
                        return;
                    }
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (string item in listBoxData.Items)
                        {
                            writer.WriteLine(item);
                        }
                    }
                    MessageBox.Show("Данные сохранены в файл.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxInput.Text))
            {
                listBoxData.Items.Add(textBoxInput.Text);
                textBoxInput.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Загрузить список из файла";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    listBoxData.Items.Clear();
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBoxData.Items.Add(line);
                        }
                    }
                    MessageBox.Show("Данные загружены из файла.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке: {ex.Message}");
                }
            }
        }

        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
