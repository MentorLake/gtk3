namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Enum values used to denote the different events that happen during a
/// #WebKitWebView load operation.
/// </para>
/// </summary>

[Flags]
public enum WebKitLoadEvent
{
/// <summary>
/// <para>
/// A new load request has been made.
/// No data has been received yet, empty structures have
/// been allocated to perform the load; the load may still
/// fail due to transport issues such as not being able to
/// resolve a name, or connect to a port.
/// </para>
/// </summary>

	WEBKIT_LOAD_STARTED = 0,
/// <summary>
/// <para>
/// A provisional data source received
/// a server redirect.
/// </para>
/// </summary>

	WEBKIT_LOAD_REDIRECTED = 1,
/// <summary>
/// <para>
/// The content started arriving for a page load.
/// The necessary transport requirements are established, and the
/// load is being performed.
/// </para>
/// </summary>

	WEBKIT_LOAD_COMMITTED = 2,
/// <summary>
/// <para>
/// Load completed. All resources are done loading
/// or there was an error during the load operation.
/// </para>
/// </summary>

	WEBKIT_LOAD_FINISHED = 3
}
