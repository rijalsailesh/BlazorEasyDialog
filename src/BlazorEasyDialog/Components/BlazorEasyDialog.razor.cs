using Microsoft.AspNetCore.Components;

namespace BlazorEasyDialog.Components;

public partial class BlazorEasyDialog : ComponentBase
{
    [Parameter] public bool ShowDialog { get; set; }
    [Parameter] public string Id { get; set; } = Guid.NewGuid().ToString();
    [Parameter] public string? HeaderTitle { get; set; }
    [Parameter] public string? HeaderTitleTemplate { get; set; }
    [Parameter] public RenderFragment? HeaderTemplate { get; set; }
    [Parameter] public bool ShowCloseButton { get; set; }
    [Parameter] public bool ShowHeader { get; set; } = true;
    [Parameter] public bool ShowOverlay { get; set; } = true;
    [Parameter] public bool ShowFooter { get; set; } = true;
    [Parameter] public RenderFragment? DialogBody { get; set; }
    [Parameter] public RenderFragment? FooterTemplate { get; set; }
    [Parameter] public string PrimaryButtonText { get; set; } = "Yes";
    [Parameter] public string SecondaryButtonText { get; set; } = "No";
    [Parameter] public bool DisablePrimaryButton { get; set; }
    [Parameter] public bool DisableSecondaryButton { get; set; }
    [Parameter] public bool ShowPrimaryButton { get; set; } = true;
    [Parameter] public bool ShowSecondaryButton { get; set; } = true;
    [Parameter] public bool DismissOnOverlayClick { get; set; }
    [Parameter] public string OverlayBackgroundColor { get; set; } = "rgba(223, 223, 223, 0.2)";
    [Parameter] public string Width { get; set; } = "500px";
    [Parameter] public string? MaxWidth { get; set; } = "auto";
    [Parameter] public string? MinWidth { get; set; } = "auto";
    [Parameter] public string Height { get; set; } = "auto";
    [Parameter] public string? MaxHeight { get; set; } = "80vh";
    [Parameter] public string? MinHeight { get; set; } = "auto";
    [Parameter] public string HeaderBackgroundColor { get; set; } = "#592c8c";
    [Parameter] public string PrimaryButtonColor { get; set; } = "#592c8c";
    [Parameter] public string SecondaryButtonColor { get; set; } = "#c61938";
    [Parameter] public EventCallback<bool> SubmitDialog { get; set; }

    public void DismissDialog()
    {
        ShowDialog = false;
    }

    private async Task OnSubmitDialogAsync()
    {
        if (SubmitDialog.HasDelegate)
            await SubmitDialog.InvokeAsync(true)
                .ConfigureAwait(false);

    }

    private async Task CancelDialog()
    {
        ShowDialog = false;
        if(SubmitDialog.HasDelegate)
            await SubmitDialog.InvokeAsync(false)
                .ConfigureAwait(false);
        this.StateHasChanged();
    }

    private void OnOverlayClicked()
    {
        if(DismissOnOverlayClick)
            DismissDialog();
    }
}