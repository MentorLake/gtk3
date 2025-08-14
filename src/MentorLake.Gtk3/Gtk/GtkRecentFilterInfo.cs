namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkRecentFilterInfo struct is used
/// to pass information about the tested file to gtk_recent_filter_filter().
/// </para>
/// </summary>

public class GtkRecentFilterInfoHandle : BaseSafeHandle
{
}


public static class GtkRecentFilterInfoExtensions
{

	public static GtkRecentFilterInfo Dereference(this GtkRecentFilterInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentFilterInfo>(x.DangerousGetHandle());
}
internal class GtkRecentFilterInfoExterns
{
}

/// <summary>
/// <para>
/// A GtkRecentFilterInfo struct is used
/// to pass information about the tested file to gtk_recent_filter_filter().
/// </para>
/// </summary>

public struct GtkRecentFilterInfo
{
	/// <summary>
/// <para>
/// #GtkRecentFilterFlags to indicate which fields are set.
/// </para>
/// </summary>

public GtkRecentFilterFlags contains;
	/// <summary>
/// <para>
/// The URI of the file being tested.
/// </para>
/// </summary>

public string uri;
	/// <summary>
/// <para>
/// The string that will be used to display
///    the file in the recent chooser.
/// </para>
/// </summary>

public string display_name;
	/// <summary>
/// <para>
/// MIME type of the file.
/// </para>
/// </summary>

public string mime_type;
	/// <summary>
/// <para>
/// The list of
///    applications that have registered the file.
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public string[] applications;
	/// <summary>
/// <para>
/// The groups to which
///    the file belongs to.
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public string[] groups;
	/// <summary>
/// <para>
/// The number of days elapsed since the file has been
///    registered.
/// </para>
/// </summary>

public int age;
}
