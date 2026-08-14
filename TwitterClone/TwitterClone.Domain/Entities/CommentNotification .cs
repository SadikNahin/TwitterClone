using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification() : base("Comment")
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


    }
    
}
