using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {


        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private string _comment;
        private DateTime _createdAt;
        private DateTime _updated;

        public Retweet()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime UpdatedAt
        {
            get { return _updated; }
            set { _updated = value; }
        }



    }
}
