string firstName;
string secondName;

void TestaOsNomes()
{
    if (firstName == secondName)
    {
        Console.WriteLine("Os nomes são iguais");
        Console.WriteLine($"Ambos os nomes são {firstName}");
    }
    else
    {
        Console.WriteLine("Os nomes são diferentes");
        Console.WriteLine($"O primeiro nome é {firstName} e o segundo é {secondName}");
    }
}

firstName = "Roberrrrrto";
secondName = "Carlos";
TestaOsNomes();

firstName = "Robervaldo";
secondName = "Robervaldo";
TestaOsNomes();