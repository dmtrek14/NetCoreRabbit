using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NetCoreRabbit.Banking.Domain.Commands;
using NetCoreRabbit.Banking.Domain.Events;
using NetCoreRabbit.Domain.Core.Bus;

namespace NetCoreRabbit.Banking.Domain.CommandHandlers
{
	public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
	{
		private readonly IEventBus _bus;

		public TransferCommandHandler(IEventBus bus)
		{
			_bus = bus;
		}

		public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
		{
			//publish event to rabbit
			_bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));

			return Task.FromResult(true);
		}
	}

}
