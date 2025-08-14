namespace MentorLake.Gtk;


public class GtkNativeDialogClassHandle : BaseSafeHandle
{
}


public static class GtkNativeDialogClassExtensions
{

	public static GtkNativeDialogClass Dereference(this GtkNativeDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkNativeDialogClass>(x.DangerousGetHandle());
}
internal class GtkNativeDialogClassExterns
{
}


public struct GtkNativeDialogClass
{
	
public GObjectClass parent_class;
	
public IntPtr response;
	
public IntPtr show;
	
public IntPtr hide;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
