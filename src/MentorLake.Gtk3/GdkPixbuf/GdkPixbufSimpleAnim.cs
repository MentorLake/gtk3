namespace MentorLake.Gtk3.GdkPixbuf;

public class GdkPixbufSimpleAnimHandle : GdkPixbufAnimationHandle
{
	public static GdkPixbufSimpleAnimHandle New(int width, int height, float rate)
	{
		return GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_new(width, height, rate);
	}

}

public static class GdkPixbufSimpleAnimHandleExtensions
{
	public static T AddFrame<T>(this T animation, GdkPixbufHandle pixbuf) where T : GdkPixbufSimpleAnimHandle
	{
		GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_add_frame(animation, pixbuf);
		return animation;
	}

	public static bool GetLoop(this GdkPixbufSimpleAnimHandle animation)
	{
		return GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_get_loop(animation);
	}

	public static T SetLoop<T>(this T animation, bool loop) where T : GdkPixbufSimpleAnimHandle
	{
		GdkPixbufSimpleAnimExterns.gdk_pixbuf_simple_anim_set_loop(animation, loop);
		return animation;
	}

}

internal class GdkPixbufSimpleAnimExterns
{
	[DllImport(Libraries.GdkPixbuf)]
	internal static extern GdkPixbufSimpleAnimHandle gdk_pixbuf_simple_anim_new(int width, int height, float rate);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_simple_anim_add_frame(GdkPixbufSimpleAnimHandle animation, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern bool gdk_pixbuf_simple_anim_get_loop(GdkPixbufSimpleAnimHandle animation);

	[DllImport(Libraries.GdkPixbuf)]
	internal static extern void gdk_pixbuf_simple_anim_set_loop(GdkPixbufSimpleAnimHandle animation, bool loop);

}
