namespace MentorLake.Gtk;

public class GtkCellViewHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkCellViewHandle New()
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new();
	}

	public static MentorLake.Gtk.GtkCellViewHandle NewWithContext(MentorLake.Gtk.GtkCellAreaHandle area, MentorLake.Gtk.GtkCellAreaContextHandle context)
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new_with_context(area, context);
	}

	public static MentorLake.Gtk.GtkCellViewHandle NewWithMarkup(string markup)
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new_with_markup(markup);
	}

	public static MentorLake.Gtk.GtkCellViewHandle NewWithPixbuf(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new_with_pixbuf(pixbuf);
	}

	public static MentorLake.Gtk.GtkCellViewHandle NewWithText(string text)
	{
		return GtkCellViewHandleExterns.gtk_cell_view_new_with_text(text);
	}

}

public static class GtkCellViewHandleExtensions
{
	public static MentorLake.Gtk.GtkTreePathHandle GetDisplayedRow(this MentorLake.Gtk.GtkCellViewHandle cell_view)
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_displayed_row(cell_view);
	}

	public static bool GetDrawSensitive(this MentorLake.Gtk.GtkCellViewHandle cell_view)
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_draw_sensitive(cell_view);
	}

	public static bool GetFitModel(this MentorLake.Gtk.GtkCellViewHandle cell_view)
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_fit_model(cell_view);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkCellViewHandle cell_view)
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_model(cell_view);
	}

	public static bool GetSizeOfRow(this MentorLake.Gtk.GtkCellViewHandle cell_view, MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkRequisition requisition)
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		return GtkCellViewHandleExterns.gtk_cell_view_get_size_of_row(cell_view, path, out requisition);
	}

	public static T SetBackgroundColor<T>(this T cell_view, MentorLake.Gdk.GdkColorHandle color) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_background_color(cell_view, color);
		return cell_view;
	}

	public static T SetBackgroundRgba<T>(this T cell_view, MentorLake.Gdk.GdkRGBAHandle rgba) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_background_rgba(cell_view, rgba);
		return cell_view;
	}

	public static T SetDisplayedRow<T>(this T cell_view, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_displayed_row(cell_view, path);
		return cell_view;
	}

	public static T SetDrawSensitive<T>(this T cell_view, bool draw_sensitive) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_draw_sensitive(cell_view, draw_sensitive);
		return cell_view;
	}

	public static T SetFitModel<T>(this T cell_view, bool fit_model) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_fit_model(cell_view, fit_model);
		return cell_view;
	}

	public static T SetModel<T>(this T cell_view, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkCellViewHandle
	{
		if (cell_view.IsInvalid || cell_view.IsClosed) throw new Exception("Invalid or closed handle (GtkCellViewHandle)");
		GtkCellViewHandleExterns.gtk_cell_view_set_model(cell_view, model);
		return cell_view;
	}

}

internal class GtkCellViewHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new_with_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaContextHandle>))] MentorLake.Gtk.GtkCellAreaContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new_with_markup(string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new_with_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCellViewHandle gtk_cell_view_new_with_text(string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_cell_view_get_displayed_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_view_get_draw_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_view_get_fit_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_cell_view_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_cell_view_get_size_of_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, out MentorLake.Gtk.GtkRequisition requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_background_rgba([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_displayed_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_draw_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, bool draw_sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_fit_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, bool fit_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_cell_view_set_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellViewHandle>))] MentorLake.Gtk.GtkCellViewHandle cell_view, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

}
