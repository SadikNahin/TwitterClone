using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public FriendRequestNotification() : base("FriendRequest")
        {
        }
        public Guid RequestedByUserId { get; set; }
        public void AddMessage(string message)
        {
            Message = message;
        }



        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, RequestedByUserId: {RequestedByUserId}";
        }




    }
    
}
