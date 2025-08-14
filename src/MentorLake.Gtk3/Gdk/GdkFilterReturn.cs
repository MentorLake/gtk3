namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the result of applying a #GdkFilterFunc to a native event.
/// </para>
/// </summary>

[Flags]
public enum GdkFilterReturn
{
/// <summary>
/// <para>
/// event not handled, continue processing.
/// </para>
/// </summary>

	GDK_FILTER_CONTINUE = 0,
/// <summary>
/// <para>
/// native event translated into a GDK event and stored
///  in the `event` structure that was passed in.
/// </para>
/// </summary>

	GDK_FILTER_TRANSLATE = 1,
/// <summary>
/// <para>
/// event handled, terminate processing.
/// </para>
/// </summary>

	GDK_FILTER_REMOVE = 2
}
