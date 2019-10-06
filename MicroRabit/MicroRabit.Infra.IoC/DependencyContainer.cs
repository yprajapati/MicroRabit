using MediatR;
using MicroRabit.Banking.Application.Interfaces;
using MicroRabit.Banking.Application.Services;
using MicroRabit.Banking.Data.Context;
using MicroRabit.Banking.Data.Repository;
using MicroRabit.Banking.Domain.CommandHandlers;
using MicroRabit.Banking.Domain.Commands;
using MicroRabit.Banking.Domain.Interfaces;
using MicroRabit.Domain.Core.Bus;
using MicroRabit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services) {
            services.AddTransient<IEventBus, RabitMQBus>();
            services.AddTransient<IAccountService, AccountService>();

            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
