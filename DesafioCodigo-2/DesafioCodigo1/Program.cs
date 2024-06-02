//Desafio 1: Calculando o Dano

/*
Desafio
Em jogos de RPG, é comum haver ações de ataque dos personagens, que causam um certo dano ao inimigo. Este dano pode ser calculado de diferentes formas, dependendo do sistema do jogo. Neste desafio, você deve criar uma função que calcula o dano de um ataque, levando em consideração o valor do ataque e a defesa do inimigo.

Crie uma função chamada "calcular_dano" que recebe dois parâmetros: "ataque" e "defesa". A função deve retornar o valor do dano causado pelo ataque, utilizando a seguinte fórmula:

dano = ataque - defesa

Se o valor do dano for negativo, ele deve ser considerado zero.

Entrada:
Seu programa deverá receber uma  entrada para a função "calcular_dano", que irá solicitar ao usuário que insira dois valores: o valor do ataque e o valor da defesa do inimigo. Esses valores serão passados como parâmetros para a função.

Saída:
A saída deve ser exibida com a frase "O dano causado pelo ataque foi: " seguida do valor do dano calculado. Caso o valor do dano seja negativo, deve ser exibido zero.

Por exemplo, se o valor do ataque for 10 e o valor da defesa do inimigo for 8, a chamada da função "calcular_dano" deve resultar na seguinte saída:

"O dano causado pelo ataque foi: 2"
*/

//Solução
using System;

namespace DesafioCodigo1
{
    class Program
    {
        static int CalcularDano(int ataque, int defesa)
        {
        int dano = ataque - defesa;
            if (dano < 0)
            {
                return 0;
            }
            else
            {
                return dano;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número de ataques: ");
            int ataque = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de defesas: ");
            int defesa = int.Parse(Console.ReadLine());

            int danoCausado = CalcularDano(ataque, defesa);
            Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
        }
    }
}
