namespace MentorLake.Gdk;

public class GdkRGBAHandle : BaseSafeHandle
{
}


public static class GdkRGBAExtensions
{
	public static MentorLake.Gdk.GdkRGBAHandle Copy(this MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		if (rgba.IsInvalid || rgba.IsClosed) throw new Exception("Invalid or closed handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_copy(rgba);
	}

	public static bool Equal(this MentorLake.Gdk.GdkRGBAHandle p1, MentorLake.Gdk.GdkRGBAHandle p2)
	{
		if (p1.IsInvalid || p1.IsClosed) throw new Exception("Invalid or closed handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_equal(p1, p2);
	}

	public static void Free(this MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		if (rgba.IsInvalid || rgba.IsClosed) throw new Exception("Invalid or closed handle (GdkRGBA)");
		GdkRGBAExterns.gdk_rgba_free(rgba);
	}

	public static uint Hash(this MentorLake.Gdk.GdkRGBAHandle p)
	{
		if (p.IsInvalid || p.IsClosed) throw new Exception("Invalid or closed handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_hash(p);
	}

	public static bool Parse(this MentorLake.Gdk.GdkRGBAHandle rgba, string spec)
	{
		if (rgba.IsInvalid || rgba.IsClosed) throw new Exception("Invalid or closed handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_parse(rgba, spec);
	}

	public static string ToString(this MentorLake.Gdk.GdkRGBAHandle rgba)
	{
		if (rgba.IsInvalid || rgba.IsClosed) throw new Exception("Invalid or closed handle (GdkRGBA)");
		return GdkRGBAExterns.gdk_rgba_to_string(rgba);
	}


	public static GdkRGBA Dereference(this GdkRGBAHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkRGBA>(x.DangerousGetHandle());
}
internal class GdkRGBAExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkRGBAHandle gdk_rgba_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_rgba_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle p1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle p2);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_rgba_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_rgba_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle p);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_rgba_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba, string spec);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_rgba_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle rgba);

}

public struct GdkRGBA
{
	public double red;
	public double green;
	public double blue;
	public double alpha;
}
