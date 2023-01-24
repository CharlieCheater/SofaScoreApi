using SofaScoreApi.Infrastructure;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SofaScoreApi.DAL.Enums;

[JsonConverter(typeof(JsonStringEnumConverterEx<PeriodType>))]
public enum PeriodType
{
    All,
    [EnumMember(Value = "1ST")]
    FirstHalf,
    [EnumMember(Value = "2ND")]
    SecondHalf,
    [EnumMember(Value = "ET1")]
    FirstExtraTime,
    [EnumMember(Value = "ET2")]
    SecondExtraTime
}
