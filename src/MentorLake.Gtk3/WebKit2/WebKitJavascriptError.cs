namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote errors happening when executing JavaScript
/// </para>
/// </summary>

[Flags]
public enum WebKitJavascriptError
{
/// <summary>
/// <para>
/// An exception was raised in JavaScript execution
/// </para>
/// </summary>

	WEBKIT_JAVASCRIPT_ERROR_SCRIPT_FAILED = 699,
/// <summary>
/// <para>
/// An unsupported parameter has been used to call and async function from API. Since 2.40
/// </para>
/// </summary>

	WEBKIT_JAVASCRIPT_ERROR_INVALID_PARAMETER = 600,
/// <summary>
/// <para>
/// The result of JavaScript execution could not be returned. Since 2.40
/// </para>
/// </summary>

	WEBKIT_JAVASCRIPT_ERROR_INVALID_RESULT = 601
}
