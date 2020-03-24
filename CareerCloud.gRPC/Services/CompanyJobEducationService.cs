﻿using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CareerCloud.gRPC.Protos.CompanyJobEducation;

namespace CareerCloud.gRPC.Services
{
    public class CompanyJobEducationService : CompanyJobEducationBase
    {
        private readonly CompanyJobEducationLogic _logic;

        public CompanyJobEducationService()
        {
            _logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>());
        }
        public override Task<CompanyJobEducationPayload> ReadCompanyJobEducation(IdRequestJobEducation request, ServerCallContext context)
        {
            CompanyJobEducationPoco poco = _logic.Get(Guid.Parse(request.Id));
            return new Task<CompanyJobEducationPayload>(

                () => new CompanyJobEducationPayload()
                {
                    Id = poco.ToString(),
                    Job=poco.ToString(),
                    Major= poco.ToString(),
                    Importance=(int)poco.Importance,
                }
                );

        }
        public override Task<Empty> CreateCompanyJobEducation(CompanyJobEducationPayload request, ServerCallContext context)
        {
            _logic.Add(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> DeleteCompanyJobEdution(CompanyJobEducationPayload request, ServerCallContext context)
        {
            _logic.Delete(GetArray(request));
            return new Task<Empty>(null);
        }
        public override Task<Empty> UpdateCompanyJobEdution(CompanyJobEducationPayload request, ServerCallContext context)
        {
            _logic.Update(GetArray(request));
            return new Task<Empty>(null);
        }
        public CompanyJobEducationPoco[] GetArray(CompanyJobEducationPayload payload)
        {
            CompanyJobEducationPoco poco = new CompanyJobEducationPoco()
            {
                Id = Guid.Parse(payload.Id),
                Job = Guid.Parse(payload.Job),
                Major = payload.Major,
                Importance = (short)payload.Importance
            };
            CompanyJobEducationPoco[] pocos = new CompanyJobEducationPoco[1];
            pocos[0] = poco;
            return pocos;

        }
    }
}
