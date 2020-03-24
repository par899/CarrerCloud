using CareerCloud.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CareerCloud.EntityFrameworkDataAccess
{
       public class CareerCloudContext: DbContext
    {
        

        public CareerCloudContext(DbContextOptions<CareerCloudContext>options):base(options)
        { 
        }

        public DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistorys { get; set; }
        public DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
           string _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            optionsBuilder.UseSqlServer(_connStr);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     
            modelBuilder.Entity<ApplicantEducationPoco>(entity =>
            {
                entity.ToTable("Applicant_Educations");
                entity.HasKey(e=>e.Id);
                entity.HasOne(e => e.ApplicantProfile).WithMany
                (p => p.ApplicantEducation).HasForeignKey(e=>e.Applicant);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<ApplicantJobApplicationPoco>(entity =>
             {
                 entity.HasOne(a => a.ApplicantProfile).
                 WithMany(p => p.ApplicantJobApplication).HasForeignKey(a => a.Applicant);
                 entity.HasOne(a => a.CompanyJob).
                 WithMany(c => c.ApplicantJobApplication).HasForeignKey(a=>a.Job);
                 entity.Property(e => e.TimeStamp).IsRowVersion();
             });
            modelBuilder.Entity<ApplicantProfilePoco>(entity => {
                entity.HasOne(a => a.SecurityLogin).
                WithMany(s => s.ApplicantProfil).HasForeignKey(f=>f.Login);
                entity.HasOne(a => a.SystemCountryCodes).
                WithMany(s => s.ApplicantProfile).HasForeignKey(f => f.Country);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<ApplicantResumePoco>(entity => {
                entity.HasOne(r => r.ApplicantResumeProfile).
                WithMany(p => p.ApplicantProfileResume).HasForeignKey(f=>f.Applicant);
            });
            modelBuilder.Entity<ApplicantSkillPoco>(entity =>
            {
                entity.HasOne(p => p.ApplicantProfileSkill).
                WithMany(s => s.ApplicantSkillProfile).HasForeignKey(f=>f.Applicant);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<ApplicantWorkHistoryPoco>(entity=>{
                entity.HasOne(p => p.ApplicantWorkProfile).
                WithMany(w => w.ApplicantWorkHistoryProfile).HasForeignKey(f=>f.Applicant);
                entity.HasOne(s => s.SystemCountrycodeWorkHistory).
                WithMany(w => w.ApplicantWorkHistoryCountryCode).HasForeignKey(f=>f.CountryCode);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<CompanyJobSkillPoco>(entity => {
                entity.HasOne(c => c.CompanyJobSkill).WithMany(s => s.CompanySkillJob).HasForeignKey(f=>f.Job);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<CompanyJobDescriptionPoco>(entity => {
                entity.HasOne(j => j.CompanyjobDescription).
                WithMany(d => d.CompanyJob_Des).HasForeignKey(f=>f.Job);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<CompanyLocationPoco>(entity => {
                entity.HasOne(p => p.CompanyProfile_Loc).
                WithMany(l => l.CompanyLocation_Profile).HasForeignKey(f=>f.Company);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<SecurityLoginsLogPoco>(entity=> {entity.HasOne(sl=>sl.SecurityLogin_Log).
                WithMany(l=>l.Security_logs).HasForeignKey(f=>f.Login);
                });
            modelBuilder.Entity<SecurityLoginsRolePoco>(entity => { entity.HasOne(sl => sl.SecurityLogin_Roles).
                WithMany(r=>r.Security_Logins_roles).HasForeignKey(f=>f.Login);
                entity.HasOne(sr => sr.Security_Role).WithMany(sl => sl.Role_logins).HasForeignKey(f=>f.Role);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<CompanyDescriptionPoco>(entity =>
            {
                entity.HasOne(p => p.CompanyProfile_Description).WithMany(d => d.CompanyDescription_Profile).HasForeignKey(f => f.Company);
                entity.HasOne(sl => sl.SystemLanguage_Description).WithMany(cd => cd.Company_Languages).HasForeignKey(f => f.LanguageId);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            modelBuilder.Entity<CompanyJobEducationPoco>(entity =>
            {
                entity.HasOne(e => e.Companyjob_Edu).WithMany(j => j.CompanyJobEducation).HasForeignKey(f => f.Job);
                entity.Property(e => e.TimeStamp).IsRowVersion();
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
