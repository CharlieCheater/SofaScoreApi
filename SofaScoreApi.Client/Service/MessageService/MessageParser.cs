using System.Text.RegularExpressions;

namespace SofaScoreApi.Client.Service.MessageService;

public class MessageParser : IMessageParser
{
    private string _pattern = @"^(MSG)\s([\w.]+)\s(\d)\s(\d+)\s(\{[^}]*\})";

    public IMessage Parse(string response)
    {
        var groups = Regex.Match(response, _pattern).Groups;
        MessageType messageType = GetMessageType(groups[(int)ParseType.MessageType].Value);

        if(messageType == MessageType.Unknown)
        {
            throw new Exception("Unknown message");
        }
        return null;
    }
    private MessageType GetMessageType(string response) 
    {
        return response switch
        {
            "MSG" => MessageType.Message,
            "PING" => MessageType.Ping,
            "PONG" => MessageType.Pong,
            _ => MessageType.Unknown
        };
    }
}
