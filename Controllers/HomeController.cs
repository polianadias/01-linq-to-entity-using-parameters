using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Show()
        {
            //Instânciando a variável retorno para receber o resultado da consulta
            IEnumerable<Product> retorno;
            //Instânciando o método de consulta parãmentros
            var products = new ConsultaProdutosComParamentros();
            retorno = products.retornaConsultaParamentros();
            //Passando o retorno para view
            return View(retorno);
        }


    }
}
