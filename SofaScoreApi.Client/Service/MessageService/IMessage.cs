using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaScoreApi.Client.Service.MessageService;

public interface IMessage
{
    MessageType MessageType { get; }
    string Response { get; }
}
