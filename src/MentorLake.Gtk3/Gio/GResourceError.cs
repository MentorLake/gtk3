namespace MentorLake.Gio;

/// <summary>
/// <para>
/// An error code used with %G_RESOURCE_ERROR in a #GError returned
/// from a #GResource routine.
/// </para>
/// </summary>

[Flags]
public enum GResourceError
{
/// <summary>
/// <para>
/// no file was found at the requested path
/// </para>
/// </summary>

	G_RESOURCE_ERROR_NOT_FOUND = 0,
/// <summary>
/// <para>
/// unknown error
/// </para>
/// </summary>

	G_RESOURCE_ERROR_INTERNAL = 1
}
