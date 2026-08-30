[![](https://img.shields.io/nuget/v/soenneker.dtos.idvaluepair.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idvaluepair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idvaluepair/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idvaluepair/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.idvaluepair.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idvaluepair/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idvaluepair/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idvaluepair/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdValuePair

A compact DTO for associating a string identifier with a string value. It is useful at API boundaries where a dictionary-shaped payload would be inconvenient or ambiguous.

## Install

```bash
dotnet add package Soenneker.Dtos.IdValuePair
```

## Usage

```csharp
using Soenneker.Dtos.IdValuePair;

var selection = new IdValuePair
{
    Id = "plan-42",
    Value = "Professional"
};
```

The JSON property names are `id` and `value` with both `System.Text.Json` and Newtonsoft.Json. Both properties are required during object initialization and are init-only after construction.

```json
{
  "id": "plan-42",
  "value": "Professional"
}
```

`[Required]` supplies validation metadata; it does not automatically run validation when an instance is created.
