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