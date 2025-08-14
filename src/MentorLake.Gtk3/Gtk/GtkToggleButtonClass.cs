namespace MentorLake.Gtk;


public class GtkToggleButtonClassHandle : BaseSafeHandle
{
}


public static class GtkToggleButtonClassExtensions
{

	public static GtkToggleButtonClass Dereference(this GtkToggleButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleButtonClass>(x.DangerousGetHandle());
}
internal class GtkToggleButtonClassExterns
{
}


public struct GtkToggleButtonClass
{
	
public GtkButtonClass parent_class;
	
public IntPtr toggled;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
