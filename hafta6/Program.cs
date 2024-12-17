using System;


namespace hafta6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pokemon pikachu = new pokemon("pikachu","elektırık","yildirim oku",50,30,100,40);
            pokemon sguirtle = new pokemon("sguirtle", "su", "su pompası", 40, 35, 100, 40);
            pikachu.Saldir(sguirtle);
            sguirtle.Saldir(pikachu);
            pikachu.Yenilen();
            Console.WriteLine();
            Console.ReadKey();  
        }
    }
}
