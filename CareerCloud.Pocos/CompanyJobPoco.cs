using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]
    public class CompanyJobPoco: IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        [Column("Profile_Created")]
        public DateTime? ProfileCreated { get; set; }
        [Column("Is_Inactive")]
        public Boolean IsInactive { get; set; }
        [Column("Is_Company_Hidden")]
        public Boolean IsCompanyHidden { get; set; }
        [NotMapped]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplication { get; set; }
        public virtual ICollection<CompanyJobSkillPoco> CompanySkillJob { get; set; }
        [ForeignKey("Company")]
        public virtual CompanyProfilePoco CompanyProfilejob { get; set; }
        public virtual ICollection<CompanyJobDescriptionPoco> CompanyJob_Des { get; set; }
        public virtual ICollection<CompanyJobEducationPoco> CompanyJobEducation{ get; set; }
    }
}
