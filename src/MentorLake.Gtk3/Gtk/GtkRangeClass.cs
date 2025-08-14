namespace MentorLake.Gtk;


public class GtkRangeClassHandle : BaseSafeHandle
{
}


public static class GtkRangeClassExtensions
{

	public static GtkRangeClass Dereference(this GtkRangeClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRangeClass>(x.DangerousGetHandle());
}
internal class GtkRangeClassExterns
{
}


public struct GtkRangeClass
{
	
public GtkWidgetClass parent_class;
	
public string slider_detail;
	
public string stepper_detail;
	
public IntPtr value_changed;
	
public IntPtr adjust_bounds;
	
public IntPtr move_slider;
	
public IntPtr get_range_border;
	
public IntPtr change_value;
	
public IntPtr get_range_size_request;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
}
