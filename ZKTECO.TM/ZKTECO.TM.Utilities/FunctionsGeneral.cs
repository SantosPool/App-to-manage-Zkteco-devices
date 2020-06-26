using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZKTECO.TM.Entities.Dtos;
using ZKTECO.TM.Entities.Entities;

namespace ZKTECO.TM.Utilities
{
    public class FunctionsGeneral
    {
        public static IList<AttLogDTO> GetAllAttLog(IList<AttLog> attLogs)
        {
           return attLogs.Select(x => new AttLogDTO{ Id=x.Id, UserPIN=x.UserPIN, VerifyType = Dictionarys.ATT_VERIFY[x.VerifyType], VerifyTime=x.VerifyTime, Status = Dictionarys.ATT_STATUS[x.Status], DeviceSN=x.DeviceSN }).ToList();
        }
    }
}
