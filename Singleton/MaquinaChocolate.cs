using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class MaquinaChocolate
    {
        private static MaquinaChocolate maquina;
        private int Quantidade { get; set; }
        public int Temperatura { get; set; } 

        private MaquinaChocolate(int quantidade, int temperatura)
        {
            this.Quantidade = quantidade;
            this.Temperatura = temperatura;
        }

        public static MaquinaChocolate retornaMaquina()
        {
            if (maquina == null)
            {
                maquina = new MaquinaChocolate(0,0);
            }
            return maquina; 
        }

        public void Preenche()
        {
            if (this.Quantidade == 0 && this.Temperatura == 0)
            {
                this.Quantidade += 1;
                Console.WriteLine("Preenchido"); 
            }
            else
                Console.WriteLine("Forno com chocolates");
        }

        public void Esquenta()
        {
            if(Quantidade > 0)
            {
                this.Temperatura += 1;
                Console.WriteLine("Esquentando"); 
            }
            else
            {
                Console.WriteLine("O forno está desligado!"); 
            }
        }
           
        public void Esvazia()
        {
            if (this.Quantidade > 0 && this.Temperatura == 0)
            {
                this.Quantidade -= 1;
                Console.WriteLine("Esvaziando");
            }

        }

        public void desligarForno()
        {
            if(this.Quantidade == 0)
            {
                Console.WriteLine("Forno Desligado");
                this.Temperatura = 0; 
            }
            else
            {
                Console.WriteLine("Forno Ligado"); 
            }
        }

    }
}
