namespace MentorLake.GdkPixbuf;

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

public struct GdkPixbufAnimationClass
{
	public GObjectClass parent_class;
	public IntPtr is_static_image;
	public IntPtr get_static_image;
	public IntPtr get_size;
	public IntPtr get_iter;
}
