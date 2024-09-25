using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private HyperbolicCosineCalculator hyperbolicCosineCalculator;
        private BinaryConverter binaryConverter;

        public Form1()
        {
            InitializeComponent();
            hyperbolicCosineCalculator = new HyperbolicCosineCalculator();
            binaryConverter = new BinaryConverter();
        }

        // Подія для обчислення ch(x)
        private void CalcChButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputX.Text, out double x))
            {
                double result = hyperbolicCosineCalculator.CalculateCh(x, 10); // Обчислення з 10 ітераціями
                resultChLabel.Text = $"ch({x}) = {result}";
            }
            else
            {
                resultChLabel.Text = "Некоректне значення!";
            }
        }

        // Подія для конвертації в чотирикорову систему
        private void ConvertTo4Button_Click(object sender, EventArgs e)
        {
            string binary = inputBinary.Text;
            try
            {
                string result = binaryConverter.ConvertTo4(binary);
                resultConversionLabel.Text = $"Чотирикова: {result}";
            }
            catch
            {
                resultConversionLabel.Text = "Некоректне двійкове число!";
            }
        }

        // Подія для конвертації у вісімкову систему
        private void ConvertTo8Button_Click(object sender, EventArgs e)
        {
            string binary = inputBinary.Text;
            try
            {
                string result = binaryConverter.ConvertTo8(binary);
                resultConversionLabel.Text = $"Вісімкова: {result}";
            }
            catch
            {
                resultConversionLabel.Text = "Некоректне двійкове число!";
            }
        }

        // Подія для конвертації в шістнадцяткову систему
        private void ConvertTo16Button_Click(object sender, EventArgs e)
        {
            string binary = inputBinary.Text;
            try
            {
                string result = binaryConverter.ConvertTo16(binary);
                resultConversionLabel.Text = $"Шістнадцяткова: {result}";
            }
            catch
            {
                resultConversionLabel.Text = "Некоректне двійкове число!";
            }
        }
    }
}
