/*Radite sustav koji omoguÄ‡uje rad s epizodama TV serije s brojem gledatelja, 
  ukupnom sumom njihovih ocjena i najveÄ‡om danom ocjenom iz intervala[0.0 - 10.0]. 
  Implementirajte sve potrebne klase definirajuÄ‡i njihova stanja i metode kako bi
  se testni program u nastavku mogao ispravno izvesti.*/


using System;

namespace Program_hw
{
    class Program
    {
        static double GenerateRandomScore()
        {
            Random RandomScore = new Random();
            double generateRandom = RandomScore.Next(0, 10);
            return generateRandom;
        }
        static void Main(string[] args)
        {
            Episode ep1, ep2;
            ep1 = new Episode();
            ep2 = new Episode(10, 64.39, 8.7);
            int viewers = 10;
            for (int i = 0; i < viewers; i++)
            {
                ep1.AddView(GenerateRandomScore());
                Console.WriteLine(ep1.GetMaxScore());
            }
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
            {
                Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
            }
            else
            {
                Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
            }
        }
       
    }
}
