namespace MentorLake.Gtk3.Gtk3;

public interface GtkOrientableHandle
{
}

internal class GtkOrientableHandleImpl : BaseSafeHandle, GtkOrientableHandle
{
}

public static class GtkOrientableHandleExtensions
{
	public static GtkOrientation GetOrientation(this GtkOrientableHandle orientable)
	{
		return GtkOrientableExterns.gtk_orientable_get_orientation(orientable);
	}

	public static T SetOrientation<T>(this T orientable, GtkOrientation orientation) where T : GtkOrientableHandle
	{
		GtkOrientableExterns.gtk_orientable_set_orientation(orientable, orientation);
		return orientable;
	}

}

internal class GtkOrientableExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkOrientation gtk_orientable_get_orientation(GtkOrientableHandle orientable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_orientable_set_orientation(GtkOrientableHandle orientable, GtkOrientation orientation);

}
