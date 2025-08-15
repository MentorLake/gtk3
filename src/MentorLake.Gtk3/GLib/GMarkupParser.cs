namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Any of the fields in #GMarkupParser can be %NULL, in which case they
/// will be ignored. Except for the @error function, any of these callbacks
/// can set an error; in particular the %G_MARKUP_ERROR_UNKNOWN_ELEMENT,
/// %G_MARKUP_ERROR_UNKNOWN_ATTRIBUTE, and %G_MARKUP_ERROR_INVALID_CONTENT
/// errors are intended to be set from these callbacks. If you set an error
/// from a callback, g_markup_parse_context_parse() will report that error
/// back to its caller.
/// </para>
/// </summary>

public class GMarkupParserHandle : BaseSafeHandle
{
}


public static class GMarkupParserExtensions
{

	public static GMarkupParser Dereference(this GMarkupParserHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMarkupParser>(x.DangerousGetHandle());
}
internal class GMarkupParserExterns
{
}

/// <summary>
/// <para>
/// Any of the fields in #GMarkupParser can be %NULL, in which case they
/// will be ignored. Except for the @error function, any of these callbacks
/// can set an error; in particular the %G_MARKUP_ERROR_UNKNOWN_ELEMENT,
/// %G_MARKUP_ERROR_UNKNOWN_ATTRIBUTE, and %G_MARKUP_ERROR_INVALID_CONTENT
/// errors are intended to be set from these callbacks. If you set an error
/// from a callback, g_markup_parse_context_parse() will report that error
/// back to its caller.
/// </para>
/// </summary>

public struct GMarkupParser
{
	/// <summary>
/// <para>
/// Callback to invoke when the opening tag of an element
///     is seen. The callback&apos;s @attribute_names and @attribute_values parameters
///     are %NULL-terminated.
/// </para>
/// </summary>

public IntPtr start_element;
	/// <summary>
/// <para>
/// Callback to invoke when the closing tag of an element
///     is seen. Note that this is also called for empty tags like
///     `&amp;lt;empty/&amp;gt;`.
/// </para>
/// </summary>

public IntPtr end_element;
	/// <summary>
/// <para>
/// Callback to invoke when some text is seen (text is always
///     inside an element). Note that the text of an element may be spread
///     over multiple calls of this function. If the
///     %G_MARKUP_TREAT_CDATA_AS_TEXT flag is set, this function is also
///     called for the content of CDATA marked sections.
/// </para>
/// </summary>

public IntPtr text;
	/// <summary>
/// <para>
/// Callback to invoke for comments, processing instructions
///     and doctype declarations; if you&apos;re re-writing the parsed document,
///     write the passthrough text back out in the same position. If the
///     %G_MARKUP_TREAT_CDATA_AS_TEXT flag is not set, this function is also
///     called for CDATA marked sections.
/// </para>
/// </summary>

public IntPtr passthrough;
	/// <summary>
/// <para>
/// Callback to invoke when an error occurs.
/// </para>
/// </summary>

public IntPtr error;
}
