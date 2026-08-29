[![](https://img.shields.io/nuget/v/soenneker.attributes.publicopenapiobject.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.publicopenapiobject/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.publicopenapiobject/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.publicopenapiobject/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.publicopenapiobject.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.publicopenapiobject/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.publicopenapiobject/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.publicopenapiobject/actions/workflows/codeql.yml)

# Soenneker.Attributes.PublicOpenApiObject

A marker attribute for contract classes whose schemas are eligible for a public OpenAPI document.

## Installation

```bash
dotnet add package Soenneker.Attributes.PublicOpenApiObject
```

## Usage

```csharp
using Soenneker.Attributes.PublicOpenApiObject;

[PublicOpenApiObject]
public sealed class PublicCustomer
{
    public required string Id { get; init; }
    public required string DisplayName { get; init; }
}
```

An OpenAPI schema or document filter can select marked types:

```csharp
using System.Reflection;

bool include = typeof(PublicCustomer)
    .IsDefined(typeof(PublicOpenApiObjectAttribute), inherit: true);
```

## Important behavior

- The attribute targets classes. It cannot be applied directly to structs, enums, interfaces, or individual properties.
- Derived classes observe the marker through normal inherited attribute lookup.
- The package does not add, remove, or modify OpenAPI schemas on its own; a generator integration must read the marker.
- Marking a type does not prove that every property is safe to publish. Review the complete serialized schema before including it in a public document.
