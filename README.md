
# BlazorEasyDialog

BlazorEasyDialog is a simple, JavaScript-free dialog component for Blazor applications. It allows you to easily create and customize dialogs without relying on external JavaScript libraries.



## Features

- Create dialogs without writing JavaScript
- Customize dialog appearance and behavior
- Easily integrate dialogs into existing Blazor applications
## Installation

**1. Add the nuget package in your Blazor project**

```bash
  > dotnet add package BlazorDialog
  
  OR
  
  PM> Install-Package BlazorDialog
```
**2. Add css link in head of index.html**

  ```bash
  <link rel="stylesheet" href="_content/BlazorEasyDialog/css/styles.css">

```  
**3. Add css link in the head of index.html**

  ```bash
  <link rel="stylesheet" href="_content/BlazorEasyDialog/css/styles.css">

```  

**4. Add the following line in your _Imports.razor**

  ```bash
  @using BlazorEasyDialog.Components

```  
## Usage/Examples

**1. Home.razor**

```csharp
<button class="btn btn-primary" @onclick="()=>ShowDialog = true">Open</button>

@page "/"

<p>@TextValue</p>
<button class="btn btn-primary" @onclick="()=>ShowDialog =true">Open</button>

<BlazorEasyDialog @bind-Visibility="ShowDialog" 
                  SubmitDialog="@OnSubmit"
                  HeaderBackgroundColor="red"
                  HeaderTitle="Dialog Title" >
    <DialogBody>
        <p>This is a dialog body!!</p>
    </DialogBody>
</BlazorEasyDialog>
```

**2. Home.razor.cs**

```csharp
using Microsoft.AspNetCore.Components;

namespace BlazorEasyDialog.Sample.Pages;

public partial class Home : ComponentBase
{
    public string TextValue { get; set; }
    public bool ShowDialog { get; set; }

    private void OnSubmit(bool isSuccess)
    {
        TextValue = isSuccess ? "Success" : "Not success";
        ShowDialog = false;
    }
}
```
