using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public String LanguageId { get; set; }
        [Column("Company_Name")]
        public String CompanyName { get; set; }
        [Column("Company_Description")]
        public String CompanyDescription { get; set; }
        [NotMapped]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }
        public virtual CompanyProfilePoco CompanyProfile_Description { get; set; }
        public virtual SystemLanguageCodePoco SystemLanguage_Description { get; set; }
    }
}
