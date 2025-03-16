namespace MentorLake.Gtk;

public class GtkCalendarClassHandle : BaseSafeHandle
{
}


public static class GtkCalendarClassExtensions
{

	public static GtkCalendarClass Dereference(this GtkCalendarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCalendarClass>(x.DangerousGetHandle());
}
internal class GtkCalendarClassExterns
{
}

public struct GtkCalendarClass
{
	public GtkWidgetClass parent_class;
	public IntPtr month_changed;
	public IntPtr day_selected;
	public IntPtr day_selected_double_click;
	public IntPtr prev_month;
	public IntPtr next_month;
	public IntPtr prev_year;
	public IntPtr next_year;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
