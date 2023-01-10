using Spg.DomainLinQ.App.Model;

namespace EntityTest
{
    public class UnitTest1
    {
        Shop shop1 = new Shop(
            "Wands and more",
            new Guid());

        Address address1 = new Address(
            "Agasse",
            "1212",
            "London",
            "12A");

        Address address2 = new Address(
            "Bgasse",
            "1212",
            "jadnf",
            "13A");



        [Fact]
        public void UserCreated_SuccessTest()
        {
            //Arrange
            User user1 = new User(
                1,
                new Guid(),
                "Albus",
                "Dumbledore",
                "hogwarts@wizmail.wiz",
                Gender.MALE,
                shop1,
                address1,
                address2);

            //Act

            //Assert
            Assert.NotNull(user1);
        }

        [Fact]
        public void ShopCreated_SuccessTest()
        {
            //Arrange and Act

            //Assert
            Assert.NotNull(shop1);
        }

        [Fact]
        public void ProductCreated_SuccessTest()
        {
            //Arrange and Act
            Product p1 = new Product(
                "HalloDescription",
                "143875134",
                21,
                null,
                null,
                shop1);

            //Assert
            Assert.NotNull(p1);
        }

        [Fact]
        public void SupplierCreated_SuccessTest()
        {
            //Arrange and Act
            

            Supplier s1 = new Supplier(
                "hoho",
                "hihi",
                "hoho@hihi.haha",
                new Guid(),
                address1,
                address2);

            //Assert
            Assert.NotNull(s1);
        }

        [Fact]
        public void PriceCreated_SuccessTest()
        {
            //Arrange and Act
            Product p1 = new Product(
                "HalloDescription",
                "143875134",
                21,
                null,
                null,
                shop1);

            Price price1 = new Price(
                10.0m,
                20,
                DateTime.Now,
                new Guid(),
                p1
                );

            
            //Assert
            Assert.NotNull(price1);
        }
    }
}