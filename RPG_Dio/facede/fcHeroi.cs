using RPG_Dio.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Dio.facede
{
    class fcHeroi
    {
       public fcHeroi(){}

       public static heroi montarHeroi(string Nome, int tipo, int idade, int nivel)
        {
            var heroi = new heroi();
            heroi.nmPessoa = Nome;
            heroi.tipoClasse = (classeHeroi)tipo;
            heroi.idade = idade;
            heroi.nivel = nivel;
            return heroi;
        }
        public static string atacar(heroi heroiAt)
        {
            string ataque;
            switch ((int)heroiAt.tipoClasse)
            {
                case 1:
                    ataque = "atacou com a espada!";
                    break;
                case 2:
                    ataque = "lançou uma bola de fogo!";
                    break;
                case 3:
                    ataque = "lançou  uma  flexa!";
                    break;
                default:
                    ataque = "o ataque falhou";
                    break;
            }

            return $"{heroiAt.nmPessoa??"Anônimo"} {ataque??""}";
        }

    }
}
