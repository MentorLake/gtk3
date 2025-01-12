namespace MentorLake.Gtk3.Gtk3;

public class GtkCellViewHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellLayoutHandle, GtkOrientableHandle
{
	public static GtkCellViewHandle New()
	{
		return GtkCellViewExterns.gtk_cell_view_new();
	}

	public static GtkCellViewHandle NewWithContext(GtkCellAreaHandle area, GtkCellAreaContextHandle context)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_context(area, context);
	}

	public static GtkCellViewHandle NewWithMarkup(string markup)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_markup(markup);
	}

	public static GtkCellViewHandle NewWithPixbuf(GdkPixbufHandle pixbuf)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_pixbuf(pixbuf);
	}

	public static GtkCellViewHandle NewWithText(string text)
	{
		return GtkCellViewExterns.gtk_cell_view_new_with_text(text);
	}

}

public static class GtkCellViewHandleExtensions
{
	public static GtkTreePathHandle GetDisplayedRow(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_displayed_row(cell_view);
	}

	public static bool GetDrawSensitive(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_draw_sensitive(cell_view);
	}

	public static bool GetFitModel(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_fit_model(cell_view);
	}

	public static GtkTreeModelHandle GetModel(this GtkCellViewHandle cell_view)
	{
		return GtkCellViewExterns.gtk_cell_view_get_model(cell_view);
	}

	public static bool GetSizeOfRow(this GtkCellViewHandle cell_view, GtkTreePathHandle path, out GtkRequisition requisition)
	{
		return GtkCellViewExterns.gtk_cell_view_get_size_of_row(cell_view, path, out requisition);
	}

	public static GtkCellViewHandle SetBackgroundColor(this GtkCellViewHandle cell_view, GdkColorHandle color)
	{
		GtkCellViewExterns.gtk_cell_view_set_background_color(cell_view, color);
		return cell_view;
	}

	public static GtkCellViewHandle SetBackgroundRgba(this GtkCellViewHandle cell_view, GdkRGBAHandle rgba)
	{
		GtkCellViewExterns.gtk_cell_view_set_background_rgba(cell_view, rgba);
		return cell_view;
	}

	public static GtkCellViewHandle SetDisplayedRow(this GtkCellViewHandle cell_view, GtkTreePathHandle path)
	{
		GtkCellViewExterns.gtk_cell_view_set_displayed_row(cell_view, path);
		return cell_view;
	}

	public static GtkCellViewHandle SetDrawSensitive(this GtkCellViewHandle cell_view, bool draw_sensitive)
	{
		GtkCellViewExterns.gtk_cell_view_set_draw_sensitive(cell_view, draw_sensitive);
		return cell_view;
	}

	public static GtkCellViewHandle SetFitModel(this GtkCellViewHandle cell_view, bool fit_model)
	{
		GtkCellViewExterns.gtk_cell_view_set_fit_model(cell_view, fit_model);
		return cell_view;
	}

	public static GtkCellViewHandle SetModel(this GtkCellViewHandle cell_view, GtkTreeModelHandle model)
	{
		GtkCellViewExterns.gtk_cell_view_set_model(cell_view, model);
		return cell_view;
	}

}

internal class GtkCellViewExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellViewHandle gtk_cell_view_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellViewHandle gtk_cell_view_new_with_context(GtkCellAreaHandle area, GtkCellAreaContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellViewHandle gtk_cell_view_new_with_markup(string markup);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellViewHandle gtk_cell_view_new_with_pixbuf(GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCellViewHandle gtk_cell_view_new_with_text(string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreePathHandle gtk_cell_view_get_displayed_row(GtkCellViewHandle cell_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_view_get_draw_sensitive(GtkCellViewHandle cell_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_view_get_fit_model(GtkCellViewHandle cell_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelHandle gtk_cell_view_get_model(GtkCellViewHandle cell_view);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_cell_view_get_size_of_row(GtkCellViewHandle cell_view, GtkTreePathHandle path, out GtkRequisition requisition);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_view_set_background_color(GtkCellViewHandle cell_view, GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_view_set_background_rgba(GtkCellViewHandle cell_view, GdkRGBAHandle rgba);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_view_set_displayed_row(GtkCellViewHandle cell_view, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_view_set_draw_sensitive(GtkCellViewHandle cell_view, bool draw_sensitive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_view_set_fit_model(GtkCellViewHandle cell_view, bool fit_model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_cell_view_set_model(GtkCellViewHandle cell_view, GtkTreeModelHandle model);

}
