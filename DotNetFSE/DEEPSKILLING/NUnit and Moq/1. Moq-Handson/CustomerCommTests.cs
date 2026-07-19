using NUnit.Framework;
using Moq;
using CustomerCommLib;


namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {

        private Mock<IMailSender> mockMailSender;

        private CustomerCommLib.CustomerComm customerComm;


        [SetUp]
        public void Setup()
        {
            mockMailSender = new Mock<IMailSender>();


            mockMailSender
                .Setup(x => x.SendMail(
                    It.IsAny<string>(),
                    It.IsAny<string>()))
                .Returns(true);


            customerComm =
                new CustomerCommLib.CustomerComm(
                    mockMailSender.Object
                );
        }


        [Test]
        public void SendMailToCustomer_ReturnsTrue()
        {
            bool result =
                customerComm.SendMailToCustomer();


            Assert.IsTrue(result);
        }

    }
}