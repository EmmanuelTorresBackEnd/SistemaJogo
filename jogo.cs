using System;

namespace sistemaJogo
{
public abstract class Jogo
    {
        public string nome { get; set; }
        
        public string idJogo { get; set; }

        public string genero { get; set; } 
        
        public string resumoJogo { get; set; }
        
        public DateTime dataLancamento { get; set; }

        public bool lojaDisponivel { get; set; }

        public bool online { get; set; }

    }

}