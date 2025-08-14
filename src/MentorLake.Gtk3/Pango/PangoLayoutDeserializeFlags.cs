namespace MentorLake.Pango;

/// <summary>
/// <para>
/// Flags that influence the behavior of [func@Pango.Layout.deserialize].
/// </para>
/// <para>
/// New members may be added to this enumeration over time.
/// </para>
/// </summary>

[Flags]
public enum PangoLayoutDeserializeFlags : uint
{
/// <summary>
/// <para>
/// Default behavior
/// </para>
/// </summary>

	PANGO_LAYOUT_DESERIALIZE_DEFAULT = 0,
/// <summary>
/// <para>
/// Apply context information
///   from the serialization to the `PangoContext`
/// </para>
/// </summary>

	PANGO_LAYOUT_DESERIALIZE_CONTEXT = 1
}
