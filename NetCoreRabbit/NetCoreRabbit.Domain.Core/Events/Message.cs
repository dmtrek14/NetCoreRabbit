using MediatR;

namespace NetCoreRabbit.Domain.Core.Events
{
	public abstract class Message: IRequest<bool>
	{
	}
}
