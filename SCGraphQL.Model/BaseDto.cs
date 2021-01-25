using System;

namespace SCGraphQL.Model
{
    public abstract class BaseDto : IDto
    {
        private Guid _id = Guid.NewGuid();
        public override bool Equals(object obj)
        {
            if (obj is BaseDto)
            {
                var ord = obj as BaseDto;
                return ord._id == this._id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
