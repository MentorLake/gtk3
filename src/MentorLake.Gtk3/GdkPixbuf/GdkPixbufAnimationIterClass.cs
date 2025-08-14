namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Modules supporting animations must derive a type from
/// #GdkPixbufAnimationIter, providing suitable implementations of the
/// virtual functions.
/// </para>
/// </summary>

public class GdkPixbufAnimationIterClassHandle : BaseSafeHandle
{
}


public static class GdkPixbufAnimationIterClassExtensions
{

	public static GdkPixbufAnimationIterClass Dereference(this GdkPixbufAnimationIterClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufAnimationIterClass>(x.DangerousGetHandle());
}
internal class GdkPixbufAnimationIterClassExterns
{
}

/// <summary>
/// <para>
/// Modules supporting animations must derive a type from
/// #GdkPixbufAnimationIter, providing suitable implementations of the
/// virtual functions.
/// </para>
/// </summary>

public struct GdkPixbufAnimationIterClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// returns the time in milliseconds that the current frame
///  should be shown.
/// </para>
/// </summary>

public IntPtr get_delay_time;
	/// <summary>
/// <para>
/// returns the current frame.
/// </para>
/// </summary>

public IntPtr get_pixbuf;
	/// <summary>
/// <para>
/// returns whether the current frame of @iter is
///  being loaded.
/// </para>
/// </summary>

public IntPtr on_currently_loading_frame;
	/// <summary>
/// <para>
/// advances the iterator to @current_time, possibly changing the
///  current frame.
/// </para>
/// </summary>

public IntPtr advance;
}
