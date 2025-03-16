namespace MentorLake.GdkPixbuf;

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

public struct GdkPixbufAnimationIterClass
{
	public GObjectClass parent_class;
	public IntPtr get_delay_time;
	public IntPtr get_pixbuf;
	public IntPtr on_currently_loading_frame;
	public IntPtr advance;
}
