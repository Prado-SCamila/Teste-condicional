using System;

namespace Teste_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18){
                Console.WriteLine("Você gostaria de participar do time de CS GO ?");   
                string resposta =Console.ReadLine();
                if(resposta == "SIM"){
                    Console.WriteLine("Compareça à secretaria - Falar com a Sara");

                }else{
                    Console.WriteLine("Blz! Passar bem.");
                }
            }else{
                Console.WriteLine("Você gostaria de participar do time de LOL? Sim ou não?");
                string resposta = Console.ReadLine();
                if(resposta == "SIM"){
                    Console.WriteLine("Compareça a secretaria - Falar com a Jucelina");

                }else{
                    Console.WriteLine("Muito Obrigado");
                }

            }
            }
        }
    }

