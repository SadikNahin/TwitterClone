using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    internal class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _sentAt;
        private bool _isRead;
        private DateTime _createdAt;
        private DateTime _updatedAt;


        public Message()
        {
            _id = Guid.NewGuid();
          
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }

        public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }

        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime SentAt
        {
            get { return _sentAt; }
            set { _sentAt = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { _updatedAt = value; }
        }

    }
}
