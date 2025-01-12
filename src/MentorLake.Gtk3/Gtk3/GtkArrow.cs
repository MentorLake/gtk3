namespace MentorLake.Gtk3.Gtk3;

public class GtkArrowHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkArrowHandle New(GtkArrowType arrow_type, GtkShadowType shadow_type)
	{
		return GtkArrowExterns.gtk_arrow_new(arrow_type, shadow_type);
	}

}

public static class GtkArrowHandleExtensions
{
	public static T Set<T>(this T arrow, GtkArrowType arrow_type, GtkShadowType shadow_type) where T : GtkArrowHandle
	{
		GtkArrowExterns.gtk_arrow_set(arrow, arrow_type, shadow_type);
		return arrow;
	}

}

internal class GtkArrowExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkArrowHandle gtk_arrow_new(GtkArrowType arrow_type, GtkShadowType shadow_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_arrow_set(GtkArrowHandle arrow, GtkArrowType arrow_type, GtkShadowType shadow_type);

}
