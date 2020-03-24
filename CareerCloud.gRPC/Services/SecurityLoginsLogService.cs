using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CareerCloud.gRPC.Protos.SecurityLoginsLog;

namespace CareerCloud.gRPC.Services
{
    public class SecurityLoginsLogService:SecurityLoginsLogBase
    {
        public SecurityLoginsLogService()
        {
            _logic = new SecurityLoginsLogService(new EFGenericRepository<SecurityLoginsLogPoco>());
        }
    }
}
