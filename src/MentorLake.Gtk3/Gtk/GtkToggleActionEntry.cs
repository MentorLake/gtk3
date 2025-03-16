namespace MentorLake.Gtk;

public class GtkToggleActionEntryHandle : BaseSafeHandle
{
}


public static class GtkToggleActionEntryExtensions
{

	public static GtkToggleActionEntry Dereference(this GtkToggleActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleActionEntry>(x.DangerousGetHandle());
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
	public GCallback callback;
	public bool is_active;
}
