namespace MentorLake.Gtk3.Gtk3;

public class GtkRecentDataHandle : BaseSafeHandle
{
}


public static class GtkRecentDataHandleExtensions
{
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
