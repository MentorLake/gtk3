namespace MentorLake.Gtk;

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

public struct GtkFileFilterInfo
{
	public GtkFileFilterFlags contains;
	public string filename;
	public string uri;
	public string display_name;
	public string mime_type;
}
