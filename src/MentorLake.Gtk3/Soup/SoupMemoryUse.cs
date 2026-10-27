namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The lifetime of the memory being passed.
/// </para>
/// </summary>

[Flags]
public enum SoupMemoryUse
{
/// <summary>
/// <para>
/// The memory is statically allocated and
///   constant; libsoup can use the passed-in buffer directly and not
///   need to worry about it being modified or freed.
/// </para>
/// </summary>

	SOUP_MEMORY_STATIC = 0,
/// <summary>
/// <para>
/// The caller has allocated the memory and libsoup
///   will assume ownership of it and free it with [func@GLib.free].
/// </para>
/// </summary>

	SOUP_MEMORY_TAKE = 1,
/// <summary>
/// <para>
/// The passed-in data belongs to the caller and
///   libsoup will copy it into new memory leaving the caller free
///   to reuse the original memory.
/// </para>
/// </summary>

	SOUP_MEMORY_COPY = 2
}
