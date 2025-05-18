namespace MentorLake.Gdk;

public class GdkRectangleHandle : BaseSafeHandle
{
}


public static class GdkRectangleExtensions
{
	public static bool Equal(this MentorLake.Gdk.GdkRectangleHandle rect1, MentorLake.Gdk.GdkRectangleHandle rect2)
	{
		if (rect1.IsInvalid) throw new Exception("Invalid handle (GdkRectangle)");
		return GdkRectangleExterns.gdk_rectangle_equal(rect1, rect2);
	}

	public static bool Intersect(this MentorLake.Gdk.GdkRectangleHandle src1, MentorLake.Gdk.GdkRectangleHandle src2, out MentorLake.Gdk.GdkRectangle dest)
	{
		if (src1.IsInvalid) throw new Exception("Invalid handle (GdkRectangle)");
		return GdkRectangleExterns.gdk_rectangle_intersect(src1, src2, out dest);
	}

	public static void Union(this MentorLake.Gdk.GdkRectangleHandle src1, MentorLake.Gdk.GdkRectangleHandle src2, out MentorLake.Gdk.GdkRectangle dest)
	{
		if (src1.IsInvalid) throw new Exception("Invalid handle (GdkRectangle)");
		GdkRectangleExterns.gdk_rectangle_union(src1, src2, out dest);
	}


	public static GdkRectangle Dereference(this GdkRectangleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkRectangle>(x.DangerousGetHandle());
}
internal class GdkRectangleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_rectangle_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle rect2);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_rectangle_intersect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle src1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle src2, out MentorLake.Gdk.GdkRectangle dest);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_rectangle_union([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle src1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle src2, out MentorLake.Gdk.GdkRectangle dest);

}

public struct GdkRectangle
{
	public int x;
	public int y;
	public int width;
	public int height;
}
