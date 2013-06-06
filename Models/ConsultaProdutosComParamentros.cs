using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ConsultaProdutosComParamentros
    {

        public IEnumerable<Product> retornaConsultaParamentros()
        {
            //Instânciado o modelo no EF
            AdventureWorks2012Entities Model = new AdventureWorks2012Entities();

            //Criando uma lista de string para passar como parãmentros
            List<string> productNumber = new List<string> { "BA-8327", "BL-2036", "CA-6738", "CN-6137" };

            //Declarando uma variável do tipo IEnumerable para receber o retorno da consulta
            IEnumerable<Product> ret;

            //Passando para consulta os parãmentros
            ret = from p in Model.Product
                  where productNumber.Contains(p.ProductNumber)
                  select p;
            return ret;
        }
    }
}