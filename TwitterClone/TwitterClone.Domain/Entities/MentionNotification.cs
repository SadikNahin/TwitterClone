using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification
    {
        // Added property to hold the user who mentioned someone
        public Guid MentionedByUserId { get; private set; }

        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            MentionedByUserId = mentionedByUserId;
        }
    }
}
