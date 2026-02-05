using C_DesafioPratico1;
using System.Diagnostics;

namespace DesafioPratico;

class Program
{
    private static string? resposta;

    static void Main()
    {
        Console.WriteLine("Bem Vindo!");
        
        do
        {
            Console.WriteLine("Deseja escolher um exercício? Sim/Não \n(Caso escolha não, irá percorrer todos)");
            resposta = Console.ReadLine();
            if (resposta?.ToLower() != "sim" && resposta?.ToLower() != "não" && resposta?.ToLower() != "nao")
                Console.WriteLine("Resposta inválida, por favor responda com 'Sim' ou 'Não'.");
            
        } while (resposta?.ToLower() != "sim" && resposta?.ToLower() != "não" && resposta?.ToLower() != "nao");

        if(resposta.ToLower() == "sim")
        {
            Console.WriteLine("Escolha o exercício que deseja executar (1-6):");
            var input = Console.ReadLine();
            var exercicios = new ExerciciosPraticos();
            switch (input)
            {
                case "1":
                    exercicios.Exercicio1();
                    break;
                case "2":
                    exercicios.Exercicio2();
                    break;
                case "3":
                    exercicios.Exercicio3();
                    break;
                case "4":
                    exercicios.Exercicio4();
                    break;
                case "5":
                    exercicios.Exercicio5();
                    break;
                case "6":
                    exercicios.Exercicio6();
                    break;
                default:
                    Console.WriteLine("Exercício inválido. Por favor, escolha um número entre 1 e 6.");
                    break;
            }
        }
        
        if(resposta.ToLower() == "não" || resposta.ToLower() == "nao")
        {
            var exercicios = new ExerciciosPraticos();
            Console.WriteLine("Executando todos os exercícios:\n");
            Console.WriteLine("Exercício 1:");
            exercicios.Exercicio1();
            Console.WriteLine("Exercício 2:");
            exercicios.Exercicio2();
            Console.WriteLine("Exercício 3:");
            exercicios.Exercicio3();
            Console.WriteLine("Exercício 4:");
            exercicios.Exercicio4();
            Console.WriteLine("Exercício 5:");
            exercicios.Exercicio5();
            Console.WriteLine("Exercício 6:");
            exercicios.Exercicio6();
        }
    }
}