// //Tipos de variaveis
// int x = 10;
// double pi = 3.1415;
// char letra = 'M';
// bool isTrue = true;
// string texto = "Uma linda mensagem";
    
// double outroValor;
// //conversao implicita
// outroValor = x;
// //conversao explicita
// int valorInteiro = (int) pi;
    
// //conversao com a classe Convert 
// int y =Convert.ToInt32(texto);
// //Operadores
// //+,-,/,*, = , ==
// int numero;
// Console.WriteLine("Digite um numero:");
// numero = Convert.ToInt32(Console.ReadLine());
// //concatenação de strings
// Console.WriteLine("O usuario digitou: " + numero);
// //Interpolação de strings
// Console.WriteLine($"O dobro do que o usuário digitou é : {numero*2}");

        Console.WriteLine("Digite o primeiro número para calcular: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número para calcular: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double soma = numero1 + numero2;
        double subtracao = numero1 - numero2;
        double multiplicacao = numero1 * numero2;
        double divisao = numero1 / numero2;

        Console.WriteLine("O valor da soma dos seus números é: " + soma);
        Console.WriteLine($"O valor da subtração dos seus números é: {subtracao}");
        Console.WriteLine(string.Format("A subtração dos números é igual {0}", multiplicacao));
        Console.WriteLine(string.Format("A divisão dos números é igual {0}", divisao));