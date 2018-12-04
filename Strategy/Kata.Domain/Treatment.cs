namespace Kata.Domain
{
    public class Treatment : DomainEntity
    {
        public TreatmentType TreatmentType { get; }

        public enum TreatmentEnum
        {
            Surgery,
            Dietary,
            Hydration,
            Prescription,
            Referral
        }

        public Treatment()
        {

        }

        public Treatment(TreatmentEnum treatmentEnum)
        {
            switch (treatmentEnum)
            {
                case Treatment.TreatmentEnum.Surgery:
                    this.TreatmentType = new Surgery();
                    break;
                case Treatment.TreatmentEnum.Dietary:
                    this.TreatmentType = new Dietary();
                    break;
                case Treatment.TreatmentEnum.Hydration:
                    this.TreatmentType = new Hydration();
                    break;
                case Treatment.TreatmentEnum.Prescription:
                    this.TreatmentType = new Prescription();
                    break;
                case Treatment.TreatmentEnum.Referral:
                    this.TreatmentType = new Referral();
                    break;
            }


        }
    }
}