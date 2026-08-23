using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public sealed class  CommentNotification : Notification
    {
        public CommentNotification(Guid guid) : base("Comment")
        {
        }
        public Guid CommentedByUserId { get; set; }
        public void AddMessage(string message)
        {
            Message = message;
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, CommentedByUserId: {CommentedByUserId}";
        }

        public override string GetMessage()
        {
           return $"User with ID {CommentedByUserId} commented on your post: ";
        }


    }
    
}
