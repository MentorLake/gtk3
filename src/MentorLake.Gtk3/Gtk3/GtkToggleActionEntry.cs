namespace MentorLake.Gtk3.Gtk3;

public class GtkToggleActionEntryHandle : BaseSafeHandle
{
}


public static class GtkToggleActionEntryHandleExtensions
{
}
internal class GtkToggleActionEntryExterns
{
}

public struct GtkToggleActionEntry
{
	public string name;
	public string stock_id;
	public string label;
	public string accelerator;
	public string tooltip;
	public IntPtr callback;
	public bool is_active;
}
