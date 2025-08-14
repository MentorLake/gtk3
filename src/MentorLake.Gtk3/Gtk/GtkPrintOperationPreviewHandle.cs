namespace MentorLake.Gtk;


public interface GtkPrintOperationPreviewHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkPrintOperationPreviewHandleImpl : BaseSafeHandle, GtkPrintOperationPreviewHandle
{
}

public static class GtkPrintOperationPreviewHandleExtensions
{
/// <summary>
/// <para>
/// Ends a preview.
/// </para>
/// <para>
/// This function must be called to finish a custom print preview.
/// </para>
/// </summary>

/// <param name="preview">
/// a #GtkPrintOperationPreview
/// </param>

	public static T EndPreview<T>(this T preview) where T : GtkPrintOperationPreviewHandle
	{
		if (preview.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationPreviewHandle)");
		GtkPrintOperationPreviewHandleExterns.gtk_print_operation_preview_end_preview(preview);
		return preview;
	}

/// <summary>
/// <para>
/// Returns whether the given page is included in the set of pages that
/// have been selected for printing.
/// </para>
/// </summary>

/// <param name="preview">
/// a #GtkPrintOperationPreview
/// </param>
/// <param name="page_nr">
/// a page number
/// </param>
/// <return>
/// %TRUE if the page has been selected for printing
/// </return>

	public static bool IsSelected(this MentorLake.Gtk.GtkPrintOperationPreviewHandle preview, int page_nr)
	{
		if (preview.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationPreviewHandle)");
		return GtkPrintOperationPreviewHandleExterns.gtk_print_operation_preview_is_selected(preview, page_nr);
	}

/// <summary>
/// <para>
/// Renders a page to the preview, using the print context that
/// was passed to the #GtkPrintOperation::preview handler together
/// with @preview.
/// </para>
/// <para>
/// A custom iprint preview should use this function in its ::expose
/// handler to render the currently selected page.
/// </para>
/// <para>
/// Note that this function requires a suitable cairo context to
/// be associated with the print context.
/// </para>
/// </summary>

/// <param name="preview">
/// a #GtkPrintOperationPreview
/// </param>
/// <param name="page_nr">
/// the page to render
/// </param>

	public static T RenderPage<T>(this T preview, int page_nr) where T : GtkPrintOperationPreviewHandle
	{
		if (preview.IsInvalid) throw new Exception("Invalid handle (GtkPrintOperationPreviewHandle)");
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
