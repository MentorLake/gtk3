namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used for determining the automation browsing context presentation.
/// </para>
/// </summary>

[Flags]
public enum WebKitAutomationBrowsingContextPresentation
{
/// <summary>
/// <para>
/// a window
/// </para>
/// </summary>

	WEBKIT_AUTOMATION_BROWSING_CONTEXT_PRESENTATION_WINDOW = 0,
/// <summary>
/// <para>
/// a tab
/// </para>
/// </summary>

	WEBKIT_AUTOMATION_BROWSING_CONTEXT_PRESENTATION_TAB = 1
}
