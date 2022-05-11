using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using JetBrains.Space.Common.Types;
using JetBrains.Space.Generator.Model.HttpApi;
using JetBrains.Space.Generator.Model.HttpApi.Converters;
using Xunit;

namespace JetBrains.Space.Client.Tests.Json.Serialization;

public class ApiClassConverterTests
{
    [Theory]
    [InlineData(typeof(ApiClass.Clazz), true)]
    [InlineData(typeof(ApiClass.Interface), true)]
    [InlineData(typeof(ApiClass.Object), true)]
    [InlineData(typeof(ApiType.Ref), false)]
    [InlineData(typeof(Enumeration), false)]
    [InlineData(typeof(object), false)]
    public void CanConvertTests(Type requestedType, bool expectedResult)
    {
        // Arrange
        var target = new ApiClassConverter();
            
        // Act
        var result = target.CanConvert(requestedType);
                
        // Assert
        Assert.Equal(expectedResult, result);
    }
        
    [Fact]
    public void ReadKnownValuesTests()
    {
        // Arrange
        var json = "{\"open\":false,\"abstract\":false,\"sealed\":false,\"extends\":null,\"className\":\"HA_Class.Clazz\",\"visibilityModifier\":\"DEFAULT\",\"name\":\"TestClass\",\"implements\":[],\"innerSubclasses\":[],\"properties\":[{\"visibilityModifier\":\"DEFAULT\",\"name\":\"TestProperty\",\"type\":{\"primitive\":\"String\",\"className\":\"HA_Type.Primitive\",\"nullable\":false,\"tags\":[]},\"value\":{\"expression\":\"TestValue\",\"className\":\"HA_DefaultValue.Const.Primitive\"},\"deprecation\":null,\"override\":false}],\"deprecation\":null,\"doc\":null}";
        var target = new ApiClassConverter();
            
        // Act
        ApiClass? result = null;
        var utf8JsonBytes = Encoding.UTF8.GetBytes(json);
        var reader = new Utf8JsonReader(utf8JsonBytes, true, new JsonReaderState());
        while (reader.Read())
        {
            result = target.Read(ref reader, typeof(ApiClass), new JsonSerializerOptions());
        }
                
        // Assert
        Assert.IsType<ApiClass.Clazz>(result);
            
        var classResult = result as ApiClass.Clazz;
        Assert.Equal("TestClass", classResult?.Name);
        Assert.Equal("TestProperty", classResult?.Properties.FirstOrDefault()?.Name);
        
        Assert.IsType<ApiType.Primitive>(classResult?.Properties.FirstOrDefault()?.Type);
        Assert.IsType<ApiDefaultValue.Const.Primitive>(classResult?.Properties.FirstOrDefault()?.Value);
    }
        
    [Fact]
    public void WriteTests()
    {
        // Arrange
        var input = new ApiClass.Clazz
        {
            VisibilityModifier = ApiVisibilityModifier.DEFAULT,
            Name = "TestClass",
            IsOpen = false,
            IsAbstract = false,
            IsSealed = false
        };
        input.Properties.Add(new ApiProperty
        {
            VisibilityModifier = ApiVisibilityModifier.DEFAULT,
            Name = "TestProperty",
            Type = new ApiType.Primitive { Type = "String" },
            Value = new ApiDefaultValue.Const.Primitive { Expression = "TestValue"},
            IsOverride = false
        });
        var target = new ApiClassConverter();
            
        // Act
        using var memoryStream = new MemoryStream();
        var writer = new Utf8JsonWriter(memoryStream);
        target.Write(writer, input, new JsonSerializerOptions());
        writer.Flush();
        memoryStream.Position = 0;
                
        using var reader = new StreamReader(memoryStream);
        var result = reader.ReadToEnd();
            
        // Assert
        Assert.Equal("{\"open\":false,\"abstract\":false,\"sealed\":false,\"extends\":null,\"className\":\"HA_Class.Clazz\",\"visibilityModifier\":\"DEFAULT\",\"name\":\"TestClass\",\"implements\":[],\"innerSubclasses\":[],\"properties\":[{\"visibilityModifier\":\"DEFAULT\",\"name\":\"TestProperty\",\"type\":{\"primitive\":\"String\",\"className\":\"HA_Type.Primitive\",\"nullable\":false,\"tags\":[]},\"value\":{\"expression\":\"TestValue\",\"className\":\"HA_DefaultValue.Const.Primitive\"},\"deprecation\":null,\"override\":false}],\"deprecation\":null,\"doc\":null}", result);
    }
}