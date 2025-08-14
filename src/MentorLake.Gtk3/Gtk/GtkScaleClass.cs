namespace MentorLake.Gtk;


public class GtkScaleClassHandle : BaseSafeHandle
{
}


public static class GtkScaleClassExtensions
{

	public static GtkScaleClass Dereference(this GtkScaleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkScaleClass>(x.DangerousGetHandle());
}
internal class GtkScaleClassExterns
{
}


public struct GtkScaleClass
{
	
public GtkRangeClass parent_class;
	
public IntPtr format_value;
	
public IntPtr draw_value;
	
public IntPtr get_layout_offsets;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
