namespace MentorLake.Gtk;

public class GtkCellRendererClassHandle : BaseSafeHandle
{
}


public static class GtkCellRendererClassExtensions
{
	public static void SetAccessibleType(this MentorLake.Gtk.GtkCellRendererClassHandle renderer_class, MentorLake.GObject.GType type)
	{
		if (renderer_class.IsInvalid) throw new Exception("Invalid handle (GtkCellRendererClass)");
		GtkCellRendererClassExterns.gtk_cell_renderer_class_set_accessible_type(renderer_class, type);
	}


	public static GtkCellRendererClass Dereference(this GtkCellRendererClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellRendererClass>(x.DangerousGetHandle());
}
internal class GtkCellRendererClassExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_renderer_class_set_accessible_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellRendererClassHandle>))] MentorLake.Gtk.GtkCellRendererClassHandle renderer_class, MentorLake.GObject.GType type);

}

public struct GtkCellRendererClass
{
	public IntPtr get_request_mode;
	public IntPtr get_preferred_width;
	public IntPtr get_preferred_height_for_width;
	public IntPtr get_preferred_height;
	public IntPtr get_preferred_width_for_height;
	public IntPtr get_aligned_area;
	public IntPtr get_size;
	public IntPtr render;
	public IntPtr activate;
	public IntPtr start_editing;
	public IntPtr editing_canceled;
	public IntPtr editing_started;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
