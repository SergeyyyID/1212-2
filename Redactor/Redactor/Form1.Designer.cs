namespace Redactor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownPenSize = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChangeSize = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.radioButtonPencil = new System.Windows.Forms.RadioButton();
            this.radioButtonBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonEraser = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.checkBoxFill = new System.Windows.Forms.CheckBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPenSize
            // 
            this.numericUpDownPenSize.Location = new System.Drawing.Point(12, 7);
            this.numericUpDownPenSize.Name = "numericUpDownPenSize";
            this.numericUpDownPenSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPenSize.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(35, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChangeSize
            // 
            this.buttonChangeSize.Location = new System.Drawing.Point(596, 415);
            this.buttonChangeSize.Name = "buttonChangeSize";
            this.buttonChangeSize.Size = new System.Drawing.Size(148, 23);
            this.buttonChangeSize.TabIndex = 2;
            this.buttonChangeSize.Text = "Изменить размер холста";
            this.buttonChangeSize.UseVisualStyleBackColor = true;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(289, 6);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 3;
            this.textBoxHeight.Text = "Высота";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(152, 7);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 4;
            this.textBoxWidth.Text = "Ширина ";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(370, 415);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Открыть";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // radioButtonPencil
            // 
            this.radioButtonPencil.AutoSize = true;
            this.radioButtonPencil.Location = new System.Drawing.Point(12, 43);
            this.radioButtonPencil.Name = "radioButtonPencil";
            this.radioButtonPencil.Size = new System.Drawing.Size(76, 17);
            this.radioButtonPencil.TabIndex = 6;
            this.radioButtonPencil.TabStop = true;
            this.radioButtonPencil.Tag = "1";
            this.radioButtonPencil.Text = "Карандаш\r\n";
            this.radioButtonPencil.UseVisualStyleBackColor = true;
            this.radioButtonPencil.CheckedChanged += new System.EventHandler(this.radioButtonTool_CheckedChanged);
            // 
            // radioButtonBrush
            // 
            this.radioButtonBrush.AutoSize = true;
            this.radioButtonBrush.Location = new System.Drawing.Point(152, 43);
            this.radioButtonBrush.Name = "radioButtonBrush";
            this.radioButtonBrush.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBrush.TabIndex = 7;
            this.radioButtonBrush.TabStop = true;
            this.radioButtonBrush.Tag = "2";
            this.radioButtonBrush.Text = "Кисть\r\n";
            this.radioButtonBrush.UseVisualStyleBackColor = true;
            this.radioButtonBrush.CheckedChanged += new System.EventHandler(this.radioButtonTool_CheckedChanged);
            // 
            // radioButtonEraser
            // 
            this.radioButtonEraser.AutoSize = true;
            this.radioButtonEraser.Location = new System.Drawing.Point(289, 43);
            this.radioButtonEraser.Name = "radioButtonEraser";
            this.radioButtonEraser.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEraser.TabIndex = 8;
            this.radioButtonEraser.TabStop = true;
            this.radioButtonEraser.Tag = "3";
            this.radioButtonEraser.Text = "Ластик";
            this.radioButtonEraser.UseVisualStyleBackColor = true;
            this.radioButtonEraser.CheckedChanged += new System.EventHandler(this.radioButtonTool_CheckedChanged);
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(423, 43);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEllipse.TabIndex = 9;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Tag = "6";
            this.radioButtonEllipse.Text = "Эллипс\r\n";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonTool_CheckedChanged);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(538, 43);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(105, 17);
            this.radioButtonRectangle.TabIndex = 10;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Tag = "7";
            this.radioButtonRectangle.Text = "Прямоугольник";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonTool_CheckedChanged);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(694, 43);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(57, 17);
            this.radioButtonLine.TabIndex = 11;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Tag = "8";
            this.radioButtonLine.Text = "Линия";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            this.radioButtonLine.CheckedChanged += new System.EventHandler(this.radioButtonTool_CheckedChanged);
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.Location = new System.Drawing.Point(574, 9);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(69, 17);
            this.checkBoxFill.TabIndex = 12;
            this.checkBoxFill.Text = "Заливка";
            this.checkBoxFill.UseVisualStyleBackColor = true;
            this.checkBoxFill.CheckedChanged += new System.EventHandler(this.checkBoxFill_CheckedChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(423, 7);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 13;
            this.comboBoxColor.Text = "Выбор цвета";
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(22, 139);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(757, 270);
            this.pictureBoxCanvas.TabIndex = 14;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            this.pictureBoxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseDown);
            this.pictureBoxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.checkBoxFill);
            this.Controls.Add(this.radioButtonLine);
            this.Controls.Add(this.radioButtonRectangle);
            this.Controls.Add(this.radioButtonEllipse);
            this.Controls.Add(this.radioButtonEraser);
            this.Controls.Add(this.radioButtonBrush);
            this.Controls.Add(this.radioButtonPencil);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonChangeSize);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownPenSize);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPenSize;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonChangeSize;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.RadioButton radioButtonPencil;
        private System.Windows.Forms.RadioButton radioButtonBrush;
        private System.Windows.Forms.RadioButton radioButtonEraser;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.CheckBox checkBoxFill;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
    }
}

