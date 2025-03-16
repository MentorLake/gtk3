namespace MentorLake.Gtk;

public class GtkActionEntryHandle : BaseSafeHandle
{
}


public static class GtkActionEntryExtensions
{

	public static GtkActionEntry Dereference(this GtkActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionEntry>(x.DangerousGetHandle());
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
	public GCallback callback;
}
