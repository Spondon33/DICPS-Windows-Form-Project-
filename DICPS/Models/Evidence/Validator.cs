using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICPS.Models.Evidence
{
    public static class Validator
    {
        public static bool ValidateEvidenceInput(string description, DateTime dateCollected, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                errorMessage = "Description is required.";
                return false;
            }

            if (!ValidateDateInput(dateCollected, out errorMessage))
            {
                return false;
            }

            errorMessage = "";
            return true;
        }

        public static bool ValidateDateInput(DateTime date, out string errorMessage)
        {
            if (date > DateTime.Now)
            {
                errorMessage = "Date collected cannot be in the future.";
                return false;
            }

            errorMessage = "";
            return true;
        }
    }
}
