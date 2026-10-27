namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Specifies how to treat an user style sheet.
/// </para>
/// </summary>

[Flags]
public enum WebKitUserStyleLevel
{
/// <summary>
/// <para>
/// The style sheet is an user style sheet,
///   its contents always override other style sheets. This is the default.
/// </para>
/// </summary>

	WEBKIT_USER_STYLE_LEVEL_USER = 0,
/// <summary>
/// <para>
/// The style sheet will be treated as if
///   it was provided by the loaded documents. That means other user style
///   sheets may still override it.
/// </para>
/// </summary>

	WEBKIT_USER_STYLE_LEVEL_AUTHOR = 1
}
