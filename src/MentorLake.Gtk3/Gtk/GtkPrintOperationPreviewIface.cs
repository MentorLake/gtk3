namespace MentorLake.Gtk;

public class GtkPrintOperationPreviewIfaceHandle : BaseSafeHandle
{
}


public static class GtkPrintOperationPreviewIfaceExtensions
{

	public static GtkPrintOperationPreviewIface Dereference(this GtkPrintOperationPreviewIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPrintOperationPreviewIface>(x.DangerousGetHandle());
}
internal class GtkPrintOperationPreviewIfaceExterns
{
}

public struct GtkPrintOperationPreviewIface
{
	public GTypeInterface g_iface;
	public IntPtr ready;
	public IntPtr got_page_size;
	public IntPtr render_page;
	public IntPtr is_selected;
	public IntPtr end_preview;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}
