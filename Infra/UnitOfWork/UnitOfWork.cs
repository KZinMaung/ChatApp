using Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Infra.UnitOfWork
{
    public class UnitOfWork
    {
        private ChatAppDBContext _ctx;
        public UnitOfWork(ChatAppDBContext ctx)
        {
            _ctx = ctx;
        }

        ~UnitOfWork()
        {
            _ctx.Dispose();
        }
    }
}
