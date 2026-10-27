namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values with flags representing the context of a #WebKitHitTestResult.
/// </para>
/// </summary>

[Flags]
public enum WebKitHitTestResultContext : uint
{
/// <summary>
/// <para>
/// anywhere in the document.
/// </para>
/// </summary>

	WEBKIT_HIT_TEST_RESULT_CONTEXT_DOCUMENT = 2,
/// <summary>
/// <para>
/// a hyperlink element.
/// </para>
/// </summary>

	WEBKIT_HIT_TEST_RESULT_CONTEXT_LINK = 4,
/// <summary>
/// <para>
/// an image element.
/// </para>
/// </summary>

	WEBKIT_HIT_TEST_RESULT_CONTEXT_IMAGE = 8,
/// <summary>
/// <para>
/// a video or audio element.
/// </para>
/// </summary>

	WEBKIT_HIT_TEST_RESULT_CONTEXT_MEDIA = 16,
/// <summary>
/// <para>
/// an editable element
/// </para>
/// </summary>

	WEBKIT_HIT_TEST_RESULT_CONTEXT_EDITABLE = 32,
/// <summary>
/// <para>
/// a scrollbar element.
/// </para>
/// </summary>

	WEBKIT_HIT_TEST_RESULT_CONTEXT_SCROLLBAR = 64,
/// <summary>
/// <para>
/// a selected element. Since 2.8
/// </para>
/// </summary>

	WEBKIT_HIT_TEST_RESULT_CONTEXT_SELECTION = 128
}
