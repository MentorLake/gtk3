namespace MentorLake.GdkPixbuf;

public class GdkPixbufNonAnimHandle : GdkPixbufAnimationHandle
{
	public static MentorLake.GdkPixbuf.GdkPixbufNonAnimHandle New(MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		return GdkPixbufNonAnimHandleExterns.gdk_pixbuf_non_anim_new(pixbuf);
	}

}

public static class GdkPixbufNonAnimHandleExtensions
{
}

internal class GdkPixbufNonAnimHandleExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufNonAnimHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufNonAnimHandle gdk_pixbuf_non_anim_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

}
