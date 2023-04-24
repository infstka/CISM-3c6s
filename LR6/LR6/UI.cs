using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace LR6
{
    public partial class UI : Form
    {
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        //IV
        private readonly List<char> _rotorL =
            new List<char> { 'e', 's', 'o', 'v', 'p', 'z', 'j', 'a', 'y', 'q', 'u', 'i', 'r', 'h', 'x', 'l', 'n', 'f', 't', 'g', 'k', 'd', 'c', 'm', 'w', 'b' };
        //III
        private readonly List<char> _rotorM =
            new List<char> { 'b', 'd', 'f', 'h', 'j', 'l', 'c', 'p', 'r', 't', 'x', 'v', 'z', 'n', 'y', 'e', 'i', 'w', 'g', 'a', 'k', 'm', 'u', 's', 'q', 'o' };
        //II
        private readonly List<char> _rotorR =
            new List<char> { 'a', 'j', 'd', 'k', 's', 'i', 'r', 'u', 'x', 'b', 'l', 'h', 'w', 't', 'm', 'c', 'q', 'g', 'z', 'n', 'p', 'y', 'f', 'v', 'o', 'e' };

        //C Dunn
        private readonly Dictionary<char, char> _reflector =
            new Dictionary<char, char> { { 'a', 'r' }, { 'b', 'd' }, { 'c', 'o' }, { 'e', 'j' }, { 'f', 'n' }, { 'g', 't' }, { 'h', 'k' }, { 'i', 'v' }, { 'l', 'm' }, { 'p', 'w' }, { 'q', 'z' }, { 's', 'x' }, { 'u', 'y' } };

        private char _startPosCharRotorL = 'a';
        private char _startPosCharRotorM = 'a';
        private char _startPosCharRotorR = 'a';
        int Li = 0, Mi = 0, Ri = 4;

        public UI()
        {
            InitializeComponent();

            LRotor_combobox.DataSource = _rotorL;
            MRotor_combobox.DataSource = _rotorM;
            RRotor_combobox.DataSource = _rotorR;
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            string originalMessage = input_textbox.Text.Replace(" ", "").ToLower();
            input_textbox.Text = originalMessage;

            _startPosCharRotorL = (char)LRotor_combobox.SelectedItem;
            _startPosCharRotorM = (char)MRotor_combobox.SelectedItem;
            _startPosCharRotorR = (char)RRotor_combobox.SelectedItem;

            string encryptionResult = EnigmaCipherMachine.Encryption(
                _rotorL, _rotorM, _rotorR,
                _startPosCharRotorL, _startPosCharRotorM, _startPosCharRotorR,
                _reflector,
                Li, Mi, Ri,
                Alphabet, originalMessage
            );

            result_textbox.Text = encryptionResult;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            input_textbox.Text = "";
            result_textbox.Text = "";
        }
    }
}