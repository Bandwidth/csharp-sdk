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
        public void PageFieldsTest()
        {
            Assert.IsType<Page>(instance);
            Assert.Equal(10, instance.PageSize);
            Assert.Equal(100, instance.TotalElements);
            Assert.Equal(10, instance.TotalPages);
            Assert.Equal(0, instance.PageNumber);
        }
    }
}
