using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal class Enigma
    {
        static public string Encryption(
            List<char> L_Value, List<char> M_Value, List<char> R_Rotor,
            char L_Start_Position, char M_Start_Position, char R_Start_Position,
            Dictionary<char, char> Reflector,
            int L_Shift, int M_Shift, int R_Shift,
            string alphabet, string text
        )
        {
            string encrypt_res = "";

            List<char> Shifted_R_Value = RotorShift(R_Rotor, R_Rotor.IndexOf(R_Start_Position));
            List<char> Shifted_M_Value = RotorShift(M_Value, M_Value.IndexOf(M_Start_Position));
            List<char> Shifted_L_Value = RotorShift(L_Value, L_Value.IndexOf(L_Start_Position));

            //shift number
            int R_NOS = 0;
            int M_NOS = 0;

            foreach (char text_symbol in text)
            {
                int symbol_index = alphabet.IndexOf(text_symbol);
                char R_Encrypted_Symbol = Shifted_R_Value[symbol_index];

                symbol_index = alphabet.IndexOf(R_Encrypted_Symbol);
                char M_Encrypted_Symbol = Shifted_M_Value[symbol_index];

                symbol_index = alphabet.IndexOf(M_Encrypted_Symbol);
                char L_Encrypted_Symbol = Shifted_L_Value[symbol_index];

                char paired_symbols = alphabet[0];
                foreach (var pair in Reflector)
                {
                    if (pair.Key == L_Encrypted_Symbol)
                    {
                        paired_symbols = pair.Value;
                        break;
                    }
                    else if (pair.Value == L_Encrypted_Symbol)
                    {
                        paired_symbols = pair.Key;
                        break;
                    }
                }

                int EncryptedSymbolIndex_RotorLAndRelector = Shifted_L_Value.IndexOf(paired_symbols);
                char EncryptedSymbol_InLRotorAndReflector = alphabet[EncryptedSymbolIndex_RotorLAndRelector];

                int EncryptedSymbolIndex_RotorMAndRelector = Shifted_M_Value.IndexOf(EncryptedSymbol_InLRotorAndReflector);
                char EncryptedSymbol_InMRotorAndReflector = alphabet[EncryptedSymbolIndex_RotorMAndRelector];

                int EncryptedSymbolIndex_RotorRAndRelector = Shifted_R_Value.IndexOf(EncryptedSymbol_InMRotorAndReflector);
                char EncryptedSymbol_InRRotorAndReflector = alphabet[EncryptedSymbolIndex_RotorRAndRelector];

                encrypt_res += EncryptedSymbol_InRRotorAndReflector;

                Shifted_R_Value = RotorShift(Shifted_R_Value, R_Shift);
                R_NOS += R_Shift;

                Shifted_M_Value = RotorShift(Shifted_M_Value, M_Shift);
                M_NOS += M_Shift;

                Shifted_L_Value = RotorShift(Shifted_L_Value, L_Shift);

                if (R_NOS % 26 == 0)
                {
                    Shifted_M_Value = RotorShift(Shifted_M_Value, 1);
                    M_NOS++;
                }

                if (M_NOS % 26 == 0)
                {
                    Shifted_L_Value = RotorShift(Shifted_L_Value, 1);
                }
            }

            return encrypt_res;
        }

        public static List<char> RotorShift(List<char> valuesRotor, int n)
        {
            List<char> result = new List<char>();
            result.AddRange(valuesRotor.GetRange(n, valuesRotor.Count - n));
            result.AddRange(valuesRotor.GetRange(0, n));

            return result;
        }
    }
}
