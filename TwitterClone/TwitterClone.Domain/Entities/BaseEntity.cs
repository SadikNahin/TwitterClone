using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? _updatedAt { get; set; }
        public Guid _createdBy { get; set; }
        public Guid? _updatedBy { get; set; }



        public BaseEntity(Guid guid)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }

        public virtual string DescribeRecord()
        {

            return $"Id: {Id}, CreatedAt: {CreatedAt}, UpdatedAt: {_updatedAt}, CreatedBy: {_createdBy}, UpdatedBy: {_updatedBy}";



        }





    }
}
