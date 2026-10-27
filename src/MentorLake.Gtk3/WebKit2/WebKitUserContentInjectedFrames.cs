namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Specifies in which frames user style sheets are to be inserted in.
/// </para>
/// </summary>

[Flags]
public enum WebKitUserContentInjectedFrames
{
/// <summary>
/// <para>
/// Insert the user style
///   sheet in all the frames loaded by the web view, including
///   nested frames. This is the default.
/// </para>
/// </summary>

	WEBKIT_USER_CONTENT_INJECT_ALL_FRAMES = 0,
/// <summary>
/// <para>
/// Insert the user style
///   sheet *only* in the top-level frame loaded by the web view,
///   and *not* in the nested frames.
/// </para>
/// </summary>

	WEBKIT_USER_CONTENT_INJECT_TOP_FRAME = 1
}
