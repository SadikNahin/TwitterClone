using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {


        private Guid _userId;
        private Guid _tweetId;
        private string _comment;


        public Retweet() : base(Guid.NewGuid())
        {

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


        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, Retweet: {Comment}, UserId: {UserId}, TweetId: {TweetId}";
        }




    }
}
