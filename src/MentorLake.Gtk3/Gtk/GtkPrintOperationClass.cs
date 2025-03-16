namespace MentorLake.Gtk;

public class GtkPrintOperationClassHandle : BaseSafeHandle
{
}


public static class GtkPrintOperationClassExtensions
{

	public static GtkPrintOperationClass Dereference(this GtkPrintOperationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPrintOperationClass>(x.DangerousGetHandle());
}
internal class GtkPrintOperationClassExterns
{
}

public struct GtkPrintOperationClass
{
	public GObjectClass parent_class;
	public IntPtr done;
	public IntPtr begin_print;
	public IntPtr paginate;
	public IntPtr request_page_setup;
	public IntPtr draw_page;
	public IntPtr end_print;
	public IntPtr status_changed;
	public IntPtr create_custom_widget;
	public IntPtr custom_widget_apply;
	public IntPtr preview;
	public IntPtr update_custom_widget;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}
