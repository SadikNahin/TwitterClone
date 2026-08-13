using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _userId;
        private string _type;
        private string _message;
        private bool _isRead;
        



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

        

     }

}
