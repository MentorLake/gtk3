namespace MentorLake.Gtk;

public interface GtkPrintOperationPreviewHandle
{
}

internal class GtkPrintOperationPreviewHandleImpl : BaseSafeHandle, GtkPrintOperationPreviewHandle
{
}

public static class GtkPrintOperationPreviewHandleExtensions
{
	public static T EndPreview<T>(this T preview) where T : GtkPrintOperationPreviewHandle
	{
		GtkPrintOperationPreviewHandleExterns.gtk_print_operation_preview_end_preview(preview);
		return preview;
	}

	public static bool IsSelected(this MentorLake.Gtk.GtkPrintOperationPreviewHandle preview, int page_nr)
	{
		return GtkPrintOperationPreviewHandleExterns.gtk_print_operation_preview_is_selected(preview, page_nr);
	}

	public static T RenderPage<T>(this T preview, int page_nr) where T : GtkPrintOperationPreviewHandle
	{
		GtkPrintOperationPreviewHandleExterns.gtk_print_operation_preview_render_page(preview, page_nr);
		return preview;
	}

}

internal class GtkPrintOperationPreviewHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_preview_end_preview([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationPreviewHandleImpl>))] MentorLake.Gtk.GtkPrintOperationPreviewHandle preview);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_preview_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationPreviewHandleImpl>))] MentorLake.Gtk.GtkPrintOperationPreviewHandle preview, int page_nr);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_preview_render_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationPreviewHandleImpl>))] MentorLake.Gtk.GtkPrintOperationPreviewHandle preview, int page_nr);

}
