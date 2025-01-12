namespace MentorLake.Gtk3.Gtk3;

public class GtkFileFilterInfoHandle : BaseSafeHandle
{
}


public static class GtkFileFilterInfoHandleExtensions
{
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
