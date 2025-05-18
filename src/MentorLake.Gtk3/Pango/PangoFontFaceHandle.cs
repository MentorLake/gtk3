namespace MentorLake.Pango;

public class PangoFontFaceHandle : GObjectHandle
{
}

public static class PangoFontFaceHandleExtensions
{
	public static MentorLake.Pango.PangoFontDescriptionHandle Describe(this MentorLake.Pango.PangoFontFaceHandle face)
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		return PangoFontFaceHandleExterns.pango_font_face_describe(face);
	}

	public static string GetFaceName(this MentorLake.Pango.PangoFontFaceHandle face)
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		return PangoFontFaceHandleExterns.pango_font_face_get_face_name(face);
	}

	public static MentorLake.Pango.PangoFontFamilyHandle GetFamily(this MentorLake.Pango.PangoFontFaceHandle face)
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		return PangoFontFaceHandleExterns.pango_font_face_get_family(face);
	}

	public static bool IsSynthesized(this MentorLake.Pango.PangoFontFaceHandle face)
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		return PangoFontFaceHandleExterns.pango_font_face_is_synthesized(face);
	}

	public static T ListSizes<T>(this T face, out int[] sizes, out int n_sizes) where T : PangoFontFaceHandle
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		PangoFontFaceHandleExterns.pango_font_face_list_sizes(face, out sizes, out n_sizes);
		return face;
	}

}

internal class PangoFontFaceHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))]
	internal static extern MentorLake.Pango.PangoFontDescriptionHandle pango_font_face_describe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] MentorLake.Pango.PangoFontFaceHandle face);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_face_get_face_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] MentorLake.Pango.PangoFontFaceHandle face);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))]
	internal static extern MentorLake.Pango.PangoFontFamilyHandle pango_font_face_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] MentorLake.Pango.PangoFontFaceHandle face);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_face_is_synthesized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] MentorLake.Pango.PangoFontFaceHandle face);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_face_list_sizes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] MentorLake.Pango.PangoFontFaceHandle face, out int[] sizes, out int n_sizes);

}
