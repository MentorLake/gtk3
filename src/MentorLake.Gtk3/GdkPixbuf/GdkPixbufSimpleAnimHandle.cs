namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// An opaque struct representing a simple animation.
/// </para>
/// </summary>

public class GdkPixbufSimpleAnimHandle : GdkPixbufAnimationHandle
{
/// <summary>
/// <para>
/// Creates a new, empty animation.
/// </para>
/// </summary>

/// <param name="width">
/// the width of the animation
/// </param>
/// <param name="height">
/// the height of the animation
/// </param>
/// <param name="rate">
/// the speed of the animation, in frames per second
/// </param>
/// <return>
/// a newly allocated #GdkPixbufSimpleAnim
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle New(int width, int height, float rate)
	{
		return GdkPixbufSimpleAnimHandleExterns.gdk_pixbuf_simple_anim_new(width, height, rate);
	}

}

public static class GdkPixbufSimpleAnimHandleExtensions
{
/// <summary>
/// <para>
/// Adds a new frame to @animation. The @pixbuf must
/// have the dimensions specified when the animation
/// was constructed.
/// </para>
/// </summary>

/// <param name="animation">
/// a #GdkPixbufSimpleAnim
/// </param>
/// <param name="pixbuf">
/// the pixbuf to add
/// </param>

	public static T AddFrame<T>(this T animation, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GdkPixbufSimpleAnimHandle
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufSimpleAnimHandle)");
		GdkPixbufSimpleAnimHandleExterns.gdk_pixbuf_simple_anim_add_frame(animation, pixbuf);
		return animation;
	}

/// <summary>
/// <para>
/// Gets whether @animation should loop indefinitely when it reaches the end.
/// </para>
/// </summary>

/// <param name="animation">
/// a #GdkPixbufSimpleAnim
/// </param>
/// <return>
/// %TRUE if the animation loops forever, %FALSE otherwise
/// </return>

	public static bool GetLoop(this MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle animation)
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufSimpleAnimHandle)");
		return GdkPixbufSimpleAnimHandleExterns.gdk_pixbuf_simple_anim_get_loop(animation);
	}

/// <summary>
/// <para>
/// Sets whether @animation should loop indefinitely when it reaches the end.
/// </para>
/// </summary>

/// <param name="animation">
/// a #GdkPixbufSimpleAnim
/// </param>
/// <param name="loop">
/// whether to loop the animation
/// </param>

	public static T SetLoop<T>(this T animation, bool loop) where T : GdkPixbufSimpleAnimHandle
	{
		if (animation.IsInvalid) throw new Exception("Invalid handle (GdkPixbufSimpleAnimHandle)");
		GdkPixbufSimpleAnimHandleExterns.gdk_pixbuf_simple_anim_set_loop(animation, loop);
		return animation;
	}

}

internal class GdkPixbufSimpleAnimHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle gdk_pixbuf_simple_anim_new(int width, int height, float rate);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_simple_anim_add_frame([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle>))] MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle animation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_simple_anim_get_loop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle>))] MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle animation);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_simple_anim_set_loop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle>))] MentorLake.GdkPixbuf.GdkPixbufSimpleAnimHandle animation, bool loop);

}
