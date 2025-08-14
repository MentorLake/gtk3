namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkAspectFrame is useful when you want
/// pack a widget so that it can resize but always retains
/// the same aspect ratio. For instance, one might be
/// drawing a small preview of a larger image. #GtkAspectFrame
/// derives from #GtkFrame, so it can draw a label and
/// a frame around the child. The frame will be
/// “shrink-wrapped” to the size of the child.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkAspectFrame uses a CSS node with name frame.
/// </para>
/// </summary>

public class GtkAspectFrameHandle : GtkFrameHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Create a new #GtkAspectFrame.
/// </para>
/// </summary>

/// <param name="label">
/// Label text.
/// </param>
/// <param name="xalign">
/// Horizontal alignment of the child within the allocation of
///  the #GtkAspectFrame. This ranges from 0.0 (left aligned)
///  to 1.0 (right aligned)
/// </param>
/// <param name="yalign">
/// Vertical alignment of the child within the allocation of
///  the #GtkAspectFrame. This ranges from 0.0 (top aligned)
///  to 1.0 (bottom aligned)
/// </param>
/// <param name="ratio">
/// The desired aspect ratio.
/// </param>
/// <param name="obey_child">
/// If %TRUE, @ratio is ignored, and the aspect
///  ratio is taken from the requistion of the child.
/// </param>
/// <return>
/// the new #GtkAspectFrame.
/// </return>

	public static MentorLake.Gtk.GtkAspectFrameHandle New(string label, float xalign, float yalign, float ratio, bool obey_child)
	{
		return GtkAspectFrameHandleExterns.gtk_aspect_frame_new(label, xalign, yalign, ratio, obey_child);
	}

}

public static class GtkAspectFrameHandleExtensions
{
/// <summary>
/// <para>
/// Set parameters for an existing #GtkAspectFrame.
/// </para>
/// </summary>

/// <param name="aspect_frame">
/// a #GtkAspectFrame
/// </param>
/// <param name="xalign">
/// Horizontal alignment of the child within the allocation of
///  the #GtkAspectFrame. This ranges from 0.0 (left aligned)
///  to 1.0 (right aligned)
/// </param>
/// <param name="yalign">
/// Vertical alignment of the child within the allocation of
///  the #GtkAspectFrame. This ranges from 0.0 (top aligned)
///  to 1.0 (bottom aligned)
/// </param>
/// <param name="ratio">
/// The desired aspect ratio.
/// </param>
/// <param name="obey_child">
/// If %TRUE, @ratio is ignored, and the aspect
///  ratio is taken from the requistion of the child.
/// </param>

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
