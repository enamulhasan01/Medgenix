using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medgenix;
namespace Medgenix
{
    public class ContributorData
    {
        public int Id { get; set; } 
        public string DiseaseName { get; set; }
        public string Reason { get; set; }
        public string Symptom { get; set; }
        public string Treatment { get; set; }
        public string Hospital { get; set; }
        public string BloodGroup { get; set; }
        public string AgeGroup { get; set; }
        public string CureStatus { get; set; }
        public string Area { get; set; }
        public string DateTime { get; set; } 

        public string SubmittedByRole { get; set; }

        public string Drive {  get; set; }

       
        public int ContributorId {  get; set; }

    }

}
