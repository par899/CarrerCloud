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
using static CareerCloud.gRPC.Protos.ApplicantEducation;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantEducationService:ApplicantEducationBase
    {
        private readonly ApplicantEducationLogic _logic;

        public ApplicantEducationService()
        {
            _logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>());
        }
        public override Task<ApplicantEducationPayload> ReadApplicantEducation(IdRequest request, ServerCallContext context)
        {
            ApplicantEducationPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<ApplicantEducationPayload>(
                () => new ApplicantEducationPayload()
                {
                    Id = poco.Id.ToString(),
                    Applicant = poco.Applicant.ToString(),
                    Major = poco.Major,
                    CertificateDiploma = poco.CertificateDiploma,
                    StartDate = poco.StartDate is null ? null : Timestamp.FromDateTime((DateTime)poco.StartDate),
                    CompletionDate = poco.CompletionDate is null ? null : Timestamp.FromDateTime((DateTime)poco.CompletionDate),
                    CompletionPercent = poco.CompletionPercent is null ? 0 : (int)poco.CompletionPercent,
                }
                );
        }
        public override Task<Empty> CreateApplicantEducation(ApplicantEducationPayload request, ServerCallContext context)
        {

            //ApplicantEducationPoco[] poco = new ApplicantEducationPoco[1000];
            ApplicantEducationPoco[] pocos = new ApplicantEducationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Major = request.Major;
                poco.StartDate = request.StartDate.ToDateTime();
                poco.CompletionDate = request.CompletionDate.ToDateTime();
                poco.CompletionPercent = Convert.ToByte(request.CompletionPercent);


            }
            _logic.Add(pocos);
            return new Task<Empty>(() => new Empty());

        }

        public override Task<Empty> UpdateApplicantEducation(ApplicantEducationPayload request, ServerCallContext context)
        {
            ApplicantEducationPoco[] pocos = new ApplicantEducationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Major = request.Major;
                poco.StartDate = request.StartDate.ToDateTime();
                poco.CompletionDate = request.CompletionDate.ToDateTime();
                poco.CompletionPercent = Convert.ToByte(request.CompletionPercent);


            }
            _logic.Update(pocos);
            return new Task<Empty>(() => new Empty());


        }

        public override Task<Empty> DeleteApplicantEducation(ApplicantEducationPayload request, ServerCallContext context)
        {
            ApplicantEducationPoco[] pocos = new ApplicantEducationPoco[1];
            foreach (var poco in pocos)
            {
                poco.Id = Guid.Parse(request.Id);
                poco.Applicant = Guid.Parse(request.Applicant);
                poco.Major = request.Major;
                poco.StartDate = request.StartDate.ToDateTime();
                poco.CompletionDate = request.CompletionDate.ToDateTime();
                poco.CompletionPercent = Convert.ToByte(request.CompletionPercent);


            }
            _logic.Delete(pocos);
            return new Task<Empty>(() => new Empty());



            
        }
    }
}
    



