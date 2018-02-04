using System;
using Domain;
using Domain.HolidayRequestAggregate;
using Xunit;

namespace Spec
{
    public class HolidayRequestIdTests
    {
        [Fact]
        public void Equality()
        {
            var a = new HolidayRequestId(new Guid("cec6ae29-96ce-4908-8475-ff980cb6ad52"));
            var b = new HolidayRequestId(new Guid("cec6ae29-96ce-4908-8475-ff980cb6ad52"));

            Assert.Equal(a, b);
        }

        [Fact]
        public void ImplicitOperator()
        {
            HolidayRequestId subject = new Guid("cec6ae29-96ce-4908-8475-ff980cb6ad52");
            Assert.Equal<HolidayRequestId>(new Guid("cec6ae29-96ce-4908-8475-ff980cb6ad52"), subject);
        }
    }
}
