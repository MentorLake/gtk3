namespace MentorLake.Gtk;

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

public struct GtkRecentFilterInfo
{
	public GtkRecentFilterFlags contains;
	public string uri;
	public string display_name;
	public string mime_type;
	[MarshalAs(UnmanagedType.ByValArray)] public string[] applications;
	[MarshalAs(UnmanagedType.ByValArray)] public string[] groups;
	public int age;
}
