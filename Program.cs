namespace VSCode_brabos;
class Program
{
    static void Main(string[] args)
    {
            
            Console.WriteLine("Diga a velocidade do objeto 1 (m/s)");
                decimal v1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Diga o peso do objeto 1");

                decimal p1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Diga a velocidade do objeto 2");

                decimal v2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("diga o peso do objeto 2");

                decimal p2 = decimal.Parse(Console.ReadLine());



             areadecalculos(p1, p2, v1, v2);
            Console.ReadLine();
        

    }

    static void areadecalculos(decimal p1, decimal p2, decimal v1, decimal v2)
    {
        decimal fator1 = p1 * v1; 
                decimal fator2 = p2 * v2;
                decimal sfator = fator1 + fator2;
                decimal svs = p1 + p2;
                decimal resultado = sfator / svs;

        if (p1 > p2)  Console.WriteLine("O: " + resultado + "m/s");
        else if (p2 > p1) Console.WriteLine("O objeto 2 bate no objeto 1 e os dois objetos andam na mesma direção a: " + resultado + "m/s");
        else if (p2 == p1) Console.WriteLine("Os dois objetos se chocam e andam em direções contrárias a " + resultado + "m/s");

        Console.WriteLine("pau no cu do vitor lima");

    }
}
