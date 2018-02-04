using System;

namespace Domain.HolidayRequestAggregate
{
    public class HolidayRequest : IAggregate
    {
        private HolidayRequestId Id;

        public HolidayRequest(HolidayRequestId id)
        {
            Id = id;
        }

        public HolidayRequestApproved Approve()
        {
            return new HolidayRequestApproved(Id);
        }
    }

    public class HolidayRequestApproved
    {
        public readonly HolidayRequestId Id;

        public HolidayRequestApproved(HolidayRequestId id)
        {
            Id = id;
        }
    }
}
