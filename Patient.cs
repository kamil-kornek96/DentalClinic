using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    internal class Patient : Person
    {
        public bool IsLoyal()
        {
            var clinic = Clinic.Instance;
            List<Visit> allPatientVisits = clinic.GetAllPatientVisits(this);
            var currentDate = DateTime.Now;
            var allPatientVisitsInLastThreeMonths =
                allPatientVisits.Where(x => x.visiDateTime > currentDate.AddMonths(-3)).ToList();
            if (allPatientVisitsInLastThreeMonths.Count >= 3)
                return true;
            return false;
        }

        public Patient(int id, string name) :base(id,name)
        {
            
        }
    }
}
