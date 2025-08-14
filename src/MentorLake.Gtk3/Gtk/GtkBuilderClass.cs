namespace MentorLake.Gtk;


public class GtkBuilderClassHandle : BaseSafeHandle
{
}


public static class GtkBuilderClassExtensions
{

	public static GtkBuilderClass Dereference(this GtkBuilderClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBuilderClass>(x.DangerousGetHandle());
}
internal class GtkBuilderClassExterns
{
}


public struct GtkBuilderClass
{
	
public GObjectClass parent_class;
	
public IntPtr get_type_from_name;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
	
public IntPtr _gtk_reserved7;
	
public IntPtr _gtk_reserved8;
}
