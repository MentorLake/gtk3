namespace MentorLake.Pango;

public class PangoColorHandle : BaseSafeHandle
{
}


public static class PangoColorExtensions
{
	public static MentorLake.Pango.PangoColorHandle Copy(this MentorLake.Pango.PangoColorHandle src)
	{
		if (src.IsInvalid || src.IsClosed) throw new Exception("Invalid or closed handle (PangoColor)");
		return PangoColorExterns.pango_color_copy(src);
	}

	public static void Free(this MentorLake.Pango.PangoColorHandle color)
	{
		if (color.IsInvalid || color.IsClosed) throw new Exception("Invalid or closed handle (PangoColor)");
		PangoColorExterns.pango_color_free(color);
	}

	public static bool Parse(this MentorLake.Pango.PangoColorHandle color, string spec)
	{
		if (color.IsInvalid || color.IsClosed) throw new Exception("Invalid or closed handle (PangoColor)");
		return PangoColorExterns.pango_color_parse(color, spec);
	}

	public static bool ParseWithAlpha(this MentorLake.Pango.PangoColorHandle color, out ushort alpha, string spec)
	{
		if (color.IsInvalid || color.IsClosed) throw new Exception("Invalid or closed handle (PangoColor)");
		return PangoColorExterns.pango_color_parse_with_alpha(color, out alpha, spec);
	}

	public static string ToString(this MentorLake.Pango.PangoColorHandle color)
	{
		if (color.IsInvalid || color.IsClosed) throw new Exception("Invalid or closed handle (PangoColor)");
		return PangoColorExterns.pango_color_to_string(color);
	}


	public static PangoColor Dereference(this PangoColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoColor>(x.DangerousGetHandle());
}
internal class PangoColorExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoColorHandle pango_color_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle src);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_color_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_color_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color, string spec);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_color_parse_with_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color, out ushort alpha, string spec);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_color_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color);

}

public struct PangoColor
{
	public ushort red;
	public ushort green;
	public ushort blue;
}
