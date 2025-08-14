namespace MentorLake.Gtk;


public class GtkCheckButtonClassHandle : BaseSafeHandle
{
}


public static class GtkCheckButtonClassExtensions
{

	public static GtkCheckButtonClass Dereference(this GtkCheckButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCheckButtonClass>(x.DangerousGetHandle());
}
internal class GtkCheckButtonClassExterns
{
}


public struct GtkCheckButtonClass
{
	
public GtkToggleButtonClass parent_class;
	
public IntPtr draw_indicator;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
