using System;
using Xunit;
using System.Collections.Generic;
namespace EmployersLibrary.Test
{
    public class EmployersLibraryTests
    {
        [Fact]
        public void GetStuffOfficeEmployers_WhenAllPersonInOffice()
        {
            // arrange
            Company FLS = new Company();
            Person alexV = new Person() { LastName = "Vlasov", FirstName = "Alexei" };
            Person andrewV = new Person() { LastName = "Ivlev", FirstName = "Andrei" };
            Person andreiI = new Person() { LastName = "Vlasov", FirstName = "Andrei" };
            Person vladimirF = new Person() { LastName = "Filipov", FirstName = "Vladimir" };
            FLS.stuff = new List<Person>();
            FLS.stuff.Add(vladimirF);
            FLS.stuff.Add(alexV);
            FLS.stuff.Add(andreiI);
            FLS.stuff.Add(andrewV);

            //act
            List<Person> actualResult = FLS.stuffOfficeEmployers;

            // assert
            Assert.Collection(actualResult, item => Assert.Contains("Filipov", item.LastName),
                           item => Assert.Contains("Vlasov", item.LastName), item => Assert.Contains("Vlasov", item.LastName),
                           item => Assert.Contains("Ivlev", item.LastName));
            Assert.DoesNotContain(actualResult, item => item.IsEntered == false);
            Assert.Equal(4, actualResult.Count);
            Assert.Equal(4, FLS.stuff.Count);
            Assert.Collection(FLS.stuff, item => Assert.Contains("Filipov", item.LastName),
                           item => Assert.Contains("Vlasov", item.LastName), item => Assert.Contains("Vlasov", item.LastName),
                           item => Assert.Contains("Ivlev", item.LastName));
        }


        [Fact]
        public void GetStuffOfficeEmployers_WhenNobodyPersonInOffice()
        {
            // arrange
            Company FLS = new Company();
            Person alexV = new Person() { LastName = "Vlasov", FirstName = "Alexei" };
            Person andrewV = new Person() { LastName = "Ivlev", FirstName = "Andrei" };
            Person andreiI = new Person() { LastName = "Vlasov", FirstName = "Andrei" };
            Person vladimirF = new Person() { LastName = "Filipov", FirstName = "Vladimir" };
            FLS.stuff = new List<Person>();
            FLS.stuff.Add(vladimirF);
            FLS.stuff.Add(alexV);
            FLS.stuff.Add(andreiI);
            FLS.stuff.Add(andrewV);

            //act
            FLS.PersonComeOut(vladimirF);
            FLS.PersonComeOut(alexV);
            FLS.PersonComeOut(andreiI);
            FLS.PersonComeOut(andrewV);
            List<Person> actualResult = FLS.stuffOfficeEmployers;

            // assert

            Assert.Equal(0, actualResult.Count);
            Assert.Equal(4, FLS.stuff.Count);
        }

        [Fact]
        public void GetAbsentOfficeEmployers_WhenAllPersonInOffice()
        {
            // arrange
            Company FLS = new Company();
            Person alex = new Person() { LastName = "Vlasov", FirstName = "Alexei" };
            Person andrew = new Person() { LastName = "Ivlev", FirstName = "Andrei" };
            Person andrei = new Person() { LastName = "Vlasov", FirstName = "Andrei" };
            Person pavel = new Person() { LastName = "Ivanov", FirstName = "Pavel" };
            FLS.stuff = new List<Person>();
            FLS.stuff.Add(alex);
            FLS.stuff.Add(andrei);
            FLS.stuff.Add(andrew);
            FLS.stuff.Add(pavel);

            // act
            List<Person> actualResult = FLS.stuffOfficeAbsentEmployers;

            // assert
            Assert.Equal(0, actualResult.Count);
        }  

        [Fact]
        public void GetAbsentOfficeEmployers_WhenOnePersonComeOut()
        {
            // arrange
            Company FLS = new Company();
            Person alex = new Person() { LastName = "Vlasov", FirstName = "Alexei" };
            Person andrew = new Person() { LastName = "Ivlev", FirstName = "Andrei" };
            Person andrei = new Person() { LastName = "Vlasov", FirstName = "Andrei" };
            Person pavel = new Person() { LastName = "Ivanov", FirstName = "Pavel" };
            FLS.stuff = new List<Person>();
            FLS.stuff.Add(alex);
            FLS.stuff.Add(andrei);
            FLS.stuff.Add(andrew);
            FLS.stuff.Add(pavel);

            // act
            FLS.PersonComeOut(pavel);
            List<Person> actualResult = FLS.stuffOfficeAbsentEmployers;


            // assert
            Assert.Collection(actualResult, item => Assert.Contains("Ivanov", item.LastName));
            Assert.Contains(actualResult, item => item.IsEntered == false);
            Assert.Equal(1, actualResult.Count);

        }
        [Fact]
        public void GetAbsentOfficeEmployers_WhenPersonComeOutAndComeIn()
        {
            // arrange
            Company FLS = new Company();
            Person alex = new Person() { LastName = "Vlasov", FirstName = "Alexei" };
            Person andrew = new Person() { LastName = "Ivlev", FirstName = "Andrei" };
            Person andrei = new Person() { LastName = "Vlasov", FirstName = "Andrei" };
            Person pavel = new Person() { LastName = "Ivanov", FirstName = "Pavel" };
            FLS.stuff = new List<Person>();
            FLS.stuff.Add(alex);
            FLS.stuff.Add(andrei);
            FLS.stuff.Add(andrew);
            FLS.stuff.Add(pavel);

            // act
            FLS.PersonComeOut(pavel);
            FLS.PersonComeOut(andrei);
            FLS.PersonComeOut(alex);
            FLS.PersonComeIn(pavel);
            List<Person> actualResult = FLS.stuffOfficeAbsentEmployers;


            //assert
            Assert.Collection(actualResult, item => Assert.Contains("Ivanov", item.LastName));
            Assert.Contains(actualResult, item => item.IsEntered == false);
            Assert.Equal(1, actualResult.Count);

        }
    }
}
