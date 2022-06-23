using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    internal class Clinic
    {
        private List<Visit> _allVisits;
        private List<Patient> _allPatients;
        private List<Staff> _allStaff;

        public void AddPatient(int id, string name)
        {
            var patient = new Patient(id, name);
            _allPatients.Add(patient);
        }

        public void AddStaff(int id, string name, Staff.Specialization specialization)
        {
            var staff = new Staff(id,name,specialization);
            _allStaff.Add(staff);
        }

        public void AddVisit(Patient patient, List<Staff> staffInvolved, string procedure, string description, string toothInvolved)
        {
            var visit = new Visit(patient, staffInvolved, procedure, description, toothInvolved);
            _allVisits.Add(visit);
        }

        public List<Patient> GetMenagerReport(Staff staff)
        {
            return _allVisits.Where(x => x._staffInvolved.Contains(staff)).Select(x => x.patient).ToList();
        }

        public List<Visit> GetAllPatientVisits(Patient patient)
        {
            return _allVisits.Where(x => x.patient == patient).ToList();
        }

        public List<Visit> GetAllStaffVisits(Staff staff)
        {
            return _allVisits.Where(x => x._staffInvolved.Contains(staff)).ToList();
        }

        private static Clinic instance = null;

        private Clinic()
        {
        }

        public static Clinic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Clinic();
                }
                return instance;
            }
        }
    }
}
