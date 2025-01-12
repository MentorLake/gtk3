namespace MentorLake.Gtk3.Gtk3;

public class GtkAlignmentHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkAlignmentHandle New(float xalign, float yalign, float xscale, float yscale)
	{
		return GtkAlignmentExterns.gtk_alignment_new(xalign, yalign, xscale, yscale);
	}

}

public static class GtkAlignmentHandleExtensions
{
	public static T GetPadding<T>(this T alignment, out uint padding_top, out uint padding_bottom, out uint padding_left, out uint padding_right) where T : GtkAlignmentHandle
	{
		GtkAlignmentExterns.gtk_alignment_get_padding(alignment, out padding_top, out padding_bottom, out padding_left, out padding_right);
		return alignment;
	}

	public static T Set<T>(this T alignment, float xalign, float yalign, float xscale, float yscale) where T : GtkAlignmentHandle
	{
		GtkAlignmentExterns.gtk_alignment_set(alignment, xalign, yalign, xscale, yscale);
		return alignment;
	}

	public static T SetPadding<T>(this T alignment, uint padding_top, uint padding_bottom, uint padding_left, uint padding_right) where T : GtkAlignmentHandle
	{
		GtkAlignmentExterns.gtk_alignment_set_padding(alignment, padding_top, padding_bottom, padding_left, padding_right);
		return alignment;
	}

}

internal class GtkAlignmentExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAlignmentHandle gtk_alignment_new(float xalign, float yalign, float xscale, float yscale);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_alignment_get_padding(GtkAlignmentHandle alignment, out uint padding_top, out uint padding_bottom, out uint padding_left, out uint padding_right);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_alignment_set(GtkAlignmentHandle alignment, float xalign, float yalign, float xscale, float yscale);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_alignment_set_padding(GtkAlignmentHandle alignment, uint padding_top, uint padding_bottom, uint padding_left, uint padding_right);

}
