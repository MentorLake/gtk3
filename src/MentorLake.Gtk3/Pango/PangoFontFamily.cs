namespace MentorLake.Gtk3.Pango;

public class PangoFontFamilyHandle : GObjectHandle, GListModelHandle
{
}

public static class PangoFontFamilyHandleExtensions
{
	public static PangoFontFaceHandle GetFace(this PangoFontFamilyHandle family, string name)
	{
		return PangoFontFamilyExterns.pango_font_family_get_face(family, name);
	}

	public static string GetName(this PangoFontFamilyHandle family)
	{
		return PangoFontFamilyExterns.pango_font_family_get_name(family);
	}

	public static bool IsMonospace(this PangoFontFamilyHandle family)
	{
		return PangoFontFamilyExterns.pango_font_family_is_monospace(family);
	}

	public static bool IsVariable(this PangoFontFamilyHandle family)
	{
		return PangoFontFamilyExterns.pango_font_family_is_variable(family);
	}

	public static T ListFaces<T>(this T family, out PangoFontFaceHandle[] faces, out int n_faces) where T : PangoFontFamilyHandle
	{
		PangoFontFamilyExterns.pango_font_family_list_faces(family, out faces, out n_faces);
		return family;
	}

}

internal class PangoFontFamilyExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoFontFaceHandle pango_font_family_get_face(PangoFontFamilyHandle family, string name);

	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_family_get_name(PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_family_is_monospace(PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_family_is_variable(PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_family_list_faces(PangoFontFamilyHandle family, out PangoFontFaceHandle[] faces, out int n_faces);

}
