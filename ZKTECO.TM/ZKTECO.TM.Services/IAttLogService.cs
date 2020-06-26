using System;
using System.Collections.Generic;
using System.Text;
using ZKTECO.TM.Database.NHibernate;
using ZKTECO.TM.Entities.Dtos;
using ZKTECO.TM.Entities.Entities;

namespace ZKTECO.TM.Services
{
    public interface IAttLogService
    {
        void Save(AttLog att);
        IList<AttLog> FindAll();
        AttLog Get(long id);
        void Update(AttLog att);
        void Delete(long id);
        Page<AttLogDTO> GetPage(int page, int pageSize, string search, string sortDirection, string sortColumn);
    }
}
