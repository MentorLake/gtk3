namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Specifies at which place of documents an user script will be inserted.
/// </para>
/// </summary>

[Flags]
public enum WebKitUserScriptInjectionTime
{
/// <summary>
/// <para>
/// Insert the code of the user
///   script at the beginning of loaded documents. This is the default.
/// </para>
/// </summary>

	WEBKIT_USER_SCRIPT_INJECT_AT_DOCUMENT_START = 0,
/// <summary>
/// <para>
/// Insert the code of the user
///   script at the end of the loaded documents.
/// </para>
/// </summary>

	WEBKIT_USER_SCRIPT_INJECT_AT_DOCUMENT_END = 1
}
