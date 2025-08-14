namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoRenderPart` defines different items to render for such
/// purposes as setting colors.
/// </para>
/// </summary>

[Flags]
public enum PangoRenderPart
{
/// <summary>
/// <para>
/// the text itself
/// </para>
/// </summary>

	PANGO_RENDER_PART_FOREGROUND = 0,
/// <summary>
/// <para>
/// the area behind the text
/// </para>
/// </summary>

	PANGO_RENDER_PART_BACKGROUND = 1,
/// <summary>
/// <para>
/// underlines
/// </para>
/// </summary>

	PANGO_RENDER_PART_UNDERLINE = 2,
/// <summary>
/// <para>
/// strikethrough lines
/// </para>
/// </summary>

	PANGO_RENDER_PART_STRIKETHROUGH = 3,
/// <summary>
/// <para>
/// overlines
/// </para>
/// </summary>

	PANGO_RENDER_PART_OVERLINE = 4
}
