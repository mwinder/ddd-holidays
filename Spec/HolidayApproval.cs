using System;
using Domain.HolidayRequestAggregate;
using Xunit;

namespace Spec
{
    public class HolidayApproval
    {
        [Fact]
        public void ApproveHoliday()
        {
            var id = new HolidayRequestId(Guid.NewGuid());
            var subject = new HolidayRequest(id);
            var ev = subject.Approve();

            Assert.Equal(id, ev.Id);
        }
    }
}
