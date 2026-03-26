using Xunit;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class PageTests
    {
        private Page instance;

        public PageTests()
        {
            instance = new Page(
                pageSize: 10,
                totalElements: 100,
                totalPages: 10,
                pageNumber: 0
            );
        }

        [Fact]
        public void PageInstanceTest()
        {
            Assert.IsType<Page>(instance);
        }

        [Fact]
        public void PageSizeTest()
        {
            Assert.Equal(10, instance.PageSize);
        }

        [Fact]
        public void TotalElementsTest()
        {
            Assert.Equal(100, instance.TotalElements);
        }

        [Fact]
        public void TotalPagesTest()
        {
            Assert.Equal(10, instance.TotalPages);
        }

        [Fact]
        public void PageNumberTest()
        {
            Assert.Equal(0, instance.PageNumber);
        }
    }
}
