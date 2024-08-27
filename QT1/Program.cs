/*-------------------------------------------------------------------
Questão 1: Seleção de Armadura
* Contextualização: Em um jogo de RPG, cada classe de personagem (Guerreiro, Arqueiro, Mago)
possui requisitos diferentes para a escolha da armadura ideal. A armadura é considerada ideal
se a defesa oferecida for alta o suficiente para a classe e se a penalidade de agilidade for
aceitável.
* Comando:
Crie um programa que receba a classe do personagem, o valor de defesa da armadura e a
penalidade de agilidade. O programa deve informar se a armadura é adequada ou não para a
classe.
* Para o Guerreiro, a defesa deve ser maior que 50 e a penalidade de agilidade menor que 20.
* Para o Arqueiro, a defesa deve ser maior que 30 e a penalidade de agilidade menor que 10.
* Para o Mago, a defesa deve ser maior que 20 e a penalidade de agilidade menor que 40.
@Lista: 02 - Condicionais
@Autor: PEDRO LIMA
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        string? classe;
        int defesa, penalidade;

        
        Console.WriteLine("Qual a classe do jogador?");
        classe = Console.ReadLine();
        Console.WriteLine("Quanto vai ser a defesa do seu jogador? ");
        int.TryParse(Console.ReadLine(), out defesa);
        Console.WriteLine("Quanto vai ser a penalidade que seu jogador vai receber? ");
        int.TryParse(Console.ReadLine(), out penalidade);
        if (classe == "guerreiro")
        {
            if (defesa > 50 & penalidade < 20)
            {
                Console.WriteLine("Armadura adequada");
            }
            else
            {

                Console.WriteLine("Armadura inadequada");
            }
        }
        if (classe == "arqueiro")
        {
            if (defesa > 30 && penalidade < 10)
            {
                Console.WriteLine("Armadura adequada");
            }
            else
            {

                Console.WriteLine("Armadura inadequada");
            }
        }
        if (classe == "mago")
        {
            if (defesa > 20 && penalidade < 40)
            {
                Console.WriteLine("Armadura adequada");
            }
            else
            {

                Console.WriteLine("Armadura inadequada");
            }
        }
    }
}

