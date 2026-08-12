using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        public User() 
        { 
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }

        public string FirstName { get; set;  }
        public string LastName { get; set; }
        public string Email { get; set; }

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
