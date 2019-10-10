using MicroRabit.Transfer.Data.Context;
using MicroRabit.Transfer.Domain.Interfaces;
using MicroRabit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _ctx;
        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
