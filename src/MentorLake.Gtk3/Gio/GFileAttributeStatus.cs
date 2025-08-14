namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Used by g_file_set_attributes_from_info() when setting file attributes.
/// </para>
/// </summary>

[Flags]
public enum GFileAttributeStatus
{
/// <summary>
/// <para>
/// Attribute value is unset (empty).
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_STATUS_UNSET = 0,
/// <summary>
/// <para>
/// Attribute value is set.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_STATUS_SET = 1,
/// <summary>
/// <para>
/// Indicates an error in setting the value.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_STATUS_ERROR_SETTING = 2
}
