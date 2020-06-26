using System;
using System.Collections.Generic;
using System.Text;
using ZKTECO.TM.Database.NHibernate;

namespace ZKTECO.TM.Entities.Entities
{
    public class User : IGenericEntity<Int64>
    {
        public virtual long Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
    }
}
