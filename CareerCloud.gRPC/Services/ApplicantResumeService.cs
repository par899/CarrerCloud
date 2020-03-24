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
using static CareerCloud.gRPC.Protos.ApplicantResume;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantResumeService:ApplicantResumeBase
    {
        private readonly ApplicantResumeLogic _logic;

        public ApplicantResumeService()
        {
            _logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>());
        }
        public override Task<ApplicantResumePayload> ReadApplicantResume(IdRequestResume request, ServerCallContext context)
        {
            ApplicantResumePoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<ApplicantResumePayload>(
                () => new ApplicantResumePayload()
                {
                    Id = poco.Id.ToString(),                  
                    Applicant = poco.ToString(),
                    Resume =poco.ToString(),        
                    LastUpdated = poco.LastUpdated is null ? null : Timestamp.FromDateTime((DateTime)poco.LastUpdated)
                }
                ) ;
        }
        public override Task<Empty> CreateApplicantResume(ApplicantResumePayload request, ServerCallContext context)
        {
            _logic.Add(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> DeleteApplicantResume(ApplicantResumePayload request, ServerCallContext context)
        {
            _logic.Delete(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> UpdateApplicantResume(ApplicantResumePayload request, ServerCallContext context)
        {
            _logic.Update(GetArray(request));
            return new Task<Empty>(null);
        }
        public ApplicantResumePoco[] GetArray(ApplicantResumePayload resumePayload)
        {
            ApplicantResumePoco poco = new ApplicantResumePoco()
            { 
            Id = Guid.Parse(resumePayload.Id),
                Applicant = Guid.Parse(resumePayload.Applicant),
                Resume = resumePayload.Resume,
                LastUpdated = resumePayload.LastUpdated.ToDateTime()
              
            };
            ApplicantResumePoco[] pocos = new ApplicantResumePoco[1];
            pocos[0] = poco;
            return pocos;
        }
       
    }
}
