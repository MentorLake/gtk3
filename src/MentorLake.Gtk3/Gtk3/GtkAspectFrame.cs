namespace MentorLake.Gtk3.Gtk3;

public class GtkAspectFrameHandle : GtkFrameHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkAspectFrameHandle New(string label, float xalign, float yalign, float ratio, bool obey_child)
	{
		return GtkAspectFrameExterns.gtk_aspect_frame_new(label, xalign, yalign, ratio, obey_child);
	}

}

public static class GtkAspectFrameHandleExtensions
{
	public static T Set<T>(this T aspect_frame, float xalign, float yalign, float ratio, bool obey_child) where T : GtkAspectFrameHandle
	{
		GtkAspectFrameExterns.gtk_aspect_frame_set(aspect_frame, xalign, yalign, ratio, obey_child);
		return aspect_frame;
	}

}

internal class GtkAspectFrameExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAspectFrameHandle gtk_aspect_frame_new(string label, float xalign, float yalign, float ratio, bool obey_child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_aspect_frame_set(GtkAspectFrameHandle aspect_frame, float xalign, float yalign, float ratio, bool obey_child);

}
