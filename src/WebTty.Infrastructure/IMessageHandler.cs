using System;
using System.Threading;
using System.Threading.Tasks;
using WebTty.Infrastructure.Connection;

namespace WebTty.Infrastructure
{
    public interface IMessageHandler
    {
        ValueTask<object> Handle(object message, ConnectionContext context, CancellationToken token = default);
    }
}