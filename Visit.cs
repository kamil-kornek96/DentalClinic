using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    internal class Visit
    {
        internal Patient patient { get; set; }
        internal List<Staff> _staffInvolved { get; set; }
        internal string procedure { get; set; }
        private string description { get; set; }
        private string toothInvolved { get; set; }
        internal DateTime visiDateTime { get; set; }

        public Visit(Patient patient, List<Staff> staffInvolved, string procedure, string description, string toothInvolved)
        {
            this.patient = patient;
            _staffInvolved = staffInvolved;
            this.procedure = procedure;
            this.description = description;
            this.toothInvolved = toothInvolved;
            visiDateTime = DateTime.Now;
        }
    }
}
