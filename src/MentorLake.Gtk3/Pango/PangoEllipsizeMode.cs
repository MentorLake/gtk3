namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoEllipsizeMode` describes what sort of ellipsization
/// should be applied to text.
/// </para>
/// <para>
/// In the ellipsization process characters are removed from the
/// text in order to make it fit to a given width and replaced
/// with an ellipsis.
/// </para>
/// </summary>

[Flags]
public enum PangoEllipsizeMode
{
/// <summary>
/// <para>
/// No ellipsization
/// </para>
/// </summary>

	PANGO_ELLIPSIZE_NONE = 0,
/// <summary>
/// <para>
/// Omit characters at the start of the text
/// </para>
/// </summary>

	PANGO_ELLIPSIZE_START = 1,
/// <summary>
/// <para>
/// Omit characters in the middle of the text
/// </para>
/// </summary>

	PANGO_ELLIPSIZE_MIDDLE = 2,
/// <summary>
/// <para>
/// Omit characters at the end of the text
/// </para>
/// </summary>

	PANGO_ELLIPSIZE_END = 3
}
