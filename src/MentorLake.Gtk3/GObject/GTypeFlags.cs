namespace MentorLake.GObject;

/// <summary>
/// <para>
/// Bit masks used to check or determine characteristics of a type.
/// </para>
/// </summary>

[Flags]
public enum GTypeFlags : uint
{
/// <summary>
/// <para>
/// No special flags. Since: 2.74
/// </para>
/// </summary>

	G_TYPE_FLAG_NONE = 0,
/// <summary>
/// <para>
/// Indicates an abstract type. No instances can be
///  created for an abstract type
/// </para>
/// </summary>

	G_TYPE_FLAG_ABSTRACT = 16,
/// <summary>
/// <para>
/// Indicates an abstract value type, i.e. a type
///  that introduces a value table, but can't be used for
///  g_value_init()
/// </para>
/// </summary>

	G_TYPE_FLAG_VALUE_ABSTRACT = 32,
/// <summary>
/// <para>
/// Indicates a final type. A final type is a non-derivable
///  leaf node in a deep derivable type hierarchy tree. Since: 2.70
/// </para>
/// </summary>

	G_TYPE_FLAG_FINAL = 64,
/// <summary>
/// <para>
/// The type is deprecated and may be removed in a
///  future version. A warning will be emitted if it is instantiated while
///  running with `G_ENABLE_DIAGNOSTIC=1`. Since 2.76
/// </para>
/// </summary>

	G_TYPE_FLAG_DEPRECATED = 128
}
