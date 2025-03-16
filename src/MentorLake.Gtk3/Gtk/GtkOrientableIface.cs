namespace MentorLake.Gtk;

public class GtkOrientableIfaceHandle : BaseSafeHandle
{
}


public static class GtkOrientableIfaceExtensions
{

	public static GtkOrientableIface Dereference(this GtkOrientableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkOrientableIface>(x.DangerousGetHandle());
}
internal class GtkOrientableIfaceExterns
{
}

public struct GtkOrientableIface
{
	public GTypeInterface base_iface;
}
