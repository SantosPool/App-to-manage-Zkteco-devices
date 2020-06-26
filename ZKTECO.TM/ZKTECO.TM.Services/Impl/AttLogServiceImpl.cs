using System;
using System.Collections.Generic;
using System.Text;
using ZKTECO.TM.Database.NHibernate;
using ZKTECO.TM.Entities.Dtos;
using ZKTECO.TM.Entities.Entities;
using ZKTECO.TM.Repositories;

namespace ZKTECO.TM.Services.Impl
{
    public class AttLogServiceImpl : IAttLogService
    {
        private IAttLogDAO attLogDAO;

        public AttLogServiceImpl(IAttLogDAO _attLogDAO)
        {
            attLogDAO = _attLogDAO;
        }
        public void Save(AttLog att)
        {
            attLogDAO.Save(att);
        }
        public IList<AttLog> FindAll()
        {
            var o = attLogDAO.FindAll();
            return o;
        }
        public AttLog Get(long id)
        {
            return attLogDAO.Get(id);
        }
        public void Update(AttLog u)
        {
            attLogDAO.Update(u);
        }
        public void Delete(long id)
        {
            attLogDAO.Delete(id);
        }
        public Page<AttLogDTO> GetPage(int page, int pageSize, string search, string sortDirection, string sortColumn)
        {
            var searchParams = new string[] { "Id" };

            var result = attLogDAO.CustomPage(page, pageSize, search, searchParams, sortDirection, sortColumn);

            return result;
        }

    }
}
