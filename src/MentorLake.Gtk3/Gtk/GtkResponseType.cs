namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Predefined values for use as response ids in gtk_dialog_add_button().
/// All predefined values are negative; GTK+ leaves values of 0 or greater for
/// application-defined response ids.
/// </para>
/// </summary>

[Flags]
public enum GtkResponseType
{
/// <summary>
/// <para>
/// Returned if an action widget has no response id,
///     or if the dialog gets programmatically hidden or destroyed
/// </para>
/// </summary>

	GTK_RESPONSE_NONE = -1,
/// <summary>
/// <para>
/// Generic response id, not used by GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_REJECT = -2,
/// <summary>
/// <para>
/// Generic response id, not used by GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_ACCEPT = -3,
/// <summary>
/// <para>
/// Returned if the dialog is deleted
/// </para>
/// </summary>

	GTK_RESPONSE_DELETE_EVENT = -4,
/// <summary>
/// <para>
/// Returned by OK buttons in GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_OK = -5,
/// <summary>
/// <para>
/// Returned by Cancel buttons in GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_CANCEL = -6,
/// <summary>
/// <para>
/// Returned by Close buttons in GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_CLOSE = -7,
/// <summary>
/// <para>
/// Returned by Yes buttons in GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_YES = -8,
/// <summary>
/// <para>
/// Returned by No buttons in GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_NO = -9,
/// <summary>
/// <para>
/// Returned by Apply buttons in GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_APPLY = -10,
/// <summary>
/// <para>
/// Returned by Help buttons in GTK+ dialogs
/// </para>
/// </summary>

	GTK_RESPONSE_HELP = -11
}
