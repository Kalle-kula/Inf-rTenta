using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RadioSystemTests
{
    [TestClass]
    public class RadioFacadeTest
    {
        [TestMethod]
        public void Test_That_Facade_Can_Be_Created()
        {
            RadioFacade facade = new RadioFacade();
            Assert.IsNotNull(facade);
            //Assert.Fail();
        }

        //[TestMethod]
        //[ExpectedException(typeof(NotImplementedException))]
        //public void Test_That_MixMegapol_Generates_Exeption()
        //{
        //    RadioFacade facade = new RadioFacade();
        //    facade.PlayMusic("MixMegapol");
        //    //Assert.Fail();
        //}

        [TestMethod]
        public void Test_That_RixFM_Can_Be_Played()
        {
            RadioFacade facade = new RadioFacade();
            facade.PlayMusic("RixFM");
            Assert.IsTrue(facade.IsPlaying);
            //Assert.Fail();
        }

        [TestMethod]
        public void Test_That_P3_Can_Be_Played()
        {
            RadioFacade facade = new RadioFacade();
            facade.PlayMusic("P3");
            Assert.IsTrue(facade.IsPlaying);
            //Assert.Fail();
        }
    }
}
