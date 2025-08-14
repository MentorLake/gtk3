namespace MentorLake.Gtk;


public class GtkLabelClassHandle : BaseSafeHandle
{
}


public static class GtkLabelClassExtensions
{

	public static GtkLabelClass Dereference(this GtkLabelClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLabelClass>(x.DangerousGetHandle());
}
internal class GtkLabelClassExterns
{
}


public struct GtkLabelClass
{
	
public GtkMiscClass parent_class;
	
public IntPtr move_cursor;
	
public IntPtr copy_clipboard;
	
public IntPtr populate_popup;
	
public IntPtr activate_link;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
	
public IntPtr _gtk_reserved8;
}
