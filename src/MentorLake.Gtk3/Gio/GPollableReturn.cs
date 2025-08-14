namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Return value for various IO operations that signal errors via the
/// return value and not necessarily via a #GError.
/// </para>
/// <para>
/// This enum exists to be able to return errors to callers without having to
/// allocate a #GError. Allocating #GErrors can be quite expensive for
/// regularly happening errors like %G_IO_ERROR_WOULD_BLOCK.
/// </para>
/// <para>
/// In case of %G_POLLABLE_RETURN_FAILED a #GError should be set for the
/// operation to give details about the error that happened.
/// </para>
/// </summary>

[Flags]
public enum GPollableReturn
{
/// <summary>
/// <para>
/// Generic error condition for when an operation fails.
/// </para>
/// </summary>

	G_POLLABLE_RETURN_FAILED = 0,
/// <summary>
/// <para>
/// The operation was successfully finished.
/// </para>
/// </summary>

	G_POLLABLE_RETURN_OK = 1,
/// <summary>
/// <para>
/// The operation would block.
/// </para>
/// </summary>

	G_POLLABLE_RETURN_WOULD_BLOCK = -27
}
