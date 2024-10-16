using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BankSystem.Models;

namespace BankSystem.Controllers
{
    public class AccountConverter : JsonConverter<Account>
    {
        public override Account? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonObject = JsonDocument.ParseValue(ref reader).RootElement;
            var accountType = jsonObject.GetProperty("AccountType").GetString();

            return accountType switch
            {
                "Everyday" => JsonSerializer.Deserialize<Everyday>(jsonObject.GetRawText(), options),
                "Invest" => JsonSerializer.Deserialize<Invest>(jsonObject.GetRawText(), options),
                "Omni" => JsonSerializer.Deserialize<Omni>(jsonObject.GetRawText(), options),
                _ => throw new JsonException($"Unknown account type: {accountType}")
            };
        }

        public override void Write(Utf8JsonWriter writer, Account value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        }
    }

}
