using System;

namespace ZKTECO.TM.Entities.Dtos
{   
    public class AttLogDTO
    {
        public virtual long Id { get; set; }
        public virtual string UserPIN { get; set; }
        public virtual string VerifyType { get; set; }
        public virtual string VerifyTime { get; set; }
        public virtual string Status { get; set; }
        public virtual string DeviceSN { get; set; }
    }
}
