using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private string _type;
        private string _message;
        private bool _isRead;
        private DateTime _createdAt;
        private DateTime _updated;


        public Notification()
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
            set { _userId = value; }
        }

            public string Type

        {
            get { return _type; }
            set { _type = value; }

        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }



        public DateTime UpdatedAt
        {
            get { return _updated; }
            set { _updated = value; }
        }

        }


}
