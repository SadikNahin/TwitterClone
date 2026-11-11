

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable, INotifiable
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

        private List<Guid> _followers = new List<Guid>();

        private List<Guid> _inComingNotifications = new List<Guid>();

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, User: {FirstName} {LastName}, Email: {Email}";
        }

        public void Follow(Guid userId)
        {
            if (!_followers.Contains(userId))
            {
                _followers.Add(userId);
            }
        }


        public void Unfollow(Guid userId)
        {
            if (_followers.Contains(userId))
            {
                _followers.Remove(userId);
            }
        }

        public void AddNotification(Guid notificationId)
        {
            if (!_inComingNotifications.Contains(notificationId))
            {
                _inComingNotifications.Add(notificationId);
            }
        }

    }
}
