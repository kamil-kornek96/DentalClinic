using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    internal class Staff : Person
    {
        private Specialization specialization { get; set; }


        public List<string> GetPerformedProcedures()
        {
            var clinic = Clinic.Instance;
            var allStaffVisits = clinic.GetAllStaffVisits(this);
            return allStaffVisits.Select(x => x.procedure).ToList();
        }

        public enum Specialization
        {
            dentist,
            dentalHygenist,
            xRayTechnician
        }

        public Staff(int id, string name, Specialization specialization) : base(id,name)
        {
            this.specialization = specialization;
        }
    }
}
