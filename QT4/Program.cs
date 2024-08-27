/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial
* Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
* Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
* Mana maior que 30.
* Vida do inimigo menor que 50%.
* Nível do jogador maior que 5.

@Lista: 02 - Condicionais
@Autor: PEDRO LIMA
@Data: 25/08/2024
---------------------------------------------------------------------*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        int mana, vida, nivel;
        
        Console.WriteLine ("Qual a quantidade de mana do jogador:");
        int.TryParse(Console.ReadLine(), out mana);
        
        Console.WriteLine ("Qual a quantidade de vida do inimigo:");
        int.TryParse(Console.ReadLine(), out vida);
        
        Console.WriteLine ("Qual o nivel do jogador:");
        int.TryParse(Console.ReadLine(), out nivel);
        
        if(mana > 30 && vida < 50 && nivel > 5)
        {
            Console.WriteLine("Ataque Especial realizado");
        }
         if(mana < 30 && vida < 50 && nivel > 5)
        {
            Console.WriteLine("Mana insuficiente");
        }
         if(mana > 30 && vida > 50 && nivel > 5)
        {
            Console.WriteLine("Vida do inimigo muito alta");
        }
         if(mana > 30 && vida < 50 && nivel < 5)
        {
            Console.WriteLine("Nivel insuficiente");
        }
      
    }
}


