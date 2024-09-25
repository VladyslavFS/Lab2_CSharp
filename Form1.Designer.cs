using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        // Компоненти інтерфейсу для обох завдань
        private TextBox inputX;
        private Button calcChButton;
        private Label resultChLabel;

        private TextBox inputBinary;
        private Button convertTo4Button;
        private Button convertTo8Button;
        private Button convertTo16Button;
        private Label resultConversionLabel;

        private void InitializeComponent()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // Встановлення фіксованої рамки
            this.MaximizeBox = false;  // Вимкнення кнопки максимізації
            // Інтерфейс для Завдання 1 - обчислення ch(x)
            this.inputX = new TextBox { Location = new System.Drawing.Point(20, 20), Width = 100 };
            this.calcChButton = new Button { Text = "Обчислити ch(x)", Location = new System.Drawing.Point(130, 20), Width = 150 };
            this.resultChLabel = new Label { Location = new System.Drawing.Point(20, 60), Width = 260 };

            // Інтерфейс для Завдання 2 - Конвертація двійкового числа
            this.inputBinary = new TextBox { Location = new System.Drawing.Point(20, 120), Width = 150 };
            this.convertTo4Button = new Button { Text = "Чотирикова", Location = new System.Drawing.Point(180, 120), Width = 100 };
            this.convertTo8Button = new Button { Text = "Вісімкова", Location = new System.Drawing.Point(180, 160), Width = 100 };
            this.convertTo16Button = new Button { Text = "Шістнадцяткова", Location = new System.Drawing.Point(180, 200), Width = 100 };
            this.resultConversionLabel = new Label { Location = new System.Drawing.Point(20, 240), Width = 260 };

            // Додавання елементів на форму
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.calcChButton);
            this.Controls.Add(this.resultChLabel);
            this.Controls.Add(this.inputBinary);
            this.Controls.Add(this.convertTo4Button);
            this.Controls.Add(this.convertTo8Button);
            this.Controls.Add(this.convertTo16Button);
            this.Controls.Add(this.resultConversionLabel);

            // Налаштування форми
            this.Text = "Обчислення та Конвертація";
            this.Size = new System.Drawing.Size(350, 320);

            // Прив'язка подій
            this.calcChButton.Click += new System.EventHandler(this.CalcChButton_Click);
            this.convertTo4Button.Click += new System.EventHandler(this.ConvertTo4Button_Click);
            this.convertTo8Button.Click += new System.EventHandler(this.ConvertTo8Button_Click);
            this.convertTo16Button.Click += new System.EventHandler(this.ConvertTo16Button_Click);
        }
    }
}
