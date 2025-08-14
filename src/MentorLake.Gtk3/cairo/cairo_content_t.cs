namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_content_t is used to describe the content that a surface will
/// contain, whether color information, alpha information (translucence
/// vs. opacity), or both.
/// </para>
/// <para>
/// Note: The large values here are designed to keep #cairo_content_t
/// values distinct from #cairo_format_t values so that the
/// implementation can detect the error if users confuse the two types.
/// </para>
/// </summary>

[Flags]
public enum cairo_content_t
{
/// <summary>
/// <para>
/// The surface will hold color content only. (Since 1.0)
/// </para>
/// </summary>

	CAIRO_CONTENT_COLOR = 4096,
/// <summary>
/// <para>
/// The surface will hold alpha content only. (Since 1.0)
/// </para>
/// </summary>

	CAIRO_CONTENT_ALPHA = 8192,
/// <summary>
/// <para>
/// The surface will hold color and alpha content. (Since 1.0)
/// </para>
/// </summary>

	CAIRO_CONTENT_COLOR_ALPHA = 12288
}
