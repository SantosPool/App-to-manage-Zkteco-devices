using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using ZKTECO.TM.Entities.Entities;

namespace ZKTECO.TM.Entities.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("tblUser");
            Id(x => x.Id, "id");
            Map(x => x.Username, "username");
            Map(x => x.Password, "password");
        }
    }
}
