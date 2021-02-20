using MediatR;
using NetCoreRabbit.Domain.Core.Bus;
using NetCoreRabbit.Domain.Core.Commands;
using NetCoreRabbit.Domain.Core.Events;
using System.Threading.Tasks;

namespace NetCoreRabbit.Infra.Bus
{
	public sealed class RabbitMQBus : IEventBus
	{
		private readonly IMediator _mediator;

		public Task SendCommand<T>(T command) where T : Command
		{
			return _mediator.Send(command);
		}

		public void Publish<T>(T @event) where T : Event
		{
			throw new System.NotImplementedException();
		}

		public void Subscribe<T, TH>()
			where T : Event
			where TH : IEventHandler<T>
		{
			throw new System.NotImplementedException();
		}
	}
}
