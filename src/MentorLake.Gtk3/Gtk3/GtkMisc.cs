namespace MentorLake.Gtk3.Gtk3;

public class GtkMiscHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkMiscHandleExtensions
{
	public static T GetAlignment<T>(this T misc, out float xalign, out float yalign) where T : GtkMiscHandle
	{
		GtkMiscExterns.gtk_misc_get_alignment(misc, out xalign, out yalign);
		return misc;
	}

	public static T GetPadding<T>(this T misc, out int xpad, out int ypad) where T : GtkMiscHandle
	{
		GtkMiscExterns.gtk_misc_get_padding(misc, out xpad, out ypad);
		return misc;
	}

	public static T SetAlignment<T>(this T misc, float xalign, float yalign) where T : GtkMiscHandle
	{
		GtkMiscExterns.gtk_misc_set_alignment(misc, xalign, yalign);
		return misc;
	}

	public static T SetPadding<T>(this T misc, int xpad, int ypad) where T : GtkMiscHandle
	{
		GtkMiscExterns.gtk_misc_set_padding(misc, xpad, ypad);
		return misc;
	}

}

internal class GtkMiscExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_misc_get_alignment(GtkMiscHandle misc, out float xalign, out float yalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_misc_get_padding(GtkMiscHandle misc, out int xpad, out int ypad);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_misc_set_alignment(GtkMiscHandle misc, float xalign, float yalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_misc_set_padding(GtkMiscHandle misc, int xpad, int ypad);

}
