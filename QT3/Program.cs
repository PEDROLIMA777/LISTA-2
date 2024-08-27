/*-------------------------------------------------------------------
Questão 3: Loja de Poções
* Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
* Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
* Guerreiro recebe 10% de desconto na compra de poções de Vida.
* Mago recebe 15% de desconto na compra de poções de Mana.
* Paladino recebe 20% de desconto na compra de poções de Resistência.
* Exiba o preço total com e sem desconto.
@Lista: 02 - Condicionais
@Autor: PEDRO LIMA 
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
            string classe, tipodPocao;
            int quantidade, resultados;
            double total;
            
        Console.WriteLine ("Qual a classe do seu jogador?");
        classe = Console.ReadLine();
        Console.WriteLine ("Qual o tipo de pocao que voce quer comprar:");
        tipodPocao = Console.ReadLine();
        
        Console.WriteLine ("Qual a quantidade de pocoes quer voce quer:");
        int.TryParse(Console.ReadLine(), out quantidade);
        
        if(tipodPocao == "vida")
        {
            resultados = 10 * quantidade;
            Console.WriteLine($"Resultado sem o desconto:{resultados}");
        }
        if(tipodPocao == "mana")
        {
        resultados = 15 * quantidade;
        Console.WriteLine($"Resultado sem o desconto:{resultados}");
        }
         if(tipodPocao == "resistencia")
        {
        resultados = 20 * quantidade;
        Console.WriteLine($"Resultado sem o desconto :{resultados}");
        }
        if(classe == "guerreiro" && tipodPocao == "vida")
        {
            resultados = (10 * quantidade);
            total = resultados - (resultados * 0.1);
            Console.WriteLine($"O resultado sem o desconto:{resultados}");
            Console.WriteLine($"Resultado com o desconto:{total}");
        }
        if(classe == "mago" && tipodPocao == "mana")
        {
            resultados = (15 * quantidade);
            total = resultados - (resultados * 0.15);
             Console.WriteLine($"O resultado sem o desconto:{resultados}");
            Console.WriteLine($"Resultado com o descoonto:{total}");
        }
        if(classe == "paladino" && tipodPocao == "resistencia")
        {
            resultados = (20 * quantidade);
           total = resultados - (resultados * 0.2);
             Console.WriteLine($"O resultado sem o  desconto:{resultados}");
           Console.WriteLine($"Resultado com o desconto:{total}");
        }
    }
}