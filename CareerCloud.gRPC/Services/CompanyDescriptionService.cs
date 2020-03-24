using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CareerCloud.gRPC.Protos.CompanyDescription;

namespace CareerCloud.gRPC.Services
{
    public class CompanyDescriptionService:CompanyDescriptionBase
    {
        private readonly CompanyDescriptionLogic _logic;

        public CompanyDescriptionService()
        {
            _logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>());
        }
        public override Task<CompanyDescriptionPayload> ReadCompanyDescription(IdRequestDescription request, ServerCallContext context)
        {
            CompanyDescriptionPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<CompanyDescriptionPayload>(
                ()=> new CompanyDescriptionPayload()
                {
                    Id=poco.ToString(),
                    Company=poco.ToString(),
                    LanguageId=poco.ToString(),
                    CompanyName = poco.ToString(),
                    CompanyDescription=poco.ToString(),
                }
                );
        }
        public override Task<Empty> CreateCompanyDescription(CompanyDescriptionPayload request, ServerCallContext context)
        {
            _logic.Add(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> DeleteCompanyDescription(CompanyDescriptionPayload request, ServerCallContext context)
        {
            _logic.Delete(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> UpdateCompanyDescription(CompanyDescriptionPayload request, ServerCallContext context)
        {
            _logic.Update(GetArray(request));
            return new Task<Empty>(null);
        }
        public CompanyDescriptionPoco[] GetArray(CompanyDescriptionPayload payload)
        {
            CompanyDescriptionPoco poco = new CompanyDescriptionPoco()
            {
                Id = Guid.Parse(payload.Id),
                Company = Guid.Parse(payload.Company),
                LanguageId = payload.LanguageId,
                CompanyName = payload.CompanyName,
                CompanyDescription = payload.CompanyDescription
            };

            CompanyDescriptionPoco[] pocos = new CompanyDescriptionPoco[1];
            pocos[0] = poco;
            return pocos;
        }

        
    }
}
