namespace MentorLake.Gtk3.Gtk3;

public class GtkActionEntryHandle : BaseSafeHandle
{
}


public static class GtkActionEntryHandleExtensions
{
}
internal class GtkActionEntryExterns
{
}

public struct GtkActionEntry
{
	public string name;
	public string stock_id;
	public string label;
	public string accelerator;
	public string tooltip;
	public IntPtr callback;
}
