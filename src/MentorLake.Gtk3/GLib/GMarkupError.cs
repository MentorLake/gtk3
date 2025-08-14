namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by markup parsing.
/// </para>
/// </summary>

[Flags]
public enum GMarkupError
{
/// <summary>
/// <para>
/// text being parsed was not valid UTF-8
/// </para>
/// </summary>

	G_MARKUP_ERROR_BAD_UTF8 = 0,
/// <summary>
/// <para>
/// document contained nothing, or only whitespace
/// </para>
/// </summary>

	G_MARKUP_ERROR_EMPTY = 1,
/// <summary>
/// <para>
/// document was ill-formed
/// </para>
/// </summary>

	G_MARKUP_ERROR_PARSE = 2,
/// <summary>
/// <para>
/// error should be set by #GMarkupParser
///     functions; element wasn't known
/// </para>
/// </summary>

	G_MARKUP_ERROR_UNKNOWN_ELEMENT = 3,
/// <summary>
/// <para>
/// error should be set by #GMarkupParser
///     functions; attribute wasn't known
/// </para>
/// </summary>

	G_MARKUP_ERROR_UNKNOWN_ATTRIBUTE = 4,
/// <summary>
/// <para>
/// error should be set by #GMarkupParser
///     functions; content was invalid
/// </para>
/// </summary>

	G_MARKUP_ERROR_INVALID_CONTENT = 5,
/// <summary>
/// <para>
/// error should be set by #GMarkupParser
///     functions; a required attribute was missing
/// </para>
/// </summary>

	G_MARKUP_ERROR_MISSING_ATTRIBUTE = 6
}
