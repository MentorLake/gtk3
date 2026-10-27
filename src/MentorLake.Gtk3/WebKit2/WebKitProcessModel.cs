namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used for determining the #WebKitWebContext process model.
/// </para>
/// </summary>

[Flags]
public enum WebKitProcessModel
{
/// <summary>
/// <para>
/// Deprecated 2.26.
/// </para>
/// </summary>

	WEBKIT_PROCESS_MODEL_SHARED_SECONDARY_PROCESS = 0,
/// <summary>
/// <para>
/// Use one process
///   for each #WebKitWebView, while still allowing for some of them to
///   share a process in certain situations. The main advantage
///   of this process model is that the rendering process for a web view
///   can crash while the rest of the views keep working normally. This
///   process model is indicated for applications which may use a number
///   of web views and the content of in each must not interfere with the
///   rest — for example a full-fledged web browser with support for
///   multiple tabs.
/// </para>
/// </summary>

	WEBKIT_PROCESS_MODEL_MULTIPLE_SECONDARY_PROCESSES = 1
}
