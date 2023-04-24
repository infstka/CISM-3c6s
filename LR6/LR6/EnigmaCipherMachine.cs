using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    internal class EnigmaCipherMachine
    {
        static public string Encryption(
            List<char> valuesRotorL, List<char> valuesRotorM, List<char> valuesRotorR,
            char startPosCharRotorL, char startPosCharRotorM, char startPosCharRotorR,
            Dictionary<char, char> reflector,
            int shiftRotorL, int shiftRotorM, int shiftRotorR,
            string alphabet, string message
        )
        {
            string encryptionResult = "";

            // при установке начальной позиции: сдвигаем символы ротора на начальную позицию, то есть,
            // если начальный символ = 'b', то мы делаем циклический сдвиг влево, пока 'b' не станет на индекс 0
            List<char> valuesRotorRShifted = shift(valuesRotorR, valuesRotorR.IndexOf(startPosCharRotorR));
            List<char> valuesRotorMShifted = shift(valuesRotorM, valuesRotorM.IndexOf(startPosCharRotorM));
            List<char> valuesRotorLShifted = shift(valuesRotorL, valuesRotorL.IndexOf(startPosCharRotorL));

            // для отслеживания полного проворота ротора R и M
            int amountOfShiftRotorR = 0;
            int amountOfShiftRotorM = 0;

            foreach (char messageSymbol in message)
            {
                // ---------------- роторы
                // подаем символ исходного сообщения на R ротор, в роторе он преобразуется в шифртекст 1 (т.е. в новый символ)
                int alphabetSymbolIndex = alphabet.IndexOf(messageSymbol);
                char encryptedSymbolInRotorR = valuesRotorRShifted[alphabetSymbolIndex];

                // символ с ротора R подаем на ротор M - получем шифртекст 2
                alphabetSymbolIndex = alphabet.IndexOf(encryptedSymbolInRotorR);
                char encryptedSymbolInRotorM = valuesRotorMShifted[alphabetSymbolIndex];

                // символ с ротора M подаем на ротор L - получем шифртекст 3
                alphabetSymbolIndex = alphabet.IndexOf(encryptedSymbolInRotorM);
                char encryptedSymbolInRotorL = valuesRotorLShifted[alphabetSymbolIndex];

                // ---------------- отражатель
                // ищем шифртекст 3 в словаре с парами символов (в отражателе) и получаем символ,
                // стоящий в паре с данным символом - получаем шифротекст 4
                char pairedSymbol = alphabet[0]; // просто надо как-то инициализировать переменную
                foreach (var pair in reflector)
                {
                    if (pair.Key == encryptedSymbolInRotorL)
                    {
                        pairedSymbol = pair.Value;
                        break;
                    }
                    else if (pair.Value == encryptedSymbolInRotorL)
                    {
                        pairedSymbol = pair.Key;
                        break;
                    }
                }

                // символ из пары в отражателе подаем на ротор L - получаем шифртекст 5
                int encryptedSymbolIndexInRotorLAndReflector = valuesRotorLShifted.IndexOf(pairedSymbol);
                char encryptedSymbolInRotorLAndReflector = alphabet[encryptedSymbolIndexInRotorLAndReflector];

                // символ с ротора L попадает на ротор M - получаем шифртекст 6
                int encryptedSymbolIndexInRotorMAndReflector = valuesRotorMShifted.IndexOf(encryptedSymbolInRotorLAndReflector);
                char encryptedSymbolInRotorMAndReflector = alphabet[encryptedSymbolIndexInRotorMAndReflector];

                // символ с ротора M попадает на ротор R - получаем шифртекст 7
                int encryptedSymbolIndexInRotorRAndReflector = valuesRotorRShifted.IndexOf(encryptedSymbolInRotorMAndReflector);
                char encryptedSymbolInRotorRAndReflector = alphabet[encryptedSymbolIndexInRotorRAndReflector];

                encryptionResult += encryptedSymbolInRotorRAndReflector;

                // ---------------- сдвиг роторов
                // сначала выполняем сдвиги, согласно варианту 4: Li-Mi-Ri = 0-0-4
                // то есть каждый символ повлечет за собой сдвиг L и R роторов на 1 символ
                valuesRotorRShifted = shift(valuesRotorRShifted, shiftRotorR);
                amountOfShiftRotorR += shiftRotorR;

                valuesRotorMShifted = shift(valuesRotorMShifted, shiftRotorM);
                amountOfShiftRotorM += shiftRotorM;

                valuesRotorLShifted = shift(valuesRotorLShifted, shiftRotorL);

                // далее выполняем сдвиг ротора M, если R сделал полный оборот
                if (amountOfShiftRotorR % 26 == 0)
                {
                    valuesRotorMShifted = shift(valuesRotorMShifted, 1);
                    amountOfShiftRotorM++;
                }
                // и ротора L, если M сделал полный оборот
                if (amountOfShiftRotorM % 26 == 0)
                {
                    valuesRotorLShifted = shift(valuesRotorLShifted, 1);
                }
            }

            return encryptionResult;
        }

        // циклический сдвиг влево на указанное кол-во шагов n
        public static List<char> shift(List<char> valuesRotor, int n)
        {
            List<char> result = new List<char>();
            result.AddRange(valuesRotor.GetRange(n, valuesRotor.Count - n));
            result.AddRange(valuesRotor.GetRange(0, n));

            return result;
        }
    }
}
