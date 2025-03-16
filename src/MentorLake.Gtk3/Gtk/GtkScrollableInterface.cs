namespace MentorLake.Gtk;

public class GtkScrollableInterfaceHandle : BaseSafeHandle
{
}


public static class GtkScrollableInterfaceExtensions
{

	public static GtkScrollableInterface Dereference(this GtkScrollableInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScrollableInterface>(x.DangerousGetHandle());
}
internal class GtkScrollableInterfaceExterns
{
}

public struct GtkScrollableInterface
{
	public GTypeInterface base_iface;
	public IntPtr get_border;
}
