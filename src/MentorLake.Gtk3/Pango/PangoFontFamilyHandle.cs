namespace MentorLake.Pango;

public class PangoFontFamilyHandle : GObjectHandle, GListModelHandle
{
}

public static class PangoFontFamilyHandleExtensions
{
	public static MentorLake.Pango.PangoFontFaceHandle GetFace(this MentorLake.Pango.PangoFontFamilyHandle family, string name)
	{
		if (family.IsInvalid || family.IsClosed) throw new Exception("Invalid or closed handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_get_face(family, name);
	}

	public static string GetName(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid || family.IsClosed) throw new Exception("Invalid or closed handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_get_name(family);
	}

	public static bool IsMonospace(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid || family.IsClosed) throw new Exception("Invalid or closed handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_is_monospace(family);
	}

	public static bool IsVariable(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid || family.IsClosed) throw new Exception("Invalid or closed handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_is_variable(family);
	}

	public static T ListFaces<T>(this T family, out MentorLake.Pango.PangoFontFaceHandle[] faces, out int n_faces) where T : PangoFontFamilyHandle
	{
		if (family.IsInvalid || family.IsClosed) throw new Exception("Invalid or closed handle (PangoFontFamilyHandle)");
		PangoFontFamilyHandleExterns.pango_font_family_list_faces(family, out faces, out n_faces);
		return family;
	}

}

internal class PangoFontFamilyHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontFaceHandle pango_font_family_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family, string name);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_family_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_family_is_monospace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_family_is_variable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_family_list_faces([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] out MentorLake.Pango.PangoFontFaceHandle[] faces, out int n_faces);

}
