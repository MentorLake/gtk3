namespace MentorLake.Gdk;

public class GdkColorHandle : BaseSafeHandle
{
}


public static class GdkColorExtensions
{
	public static MentorLake.Gdk.GdkColorHandle Copy(this MentorLake.Gdk.GdkColorHandle color)
	{
		return GdkColorExterns.gdk_color_copy(color);
	}

	public static bool Equal(this MentorLake.Gdk.GdkColorHandle colora, MentorLake.Gdk.GdkColorHandle colorb)
	{
		return GdkColorExterns.gdk_color_equal(colora, colorb);
	}

	public static void Free(this MentorLake.Gdk.GdkColorHandle color)
	{
		GdkColorExterns.gdk_color_free(color);
	}

	public static uint Hash(this MentorLake.Gdk.GdkColorHandle color)
	{
		return GdkColorExterns.gdk_color_hash(color);
	}

	public static string ToString(this MentorLake.Gdk.GdkColorHandle color)
	{
		return GdkColorExterns.gdk_color_to_string(color);
	}


	public static GdkColor Dereference(this GdkColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkColor>(x.DangerousGetHandle());
}
internal class GdkColorExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkColorHandle gdk_color_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_color_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle colora, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle colorb);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_color_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_color_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_color_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_color_parse(string spec, out MentorLake.Gdk.GdkColor color);

}

public struct GdkColor
{
	public uint pixel;
	public ushort red;
	public ushort green;
	public ushort blue;
	public static bool Parse(string spec, out MentorLake.Gdk.GdkColor color)
	{
		return GdkColorExterns.gdk_color_parse(spec, out color);
	}

}
