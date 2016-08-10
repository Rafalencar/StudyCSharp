using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Study.LojaVirtual.Web.HtmlHelpers;
using Study.LojaVirtual.Web.Models;

namespace Study.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void TestaPaginacao()
        {
            //Arrange
            HtmlHelper htmlHelper = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensTotal = 28,
                ItensPorPagina = 10
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;


            //Act
            MvcHtmlString resultado = htmlHelper.PageLinks(paginacao, paginaUrl);

            //Assert

            Assert.AreEqual(
                    @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                 + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                 + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
                 );
        }  
    }
}
