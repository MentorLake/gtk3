namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Used in #GdkDragContext to indicate what the destination
/// should do with the dropped data.
/// </para>
/// </summary>

[Flags]
public enum GdkDragAction : uint
{
/// <summary>
/// <para>
/// Means nothing, and should not be used.
/// </para>
/// </summary>

	GDK_ACTION_DEFAULT = 1,
/// <summary>
/// <para>
/// Copy the data.
/// </para>
/// </summary>

	GDK_ACTION_COPY = 2,
/// <summary>
/// <para>
/// Move the data, i.e. first copy it, then delete
///  it from the source using the DELETE target of the X selection protocol.
/// </para>
/// </summary>

	GDK_ACTION_MOVE = 4,
/// <summary>
/// <para>
/// Add a link to the data. Note that this is only
///  useful if source and destination agree on what it means.
/// </para>
/// </summary>

	GDK_ACTION_LINK = 8,
/// <summary>
/// <para>
/// Special action which tells the source that the
///  destination will do something that the source doesn’t understand.
/// </para>
/// </summary>

	GDK_ACTION_PRIVATE = 16,
/// <summary>
/// <para>
/// Ask the user what to do with the data.
/// </para>
/// </summary>

	GDK_ACTION_ASK = 32
}
