class InputInfoApp
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao InputInfoApp!");

        Console.Write("Qual é o seu nome? ");
        string nome = Console.ReadLine();

        Console.Write("Qual é a sua idade? ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Em qual bairro você mora? ");
        string bairro = Console.ReadLine();

        Console.WriteLine("\nInformações fornecidas:");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Bairro: " + bairro);
    }
}
