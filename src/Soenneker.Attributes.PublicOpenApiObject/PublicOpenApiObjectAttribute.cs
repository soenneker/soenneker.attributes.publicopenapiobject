using System;

namespace Soenneker.Attributes.PublicOpenApiObject;

/// <summary>
/// For decorating objects that should be publicly accessible to see within OpenApi
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class PublicOpenApiObjectAttribute : Attribute
{
}