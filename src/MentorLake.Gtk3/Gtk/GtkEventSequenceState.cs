namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes the state of a #GdkEventSequence in a #GtkGesture.
/// </para>
/// </summary>

[Flags]
public enum GtkEventSequenceState
{
/// <summary>
/// <para>
/// The sequence is handled, but not grabbed.
/// </para>
/// </summary>

	GTK_EVENT_SEQUENCE_NONE = 0,
/// <summary>
/// <para>
/// The sequence is handled and grabbed.
/// </para>
/// </summary>

	GTK_EVENT_SEQUENCE_CLAIMED = 1,
/// <summary>
/// <para>
/// The sequence is denied.
/// </para>
/// </summary>

	GTK_EVENT_SEQUENCE_DENIED = 2
}
