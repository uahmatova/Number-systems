
//Класс формы - Form1 представляет графическую форму - фактически то окно,
//которое мы увидим на экране при запуске проекта.

namespace приложение
{
    public partial class Form1 : Form
    {
        private int first, second, osn_first, osn_second, ss_result;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (osn_first > 10 || osn_first < 2 || osn_second > 10 || osn_second < 2 || ss_result > 10 || ss_result < 2)
                MessageBox.Show("Мы не работаем в данной СС.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Logic.Check(first, osn_first) == true && Logic.Check(second, osn_second) == true)
                {
                    MessageBox.Show(Logic.Sravnenie(first, osn_first, second, osn_second));
                }
                else MessageBox.Show("Число не соответствует данной СС.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                second = Convert.ToInt32(this.второе_число.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Введены некорректные данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (osn_first > 10 || osn_first < 2 || osn_second > 10 || osn_second < 2 
                || ss_result > 10 || ss_result < 2)
                MessageBox.Show("Мы не работаем в данной СС.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Logic.Check(first, osn_first) == true 
                    && Logic.Check(second, osn_second) == true)
                {
                    double result = Logic.Summa(first, osn_first, second, osn_second, ss_result);
                    MessageBox.Show("Сумма этих двух чисел: " + result);
                }
                else MessageBox.Show("Число не соответствует данной СС.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                first = Convert.ToInt32(this.первое_число.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Введены некорректные данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void сс_второго_TextChanged(object sender, EventArgs e)
        {
            try
            {
                osn_second = Convert.ToInt32(this.сс_второго.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Введены некорректные данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void сс_первого_TextChanged(object sender, EventArgs e)
        {
            try
            {
                osn_first = Convert.ToInt32(this.сс_первого.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Введены некорректные данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void кнопка_для_умножения_Click(object sender, EventArgs e)
        {
            if (osn_first > 10 || osn_first < 2 || osn_second > 10 || osn_second < 2 || ss_result > 10 || ss_result < 2)
                MessageBox.Show("Мы не работаем в данной СС.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Logic.Check(first, osn_first) == true && Logic.Check(second, osn_second) == true)
                {
                    int result = Logic.Mult(first, osn_first, second, osn_second, ss_result);
                    MessageBox.Show("Произведение этих чисел: " + result);
                }
                else MessageBox.Show("Проверьте корректность ввода СС.");
            }
        }

        private void кнопка_для_деления_Click(object sender, EventArgs e)
        {
            if (osn_first > 10 || osn_first < 2 || osn_second > 10 || osn_second < 2 || ss_result > 10 || ss_result < 2)
                MessageBox.Show("Мы не работаем в данной СС.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Logic.Check(first, osn_first) == true && Logic.Check(second, osn_second) == true)
                {
                    int result = Logic.Delenie(first, osn_first, second, osn_second, ss_result);
                    MessageBox.Show("Частное этих чисел: " + result);
                }
                else MessageBox.Show("Проверьте корректность ввода СС.");
            }
        }

        private void приколюха_Click(object sender, EventArgs e)
        {
            MessageBox.Show("приветики! ты солнышко, у тебя всё получится (´｡• ᵕ •｡`) ♡");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void сс_ответа_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ss_result = Convert.ToInt32(this.сс_ответа.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Введены некорректные данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void кнопка_для_переводаиз10сс_Click(object sender, EventArgs e)
        {
            if (osn_first > 10 || osn_first < 2 || osn_second > 10 || osn_second < 2 || ss_result > 10 || ss_result < 2)
                MessageBox.Show("Мы не работаем в данной СС.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Logic.Check(first, osn_first) == true && Logic.Check(second, osn_second) == true
                    && osn_first == 10 && osn_second == 10)
                    MessageBox.Show($"Первое число из 10сс в {ss_result}сс: " + Logic.Perevod_from_10(first, ss_result)
                        + $"\nВторое число из 10сс в {ss_result}сс: " + Logic.Perevod_from_10(second, ss_result));
                else MessageBox.Show("Проверьте корректность СС.");
            }
        }

        private void кнопка_для_переводав10сс_Click(object sender, EventArgs e)
        {
            if (osn_first > 10 || osn_first < 2 || osn_second > 10 || osn_second < 2 || ss_result > 10 || ss_result < 2)
                MessageBox.Show("Мы не работаем в данной СС.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Logic.Check(first, osn_first) == true && Logic.Check(second, osn_second) == true)
                    MessageBox.Show($"Первое число в 10сс из {osn_first}сс: " 
                        + Logic.Perevod_v_10(first, osn_first)
                        + $"\nВторое число в 10сс из {osn_second}сс: " 
                        + Logic.Perevod_v_10(second, osn_second));
                else MessageBox.Show("Проверьте корректность СС.");
            }
        }
        private void кнопка_для_вычитания_Click(object sender, EventArgs e)
        {
            if (osn_first > 10 || osn_first < 2 || osn_second > 10 || osn_second < 2 || ss_result > 10 || ss_result < 2)
                MessageBox.Show("Мы не работаем в данной СС.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Logic.Check(first, osn_first) == true && Logic.Check(second, osn_second) == true)
                {
                    double result = Logic.Raznost(first, osn_first, second, osn_second, ss_result);
                    MessageBox.Show("Разность этих двух чисел: " + result);
                }
                else MessageBox.Show("Число не соответствует данной СС.");
            }

            void button1_Click_1(object sender, EventArgs e)
            {

            }

        }
    }
}
