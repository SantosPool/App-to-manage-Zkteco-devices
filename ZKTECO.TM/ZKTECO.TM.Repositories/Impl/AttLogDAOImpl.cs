using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.Text;
using ZKTECO.TM.Database.NHibernate;
using ZKTECO.TM.Database.NHibernate.Implementation;
using ZKTECO.TM.Entities.Dtos;
using ZKTECO.TM.Entities.Entities;
using ZKTECO.TM.Utilities;

namespace ZKTECO.TM.Repositories.Impl
{
    public class AttLogDAOImpl : NHGenericDAOImpl<AttLog, Int64>, IAttLogDAO
    {
        public Page<AttLogDTO> CustomPage(int page, int pageSize, string search, string[] searchParams, string sortDirection, string sortColumn)
        {
            ICriteria criteria = Session.CreateCriteria<AttLog>();
            //.CreateAlias("Contact", "c")
            //.CreateAlias("c.Email", "e", JoinType.LeftOuterJoin)
            //.CreateAlias("c.Address", "a", JoinType.LeftOuterJoin);

            criteria.SetProjection(Projections.ProjectionList()
                .Add(Projections.Property("Id"), "Id")
                .Add(Projections.Property("UserPIN"), "UserPIN")
                .Add(Projections.Property("VerifyType"), "VerifyType")
                .Add(Projections.Property("VerifyTime"), "VerifyTime")
                .Add(Projections.Property("Status"), "Status")
                .Add(Projections.Property("DeviceSN"), "DeviceSN")
                );

            criteria.AddOrder(Order.Asc("Id"));

            criteria.SetMaxResults(pageSize);
            criteria.SetFirstResult(page * pageSize);

            var attLogs = criteria.SetResultTransformer(Transformers.AliasToBean<AttLog>()).List<AttLog>();
            var attLogsDto = FunctionsGeneral.GetAllAttLog(attLogs);

            var count = Session.QueryOver<AttLog>()
                .RowCountInt64();

            Page<AttLogDTO> pageResult = new Page<AttLogDTO>(attLogsDto, count, page, pageSize);

            return pageResult;
        }
    }
}
