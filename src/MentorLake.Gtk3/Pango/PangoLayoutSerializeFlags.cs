namespace MentorLake.Pango;

/// <summary>
/// <para>
/// Flags that influence the behavior of [method@Pango.Layout.serialize].
/// </para>
/// <para>
/// New members may be added to this enumeration over time.
/// </para>
/// </summary>

[Flags]
public enum PangoLayoutSerializeFlags : uint
{
/// <summary>
/// <para>
/// Default behavior
/// </para>
/// </summary>

	PANGO_LAYOUT_SERIALIZE_DEFAULT = 0,
/// <summary>
/// <para>
/// Include context information
/// </para>
/// </summary>

	PANGO_LAYOUT_SERIALIZE_CONTEXT = 1,
/// <summary>
/// <para>
/// Include information about the formatted output
/// </para>
/// </summary>

	PANGO_LAYOUT_SERIALIZE_OUTPUT = 2
}
