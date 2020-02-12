﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CareerCloud.Pocos
{
    [Table("System_Country_Codes")]
    public class SystemCountryCodePoco
    {
        [Key]
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicantProfilePoco> ApplicantProfile { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistoryCountryCode { get; set; }
    }
}
