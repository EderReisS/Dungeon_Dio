using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Dio.classes
{
    public enum classeHeroi
    {
        guerreiro = 1,
        mago = 2,
        range = 3,
    }
    class heroi:pessoa
    {
        public int nivel { get; set; }
        public float hp { get; set; }
        public float mp { get; set; }
        public classeHeroi tipoClasse { get; set; }
        
        public heroi(){}
        public string mostrarStatus()
        {
            return "Nome:"+this.nmPessoa+", "+"Nivel:" + this.nivel + ", " + "HP:" + this.hp + ", " + "MP:" + this.mp;
        }
        public override string ToString()
        {
            return $@"Nome:{this.nmPessoa}, Classe:{this.tipoClasse} , Nivel:{this.nivel}";
        }
    }
}
