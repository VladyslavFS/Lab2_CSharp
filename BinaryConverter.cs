using System.Numerics;

namespace Lab2
{
    public class BinaryConverter
    {
        public string ConvertTo4(string binary)
        {
            if (binary.Length % 2 != 0)
            {
                // Додавання нуля на початок для вирівнювання кількості бітів
                binary = "0" + binary;
            }

            // Результат переведення у четвіркову систему
            string quaternaryNumber = "";

            // Проходження по двійковому числу по 2 біти
            for (int i = 0; i < binary.Length; i += 2)
            {
                string twoBitGroup = binary.Substring(i, 2);

                // Переведення кожної групи з 2 бітів у четвіркову цифру
                switch (twoBitGroup)
                {
                    case "00":
                        quaternaryNumber += "0";
                        break;
                    case "01":
                        quaternaryNumber += "1";
                        break;
                    case "10":
                        quaternaryNumber += "2";
                        break;
                    case "11":
                        quaternaryNumber += "3";
                        break;
                }
            }
            return quaternaryNumber;
        }

        public string ConvertTo8(string binary)
        {
            return Convert.ToString(Convert.ToInt64(binary, 2), 8);
        }

        public string ConvertTo16(string binary)
        {
            return Convert.ToString(Convert.ToInt64(binary, 2), 16).ToUpper();
        }
    }
}
