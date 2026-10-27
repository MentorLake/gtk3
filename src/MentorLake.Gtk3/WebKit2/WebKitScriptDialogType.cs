namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used for determining the type of #WebKitScriptDialog
/// </para>
/// </summary>

[Flags]
public enum WebKitScriptDialogType
{
/// <summary>
/// <para>
/// Alert script dialog, used to show a
/// message to the user.
/// </para>
/// </summary>

	WEBKIT_SCRIPT_DIALOG_ALERT = 0,
/// <summary>
/// <para>
/// Confirm script dialog, used to ask
/// confirmation to the user.
/// </para>
/// </summary>

	WEBKIT_SCRIPT_DIALOG_CONFIRM = 1,
/// <summary>
/// <para>
/// Prompt script dialog, used to ask
/// information to the user.
/// </para>
/// </summary>

	WEBKIT_SCRIPT_DIALOG_PROMPT = 2,
/// <summary>
/// <para>
/// Before unload confirm dialog,
/// used to ask confirmation to leave the current page to the user. Since 2.12
/// </para>
/// </summary>

	WEBKIT_SCRIPT_DIALOG_BEFORE_UNLOAD_CONFIRM = 3
}
