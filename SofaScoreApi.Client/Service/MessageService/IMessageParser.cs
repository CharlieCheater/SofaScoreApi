namespace SofaScoreApi.Client.Service.MessageService;
public interface IMessageParser
{
    IMessage Parse(string response);
}
