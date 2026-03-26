using Xunit;
using System;
using System.Collections.Generic;
using Bandwidth.Standard.Model;

namespace Bandwidth.Standard.Test.Unit.Model
{
    public class ErrorResponseTests
    {
        private ErrorResponse instance;

        public ErrorResponseTests()
        {
            var link = new Link(rel: "self", href: "/accounts/123/endpoints");
            var error = new Error(type: "validation", description: "Invalid input");

            instance = new ErrorResponse(
                links: new List<Link> { link },
                data: new object(),
                errors: new List<Error> { error }
            );
        }

        [Fact]
        public void ErrorResponseInstanceTest()
        {
            Assert.IsType<ErrorResponse>(instance);
        }

        [Fact]
        public void LinksTest()
        {
            Assert.NotNull(instance.Links);
            Assert.Single(instance.Links);
            Assert.Equal("self", instance.Links[0].Rel);
        }

        [Fact]
        public void DataTest()
        {
            Assert.NotNull(instance.Data);
        }

        [Fact]
        public void ErrorsTest()
        {
            Assert.NotNull(instance.Errors);
            Assert.Single(instance.Errors);
        }

        [Fact]
        public void LinksRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new ErrorResponse(
                links: null,
                data: new object(),
                errors: new List<Error>()
            ));
        }

        [Fact]
        public void DataRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new ErrorResponse(
                links: new List<Link>(),
                data: null,
                errors: new List<Error>()
            ));
        }

        [Fact]
        public void ErrorsRequiredTest()
        {
            Assert.Throws<ArgumentNullException>(() => new ErrorResponse(
                links: new List<Link>(),
                data: new object(),
                errors: null
            ));
        }
    }
}
