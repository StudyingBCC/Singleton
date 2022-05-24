using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Singleton
    {
        private static Singleton instancia;
        public string nome; 

        private Singleton()
        {

        }

        public static Singleton retornaInstancia()
        {
            if(instancia == null)
            {
                instancia = new Singleton();
            }
            return instancia; 
        }


        //A ideia do Singleton é poder criar vários objetos que recebem os mesmos dados, porem são unicos; 
    }
}
