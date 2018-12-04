namespace Kata.Domain
{
    public class Referral : TreatmentType
    {
        public override string CourseOfAction
        {
            get { return "Do referral."; }
        }
    }
}
