using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithIsbn_CallsGetAllByIsbn()
        {
            var productRepositoryStub = new Mock<IProductRepository>();
            productRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
                                 .Returns(new[] {new Product(1, "", "", "") });

            productRepositoryStub = new Mock<IProductRepository>();
            productRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                                 .Returns(new[] { new Product(2, "", "", "") });

            var productService = new ProductService(productRepositoryStub.Object);
            var validIsbn = "ISBN 12345-67890";

            var actual = productService.GetAllByQuery(validIsbn);
            Assert.Collection(actual, product => Assert.Equal(1, product.Id));


        }
    }
}
