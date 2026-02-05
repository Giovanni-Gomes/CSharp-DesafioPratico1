using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DesafioPratico1;

internal class ExerciciosPraticos
{
    public void Exercicio1()
    {
        Console.WriteLine("Digite seu nome:");
        var nome = Console.ReadLine();
        var saudacao = $"Olá, {nome}! Seja bem-vindo(a)!";
        Console.WriteLine(saudacao);
    }

    public void Exercicio2()
    {
        Console.WriteLine("Digite seu nome:");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome:");
        var sobrenome = Console.ReadLine();
        Console.WriteLine($"Seu nome completo:");
        Console.WriteLine(nome + " " + sobrenome);
    }

    public void Exercicio3()
    {
        Console.WriteLine("Vamos Calcular!");
        Console.WriteLine("Digite o primeiro número (aceita double):");
        var firstNumber = Console.ReadLine();
        Console.WriteLine("Digite o segundo número (aceita double):");
        var secondNumber = Console.ReadLine();
        if (double.TryParse(firstNumber, out double numero1) && double.TryParse(secondNumber, out double numero2))
        {
            var soma = numero1 + numero2;
            Console.WriteLine($"A soma dos números {numero1} e {numero2} é {soma}.");

            var subtracao = numero1 - numero2;
            Console.WriteLine($"A subtração dos números {numero1} e {numero2} é {subtracao}.");

            var multiplicacao = numero1 * numero2;
            Console.WriteLine($"A multiplicação dos números {numero1} e {numero2} é {multiplicacao}.");

            var divisao = numero1 / numero2;
            Console.WriteLine($"A divisão dos números {numero1} e {numero2} é {divisao}.");

            var mediana = (numero1 + numero2) / 2; 
            Console.WriteLine($"A mediana dos números {numero1} e {numero2} é {mediana}.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número decimal.");
        }
    }

    public void Exercicio4()
    {
        Console.WriteLine("Digite algo:");
        var input = Console.ReadLine();
        if (input is not null)
        {
            var inputTrimmed = input.Trim().Replace(" ", "");
            
            if (input.Length > 0 && input.Length == inputTrimmed?.Length)
            {
                Console.WriteLine($"A quantidade de caracteres é {input.Length}");
            } else if (input.Length != inputTrimmed?.Length)
            {
                Console.WriteLine($"A quantidade de caracteres é {input.Length} e sem contar espaçoes vazios é {inputTrimmed?.Length}");
            }
        }
        else
        {
             Console.WriteLine("Entrada inválida.");
        }
    }

    public void Exercicio5()
    {
        Console.WriteLine("Digite uma placa de um veículo:");
        var input = Console.ReadLine();
        var inputTrimmed = input?.Trim();
        if (inputTrimmed is not null && inputTrimmed.Length < 8)
        {
            var threeFirstChars = inputTrimmed.Substring(0, 3);
            var fourLastChars = inputTrimmed.Substring(3);
            if (threeFirstChars.All(char.IsLetter) && fourLastChars.All(char.IsDigit))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
        else {
            Console.WriteLine("Entrada inválida.");
        }
    }

    public void Exercicio6() 
    { 
        Console.WriteLine("Digite o número da opção correspondente ao formato de exibição da data atual:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2 - Apenas a data no formato dd/mm/yyyy");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4 - A data com o mês por extenso.");
        var input = Console.ReadLine();

        var date = DateTime.Now;
        var pt = new CultureInfo("pt-BR");

        switch (input)
        {
            case "1":
                {
                    var stringDate = date.ToString(pt);
                    Console.WriteLine(stringDate);
                }
                break;
            case "2":
                {
                    var dateOnly = DateOnly.FromDateTime(DateTime.Now);
                    Console.WriteLine(dateOnly.ToString(pt));
                }
                break;
            case "3":
                {
                    var hour = date.Hour;
                    Console.WriteLine(hour.ToString(pt));
                }
                break;
            case "4":
                {
                    var dateOnly = date.Date;
                    Console.WriteLine(dateOnly.ToString("d MMMM yyyy", pt));
                }
                break;
            default:
                {
                    Console.WriteLine("Entrada inválida.");
                }
                break;
        }
    }
}
