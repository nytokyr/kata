namespace Kata.Domain
{
    public class Surgery : TreatmentType
    {
        public override string CourseOfAction
        {
            get { return "Do something."; }
        }
    }
}