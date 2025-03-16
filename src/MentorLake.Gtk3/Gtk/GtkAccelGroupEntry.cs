namespace MentorLake.Gtk;

public class GtkAccelGroupEntryHandle : BaseSafeHandle
{
}


public static class GtkAccelGroupEntryExtensions
{

	public static GtkAccelGroupEntry Dereference(this GtkAccelGroupEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccelGroupEntry>(x.DangerousGetHandle());
}
internal class GtkAccelGroupEntryExterns
{
}

public struct GtkAccelGroupEntry
{
	public GtkAccelKey key;
	public IntPtr closure;
	public GQuark accel_path_quark;
}
