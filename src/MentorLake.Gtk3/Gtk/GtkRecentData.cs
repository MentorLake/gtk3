namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Meta-data to be passed to gtk_recent_manager_add_full() when
/// registering a recently used resource.
/// </para>
/// </summary>

public class GtkRecentDataHandle : BaseSafeHandle
{
}


public static class GtkRecentDataExtensions
{

	public static GtkRecentData Dereference(this GtkRecentDataHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentData>(x.DangerousGetHandle());
}
internal class GtkRecentDataExterns
{
}

/// <summary>
/// <para>
/// Meta-data to be passed to gtk_recent_manager_add_full() when
/// registering a recently used resource.
/// </para>
/// </summary>

public struct GtkRecentData
{
	/// <summary>
/// <para>
/// a UTF-8 encoded string, containing the name of the recently
///   used resource to be displayed, or %NULL;
/// </para>
/// </summary>

public string display_name;
	/// <summary>
/// <para>
/// a UTF-8 encoded string, containing a short description of
///   the resource, or %NULL;
/// </para>
/// </summary>

public string description;
	/// <summary>
/// <para>
/// the MIME type of the resource;
/// </para>
/// </summary>

public string mime_type;
	/// <summary>
/// <para>
/// the name of the application that is registering this recently
///   used resource;
/// </para>
/// </summary>

public string app_name;
	/// <summary>
/// <para>
/// command line used to launch this resource; may contain the
///   “\%f” and “\%u” escape characters which will be expanded
///   to the resource file path and URI respectively when the command line
///   is retrieved;
/// </para>
/// </summary>

public string app_exec;
	/// <summary>
/// <para>
/// a vector of strings containing
///   groups names;
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public string[] groups;
	/// <summary>
/// <para>
/// whether this resource should be displayed only by the
///   applications that have registered it or not.
/// </para>
/// </summary>

public bool is_private;
}
