namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of message being displayed in the dialog.
/// </para>
/// </summary>

[Flags]
public enum GtkMessageType
{
/// <summary>
/// <para>
/// Informational message
/// </para>
/// </summary>

	GTK_MESSAGE_INFO = 0,
/// <summary>
/// <para>
/// Non-fatal warning message
/// </para>
/// </summary>

	GTK_MESSAGE_WARNING = 1,
/// <summary>
/// <para>
/// Question requiring a choice
/// </para>
/// </summary>

	GTK_MESSAGE_QUESTION = 2,
/// <summary>
/// <para>
/// Fatal error message
/// </para>
/// </summary>

	GTK_MESSAGE_ERROR = 3,
/// <summary>
/// <para>
/// None of the above
/// </para>
/// </summary>

	GTK_MESSAGE_OTHER = 4
}
