using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Queries;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Queries
{

    [TestClass]
    public class StudentQueriesTests
    {
        
        private IList<Student> _students;

        public StudentQueriesTests()
        {
            for(var i=0; i<=0; i++)
            {
                _students.Add(new Student(
                    new Name("Aluno", i.ToString()), 
                    new Document("08166348900" + i.ToString(), EDocumentType.CPF),
                    new Email(i.ToString() + "@balta.io")
                    
                ));
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenDocumentNotExists()
        {
            var exp = StudentQueries.GetStudentInfo("12345678911");
            var studn = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, studn);
        }

        [TestMethod]
        public void ShouldReturnStudentWhenDocumentExists()
        {
            var exp = StudentQueries.GetStudentInfo("08166348900");
            var studn = _students.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, studn);
        }
    }
}