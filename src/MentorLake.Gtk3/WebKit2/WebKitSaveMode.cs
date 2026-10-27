namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values to specify the different ways in which a #WebKitWebView
/// can save its current web page into a self-contained file.
/// </para>
/// </summary>

[Flags]
public enum WebKitSaveMode
{
/// <summary>
/// <para>
/// Save the current page using the MHTML format.
/// </para>
/// </summary>

	WEBKIT_SAVE_MODE_MHTML = 0
}
