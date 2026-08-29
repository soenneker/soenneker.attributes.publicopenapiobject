[![](https://img.shields.io/nuget/v/soenneker.attributes.publicopenapiobject.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.publicopenapiobject/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.publicopenapiobject/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.publicopenapiobject/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.publicopenapiobject.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.publicopenapiobject/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.publicopenapiobject/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.publicopenapiobject/actions/workflows/codeql.yml)

# Soenneker.Attributes.PublicOpenApiObject

Marks a contract type as eligible for inclusion in a public OpenAPI document.

## Install

```bash
dotnet add package Soenneker.Attributes.PublicOpenApiObject
```

## Quick start

```csharp
using Soenneker.Attributes.PublicOpenApiObject;

[PublicOpenApiObject]
public sealed class Example
{
}
```

Marks a contract type as eligible for inclusion in a public OpenAPI document.

## What you get

- `PublicOpenApiObjectAttribute` — Marks a contract type as eligible for inclusion in a public OpenAPI document.

## Important behavior

- `PublicOpenApiObjectAttribute`: Apply this attribute to request, response, DTO, and value-object types whose schema is safe and useful for public API consumers.
