namespace MentorLake.Gtk3.Gtk3;

public class GtkLayoutHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
	public static GtkLayoutHandle New(GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment)
	{
		return GtkLayoutExterns.gtk_layout_new(hadjustment, vadjustment);
	}

}

public static class GtkLayoutHandleExtensions
{
	public static GdkWindowHandle GetBinWindow(this GtkLayoutHandle layout)
	{
		return GtkLayoutExterns.gtk_layout_get_bin_window(layout);
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkLayoutHandle layout)
	{
		return GtkLayoutExterns.gtk_layout_get_hadjustment(layout);
	}

	public static GtkLayoutHandle GetSize(this GtkLayoutHandle layout, out uint width, out uint height)
	{
		GtkLayoutExterns.gtk_layout_get_size(layout, out width, out height);
		return layout;
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkLayoutHandle layout)
	{
		return GtkLayoutExterns.gtk_layout_get_vadjustment(layout);
	}

	public static GtkLayoutHandle Move(this GtkLayoutHandle layout, GtkWidgetHandle child_widget, int x, int y)
	{
		GtkLayoutExterns.gtk_layout_move(layout, child_widget, x, y);
		return layout;
	}

	public static GtkLayoutHandle Put(this GtkLayoutHandle layout, GtkWidgetHandle child_widget, int x, int y)
	{
		GtkLayoutExterns.gtk_layout_put(layout, child_widget, x, y);
		return layout;
	}

	public static GtkLayoutHandle SetHadjustment(this GtkLayoutHandle layout, GtkAdjustmentHandle adjustment)
	{
		GtkLayoutExterns.gtk_layout_set_hadjustment(layout, adjustment);
		return layout;
	}

	public static GtkLayoutHandle SetSize(this GtkLayoutHandle layout, uint width, uint height)
	{
		GtkLayoutExterns.gtk_layout_set_size(layout, width, height);
		return layout;
	}

	public static GtkLayoutHandle SetVadjustment(this GtkLayoutHandle layout, GtkAdjustmentHandle adjustment)
	{
		GtkLayoutExterns.gtk_layout_set_vadjustment(layout, adjustment);
		return layout;
	}

}

internal class GtkLayoutExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkLayoutHandle gtk_layout_new(GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_layout_get_bin_window(GtkLayoutHandle layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_layout_get_hadjustment(GtkLayoutHandle layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_layout_get_size(GtkLayoutHandle layout, out uint width, out uint height);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_layout_get_vadjustment(GtkLayoutHandle layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_layout_move(GtkLayoutHandle layout, GtkWidgetHandle child_widget, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_layout_put(GtkLayoutHandle layout, GtkWidgetHandle child_widget, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_layout_set_hadjustment(GtkLayoutHandle layout, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_layout_set_size(GtkLayoutHandle layout, uint width, uint height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_layout_set_vadjustment(GtkLayoutHandle layout, GtkAdjustmentHandle adjustment);

}
