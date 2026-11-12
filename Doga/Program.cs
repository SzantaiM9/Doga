namespace Doga
{
    internal class Program
    {
        static string[] huto = { "husi", "" ,"", "sonka", "szalámi", "", "sajt", "", "ubi", "paradicsom"};

        static int[] szamok = new int[10];
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

        static int KeresEtel(string etelNeve)
        {
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] == etelNeve)
                {
                    return i;
                }
            }
            return 0;
        }

        static void Lista()
        {
            string maganhangzok = "aáeéiíoóöőuúüű";

            for(int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "")
                {
                    for(int j = 0; j < maganhangzok.Length; j++)
                    {
                        if (huto[i][0] == maganhangzok[j])
                        {
                            Console.WriteLine(huto[i]);
                            break;
                        }
                    }
                }
                
                
            }
        }

        static void FeltoltoEgyeiekkel(int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                bool van = false;

                do
                {
                    szamok[i] = rnd.Next(min, max + 1);
                    van = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (szamok[i] == szamok[j])
                        {
                            van = true;
                        }
                    }
                } while (van);
            }
        }

        static int[] LeghosszabbNovekvo()
        {
            int db = 1;
            int maxdb = 1;
            int kezdo = 0;
            int maxKezdo = 0;

            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] > szamok[i - 1])
                {
                    db++;
                }
                else
                {
                    db = 1;
                    kezdo = i;
                }

                if(db > maxdb)
                {
                    maxdb = db;
                    maxKezdo = kezdo;
                }
            }

            int[] eredmeny = new int[maxdb];

            for(int i =0; i < maxdb; i++)
            {
                eredmeny[i] = szamok[maxKezdo + i];
            }


            return eredmeny;
        }

        static void AtlagAlattiDuplazas()
        {
            double atlag = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                atlag += szamok[i];
            }

            atlag = atlag / szamok.Length;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < atlag)
                {
                    szamok[i] = szamok[i] * 2;
                }
            }
        }


        static void Main(string[] args)
        {

            //Console.WriteLine("Élelmiszerek száma: " + Takarit());

            //Console.WriteLine("Husi indexe: " + (KeresEtel("husi")+1));

            //Console.WriteLine("Magánhangzóval kezdődő ételek: ");
            //Lista();

            FeltoltoEgyeiekkel(1, 50);

            Console.WriteLine("Eredeti tömb: ");

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i] + " ");
            }

            Console.WriteLine("\nLeghosszabb növekvő sorozat: ");

            int[] eredmeny = LeghosszabbNovekvo();

            for(int i = 0; i < eredmeny.Length; i++)
            {

            }





        }
    }
}
