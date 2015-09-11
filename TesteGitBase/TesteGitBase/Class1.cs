using System;
using System.Collections.Generic;
using System.Web;

namespace TesteGitBase
{
    public class Class1
    {
        private int valorUm()
        {
            return 2;        
        }
        private int valorDois()
        {
            return 3;
        }
        public int Soma()
        {            
            return (valorUm() + valorDois());
        }
    }

}