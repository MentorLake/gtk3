namespace MentorLake.Gtk;


public class GtkMenuButtonClassHandle : BaseSafeHandle
{
}


public static class GtkMenuButtonClassExtensions
{

	public static GtkMenuButtonClass Dereference(this GtkMenuButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMenuButtonClass>(x.DangerousGetHandle());
}
internal class GtkMenuButtonClassExterns
{
}


public struct GtkMenuButtonClass
{
	
public GtkToggleButtonClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
