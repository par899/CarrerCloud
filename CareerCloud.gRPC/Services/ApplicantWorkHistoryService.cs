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
using static CareerCloud.gRPC.Protos.ApplicantWorkHistory;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantWorkHistoryService:ApplicantWorkHistoryBase
    {
        private readonly ApplicantWorkHistoryLogic _logic;

        public ApplicantWorkHistoryService()
        {
            _logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>());
        }
        public override Task<ApplicantWorkHistoryPayload> ReadApplicantWorkHistory(IdRequestWorkHistory request, ServerCallContext context)
        {
            ApplicantWorkHistoryPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<ApplicantWorkHistoryPayload>(
                ()=> new ApplicantWorkHistoryPayload()
                {
                    Id=poco.Id.ToString(),
                    Applicant = poco.ToString(),
                    CompanyName =poco.ToString(),
                    CountryCode =poco.ToString(),
                    Location =poco.ToString(),
                    JobTitle=poco.ToString(),
                    JobDescription=poco.ToString(),
                    StartMonth=(int)poco.StartMonth,
                    StartYear=(int)poco.StartYear,
                    EndMonth=(int)poco.EndMonth,
                    EndYear=(int)poco.EndYear,
                }
                );
        }
        public override Task<Empty> CreateApplicantWorkHistory(ApplicantWorkHistoryPayload request, ServerCallContext context)
        {
            _logic.Add(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> DeleteApplicantWorkHistory(ApplicantWorkHistoryPayload request, ServerCallContext context)
        {
            _logic.Delete(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> UpdateApplicantWorkHistory(ApplicantWorkHistoryPayload request, ServerCallContext context)
        {
            _logic.Update(GetArray(request));
            return new Task<Empty>(null);
        }
        public ApplicantWorkHistoryPoco[] GetArray(ApplicantWorkHistoryPayload payload)
        {
            ApplicantWorkHistoryPoco poco = new ApplicantWorkHistoryPoco()
            {
                Id = Guid.Parse(payload.Id),
                Applicant = Guid.Parse(payload.Applicant),
                CompanyName = payload.CompanyName,
                CountryCode = payload.CountryCode,
                Location = payload.Location,
                JobTitle = payload.JobTitle,
                JobDescription = payload.JobDescription,
                StartMonth = (short)payload.StartMonth,
                StartYear = payload.StartYear,
                EndMonth = (short)payload.EndMonth,
                EndYear = payload.EndYear
            };
            ApplicantWorkHistoryPoco[] pocos = new ApplicantWorkHistoryPoco[1];
            pocos[0] = poco;
            return pocos;
        }

    }
}
