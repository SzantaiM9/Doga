namespace Doga
{
    internal class Program
    {
        static string[] huto = { "husi", "" ,"", "sonka", "szalámi", "", "sajt", "", "ubi", "paradicsom"};
        
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
        static void Main(string[] args)
        {
           
            

            Console.WriteLine("Élelmiszerek száma: " + Takarit());

            Console.WriteLine("Husi indexe: " + (KeresEtel("husi")+1));

            Console.WriteLine("Magánhangzóval kezdődő ételek: ");
            Lista();


        }
    }
}
