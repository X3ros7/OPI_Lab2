using System.Text;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, який виконується при натисканні на кнопку Submit
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            if (!int.TryParse(enterTextBox.Text, out num))
            {
                MessageBox.Show("Enter a number");
                return;
            }

            resultLabel.Text = generateMessage(num);
            resultLabel.Visible = true;
        }

        /// <summary>
        /// Метод, який генерує фінальне повідомлення, в якому будуть усі дільники переданого числа.
        /// </summary>
        /// <param name="num">Число, до якого треба знайти дільники</param>
        /// <returns>Повідомлення, в якому будуть усі дільники числа</returns>
        private string generateMessage(int num)
        {
            StringBuilder message = new StringBuilder($"Divisiors of {num}: ");
            for (int i = 1;  i <= num; i++)
            {
                if (num % i == 0)
                {
                    message.Append(" " + i);
                }
            }
            return message.ToString();
        }
    }
}
