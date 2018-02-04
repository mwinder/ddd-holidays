using System;

namespace Domain.HolidayRequestAggregate
{
    public class HolidayRequestId : IEquatable<HolidayRequestId>
    {
        private readonly Guid _id;

        public HolidayRequestId(Guid id)
        {
            _id = id;
        }

        public static implicit operator Guid(HolidayRequestId value) => value._id;
        public static implicit operator HolidayRequestId(Guid id) => new HolidayRequestId(id);

        public bool Equals(HolidayRequestId other)
        {
            return _id == other._id;
        }
    }
}