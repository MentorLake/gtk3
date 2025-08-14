namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The data types for file attributes.
/// </para>
/// </summary>

[Flags]
public enum GFileAttributeType
{
/// <summary>
/// <para>
/// indicates an invalid or uninitialized type.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_INVALID = 0,
/// <summary>
/// <para>
/// a null terminated UTF8 string.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_STRING = 1,
/// <summary>
/// <para>
/// a zero terminated string of non-zero bytes.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_BYTE_STRING = 2,
/// <summary>
/// <para>
/// a boolean value.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_BOOLEAN = 3,
/// <summary>
/// <para>
/// an unsigned 4-byte/32-bit integer.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_UINT32 = 4,
/// <summary>
/// <para>
/// a signed 4-byte/32-bit integer.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_INT32 = 5,
/// <summary>
/// <para>
/// an unsigned 8-byte/64-bit integer.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_UINT64 = 6,
/// <summary>
/// <para>
/// a signed 8-byte/64-bit integer.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_INT64 = 7,
/// <summary>
/// <para>
/// a #GObject.
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_OBJECT = 8,
/// <summary>
/// <para>
/// a %NULL terminated char **. Since 2.22
/// </para>
/// </summary>

	G_FILE_ATTRIBUTE_TYPE_STRINGV = 9
}
