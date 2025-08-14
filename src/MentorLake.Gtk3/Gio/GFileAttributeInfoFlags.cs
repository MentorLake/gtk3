namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags specifying the behaviour of an attribute.
/// </para>
/// </summary>

[Flags]
public enum GFileAttributeInfoFlags : uint
{
/// <summary>
/// <para>
/// no flags set.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_INFO_NONE = 0,
/// <summary>
/// <para>
/// copy the attribute values when the file is copied.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_INFO_COPY_WITH_FILE = 1,
/// <summary>
/// <para>
/// copy the attribute values when the file is moved.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_INFO_COPY_WHEN_MOVED = 2
}
