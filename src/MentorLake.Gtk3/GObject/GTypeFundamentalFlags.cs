namespace MentorLake.GObject;

/// <summary>
/// <para>
/// Bit masks used to check or determine specific characteristics of a
/// fundamental type.
/// </para>
/// </summary>

[Flags]
public enum GTypeFundamentalFlags : uint
{
/// <summary>
/// <para>
/// Indicates a classed type
/// </para>
/// </summary>

	G_TYPE_FLAG_CLASSED = 1,
/// <summary>
/// <para>
/// Indicates an instantiatable type (implies classed)
/// </para>
/// </summary>

	G_TYPE_FLAG_INSTANTIATABLE = 2,
/// <summary>
/// <para>
/// Indicates a flat derivable type
/// </para>
/// </summary>

	G_TYPE_FLAG_DERIVABLE = 4,
/// <summary>
/// <para>
/// Indicates a deep derivable type (implies derivable)
/// </para>
/// </summary>

	G_TYPE_FLAG_DEEP_DERIVABLE = 8
}
