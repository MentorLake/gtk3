namespace MentorLake.GdkPixbuf;

public class GdkPixbufAnimationIterHandle : GObjectHandle
{
}

public static class GdkPixbufAnimationIterHandleExtensions
{
	public static bool Advance(this MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter, MentorLake.GLib.GTimeValHandle current_time)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationIterHandle)");
		return GdkPixbufAnimationIterHandleExterns.gdk_pixbuf_animation_iter_advance(iter, current_time);
	}

	public static int GetDelayTime(this MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationIterHandle)");
		return GdkPixbufAnimationIterHandleExterns.gdk_pixbuf_animation_iter_get_delay_time(iter);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.GdkPixbuf.GdkPixbufAnimationIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GdkPixbufAnimationIterHandle)");
		return GdkPixbufAnimationIterHandleExterns.gdk_pixbuf_animation_iter_get_pixbuf(iter);
	}

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
