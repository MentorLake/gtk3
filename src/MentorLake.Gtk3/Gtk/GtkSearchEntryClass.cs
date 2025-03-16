namespace MentorLake.Gtk;

public class GtkSearchEntryClassHandle : BaseSafeHandle
{
}


public static class GtkSearchEntryClassExtensions
{

	public static GtkSearchEntryClass Dereference(this GtkSearchEntryClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSearchEntryClass>(x.DangerousGetHandle());
}
internal class GtkSearchEntryClassExterns
{
}

public struct GtkSearchEntryClass
{
	public GtkEntryClass parent_class;
	public IntPtr search_changed;
	public IntPtr next_match;
	public IntPtr previous_match;
	public IntPtr stop_search;
}
