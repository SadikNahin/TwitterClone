using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _created;
        private DateTime _updated;

        public Follow()
        {
            _id = Guid.NewGuid();
            _created = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }

        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }

        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        public DateTime Updated
        {
            get { return _updated; }
            set { _updated = value; }
        }


    }
}
