using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyProfileLogic : BaseLogic<CompanyProfilePoco>
    {
        public CompanyProfileLogic(IDataRepository<CompanyProfilePoco> repository) : base(repository)
        { }
        protected override void Verify(CompanyProfilePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach (CompanyProfilePoco poco in pocos)
            {
                string[] requiredWebsiteExtensions = new string[] { ".ca", ".com", ".biz" };
                if (string.IsNullOrEmpty(poco.CompanyWebsite))
                {
                    exceptions.Add(new ValidationException(600, 
                        $"Valid Website must end with following extensions-.ca,.com,.biz"));
                }
                else if (!requiredWebsiteExtensions.Any(t => poco.CompanyWebsite.Contains(t)))
                {
                    exceptions.Add(new ValidationException(600, 
                        $"Valid Website must end with following extensions-.ca,.com,.biz"));
                }
                /* if (string.IsNullOrEmpty(poco.ContactPhone))
                 {
                     exceptions.Add(new ValidationException(601, $"Phone number have "));
                 }
                 else
                 {
                     string[] phoneComponents = poco.ContactPhone.Split('-');
                     if (phoneComponents.Length != 3)
                     {
                         exceptions.Add(new ValidationException(601,
                             $"Must Corrospond to valid phone number(e.g 416-555-1234)"));
                     }
                     else
                     {
                         if (phoneComponents[0].Length != 3)
                         {
                             exceptions.Add(new ValidationException(601,
                                 $"Must Corrospond to valid phone number(e.g 416-555-1234)"));
                         }
                         else if (phoneComponents[1].Length != 3)
                         {
                             exceptions.Add(new ValidationException(601, 
                                 $"Must Corrospond to valid phone number(e.g 416-555-1234)"));
                         }
                         else if (phoneComponents[0].Length != 4)
                         {
                             exceptions.Add(new ValidationException(601,
                                 $"Must Corrospond to valid phone number(e.g 416-555-1234)"));
                         }
                     }*/
                if (string.IsNullOrEmpty(poco.ContactPhone) ||
              !Regex.IsMatch(poco.ContactPhone, @"^\s*[0-9]{3}\s*-\s*[0-9]{3}\s*-\s*[0-9]{4}\s*$")
             )
                {
                    exceptions.Add(new ValidationException(601,
                       "ContactPhone Must correspond to a valid phone number(e.g. 416 - 555 - 1234)"));
                }



            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }

        public override void Add(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(CompanyProfilePoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

    }
}
