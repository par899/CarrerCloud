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
using static CareerCloud.gRPC.Protos.ApplicantSkill;
namespace CareerCloud.gRPC.Services
{
    public class ApplicantSkillService:ApplicantSkillBase
    {
        private readonly ApplicantSkillLogic _logic;

        public ApplicantSkillService()
        {
            _logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>());
        }
        public override Task<ApplicantSkillPayload> ReadApplicantSkill(IdRequestSkill request, ServerCallContext context)
        {
            ApplicantSkillPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<ApplicantSkillPayload>(
                () => new ApplicantSkillPayload()
                {
                    Id = poco.ToString(),
                    Applicant = poco.ToString(),
                    Skill = poco.ToString(),
                    SkillLevel = poco.ToString(),
                    StartMonth = (int)poco.StartMonth,
                    StartYear = (int)poco.StartYear,
                    EndMonth = (int)poco.EndMonth,
                    EndYear = (int)poco.EndYear,
                }
                );
        }
        public override Task<Empty> CreateAplicantSkill(ApplicantSkillPayload request, ServerCallContext context)
        {
            _logic.Add(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> DeleteApplicantSkill(ApplicantSkillPayload request, ServerCallContext context)
        {
            _logic.Delete(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> UpdateApplicantSkill(ApplicantSkillPayload request, ServerCallContext context)
        {
            _logic.Update(GetArray(request));
            return new Task<Empty>(null);
        }
        public ApplicantSkillPoco[] GetArray(ApplicantSkillPayload payload)
        {
            ApplicantSkillPoco poco = new ApplicantSkillPoco()
            {
                Id = Guid.Parse(payload.Id),
                Applicant = Guid.Parse(payload.Applicant),
                Skill = payload.Skill,
                SkillLevel = payload.SkillLevel,
                StartMonth = (Byte)payload.StartMonth,
                StartYear = payload.StartYear,
                EndMonth = (Byte)payload.EndMonth,
                EndYear = payload.EndYear
            };
            ApplicantSkillPoco[] pocos = new ApplicantSkillPoco[1];
            pocos[0] = poco;
            return pocos;
        }
    }
}
