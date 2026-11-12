namespace Doga
{
    internal class Program
    {
        static string[] huto = new string[10];

        static void HutoFeltoltes()
        {
            for(int i = 0; i < huto.Length; i++)
            {
                huto[i] = "";
            }
        }

        static void Elhelyezes(string etel)
        {
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] == "")
                {
                    huto[i] = etel;
                    return;
                }
            }
            Console.WriteLine("A hűtő tele van!");
        }

        static int Takarit()
        {
            int db = 0;

            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "")
                {
                    huto[db] = huto[i];
                    db++;
                }
            }
            for (int i = db; i < huto.Length; i++)
            {
                huto[i] = "";
            }
            return db;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
