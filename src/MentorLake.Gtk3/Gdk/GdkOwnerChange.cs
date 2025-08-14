namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies why a selection ownership was changed.
/// </para>
/// </summary>

[Flags]
public enum GdkOwnerChange
{
/// <summary>
/// <para>
/// some other app claimed the ownership
/// </para>
/// </summary>

	GDK_OWNER_CHANGE_NEW_OWNER = 0,
/// <summary>
/// <para>
/// the window was destroyed
/// </para>
/// </summary>

	GDK_OWNER_CHANGE_DESTROY = 1,
/// <summary>
/// <para>
/// the client was closed
/// </para>
/// </summary>

	GDK_OWNER_CHANGE_CLOSE = 2
}
