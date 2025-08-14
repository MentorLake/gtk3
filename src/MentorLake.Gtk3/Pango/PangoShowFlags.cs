namespace MentorLake.Pango;

/// <summary>
/// <para>
/// These flags affect how Pango treats characters that are normally
/// not visible in the output.
/// </para>
/// </summary>

[Flags]
public enum PangoShowFlags : uint
{
/// <summary>
/// <para>
/// No special treatment for invisible characters
/// </para>
/// </summary>

	PANGO_SHOW_NONE = 0,
/// <summary>
/// <para>
/// Render spaces, tabs and newlines visibly
/// </para>
/// </summary>

	PANGO_SHOW_SPACES = 1,
/// <summary>
/// <para>
/// Render line breaks visibly
/// </para>
/// </summary>

	PANGO_SHOW_LINE_BREAKS = 2,
/// <summary>
/// <para>
/// Render default-ignorable Unicode
///   characters visibly
/// </para>
/// </summary>

	PANGO_SHOW_IGNORABLES = 4
}
