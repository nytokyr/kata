namespace Kata.Domain
{
    public abstract class TreatmentType
    {
        public abstract string CourseOfAction { get; }

        public static TreatmentType CreateTreatment(Treatment.TreatmentEnum treatmentToUse)
        {
            switch (treatmentToUse)
            {
                case Treatment.TreatmentEnum.Surgery:
                    return new Surgery();
                case Treatment.TreatmentEnum.Dietary:
                    return new Dietary();
                case Treatment.TreatmentEnum.Hydration:
                    return new Hydration();
                case Treatment.TreatmentEnum.Prescription:
                    return new Prescription();
                case Treatment.TreatmentEnum.Referral:
                    return new Referral();
            }

            return null;
        }
    }
}
