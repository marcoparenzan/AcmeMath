using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AcmeScripting
{
    public class DynamicJsonDocument : DynamicObject
    {
        public static DynamicJsonDocument Parse(string json)
        {
            var rr = new ReadOnlySpan<byte>(Encoding.UTF8.GetBytes(json));

            var options = new JsonReaderOptions
            {
                AllowTrailingCommas = true,
                CommentHandling = JsonCommentHandling.Skip
            };
            var reader = new Utf8JsonReader(rr, options);
            reader.Read();
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    return DynamicJsonElement.Parse(ref reader);
                case JsonTokenType.StartArray:
                    return DynamicJsonElement.Parse(ref reader);
                default:
                    throw new ArgumentException("invalid json");
            }
        }
    }

    public class DynamicJsonElement : DynamicJsonDocument
    {
        Dictionary<string, dynamic> items = new Dictionary<string, dynamic>();

        internal static dynamic Parse(ref Utf8JsonReader reader)
        {
            var xxx = new DynamicJsonElement();
            string propertyName = default;

            var stay = true;
            while (stay)
            {
                reader.Read();
                switch (reader.TokenType)
                {
                    case JsonTokenType.PropertyName:
                        {
                            propertyName = reader.GetString();
                            break;
                        }

                    case JsonTokenType.String:
                        {
                            xxx.items.Add(propertyName, reader.GetString());
                            propertyName = default;
                            break;
                        }

                    case JsonTokenType.Number:
                        {
                            xxx.items.Add(propertyName, reader.GetInt32());
                            propertyName = default;
                            break;
                        }

                    case JsonTokenType.StartObject:
                        {
                            xxx.items.Add(propertyName, DynamicJsonElement.Parse(ref reader));
                            propertyName = default;
                            break;
                        }

                    case JsonTokenType.StartArray:
                        {
                            xxx.items.Add(propertyName, DynamicJsonArray.Parse(ref reader));
                            propertyName = default;
                            break;
                        }
                    case JsonTokenType.EndArray:
                        {
                            throw new InvalidOperationException("Cannot end on an array");
                        }
                    case JsonTokenType.EndObject:
                        {
                            stay = false;
                            break;
                        }
                }
            }

            return xxx;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (items.ContainsKey(binder.Name))
            {
                result = items[binder.Name];
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (items.ContainsKey(binder.Name))
            {
                items[binder.Name] = value;
            }
            else
            {
                items.Add(binder.Name, value);
            }
            return true;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(items);
        }
    }

    public class DynamicJsonArray : DynamicJsonDocument
    {
        List<dynamic> items = new List<dynamic>();

        internal static dynamic Parse(ref Utf8JsonReader reader)
        {
            var xxx = new DynamicJsonArray();
            string propertyName = default;


            var stay = true;
            while (stay)
            {
                reader.Read();
                switch (reader.TokenType)
                {
                    case JsonTokenType.PropertyName:
                        {
                            propertyName = reader.GetString();
                            break;
                        }

                    case JsonTokenType.String:
                        {
                            xxx.items.Add(reader.GetString());
                            propertyName = default;
                            break;
                        }

                    case JsonTokenType.Number:
                        {
                            xxx.items.Add(reader.GetInt32());
                            propertyName = default;
                            break;
                        }

                    case JsonTokenType.StartObject:
                        {
                            xxx.items.Add(DynamicJsonElement.Parse(ref reader));
                            propertyName = default;
                            break;
                        }

                    case JsonTokenType.StartArray:
                        {
                            xxx.items.Add(DynamicJsonArray.Parse(ref reader));
                            propertyName = default;
                            break;
                        }
                    case JsonTokenType.EndArray:
                        {
                            throw new InvalidOperationException("Cannot end on an array");
                        }
                    case JsonTokenType.EndObject:
                        {
                            stay = false;
                            break;
                        }
                }
            }

            return xxx;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            //if (items.ContainsKey(binder.Name))
            //{
            //    result = items[binder.Name];
            //    return true;
            //}
            //else
            //{
            //    result = default;
            //    return false;
            //}
            result = default;
            return false;
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            return true;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(items);
        }
    }
}
