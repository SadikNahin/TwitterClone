using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public LikeNotification() : base("Like")
        {
        }

        public Guid LikedByUserId { get; set; }

        public void AddMessage(string message)
        {
            Message = message;
        }
    }
}
