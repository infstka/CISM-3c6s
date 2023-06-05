using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace LR6
{
    public partial class UI : Form
    {
        int L = 0, M = 0, R = 4;

        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        //IV
        private readonly List<char> L_Rotor =
            new List<char> { 'e', 's', 'o', 'v', 'p', 'z', 'j', 'a', 'y', 'q', 'u', 'i', 'r', 'h', 'x', 'l', 'n', 'f', 't', 'g', 'k', 'd', 'c', 'm', 'w', 'b' };
        //III
        private readonly List<char> M_Rotor =
            new List<char> { 'b', 'd', 'f', 'h', 'j', 'l', 'c', 'p', 'r', 't', 'x', 'v', 'z', 'n', 'y', 'e', 'i', 'w', 'g', 'a', 'k', 'm', 'u', 's', 'q', 'o' };
        //II
        private readonly List<char> R_Rotor =
            new List<char> { 'a', 'j', 'd', 'k', 's', 'i', 'r', 'u', 'x', 'b', 'l', 'h', 'w', 't', 'm', 'c', 'q', 'g', 'z', 'n', 'p', 'y', 'f', 'v', 'o', 'e' };

        //C Dunn
        private readonly Dictionary<char, char> Reflector = new Dictionary<char, char> { 
            { 'a', 'r' }, 
            { 'b', 'd' }, 
            { 'c', 'o' }, 
            { 'e', 'j' }, 
            { 'f', 'n' }, 
            { 'g', 't' }, 
            { 'h', 'k' }, 
            { 'i', 'v' }, 
            { 'l', 'm' }, 
            { 'p', 'w' }, 
            { 'q', 'z' }, 
            { 's', 'x' }, 
            { 'u', 'y' } 
        };

        private char L_Rotor_start_position = 'a';
        private char M_Rotor_start_position = 'a';
        private char R_Rotor_start_position = 'a';

        public UI()
        {
            InitializeComponent();

            LRotor_combobox.DataSource = L_Rotor;
            MRotor_combobox.DataSource = M_Rotor;
            RRotor_combobox.DataSource = R_Rotor;
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            string message = input_textbox.Text.Replace(" ", "").ToLower();
            input_textbox.Text = message;

            L_Rotor_start_position = (char)LRotor_combobox.SelectedItem;
            M_Rotor_start_position = (char)MRotor_combobox.SelectedItem;
            R_Rotor_start_position = (char)RRotor_combobox.SelectedItem;

            string encrypted_result = Enigma.Encryption(
                L_Rotor, M_Rotor, R_Rotor,
                L_Rotor_start_position, M_Rotor_start_position, R_Rotor_start_position,
                Reflector,
                L, M, R,
                alphabet, message
            );

            result_textbox.Text = encrypted_result;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            input_textbox.Text = "";
            result_textbox.Text = "";
        }
    }
}