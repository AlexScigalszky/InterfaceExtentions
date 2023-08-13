using InterfaceExtentions.Impl;
using InterfaceExtentions.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceExtentions.Interfaces;

namespace InterfaceExtentions.Extensions.Tests
{
    [TestClass()]
    public class WrapperExtensionsTests
    {
        [TestMethod()]
        public void Use_Class_Class_Extension_Test()
        {
            var wrapper = new Wrapper<Request, Response>();
            
            var result = wrapper.ExecuteClassClass<Request, Response>();

            Assert.AreEqual("[Class, Class] Type: Wrapper`2", result);
        }

        [TestMethod()]
        public void Use_Class_Interface_Extension_Test()
        {
            var wrapper = new Wrapper<IRequest, IResponse>();

            var result = wrapper.ExecuteClassInterface<IRequest, IResponse>();

            Assert.AreEqual("[Class, Interface] Type: Wrapper`2", result);
        }

        [TestMethod()]
        public void Use_Interface_Interface_Extension_Test()
        {
            IWrapper<IRequest, IResponse> wrapper = new Wrapper<Request, Response>();

            var result = wrapper.ExecuteInterfaceInterface<IRequest, IResponse>();

            Assert.AreEqual("[Interface, Interface] Type: Wrapper`2", result);
        }

        [TestMethod()]
        public void Use_Interface_Class_Extension_Test()
        {
            IWrapper<Request, Response> wrapper = new Wrapper<Request, Response>();

            var result = wrapper.ExecuteInterfaceClass<Request, Response>();

            Assert.AreEqual("[Interface, Class] Type: Wrapper`2", result);
        }
    }
}