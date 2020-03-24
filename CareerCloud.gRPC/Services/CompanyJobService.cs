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
using static CareerCloud.gRPC.Protos.CompanyJob;

namespace CareerCloud.gRPC.Services
{
    public class CompanyJobService:CompanyJobBase
    {
        private readonly CompanyJobLogic _logic;

        public CompanyJobService()
        {
            _logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>());
        }
        public override Task<CompanyJobPayload> ReadCompanyJob(IdRequestJob request, ServerCallContext context)
        {
            CompanyJobPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<CompanyJobPayload>(

                () => new CompanyJobPayload()
                {
                        Id = poco.ToString(),
                        Company=poco.ToString(),                   
                        ProfileCreated = poco.ProfileCreated is null ? null: Timestamp.FromDateTime((DateTime) poco.ProfileCreated),
                        IsInactive = poco.IsInactive,
                        IsCompanyHidden = poco.IsCompanyHidden
                }
            );
        }
        public override Task<Empty> CreateCompanyJob(CompanyJobPayload request, ServerCallContext context)
        {
            _logic.Add(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> DeleteCompanyJob(CompanyJobPayload request, ServerCallContext context)
        {
            _logic.Delete(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> UpdateCompanyJob(CompanyJobPayload request, ServerCallContext context)
        {
            _logic.Update(GetArray(request));
            return new Task<Empty>(null);
        }
        public CompanyJobPoco[] GetArray(CompanyJobPayload payload)
        {
            CompanyJobPoco poco = new CompanyJobPoco()
            {
                d = Guid.Parse(payload.Id),
                Company = Guid.Parse(payload.Company),
                ProfileCreated = payload.ProfileCreated.ToDateTime(),
                IsInactive = payload.IsInactive,
                IsCompanyHidden = payload.IsCompanyHidden
            };
            CompanyJobPoco[] pocos = new CompanyJobPoco[1];
            pocos[0] = poco;
            return pocos;

        }
    }
}
