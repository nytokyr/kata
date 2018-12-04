using System;
using System.Collections.Generic;

namespace Kata.Domain
{
    public class Pet : DomainEntity
    {
        public List<Treatment> Treatments { get; set; } = new List<Treatment>();

        public void AddTreatment(Treatment treatment)
        {
            this.Treatments.Add(treatment);
        }
    }
}
