using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Wyswietlacz7seg
{
    [Serializable]
    public class Mechanizm
    {
        private bool[] stan;

        public Mechanizm()
        {
            stan = new bool[7];
            WyzerujStany();
        }

        public void WyzerujStany()
        {
            for (int i = 0; i < stan.Length; i++)
            {
                stan[i] = false;
            }
        }

        public void UstawStan(char podanyStan)
        {
            if (podanyStan == '0') Ustaw0();
            if (podanyStan == '1') Ustaw1();
            if (podanyStan == '2') Ustaw2();
            if (podanyStan == '3') Ustaw3();
            if (podanyStan == '4') Ustaw4();
            if (podanyStan == '5') Ustaw5();
            if (podanyStan == '6') Ustaw6();
            if (podanyStan == '7') Ustaw7();
            if (podanyStan == '8') Ustaw8();
            if (podanyStan == '9') Ustaw9();
            if (podanyStan == 'a' || podanyStan == 'A') UstawA();
            if (podanyStan == 'b' || podanyStan == 'B') UstawB();
            if (podanyStan == 'c' || podanyStan == 'C') UstawC();
            if (podanyStan == 'd' || podanyStan == 'D') UstawD();
            if (podanyStan == 'e' || podanyStan == 'E') UstawE();
            if (podanyStan == 'f' || podanyStan == 'F') UstawF();
        }

        public bool[] GetStan()
        {
            return stan;
        }


        public void SetStan(bool[] podanyStan)
        {
            stan = podanyStan;
        }

        public void Ustaw1()
        {
            stan = new bool[] { false, true, true, false, false, false, false };
        }
        public void Ustaw2()
        {
            stan = new bool[] { true, true, false, true, true, false, true };
        }
        public void Ustaw3()
        {
            stan = new bool[] { true, true, true, true, false, false, true };
        }
        public void Ustaw4()
        {
            stan = new bool[] { false, true, true, false, false, true, true };
        }
        public void Ustaw5()
        {
            stan = new bool[] { true, false, true, true, false, true, true };
        }
        public void Ustaw6()
        {
            stan = new bool[] { true, false, true, true, true, true, true };
        }
        public void Ustaw7()
        {
            stan = new bool[] { true, true, true, false, false, false, false };
        }
        public void Ustaw8()
        {
            stan = new bool[] { true, true, true, true, true, true, true };
        }
        public void Ustaw9()
        {
            stan = new bool[] { true, true, true, true, false, true, true };
        }
        public void Ustaw0()
        {
            stan = new bool[] { true, true, true, true, true, true, false };
        }
        public void UstawA()
        {
            stan = new bool[] { true, true, true, false, true, true, true };
        }
        public void UstawB() { 
            stan = new bool[] { false, false, true, true, true, true, true };
        }
        public void UstawC()
        {
            stan = new bool[] { true, false, false, true, true, true, false };
        }
        public void UstawD()
        {
            stan = new bool[] { false, true, true, true, true, false, true };
        }
        public void UstawE()
        {
            stan = new bool[] { true, false, false, true, true, true, true };
        }
        public void UstawF()
        {
            stan = new bool[] { true, false, false, false, true, true, true };
        }



        public void Serialize(String path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }


        public Mechanizm Deserialize(String path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                Mechanizm mechanizm = (Mechanizm)formatter.Deserialize(fs);
                return mechanizm;
            }
            catch
            {
                return new Mechanizm();
            }

        }
    }
}

