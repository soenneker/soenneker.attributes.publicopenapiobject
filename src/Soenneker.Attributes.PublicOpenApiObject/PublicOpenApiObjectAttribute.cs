using System;

namespace Soenneker.Attributes.PublicOpenApiObject;

/// <summary>
/// Marks a contract type as eligible for inclusion in a public OpenAPI document.
/// </summary>
/// <remarks>
/// Apply this attribute to request, response, DTO, and value-object types whose schema is safe and useful for public API consumers.
/// </remarks>
[AttributeUsage(AttributeTargets.Class)]
public class PublicOpenApiObjectAttribute : Attribute
{
}
