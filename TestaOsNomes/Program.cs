class Program
{
    static string firstName;
    static string secondName;



    static void TestaOsNomes()
    {
        if (firstName == secondName)
        {
            Console.WriteLine("Os nomes são iguais");
            Console.WriteLine($"Ambos os nomes são {firstName}\n");
        }
        else
        {
            Console.WriteLine("Os nomes são diferentes");
            Console.WriteLine($"O primeiro nome é {firstName} e o segundo é {secondName}\n");
        }
    }

    static void InputUsuario()
    {
        Console.Write("Escolha um nome: ");
        firstName = Console.ReadLine();
        Console.Write("Escolha o nome que deseja comparar: ");
        secondName = Console.ReadLine();
    }

    static bool DesejaContinuar()
    {
        Console.Write("Deseja Continuar (y/n): ");
        string respostaUsuario = Console.ReadLine();

        if (respostaUsuario == "y")
        {
            Console.WriteLine("Continuando o programa...\n");
            Thread.Sleep(1000);
            return true;
        }

        else if (respostaUsuario == "n")
        {
            Console.WriteLine("Fechando o programa...\n");
            Thread.Sleep(2000);
            return false;
        }
        else
        {
            Console.WriteLine("Opção invalida\n");
            Thread.Sleep(2000);
            return DesejaContinuar();
        }
    }

    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            InputUsuario();
            TestaOsNomes();
            continuar = DesejaContinuar();
        }
    }
}