using System;

namespace TwitterClone.Domain.Entities
{
    public sealed class LikeNotification : Notification
    {
        public Guid LikedByUserId { get; set; }

        

        public LikeNotification(Guid likedByUserId) : base("Like")
        {
            LikedByUserId = likedByUserId;
        }

        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, LikedByUserId: {LikedByUserId}";
        }

        public override string GetMessage()
        {
            return $"User with ID {LikedByUserId} liked your post.";
        }
    }
}
