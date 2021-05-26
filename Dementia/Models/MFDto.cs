using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dementia.Models
{
    class MFDto
    {
        public int IdMedicalFile { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        public int IdAnalyzes { get; set; }
    }
}
