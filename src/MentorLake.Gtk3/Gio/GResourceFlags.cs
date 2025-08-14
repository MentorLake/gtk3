namespace MentorLake.Gio;

/// <summary>
/// <para>
/// GResourceFlags give information about a particular file inside a resource
/// bundle.
/// </para>
/// </summary>

[Flags]
public enum GResourceFlags : uint
{
/// <summary>
/// <para>
/// No flags set.
/// </para>
/// </summary>

	G_RESOURCE_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// The file is compressed.
/// </para>
/// </summary>

	G_RESOURCE_FLAGS_COMPRESSED = 1
}
