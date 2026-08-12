namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likedAt;
        private DateTime _updatedAt;

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime LikedAt
        {
            get { return _likedAt; }
        } 

        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }

    }
}
