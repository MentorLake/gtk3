namespace MentorLake.Gtk3.Gtk3;

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
		GtkPrintOperationPreviewExterns.gtk_print_operation_preview_end_preview(preview);
		return preview;
	}

	public static bool IsSelected(this GtkPrintOperationPreviewHandle preview, int page_nr)
	{
		return GtkPrintOperationPreviewExterns.gtk_print_operation_preview_is_selected(preview, page_nr);
	}

	public static T RenderPage<T>(this T preview, int page_nr) where T : GtkPrintOperationPreviewHandle
	{
		GtkPrintOperationPreviewExterns.gtk_print_operation_preview_render_page(preview, page_nr);
		return preview;
	}

}

internal class GtkPrintOperationPreviewExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_preview_end_preview(GtkPrintOperationPreviewHandle preview);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_operation_preview_is_selected(GtkPrintOperationPreviewHandle preview, int page_nr);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_preview_render_page(GtkPrintOperationPreviewHandle preview, int page_nr);

}
