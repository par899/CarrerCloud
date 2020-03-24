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
using static CareerCloud.gRPC.Protos.CompanyLocation;

namespace CareerCloud.gRPC.Services
{
    public class CompanyLocationService:CompanyLocationBase
    {
        private readonly CompanyLocationLogic _logic;

        CompanyLocationService()
        {
            _logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>());
        }
        public override Task<CompanyLocationPayload> ReadCompanyLocation(IdRequestLocation request, ServerCallContext context)
        {
            CompanyLocationPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<CompanyLocationPayload>(

                () => new CompanyLocationPayload()
                {
                    Id=poco.ToString(),
                    Company=poco.ToString(),
                    CountryCode=poco.ToString(),
                    Province= poco.ToString(),
                    Street =poco.ToString(),
                    City =poco.ToString(),
                    PostalCode = poco.ToString(),
                }
            );
        }
        public override Task<Empty> CreateCompanyLocation(CompanyLocationPayload request, ServerCallContext context)
        {
            _logic.Add(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> DeleteCompanyLocation(CompanyLocationPayload request, ServerCallContext context)
        {
            _logic.Delete(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> UpdateCompanyLocation(CompanyLocationPayload request, ServerCallContext context)
        {
            _logic.Update(GetArray(request));
            return new Task<Empty>(null);
        }
        public CompanyLocationPoco[] GetArray(CompanyLocationPayload payload)// payload--(CompanyLocationPayload request, ServerCallContext context)
        {
            CompanyLocationPoco poco = new CompanyLocationPoco()
            {
                Id = Guid.Parse(payload.Id),
                Company = Guid.Parse(payload.Company),
                CountryCode = payload.CountryCode,
                Province = payload.Province,
                Street = payload.Street,
                City = payload.City,
                PostalCode = payload.PostalCode
            };

            CompanyLocationPoco[] pocos = new CompanyLocationPoco[1];
            pocos[0] = poco;
            return pocos;
        }

    }
}
