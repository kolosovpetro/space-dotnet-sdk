using System;
using System.IO;
using System.Text;
using System.Text.Json;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.Model.HttpApi.Converters;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class ApiFieldTypeConverterTests
{
    [Theory]
    [InlineData(typeof(ApiType.Array), true)]
    [InlineData(typeof(ApiType.Dto), true)]
    [InlineData(typeof(ApiType.Enum), true)]
    [InlineData(typeof(ApiType.UrlParam), true)]
    [InlineData(typeof(ApiType.Object), true)]
    [InlineData(typeof(ApiType.Primitive), true)]
    [InlineData(typeof(ApiType.Ref), true)]
    [InlineData(typeof(Enumeration), false)]
    [InlineData(typeof(object), false)]
    public void CanConvertTests(Type requestedType, bool expectedResult)
    {
        // Arrange
        var target = new ApiFieldTypeConverter();
            
        // Act
        var result = target.CanConvert(requestedType);
                
        // Assert
        Assert.Equal(expectedResult, result);
    }
        
    [Fact]
    public void ReadKnownValuesTests()
    {
        // Arrange
        var json = "{\"className\":\"HA_Type.Primitive\",\"primitive\":\"String\",\"nullable\":true}";
        var target = new ApiFieldTypeConverter();
            
        // Act
        ApiType? result = null;
        var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
        while (reader.Read())
        {
            result = target.Read(ref reader, typeof(ApiType), new JsonSerializerOptions());
        }
                
        // Assert
        Assert.IsType<ApiType.Primitive>(result);
            
        var primitiveResult = result as ApiType.Primitive;
        Assert.Equal("String", primitiveResult?.Type);
        Assert.True(primitiveResult?.Nullable);
    }
        
    [Fact]
    public void WriteTests()
    {
        // Arrange
        var input = new ApiType.Primitive
        {
            Type = "String",
            Nullable = true
        };
        var target = new ApiFieldTypeConverter();
            
        // Act
        using var memoryStream = new MemoryStream();
        var writer = new Utf8JsonWriter(memoryStream);
        target.Write(writer, input, new JsonSerializerOptions());
        writer.Flush();
        memoryStream.Position = 0;
                
        using var reader = new StreamReader(memoryStream);
        var result = reader.ReadToEnd();
            
        // Assert
        Assert.Equal("{\"primitive\":\"String\",\"className\":\"HA_Type.Primitive\",\"nullable\":true,\"tags\":[]}", result);
    }
}