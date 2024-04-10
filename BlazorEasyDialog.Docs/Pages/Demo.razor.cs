using Microsoft.AspNetCore.Components;

namespace BlazorEasyDialog.Docs.Pages;

public partial class Demo : ComponentBase
{
    public string? HeaderTitle { get; set; } = "Dialog Title";
    public bool ShowCloseButton { get; set; }
    public bool ShowHeader { get; set; } = true;
    public bool ShowOverlay { get; set; } = true;
    public bool ShowFooter { get; set; } = true;
    public string PrimaryButtonText { get; set; } = "Yes";
    public string SecondaryButtonText { get; set; } = "No";
    public bool DisablePrimaryButton { get; set; }
    public bool DisableSecondaryButton { get; set; }
    public bool ShowPrimaryButton { get; set; } = true;
    public bool ShowSecondaryButton { get; set; } = true;
    public bool DismissOnOverlayClick { get; set; }
    public string OverlayBackgroundColor { get; set; } = "rgba(223, 223, 223, 0.2)";
    public string Width { get; set; } = "500px";
    public string? MaxWidth { get; set; } = "auto";
    public string? MinWidth { get; set; } = "auto";
    public string Height { get; set; } = "auto";
    public string? MaxHeight { get; set; } = "80vh";
    public string? MinHeight { get; set; } = "auto";
    public string HeaderBackgroundColor { get; set; } = "#592c8c";
    public string PrimaryButtonColor { get; set; } = "#592c8c";
    public string SecondaryButtonColor { get; set; } = "#c61938";
    public string DialogContent { get; set; } = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci consequatur corporis cum deleniti, dignissimos eius eos modi natus officia quos, tempora totam vel vero?";
    public bool ShowDialog { get; set; }
}