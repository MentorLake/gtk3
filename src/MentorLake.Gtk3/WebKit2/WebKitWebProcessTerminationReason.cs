namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to specify the reason why the web process terminated abnormally.
/// </para>
/// </summary>

[Flags]
public enum WebKitWebProcessTerminationReason
{
/// <summary>
/// <para>
/// the web process crashed.
/// </para>
/// </summary>

	WEBKIT_WEB_PROCESS_CRASHED = 0,
/// <summary>
/// <para>
/// the web process exceeded the memory limit.
/// </para>
/// </summary>

	WEBKIT_WEB_PROCESS_EXCEEDED_MEMORY_LIMIT = 1,
/// <summary>
/// <para>
/// the web process termination was requested by an API call. Since: 2.34
/// </para>
/// </summary>

	WEBKIT_WEB_PROCESS_TERMINATED_BY_API = 2
}
