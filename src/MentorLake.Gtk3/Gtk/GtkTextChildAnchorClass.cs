namespace MentorLake.Gtk;


public class GtkTextChildAnchorClassHandle : BaseSafeHandle
{
}


public static class GtkTextChildAnchorClassExtensions
{

	public static GtkTextChildAnchorClass Dereference(this GtkTextChildAnchorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextChildAnchorClass>(x.DangerousGetHandle());
}
internal class GtkTextChildAnchorClassExterns
{
}


public struct GtkTextChildAnchorClass
{
	
public GObjectClass parent_class;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
