namespace MentorLake.Gtk3.Gtk3;

public class GtkFixedHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkFixedHandle New()
	{
		return GtkFixedExterns.gtk_fixed_new();
	}

}

public static class GtkFixedHandleExtensions
{
	public static T Move<T>(this T @fixed, GtkWidgetHandle widget, int x, int y) where T : GtkFixedHandle
	{
		GtkFixedExterns.gtk_fixed_move(@fixed, widget, x, y);
		return @fixed;
	}

	public static T Put<T>(this T @fixed, GtkWidgetHandle widget, int x, int y) where T : GtkFixedHandle
	{
		GtkFixedExterns.gtk_fixed_put(@fixed, widget, x, y);
		return @fixed;
	}

}

internal class GtkFixedExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFixedHandle gtk_fixed_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_fixed_move(GtkFixedHandle @fixed, GtkWidgetHandle widget, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_fixed_put(GtkFixedHandle @fixed, GtkWidgetHandle widget, int x, int y);

}
