using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dementia.Models
{
    class PatientDto
    {
        public int IdPatient { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Othername { get; set; }
        public decimal NumberPhone { get; set; }
        public decimal NumberPassport { get; set; }
        public string Address { get; set; }

    }
}
