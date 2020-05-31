using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Markov_normal_algorithm
{
    public partial class MainMenu : Form
    {
        // Введенный алфавит
        private protected string EnterText;
        private protected string Command = "";

        public List<char> Alphabet = new List<char>();

        // Конструктор класса
        public MainMenu()
        {
            InitializeComponent();
        }

        // Обработчик нажатия на кнопку 'Очистить всё'
        private void Clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            PartsDevelop.Text = "";
            InputTextBox.Text = "";
            OutputTextBox.Text = "";
            AlphabetInputTextBox.Text = "";
            Alphabet = new List<char>();
        }

        // Нажатие на кнопку 'Ok', поля ввода алфавита
        private void AlphabetInputButton_Click(object sender, EventArgs e)
        {
            if (AlphabetInputTextBox.Text != "")
            {
                for(int i = 0; i < AlphabetInputTextBox.Text.Length; i++)
                {
                    if(Alphabet.IndexOf(AlphabetInputTextBox.Text[i]) == -1)
                    {
                        Alphabet.Add(AlphabetInputTextBox.Text[i]);
                    }
                }
                MessageBox.Show("Алфавит введен успешно!", 
                    "Ввод алфавита", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вы не ввели алфавит! Пожалуйста, повторите ввод.", 
                    "Ввод алфавита", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Запуск выполнения алгоритма (кнопка 'Выполнить')
        private void Start_Click(object sender, EventArgs e)
        {
            if (Alphabet.Count == 0)
            {
                MessageBox.Show("Алфавит не задан!", 
                    "Проверка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InputTextBox.Text.Length == 0)
            {
                MessageBox.Show("Заполните входную строку!", 
                    "Проверка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Input = InputTextBox.Text;
            bool lettersCheck = true;

            for (int i = 0; i < Input.Length && lettersCheck; i++)
            {
                char letter = Input[i];

                if (Alphabet.IndexOf(letter) == -1)
                {
                    lettersCheck = false;
                }
            }

            if (!lettersCheck)
            {
                MessageBox.Show("Слово содержит символы, не принадлежащие алфавиту", 
                    "Проверка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Введите хотя бы одно условие!", 
                    "Проверка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                object v0 = dataGridView1.Rows[i].Cells[0].Value;
                object v1 = dataGridView1.Rows[i].Cells[1].Value;
                object v2 = dataGridView1.Rows[i].Cells[2].Value;
                if (v1 == null && (v0 != null || v2 != null) ||
                    v1 != null && v0 == null && v2 == null)
                {
                    MessageBox.Show("Заполните поля формы подстановки!",
                        "Проверка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            EnterText = Input;
            OutputTextBox.Text = MarkovStart(EnterText);         
        }

        // Алгоритм Маркова
        public string MarkovStart(string EnterText)
        {
            do
            {
                Beginning:
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    object v0 = dataGridView1.Rows[i].Cells[0].Value;
                    object v1 = dataGridView1.Rows[i].Cells[1].Value;
                    object v2 = dataGridView1.Rows[i].Cells[2].Value;
                    if (v1 == null && v0 == null && v2 == null)
                    {
                        continue;
                    }

                    string left, right;
                    string arrow = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    if (dataGridView1.Rows[i].Cells[2].Value == null)
                    {
                        right = "";
                    }
                    else
                    {
                        right = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    }

                    if (dataGridView1.Rows[i].Cells[0].Value == null)
                    {
                        left = "";
                    }
                    else
                    {
                        left = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    }

                    Command = $" [{left}{arrow}{right}]";

                    if (Contains(EnterText, left) == true)
                    {
                        switch (arrow)
                        {
                            case "->":
                                {
                                    if (right == "")
                                    {
                                        int indexFirst = EnterText.IndexOf(left);
                                        EnterText = EnterText.Remove(indexFirst, left.Length);
                                    }
                                    else if (left == "")
                                    {
                                        EnterText = $"{right}" + EnterText;
                                    }
                                    else
                                    {
                                        int indexFirst = EnterText.IndexOf(left);
                                        EnterText = EnterText.Remove(indexFirst, left.Length).Insert(indexFirst, right);
                                    }

                                    PartsDevelop.Text += EnterText + Command + "\n";
                                    Command = "";
                                    goto Beginning;
                                }                          
                            case "->.":
                                {
                                    int indexFirst = EnterText.IndexOf(left);
                                    EnterText = EnterText.Remove(indexFirst, left.Length).Insert(indexFirst, right);
                                    PartsDevelop.Text += EnterText + Command;
                                    Command = "";
                                    return EnterText;
                                }
                        }                 
                    }
                }
            } while (Contains(EnterText) == true);

            return EnterText;
        }

        // Проверка на вхождение текста
        public bool Contains(string EnterText)
        {
            bool result = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                object v0 = dataGridView1.Rows[i].Cells[0].Value;
                object v1 = dataGridView1.Rows[i].Cells[1].Value;
                object v2 = dataGridView1.Rows[i].Cells[2].Value;
                if (v0 == null || v1 == null || v2 == null)
                {
                    continue;
                }

                string value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (EnterText.Contains(value))
                {
                    result = true;
                }
            }
            return result;
        }

        // Проверка на вхождение текста
        public bool Contains(string EnterText, string left)
        {
            bool result = EnterText.Contains(left);
            return result;
        }
    }
}
