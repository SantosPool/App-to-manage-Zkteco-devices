using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using ZKTECO.TM.Entities.Entities;

namespace ZKTECO.TM.Entities.Mappings
{
    public class AttLogMap : ClassMap<AttLog>
    {
        public AttLogMap()
        {
            Table("att_log");
            Id(x => x.Id, "ATT_LOG_ID");
            Map(x => x.UserPIN, "USER_PIN");
            Map(x => x.VerifyType, "VERIFY_TYPE");
            Map(x => x.VerifyTime, "VERIFY_TIME");
            Map(x => x.Status, "STATUS");
            Map(x => x.WorkCode, "WORK_CODE");
            Map(x => x.SensorNo, "SENSOR_NO");
            Map(x => x.AttFlag, "ATT_FLAG");
            Map(x => x.DeviceSN, "DEVICE_SN");
            Map(x => x.Reserved1, "RESERVED1");
            Map(x => x.Reserved2, "RESERVED2");
        }
    }
}
