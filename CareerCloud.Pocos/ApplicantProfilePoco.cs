﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{

    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        public Guid Login { get; set; }
        [Column("Current_Salary")]
        public Decimal? CurrentSalary { get; set; }
        [Column("Current_Rate")]
        public Decimal? CurrentRate { get; set; }
        [Column("Currency")]
        public string  Currency { get; set; }
        [Column("Country_Code")]
        public string Country{get;set;}
        [Column("State_Province_Code")]
        public string Province { get; set; }
        [Column("Street_Address")]
        public string Street { get; set; }
        [Column("City_Town")]
        public string City { get; set; }
        [Column("Zip_Postal_Code")]
        public string PostalCode { get; set; }
        [NotMapped]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }
        public virtual ICollection<ApplicantEducationPoco> ApplicantEducation { get; set; }
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplication { get; set; }
        public virtual SecurityLoginPoco SecurityLogin { get; set; }
        public virtual SystemCountryCodePoco SystemCountryCodes { get; set; }
        public virtual ICollection<ApplicantResumePoco> ApplicantProfileResume { get; set; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkillProfile { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistoryProfile { get; set; }
    }
}
