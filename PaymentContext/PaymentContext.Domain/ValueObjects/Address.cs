using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

         AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Street, 3, "Address.Street", "A rua deve conter pelo menos 3 caracteres")
            .HasMinLen(Number, 1, "Address.Number", "Número deve conter pelo menos 1 caracteres"));
        }

        public string Street { get; private set; }

        public string Number { get; private set; }

        public string Neighborhood { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }

        public string Country { get; private set; }

        public string ZipCode { get; private set; }

    }
}