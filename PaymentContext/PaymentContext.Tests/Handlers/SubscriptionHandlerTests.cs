using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {

          // Red, Green, Refactor

            [TestMethod]
            public void ShouldReturnErrorWhenDocumentExists()
            {   
               var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
               var command = new CreateBoletoSubscriptionCommand();
                   command.FirstName ="Bruce";
                   command.LastName ="Wayne";
                   command.Email ="08166348900";
                   
                   command.BarCode ="hello@balta.io2";
                   command.BoletoNumber ="08166348900";

                   command.PaymentNumber ="12345678911";
                   command.PaidDate = DateTime.Now;
                   command.ExpireDate = DateTime.Now.AddMonths(1);
                   command.Total = 60;
                   command.TotalPaid = 60;
                   command.Payer = "WAYNE CORP";
                   command.PayerDocument ="12345678911";
                   command.PayerDocumentType = EDocumentType.CPF;
                   command.PayerEmail = "batman@dc.com";

                   command.Street = "asdas";
                   command.Number = "1231";
                   command.Neighborhood = "asdasdsa";
                   command.City = "as";
                   command.State = "as";
                   command.Country ="as";
                   command.ZipCode ="12345678";

                handler.Handle(command);
                Assert.AreEqual(false, handler.Valid);

            }

    }
}   