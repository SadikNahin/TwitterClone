

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        

        public User() : base(Guid.NewGuid())
        { 
            
        }

        

        public string FirstName { get; set;  }
        public string LastName { get; set; }
        public string Email { get; set; }



        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, User: {FirstName} {LastName}, Email: {Email}";
        }

       
      
    }
}
