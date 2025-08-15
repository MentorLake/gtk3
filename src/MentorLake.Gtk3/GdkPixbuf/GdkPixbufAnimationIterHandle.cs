namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// An opaque object representing an iterator which points to a
/// certain position in an animation.
/// </para>
/// </summary>

public class GdkPixbufAnimationIterHandle : GObjectHandle
{
}

public static class GdkPixbufAnimationIterHandleExtensions
{
/// <summary>
/// <para>
/// Possibly advances an animation to a new frame.
/// </para>
/// <para>
/// Chooses the frame based on the start time passed to
/// gdk_pixbuf_animation_get_iter().
/// </para>
/// <para>
/// @current_time would normally come from g_get_current_time(), and
/// must be greater than or equal to the time passed to
/// gdk_pixbuf_animation_get_iter(), and must increase or remain
/// unchanged each time gdk_pixbuf_animation_iter_get_pixbuf() is
/// called. That is, you can&apos;t go backward in time; animations only
/// play forward.
/// </para>
/// <para>
/// As a shortcut, pass `NULL` for the current time and g_get_current_time()
/// will be invoked on your behalf. So you only need to explicitly pass
/// @current_time if you&apos;re doing something odd like playing the animation
/// at double speed.
/// </para>
/// <para>
/// If this function returns `FALSE`, there&apos;s no need to update the animation
/// display, assuming the display had been rendered prior to advancing;
/// if `TRUE`, you need to call gdk_pixbuf_animation_iter_get_pixbuf()
/// and update the display with the new pixbuf.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GdkPixbufAnimationIter
/// </param>
/// <param name="current_time">
/// current time
/// </param>
/// <return>
/// `TRUE` if the image may need updating
/// </return>

	public static bool Advance(this MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter, MentorLake.GLib.GTimeValHandle current_time)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationIterHandle)");
		return GdkPixbufAnimationIterHandleExterns.gdk_pixbuf_animation_iter_advance(iter, current_time);
	}

/// <summary>
/// <para>
/// Gets the number of milliseconds the current pixbuf should be displayed,
/// or -1 if the current pixbuf should be displayed forever.
/// </para>
/// <para>
/// The `g_timeout_add()` function conveniently takes a timeout in milliseconds,
/// so you can use a timeout to schedule the next update.
/// </para>
/// <para>
/// Note that some formats, like GIF, might clamp the timeout values in the
/// image file to avoid updates that are just too quick. The minimum timeout
/// for GIF images is currently 20 milliseconds.
/// </para>
/// </summary>

/// <param name="iter">
/// an animation iterator
/// </param>
/// <return>
/// delay time in milliseconds (thousandths of a second)
/// </return>

	public static int GetDelayTime(this MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationIterHandle)");
		return GdkPixbufAnimationIterHandleExterns.gdk_pixbuf_animation_iter_get_delay_time(iter);
	}

/// <summary>
/// <para>
/// Gets the current pixbuf which should be displayed.
/// </para>
/// <para>
/// The pixbuf might not be the same size as the animation itself
/// (gdk_pixbuf_animation_get_width(), gdk_pixbuf_animation_get_height()).
/// </para>
/// <para>
/// This pixbuf should be displayed for gdk_pixbuf_animation_iter_get_delay_time()
/// milliseconds.
/// </para>
/// <para>
/// The caller of this function does not own a reference to the returned
/// pixbuf; the returned pixbuf will become invalid when the iterator
/// advances to the next frame, which may happen anytime you call
/// gdk_pixbuf_animation_iter_advance().
/// </para>
/// <para>
/// Copy the pixbuf to keep it (don&apos;t just add a reference), as it may get
/// recycled as you advance the iterator.
/// </para>
/// </summary>

/// <param name="iter">
/// an animation iterator
/// </param>
/// <return>
/// the pixbuf to be displayed
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationIterHandle)");
		return GdkPixbufAnimationIterHandleExterns.gdk_pixbuf_animation_iter_get_pixbuf(iter);
	}

/// <summary>
/// <para>
/// Used to determine how to respond to the area_updated signal on
/// #GdkPixbufLoader when loading an animation.
/// </para>
/// <para>
/// The `::area_updated` signal is emitted for an area of the frame currently
/// streaming in to the loader. So if you&apos;re on the currently loading frame,
/// you will need to redraw the screen for the updated area.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GdkPixbufAnimationIter
/// </param>
/// <return>
/// `TRUE` if the frame we&apos;re on is partially loaded, or the last frame
/// </return>

	public static bool OnCurrentlyLoadingFrame(this MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationIterHandle)");
		return GdkPixbufAnimationIterHandleExterns.gdk_pixbuf_animation_iter_on_currently_loading_frame(iter);
	}

}

internal class GdkPixbufAnimationIterHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_animation_iter_advance([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle current_time);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern int gdk_pixbuf_animation_iter_get_delay_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gdk_pixbuf_animation_iter_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_animation_iter_on_currently_loading_frame([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter);

}
