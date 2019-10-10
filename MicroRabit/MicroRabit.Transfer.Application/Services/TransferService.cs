using MicroRabit.Transfer.Application.Interfaces;
using MicroRabit.Transfer.Domain.Interfaces;
using MicroRabit.Transfer.Domain.Models;
using MicroRabit.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabit.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;

        private readonly IEventBus _bus;

        public TransferService(ITransferRepository accountRepository, IEventBus bus)
        {
            _transferRepository = accountRepository;
            _bus = bus;
        }
        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
