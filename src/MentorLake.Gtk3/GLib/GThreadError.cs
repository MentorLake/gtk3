namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Possible errors of thread related functions.
/// </para>
/// </summary>

[Flags]
public enum GThreadError
{
/// <summary>
/// <para>
/// a thread couldn&apos;t be created due to resource
///                        shortage. Try again later.
/// </para>
/// </summary>

	G_THREAD_ERROR_AGAIN = 0
}
