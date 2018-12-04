using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Domain
{
   public class Prescription:TreatmentType
    {
        public override string CourseOfAction
        {
            get { return "Do prescription."; }
        }
    }
}
