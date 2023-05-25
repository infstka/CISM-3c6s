using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static string str = "135066410865995223349603216278805969938881475605667027524485143851526510604859533833940287150571909441798207282164471551373680419703964191743046496589274256239341020864383202110372958725762358509643110564073501508187510676594629205563685529475213500852879416377328533906109750544334999811150056977236890927563";
        static string secondstr = "25195908475657893494027183240048398571429282126204032027777137836043662020707595556264018525880784406918290641249515082189298559149176184502808489120072844992687392807287776735971418347270261896375014971824691165077613379859095700097330459748808428401797429100642458691817195118746121515172654632282216869987549182422433637259085141865462043576798423387184774447920739934236584823824281198163815010674810451660377306056201619676256133844143603833904414952634432190114657544454178424020924616515723350778707749817125772467962926386356373289912154831438167899885040445364023527381951378636564391212010397122822120720357";
        static List<int> a = new List<int> { 15 };
        static List<BigInteger> x = new List<BigInteger> { 
            (BigInteger)Math.Pow(10,50),
            (BigInteger)Math.Pow(10, 60), (BigInteger)Math.Pow(10, 70),
            (BigInteger)Math.Pow(10, 80), (BigInteger)Math.Pow(10, 90) };
        static BigInteger n = BigInteger.Parse(str);
        static BigInteger nn = BigInteger.Parse(secondstr);
        static void Main(string[] args)
        {
            foreach(var a in a)
            {
                foreach(var x in x)
                {
                    Console.WriteLine("1024");
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    BigInteger buffer = BigInteger.ModPow(a, x, n);
                    Console.WriteLine("Значение у: " + buffer);
                    Console.WriteLine("Значение а: " + a);
                    Console.WriteLine("Значение х: " + x);
                    stopwatch.Stop();
                    TimeSpan elapsed = stopwatch.Elapsed;
                    Console.WriteLine($"Время выполнения: {elapsed.TotalMilliseconds:F2} мс\n");
                }
            }
            Console.WriteLine("\n\n");
            foreach (var a in a)
            {
                foreach (var x in x)
                {
                    Console.WriteLine("2048");
                    Stopwatch nnstopwatch = new Stopwatch();
                    nnstopwatch.Start();
                    BigInteger nnbuffer = BigInteger.ModPow(a, x, nn);
                    Console.WriteLine("Значение у: " + nnbuffer);
                    Console.WriteLine("Значение а: " + a);
                    Console.WriteLine("Значение х: " + x);
                    nnstopwatch.Stop();
                    TimeSpan nnelapsed = nnstopwatch.Elapsed;
                    Console.WriteLine($"Время выполнения: {nnelapsed.TotalMilliseconds:F2} мс\n");
                }
            }
            Console.ReadLine();
        }
    }
}
