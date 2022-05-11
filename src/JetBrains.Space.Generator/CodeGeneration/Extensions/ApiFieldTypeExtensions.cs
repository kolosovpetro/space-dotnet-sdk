using System;
using System.Linq;
using JetBrains.Space.Generator.Model.HttpApi;

namespace JetBrains.Space.Generator.CodeGeneration.Extensions;

public static class ApiFieldTypeExtensions
{
    public static ApiType GetArrayElementTypeOrType(this ApiType subject)
    {
        if (subject is ApiType.Array arrayFieldType)
        {
            return arrayFieldType.ElementType;
        }

        return subject;
    }
        
    public static ApiType GetMapValueTypeOrType(this ApiType subject)
    {
        if (subject is ApiType.Map mapFieldType)
        {
            return mapFieldType.ValueType;
        }

        return subject;
    }
        
    public static ApiType GetBatchElementTypeOrType(this ApiType subject)
    {
        if (subject is ApiType.Object objectFieldType)
        {
            return GetBatchDataType(objectFieldType)?.ElementType ?? objectFieldType;
        }

        return subject.GetArrayElementTypeOrType();
    }
        
    public static ApiType.Array? GetBatchDataType(this ApiType.Object subject)
    {
        if (subject.Kind != ApiType.Object.ObjectKind.BATCH) return null;
            
        var dataFieldType = subject.Fields.First(it => string.Equals(it.Name, "data", StringComparison.OrdinalIgnoreCase));
        var dataFieldArrayType = (ApiType.Array)dataFieldType.Type;
        return dataFieldArrayType;
    }
}