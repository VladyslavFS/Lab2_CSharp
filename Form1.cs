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

        // ���� ��� ���������� ch(x)
        private void CalcChButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputX.Text, out double x))
            {
                double result = hyperbolicCosineCalculator.CalculateCh(x, 10); // ���������� � 10 ����������
                resultChLabel.Text = $"ch({x}) = {result}";
            }
            else
            {
                resultChLabel.Text = "���������� ��������!";
            }
        }

        // ���� ��� ����������� � ������������ �������
        private void ConvertTo4Button_Click(object sender, EventArgs e)
        {
            string binary = inputBinary.Text;
            try
            {
                string result = binaryConverter.ConvertTo4(binary);
                resultConversionLabel.Text = $"����������: {result}";
            }
            catch
            {
                resultConversionLabel.Text = "���������� ������� �����!";
            }
        }

        // ���� ��� ����������� � ������� �������
        private void ConvertTo8Button_Click(object sender, EventArgs e)
        {
            string binary = inputBinary.Text;
            try
            {
                string result = binaryConverter.ConvertTo8(binary);
                resultConversionLabel.Text = $"³������: {result}";
            }
            catch
            {
                resultConversionLabel.Text = "���������� ������� �����!";
            }
        }

        // ���� ��� ����������� � �������������� �������
        private void ConvertTo16Button_Click(object sender, EventArgs e)
        {
            string binary = inputBinary.Text;
            try
            {
                string result = binaryConverter.ConvertTo16(binary);
                resultConversionLabel.Text = $"س������������: {result}";
            }
            catch
            {
                resultConversionLabel.Text = "���������� ������� �����!";
            }
        }
    }
}
