namespace _ATV3_CJ3022641
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

 Console.WriteLine("Atividade 1");
 Console.WriteLine("Digite um número: ");
 int num = int.Parse(Console.ReadLine());


 if (num % 2 == 0)
 {
     Console.WriteLine("O número é par.");
 }
 else
 {
     Console.WriteLine("O número é impar.");
 }
 
            //Atividade 2
            Console.WriteLine("Atividade 2");
            Console.WriteLine("Digite o comprimento 1: ");
            float comp1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento 2: ");
            float comp2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento 3: ");
            float comp3 = float.Parse(Console.ReadLine());

            if (comp1 == comp2 && comp2 == comp3)
            {
                Console.WriteLine("O triângulo é equilátero.");
            }
            else if (comp1 != comp2 && comp2 != comp3 && comp1 != comp3)
            {
                Console.WriteLine("O triângulo é escaleno.");
            }
            else if (comp1 == comp2 || comp1 == comp3 || comp2 == comp3)
            {
                Console.WriteLine("O triângulo é isósceles.");
            }

            //Atividade 3
            Random random = new Random();
        }
    }
}
