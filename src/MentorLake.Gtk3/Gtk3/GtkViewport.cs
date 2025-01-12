namespace MentorLake.Gtk3.Gtk3;

public class GtkViewportHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkScrollableHandle
{
	public static GtkViewportHandle New(GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment)
	{
		return GtkViewportExterns.gtk_viewport_new(hadjustment, vadjustment);
	}

}

public static class GtkViewportHandleExtensions
{
	public static GdkWindowHandle GetBinWindow(this GtkViewportHandle viewport)
	{
		return GtkViewportExterns.gtk_viewport_get_bin_window(viewport);
	}

	public static GtkAdjustmentHandle GetHadjustment(this GtkViewportHandle viewport)
	{
		return GtkViewportExterns.gtk_viewport_get_hadjustment(viewport);
	}

	public static GtkShadowType GetShadowType(this GtkViewportHandle viewport)
	{
		return GtkViewportExterns.gtk_viewport_get_shadow_type(viewport);
	}

	public static GtkAdjustmentHandle GetVadjustment(this GtkViewportHandle viewport)
	{
		return GtkViewportExterns.gtk_viewport_get_vadjustment(viewport);
	}

	public static GdkWindowHandle GetViewWindow(this GtkViewportHandle viewport)
	{
		return GtkViewportExterns.gtk_viewport_get_view_window(viewport);
	}

	public static T SetHadjustment<T>(this T viewport, GtkAdjustmentHandle adjustment) where T : GtkViewportHandle
	{
		GtkViewportExterns.gtk_viewport_set_hadjustment(viewport, adjustment);
		return viewport;
	}

	public static T SetShadowType<T>(this T viewport, GtkShadowType type) where T : GtkViewportHandle
	{
		GtkViewportExterns.gtk_viewport_set_shadow_type(viewport, type);
		return viewport;
	}

	public static T SetVadjustment<T>(this T viewport, GtkAdjustmentHandle adjustment) where T : GtkViewportHandle
	{
		GtkViewportExterns.gtk_viewport_set_vadjustment(viewport, adjustment);
		return viewport;
	}

}

internal class GtkViewportExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkViewportHandle gtk_viewport_new(GtkAdjustmentHandle hadjustment, GtkAdjustmentHandle vadjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_viewport_get_bin_window(GtkViewportHandle viewport);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_viewport_get_hadjustment(GtkViewportHandle viewport);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkShadowType gtk_viewport_get_shadow_type(GtkViewportHandle viewport);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAdjustmentHandle gtk_viewport_get_vadjustment(GtkViewportHandle viewport);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_viewport_get_view_window(GtkViewportHandle viewport);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_viewport_set_hadjustment(GtkViewportHandle viewport, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_viewport_set_shadow_type(GtkViewportHandle viewport, GtkShadowType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_viewport_set_vadjustment(GtkViewportHandle viewport, GtkAdjustmentHandle adjustment);

}
