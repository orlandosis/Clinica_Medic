using Clinica_Medic.Controllers;
using Clinica_Medic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestClinica
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestMethod1Async()
        {
            var controller = new CIE10Controller();
            var result = await controller.Details(1) as ViewResult;
            var product = (CIE10)result.ViewData.Model;
            Assert.AreEqual("A001", product.cod);
            Assert.AreEqual("Diarrea", product.name);
        }
    }
}
