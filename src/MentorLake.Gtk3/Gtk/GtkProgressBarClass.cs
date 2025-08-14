namespace MentorLake.Gtk;


public class GtkProgressBarClassHandle : BaseSafeHandle
{
}


public static class GtkProgressBarClassExtensions
{

	public static GtkProgressBarClass Dereference(this GtkProgressBarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkProgressBarClass>(x.DangerousGetHandle());
}
internal class GtkProgressBarClassExterns
{
}


public struct GtkProgressBarClass
{
	
public GtkWidgetClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
