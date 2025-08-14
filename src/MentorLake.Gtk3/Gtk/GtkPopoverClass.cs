namespace MentorLake.Gtk;


public class GtkPopoverClassHandle : BaseSafeHandle
{
}


public static class GtkPopoverClassExtensions
{

	public static GtkPopoverClass Dereference(this GtkPopoverClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPopoverClass>(x.DangerousGetHandle());
}
internal class GtkPopoverClassExterns
{
}


public struct GtkPopoverClass
{
	
public GtkBinClass parent_class;
	
public IntPtr closed;
}
