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

        public HolidayRequestDeclined Decline()
        {
            return new HolidayRequestDeclined(Id);
        }

        public HolidayRequestCanceled Cancel()
        {
            return new HolidayRequestCanceled(Id);
        }
    }

    public class HolidayRequestDeclined
    {
        public readonly HolidayRequestId Id;

        public HolidayRequestDeclined(HolidayRequestId id)
        {
            Id = id;
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

    public class HolidayRequestCanceled
    {
        public readonly HolidayRequestId Id;

        public HolidayRequestCanceled(HolidayRequestId id)
        {
            Id = id;
        }
    }
}
