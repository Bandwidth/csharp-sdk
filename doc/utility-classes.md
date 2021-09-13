
# Utility Classes Documentation

## ApiHelper Class

HttpRequest stores necessary information about the http request.

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpMethod | The HTTP verb to use for this request. | `HttpMethod` |
| QueryUrl | The query url for the http request. | `string` |
| QueryParameters | Query parameters collection for the current http request. | `Dictionary<string, object>` |
| Headers | Headers collection for the current http request. | `Dictionary<string, string>` |
| FormParameters | Form parameters for the current http request. | `List<KeyValuePair<string, object>>` |
| Body | Optional raw string to send as request body. | `object` |
| Username | Optional username for Basic Auth. | `string` |
| Password | Optional password for Basic Auth. | `string` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `DeepCloneObject<T>(T obj)` | Creates a deep clone of an object by serializing it into a json string and then deserializing back into an object. | `T` |
| `JsonSerialize(object obj, JsonConverter converter = null)` | JSON Serialization of a given object. | `string` |
| `JsonDeserialize<T>(string json, JsonConverter converter = null)` | JSON Deserialization of the given json string. | `T` |

## CustomDateTimeConverter Class

Extends from IsoDateTimeConverter to allow a custom DateTime format.

### Constructors

| Name | Description |
|  --- | --- |
| `CustomDateTimeConverter(string format)` | Initializes a new instance of the <see cref="CustomDateTimeConverter"/> class. |

## ListDateTimeConverter Class

Extends from JsonConverter, allows the use of a custom converter.

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| `Converter` | Gets or sets the JsonConverter. | `JsonConverter` |

### Constructors

| Name | Description |
|  --- | --- |
| `ListDateTimeConverter()` | Initializes a new instance of the <see cref="ListDateTimeConverter"/> class. |
| `ListDateTimeConverter(Type converter)` | Initializes a new instance of the <see cref="ListDateTimeConverter"/> class. |
| `ListDateTimeConverter(Type converter, string format)` | Initializes a new instance of the <see cref="ListDateTimeConverter"/> class. |

## UnixDateTimeConverter Class

Extends from DateTimeConverterBase, uses unix DateTime format.

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| DateTimeStyles | Gets or sets DateTimeStyles. | `DateTimeStyles` |

