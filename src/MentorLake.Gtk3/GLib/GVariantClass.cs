namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The range of possible top-level types of #GVariant instances.
/// </para>
/// </summary>

[Flags]
public enum GVariantClass
{
/// <summary>
/// <para>
/// The #GVariant is a boolean.
/// </para>
/// </summary>

	G_VARIANT_CLASS_BOOLEAN = 98,
/// <summary>
/// <para>
/// The #GVariant is a byte.
/// </para>
/// </summary>

	G_VARIANT_CLASS_BYTE = 121,
/// <summary>
/// <para>
/// The #GVariant is a signed 16 bit integer.
/// </para>
/// </summary>

	G_VARIANT_CLASS_INT16 = 110,
/// <summary>
/// <para>
/// The #GVariant is an unsigned 16 bit integer.
/// </para>
/// </summary>

	G_VARIANT_CLASS_UINT16 = 113,
/// <summary>
/// <para>
/// The #GVariant is a signed 32 bit integer.
/// </para>
/// </summary>

	G_VARIANT_CLASS_INT32 = 105,
/// <summary>
/// <para>
/// The #GVariant is an unsigned 32 bit integer.
/// </para>
/// </summary>

	G_VARIANT_CLASS_UINT32 = 117,
/// <summary>
/// <para>
/// The #GVariant is a signed 64 bit integer.
/// </para>
/// </summary>

	G_VARIANT_CLASS_INT64 = 120,
/// <summary>
/// <para>
/// The #GVariant is an unsigned 64 bit integer.
/// </para>
/// </summary>

	G_VARIANT_CLASS_UINT64 = 116,
/// <summary>
/// <para>
/// The #GVariant is a file handle index.
/// </para>
/// </summary>

	G_VARIANT_CLASS_HANDLE = 104,
/// <summary>
/// <para>
/// The #GVariant is a double precision floating
///                          point value.
/// </para>
/// </summary>

	G_VARIANT_CLASS_DOUBLE = 100,
/// <summary>
/// <para>
/// The #GVariant is a normal string.
/// </para>
/// </summary>

	G_VARIANT_CLASS_STRING = 115,
/// <summary>
/// <para>
/// The #GVariant is a D-Bus object path
///                               string.
/// </para>
/// </summary>

	G_VARIANT_CLASS_OBJECT_PATH = 111,
/// <summary>
/// <para>
/// The #GVariant is a D-Bus signature string.
/// </para>
/// </summary>

	G_VARIANT_CLASS_SIGNATURE = 103,
/// <summary>
/// <para>
/// The #GVariant is a variant.
/// </para>
/// </summary>

	G_VARIANT_CLASS_VARIANT = 118,
/// <summary>
/// <para>
/// The #GVariant is a maybe-typed value.
/// </para>
/// </summary>

	G_VARIANT_CLASS_MAYBE = 109,
/// <summary>
/// <para>
/// The #GVariant is an array.
/// </para>
/// </summary>

	G_VARIANT_CLASS_ARRAY = 97,
/// <summary>
/// <para>
/// The #GVariant is a tuple.
/// </para>
/// </summary>

	G_VARIANT_CLASS_TUPLE = 40,
/// <summary>
/// <para>
/// The #GVariant is a dictionary entry.
/// </para>
/// </summary>

	G_VARIANT_CLASS_DICT_ENTRY = 123
}
