namespace MentorLake.Gio;

/// <summary>
/// <para>
/// An error code used with %G_RESOLVER_ERROR in a #GError returned
/// from a #GResolver routine.
/// </para>
/// </summary>

[Flags]
public enum GResolverError
{
/// <summary>
/// <para>
/// the requested name/address/service was not
///     found
/// </para>
/// </summary>

	G_RESOLVER_ERROR_NOT_FOUND = 0,
/// <summary>
/// <para>
/// the requested information could not
///     be looked up due to a network error or similar problem
/// </para>
/// </summary>

	G_RESOLVER_ERROR_TEMPORARY_FAILURE = 1,
/// <summary>
/// <para>
/// unknown error
/// </para>
/// </summary>

	G_RESOLVER_ERROR_INTERNAL = 2
}
