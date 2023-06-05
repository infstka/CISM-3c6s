using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LR5
{
    public partial class UI : Form
    {
        string german_alphabet = "abcdefghijklmnopqrstuvwxyzäöüß";
        string key_name = "gleb";
        string key_surname = "bobrowitsch";

        public UI()
        {
            InitializeComponent();
        }

        private void choose_permutation(object sender, EventArgs e)
        {
            if (permutation_combobox.SelectedIndex == 0)
            {
                //number of strings
                NOS_label.Visible = true;
                NOS_textbox.Visible = true;
                table_label.Visible = true;
                table_textbox.Visible = true;
            }
            else
            {
                NOS_label.Visible = false;
                NOS_textbox.Visible = false;
                table_label.Visible = false;
                table_textbox.Visible = false;
            }
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (input_textbox.Text == "")
            {
                MessageBox.Show("Введите сообщение!");
                return;
            }
            if (permutation_combobox.SelectedIndex == 1)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string decryptedMessage = MultiplePermutation.Decrypt(input_textbox.Text, key_name, key_surname);
                stopwatch.Stop();
                result_textbox.Text = decryptedMessage;
                letter_textbox.Text = "";
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                time_textbox.Text = $"{elapsedMilliseconds} мс";
            }
            else
            {
                if (NOS_textbox.Text == "")
                {
                    MessageBox.Show("Введите количество строк!");
                    return;
                }

                if (!int.TryParse(NOS_textbox.Text, out int rows))
                {
                    MessageBox.Show("Введите количество строк!");
                    return;
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                var result_decryption = RoutePermutation.Decrypt(input_textbox.Text,rows);
                stopwatch.Stop();
                result_textbox.Text = result_decryption;
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                time_textbox.Text = $"{elapsedMilliseconds} мс";
                letter_textbox.Text = "";
            }
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (input_textbox.Text == "")
            {
                MessageBox.Show("Введите сообщение!");
                return;
            }
            if (permutation_combobox.SelectedIndex == 1)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string encryptedMessage = MultiplePermutation.Encrypt(input_textbox.Text, key_name, key_surname);
                stopwatch.Stop();
                result_textbox.Text = encryptedMessage;
                letter_textbox.Text = get_frequensy();
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                time_textbox.Text = $"{elapsedMilliseconds} мс";
            }
            else if (permutation_combobox.SelectedItem == null)
            {
                MessageBox.Show("Выберите вид перестановок!");
                return;
            }
            else
            {
                if (NOS_textbox.Text == "")
                {
                    MessageBox.Show("Введите количество строк!");
                    return;
                }
                int rows = Convert.ToInt32(NOS_textbox.Text);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                var encryptionResult = RoutePermutation.Encrypt(
                    input_textbox.Text,
                    rows
                );
                stopwatch.Stop();

                for (int i = 0; i < encryptionResult.rows; i++)
                {
                    for (int j = 0; j < encryptionResult.cols; j++)
                    {
                        if (encryptionResult.table[i, j] != ' ')
                        {
                            table_textbox.Text += encryptionResult.table[i, j] + "\t";
                        }
                        else
                        {
                            table_textbox.Text += "0\t";
                        }
                    }
                    table_textbox.Text += "\n";
                }
                result_textbox.Text = encryptionResult.result;
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                time_textbox.Text = $"{elapsedMilliseconds} мс";
                letter_textbox.Text = get_frequensy();
            }
        }

        private string get_frequensy()
        {
            var letter_frequency = SymbolFrequency.countFrequencyOfAlphabetLettersInText(input_textbox.Text, german_alphabet);
            var encrypted_letter_frequency = SymbolFrequency.countFrequencyOfAlphabetLettersInText(result_textbox.Text, german_alphabet);

            string info = "";
            string every_letter_freq = "";
            foreach (var key in letter_frequency.Keys)
            {
                every_letter_freq += "\r\n" + key + " - " + letter_frequency[key] + ",\t";
            }
            info += "Частота появления символа в исходном сообщении: " + every_letter_freq;

            string every_resletter_freq = "";
            foreach (var key in encrypted_letter_frequency.Keys)
            {
                every_resletter_freq += "\r\n" + key + " - " + encrypted_letter_frequency[key] + ",\t";
            }
            info += "\r\n" + "Частота появления символа в зашифрованном сообщении: " + every_resletter_freq;
            return info;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            input_textbox.Text = "";
            result_textbox.Text = "";
            table_textbox.Text = "";
            letter_textbox.Text = "";
            NOS_textbox.Text = "";
            time_textbox.Text = "";
        }
    }
}