using System;
using System.Collections.Generic;
using System.Text;
using ZKTECO.TM.Database.NHibernate;

namespace ZKTECO.TM.Entities.Entities
{
    public class AttLog : IGenericEntity<Int64>
    {
        public virtual long Id { get; set; }
        public virtual string UserPIN { get; set; }
        public virtual int VerifyType { get; set; }
        public virtual string VerifyTime { get; set; }
        public virtual int Status { get; set; }
        public virtual int WorkCode { get; set; }
        public virtual int SensorNo { get; set; }
        public virtual int AttFlag { get; set; }
        public virtual string DeviceSN { get; set; }
        public virtual int Reserved1 { get; set; }
        public virtual int Reserved2 { get; set; }
    }
}
