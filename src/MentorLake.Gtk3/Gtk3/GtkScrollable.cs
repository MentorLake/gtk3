namespace MentorLake.Gtk3.Gtk3;

public interface GtkScrollableHandle
{
}

internal class GtkScrollableHandleImpl : BaseSafeHandle, GtkScrollableHandle
{
}

public static class GtkScrollableHandleExtensions
{
	public static bool GetBorder(this GtkScrollableHandle scrollable, out GtkBorder border)
	{
		return GtkScrollableExterns.gtk_scrollable_get_border(scrollable, out border);
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkScrollableHandle scrollable)
	{
		return GtkScrollableExterns.gtk_scrollable_get_hadjustment(scrollable);
	}

	public static GtkScrollablePolicy GetHscrollPolicy(this GtkScrollableHandle scrollable)
	{
		return GtkScrollableExterns.gtk_scrollable_get_hscroll_policy(scrollable);
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkScrollableHandle scrollable)
	{
		return GtkScrollableExterns.gtk_scrollable_get_vadjustment(scrollable);
	}

	public static GtkScrollablePolicy GetVscrollPolicy(this GtkScrollableHandle scrollable)
	{
		return GtkScrollableExterns.gtk_scrollable_get_vscroll_policy(scrollable);
	}

	public static T SetHadjustment<T>(this T scrollable, GtkAdjustmentHandle hadjustment) where T : GtkScrollableHandle
	{
		GtkScrollableExterns.gtk_scrollable_set_hadjustment(scrollable, hadjustment);
		return scrollable;
	}

	public static T SetHscrollPolicy<T>(this T scrollable, GtkScrollablePolicy policy) where T : GtkScrollableHandle
	{
		GtkScrollableExterns.gtk_scrollable_set_hscroll_policy(scrollable, policy);
		return scrollable;
	}

	public static T SetVadjustment<T>(this T scrollable, GtkAdjustmentHandle vadjustment) where T : GtkScrollableHandle
	{
		GtkScrollableExterns.gtk_scrollable_set_vadjustment(scrollable, vadjustment);
		return scrollable;
	}

	public static T SetVscrollPolicy<T>(this T scrollable, GtkScrollablePolicy policy) where T : GtkScrollableHandle
	{
		GtkScrollableExterns.gtk_scrollable_set_vscroll_policy(scrollable, policy);
		return scrollable;
	}

}

internal class GtkScrollableExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_scrollable_get_border(GtkScrollableHandle scrollable, out GtkBorder border);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_scrollable_get_hadjustment(GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkScrollablePolicy gtk_scrollable_get_hscroll_policy(GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_scrollable_get_vadjustment(GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkScrollablePolicy gtk_scrollable_get_vscroll_policy(GtkScrollableHandle scrollable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrollable_set_hadjustment(GtkScrollableHandle scrollable, GtkAdjustmentHandle hadjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrollable_set_hscroll_policy(GtkScrollableHandle scrollable, GtkScrollablePolicy policy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrollable_set_vadjustment(GtkScrollableHandle scrollable, GtkAdjustmentHandle vadjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_scrollable_set_vscroll_policy(GtkScrollableHandle scrollable, GtkScrollablePolicy policy);

}
