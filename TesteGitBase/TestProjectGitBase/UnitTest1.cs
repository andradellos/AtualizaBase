using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteGitBase;

namespace TestProjectGitBase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void valor_nao_pode_ser_menor_que_5()
        {
            Class1 CSoma = new Class1();           
           
            if(CSoma.Soma() < 5){

                Assert.Fail("Valor pode ser menor que 5!");
            }
        }
    }
}
