namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_extend_t is used to describe how pattern color/alpha will be
/// determined for areas &quot;outside&quot; the pattern&apos;s natural area, (for
/// example, outside the surface bounds or outside the gradient
/// geometry).
/// </para>
/// <para>
/// Mesh patterns are not affected by the extend mode.
/// </para>
/// <para>
/// The default extend mode is %CAIRO_EXTEND_NONE for surface patterns
/// and %CAIRO_EXTEND_PAD for gradient patterns.
/// </para>
/// <para>
/// New entries may be added in future versions.
/// </para>
/// </summary>

[Flags]
public enum cairo_extend_t
{
/// <summary>
/// <para>
/// pixels outside of the source pattern
///   are fully transparent (Since 1.0)
/// </para>
/// </summary>

	CAIRO_EXTEND_NONE = 0,
/// <summary>
/// <para>
/// the pattern is tiled by repeating (Since 1.0)
/// </para>
/// </summary>

	CAIRO_EXTEND_REPEAT = 1,
/// <summary>
/// <para>
/// the pattern is tiled by reflecting
///   at the edges (Since 1.0; but only implemented for surface patterns since 1.6)
/// </para>
/// </summary>

	CAIRO_EXTEND_REFLECT = 2,
/// <summary>
/// <para>
/// pixels outside of the pattern copy
///   the closest pixel from the source (Since 1.2; but only
///   implemented for surface patterns since 1.6)
/// </para>
/// </summary>

	CAIRO_EXTEND_PAD = 3
}
