namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Modules supporting animations must derive a type from
/// #GdkPixbufAnimation, providing suitable implementations of the
/// virtual functions.
/// </para>
/// </summary>

public class GdkPixbufAnimationClassHandle : BaseSafeHandle
{
}


public static class GdkPixbufAnimationClassExtensions
{

	public static GdkPixbufAnimationClass Dereference(this GdkPixbufAnimationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufAnimationClass>(x.DangerousGetHandle());
}
internal class GdkPixbufAnimationClassExterns
{
}

/// <summary>
/// <para>
/// Modules supporting animations must derive a type from
/// #GdkPixbufAnimation, providing suitable implementations of the
/// virtual functions.
/// </para>
/// </summary>

public struct GdkPixbufAnimationClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// returns whether the given animation is just a static image.
/// </para>
/// </summary>

public IntPtr is_static_image;
	/// <summary>
/// <para>
/// returns a static image representing the given animation.
/// </para>
/// </summary>

public IntPtr get_static_image;
	/// <summary>
/// <para>
/// fills @width and @height with the frame size of the animation.
/// </para>
/// </summary>

public IntPtr get_size;
	/// <summary>
/// <para>
/// returns an iterator for the given animation.
/// </para>
/// </summary>

public IntPtr get_iter;
}
