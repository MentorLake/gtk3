namespace MentorLake.GdkPixbuf;

public class GdkPixbufSimpleAnimHandle : GdkPixbufAnimationHandle
{
	public static MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle New(int width, int height, float rate)
	{
		return GdkPixbufSimpleAnimHandleExterns.gdk_pixbuf_simple_anim_new(width, height, rate);
	}

}

public static class GdkPixbufSimpleAnimHandleExtensions
{
	public static T AddFrame<T>(this T animation, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GdkPixbufSimpleAnimHandle
	{
		GdkPixbufSimpleAnimHandleExterns.gdk_pixbuf_simple_anim_add_frame(animation, pixbuf);
		return animation;
	}

	public static bool GetLoop(this MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle animation)
	{
		return GdkPixbufSimpleAnimHandleExterns.gdk_pixbuf_simple_anim_get_loop(animation);
	}

	public static T SetLoop<T>(this T animation, bool loop) where T : GdkPixbufSimpleAnimHandle
	{
		GdkPixbufSimpleAnimHandleExterns.gdk_pixbuf_simple_anim_set_loop(animation, loop);
		return animation;
	}

}

internal class GdkPixbufSimpleAnimHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle gdk_pixbuf_simple_anim_new(int width, int height, float rate);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_simple_anim_add_frame([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle>))] MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle animation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_simple_anim_get_loop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle>))] MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_simple_anim_set_loop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle>))] MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle animation, bool loop);

}
