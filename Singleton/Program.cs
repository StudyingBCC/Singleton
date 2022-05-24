using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s = Singleton.retornaInstancia();
            s.nome = "Fabiana";

            Singleton x = Singleton.retornaInstancia();
            Console.WriteLine(x.nome);

            Console.WriteLine("-----------------------------------------"); 

            Console.WriteLine("BEM-VINDOS A MINHA MAQUINA DE CHOCOLATE :)"); 

            MaquinaChocolate maquinaUm = MaquinaChocolate.retornaMaquina();
            MaquinaChocolate maquinaDois = MaquinaChocolate.retornaMaquina(); 


            maquinaUm.Esvazia();
            maquinaDois.Preenche();
            maquinaUm.desligarForno();
            maquinaDois.Esquenta(); 
        }
    }
}
