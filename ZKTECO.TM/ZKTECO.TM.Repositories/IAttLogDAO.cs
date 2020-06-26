using System;
using System.Collections.Generic;
using System.Text;
using ZKTECO.TM.Database.NHibernate;
using ZKTECO.TM.Entities.Dtos;
using ZKTECO.TM.Entities.Entities;

namespace ZKTECO.TM.Repositories
{
    public interface IAttLogDAO : IDAOGeneric<AttLog, Int64>
    {
        Page<AttLogDTO> CustomPage(int page, int pageSize, string search, string[] searchParams, string sortDirection, string sortColumn);
    }
}
