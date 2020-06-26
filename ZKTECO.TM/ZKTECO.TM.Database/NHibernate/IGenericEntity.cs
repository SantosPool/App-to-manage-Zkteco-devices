using System;
using System.Collections.Generic;
using System.Text;

namespace ZKTECO.TM.Database.NHibernate
{
    public interface IGenericEntity<PK>
    {
        PK Id { get; set; }
    }
}
