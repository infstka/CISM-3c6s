using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LR5
{
    public partial class UI : Form
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyzäöüß";
        string keyName = "gleb";
        string keySurname = "bobrowitsch";

        public UI()
        {
            InitializeComponent();
        }

        private void choosePerm_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choosePerm_combobox.SelectedIndex == 0)
            {
                MPString_label.Visible = true;
                MPString_textbox.Visible = true;
                table_label.Visible = true;
                table_textbox.Visible = true;
            }
            else
            {
                MPString_label.Visible = false;
                MPString_textbox.Visible = false;
                table_label.Visible = false;
                table_textbox.Visible = false;
            }
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (input_textbox.Text == "")
            {
                MessageBox.Show("Введите сообщение!");
                return;
            }
            if (choosePerm_combobox.SelectedIndex == 1)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string encryptedMessage = MultiplePermutation.Encrypt(input_textbox.Text, keyName, keySurname);
                stopwatch.Stop();
                result_textbox.Text = encryptedMessage;
                letter_textbox.Text = getFreqInfo();
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                time_textbox.Text = $"{elapsedMilliseconds} мс";
            }
            else if (choosePerm_combobox.SelectedItem == null)
            {
                MessageBox.Show("Выберите вид перестановок!");
                return;
            }
            else
            {
                if (MPString_textbox.Text == "")
                {
                    MessageBox.Show("Введите количество строк!");
                    return;
                }
                int rows = Convert.ToInt32(MPString_textbox.Text);
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
                letter_textbox.Text = getFreqInfo();
            }
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (input_textbox.Text == "")
            {
                MessageBox.Show("Введите сообщение!");
                return;
            }
            if (choosePerm_combobox.SelectedIndex == 1)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string decryptedMessage = MultiplePermutation.Decrypt(input_textbox.Text, keyName, keySurname);
                stopwatch.Stop();
                result_textbox.Text = decryptedMessage;
                letter_textbox.Text = "";
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                time_textbox.Text = $"{elapsedMilliseconds} мс";
            }
            else
            {
                if (MPString_textbox.Text == "")
                {
                    MessageBox.Show("Введите количество строк!");
                    return;
                }

                if (!int.TryParse(MPString_textbox.Text, out int rows))
                {
                    MessageBox.Show("Введите количество строк!");
                    return;
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                var decryptionResult = RoutePermutation.Decrypt(
                    input_textbox.Text,
                    rows
                );
                stopwatch.Stop();
                result_textbox.Text = decryptionResult;
                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                time_textbox.Text = $"{elapsedMilliseconds} мс";
                letter_textbox.Text = "";
            }
        }

        private string getFreqInfo()
        {
            var sourceTextLetFreq = SymbolFrequency.countFrequencyOfAlphabetLettersInText(input_textbox.Text, alphabet);
            var encryptedTextLetFreq = SymbolFrequency.countFrequencyOfAlphabetLettersInText(result_textbox.Text, alphabet);

            string info = "";
            string frequencyOfEveryLetterInSource = "";
            foreach (var key in sourceTextLetFreq.Keys)
            {
                frequencyOfEveryLetterInSource += "\r\n" + key + " - " + sourceTextLetFreq[key] + ",\t";
            }
            info += "Частота появления символа в исходном сообщении: " + frequencyOfEveryLetterInSource;

            string frequencyOfEveryLetterInResult = "";
            foreach (var key in encryptedTextLetFreq.Keys)
            {
                frequencyOfEveryLetterInResult += "\r\n" + key + " - " + encryptedTextLetFreq[key] + ",\t";
            }
            info += "\r\n" + "Частота появления символа в зашифрованном сообщении: " + frequencyOfEveryLetterInResult;
            return info;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            input_textbox.Text = "";
            result_textbox.Text = "";
            table_textbox.Text = "";
            letter_textbox.Text = "";
            MPString_textbox.Text = "";
            time_textbox.Text = "";
        }
    }
}