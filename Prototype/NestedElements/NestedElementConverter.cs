using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace Laboratory6
{
    public class NestedElementConverter : JsonConverter<NestedElement>
    {
        public override NestedElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var type = doc.RootElement.GetProperty("ElementType").GetString();
                NestedElement element = type switch
                {
                    "Section" => JsonSerializer.Deserialize<Section>(doc.RootElement.GetRawText(), options),
                    "Image" => JsonSerializer.Deserialize<Image>(doc.RootElement.GetRawText(), options),
                    "Table" => JsonSerializer.Deserialize<Table>(doc.RootElement.GetRawText(), options),
                    _ => throw new NotSupportedException($"Type '{type}' is not supported.")
                };
                return element;
            }
        }

        public override void Write(Utf8JsonWriter writer, NestedElement value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Section section:
                    writer.WriteStartObject();
                    writer.WriteString("ElementType", "Section");
                    writer.WriteString("Title", section.Title);
                    writer.WriteString("Text", section.Text);
                    writer.WriteEndObject();
                    break;
                case Image image:
                    writer.WriteStartObject();
                    writer.WriteString("ElementType", "Image");
                    writer.WriteString("URL", image.URL);
                    writer.WriteEndObject();
                    break;
                case Table table:
                    writer.WriteStartObject();
                    writer.WriteString("ElementType", "Table");
                    writer.WriteString("Title", table.Title);
                    writer.WriteNumber("Rows", table.Rows);
                    writer.WriteNumber("Columns", table.Columns);
                    writer.WriteStartArray("Data");
                    foreach (var row in table.Data)
                    {
                        writer.WriteStartArray();
                        foreach (var cell in row)
                        {
                            writer.WriteStringValue(cell);
                        }
                        writer.WriteEndArray();
                    }
                    writer.WriteEndArray();
                    writer.WriteEndObject();
                    break;
            }
        }
    }
}
