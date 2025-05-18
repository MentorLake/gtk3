namespace MentorLake.Gtk;

public class GtkAspectFrameHandle : GtkFrameHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkAspectFrameHandle New(string label, float xalign, float yalign, float ratio, bool obey_child)
	{
		return GtkAspectFrameHandleExterns.gtk_aspect_frame_new(label, xalign, yalign, ratio, obey_child);
	}

}

public static class GtkAspectFrameHandleExtensions
{
	public static T Set<T>(this T aspect_frame, float xalign, float yalign, float ratio, bool obey_child) where T : GtkAspectFrameHandle
	{
		if (aspect_frame.IsInvalid) throw new Exception("Invalid handle (GtkAspectFrameHandle)");
		GtkAspectFrameHandleExterns.gtk_aspect_frame_set(aspect_frame, xalign, yalign, ratio, obey_child);
		return aspect_frame;
	}

}

internal class GtkAspectFrameHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAspectFrameHandle>))]
	internal static extern MentorLake.Gtk.GtkAspectFrameHandle gtk_aspect_frame_new(string label, float xalign, float yalign, float ratio, bool obey_child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_aspect_frame_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAspectFrameHandle>))] MentorLake.Gtk.GtkAspectFrameHandle aspect_frame, float xalign, float yalign, float ratio, bool obey_child);

}
