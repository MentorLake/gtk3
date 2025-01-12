namespace MentorLake.Gtk3.Gtk3;

public class GtkRecentFilterInfoHandle : BaseSafeHandle
{
}


public static class GtkRecentFilterInfoHandleExtensions
{
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
	public string[] applications;
	public string[] groups;
	public int age;
}
