namespace MentorLake.Gtk;


public class GtkAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkAccessibleClassExtensions
{

	public static GtkAccessibleClass Dereference(this GtkAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkAccessibleClassExterns
{
}


public struct GtkAccessibleClass
{
	
public AtkObjectClass parent_class;
	
public IntPtr connect_widget_destroyed;
	
public IntPtr widget_set;
	
public IntPtr widget_unset;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
