namespace MentorLake.Gtk;

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

public struct GtkRecentData
{
	public string display_name;
	public string description;
	public string mime_type;
	public string app_name;
	public string app_exec;
	public string[] groups;
	public bool is_private;
}
