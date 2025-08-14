namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkFileFilterInfo-struct is used to pass information about the
/// tested file to gtk_file_filter_filter().
/// </para>
/// </summary>

public class GtkFileFilterInfoHandle : BaseSafeHandle
{
}


public static class GtkFileFilterInfoExtensions
{

	public static GtkFileFilterInfo Dereference(this GtkFileFilterInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileFilterInfo>(x.DangerousGetHandle());
}
internal class GtkFileFilterInfoExterns
{
}

/// <summary>
/// <para>
/// A #GtkFileFilterInfo-struct is used to pass information about the
/// tested file to gtk_file_filter_filter().
/// </para>
/// </summary>

public struct GtkFileFilterInfo
{
	/// <summary>
/// <para>
/// Flags indicating which of the following fields need
///   are filled
/// </para>
/// </summary>

public GtkFileFilterFlags contains;
	/// <summary>
/// <para>
/// the filename of the file being tested
/// </para>
/// </summary>

public string filename;
	/// <summary>
/// <para>
/// the URI for the file being tested
/// </para>
/// </summary>

public string uri;
	/// <summary>
/// <para>
/// the string that will be used to display the file
///   in the file chooser
/// </para>
/// </summary>

public string display_name;
	/// <summary>
/// <para>
/// the mime type of the file
/// </para>
/// </summary>

public string mime_type;
}
