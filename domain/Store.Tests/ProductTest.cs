namespace Store.Tests
{
    public class ProductTest
    {
        [Fact]
        public void IsIsbn_withInvalidIsbn_ReturnFAlse()
        {
            bool actual = Product.IsIsbn("ISBN 123");    
            Assert.False(actual);
        }


        [Fact]
        public void IsIsbn_withIsbn10_ReturnTrue()
        {
            bool actual = Product.IsIsbn("ISBN 123-456-789 0");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_withIsbn13_ReturnTrue()
        {
            bool actual = Product.IsIsbn("ISBN 123-456-789 0123");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_withTrashStart_ReturnFalse()
        {
            bool actual = Product.IsIsbn("xxxISBN 123-456-789 0123yyy");
            Assert.False(actual);
        }
    }
}