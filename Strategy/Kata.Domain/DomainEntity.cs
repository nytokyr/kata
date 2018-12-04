using System;

namespace Kata.Domain
{
    public  class DomainEntity
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            var domain = obj as DomainEntity;
            return domain.Id == this.Id;
        }

       
    }
}
