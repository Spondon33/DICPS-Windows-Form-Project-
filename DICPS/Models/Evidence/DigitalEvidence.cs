using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICPS.Models.Evidence
{
    public class DigitalEvidence : Evidence
    {
        public override bool Verify()
        {
            return VerifyDigitalHash();
        }

        public bool VerifyDigitalHash()
        {
            return !string.IsNullOrWhiteSpace(HashValue);
        }
    }
}
