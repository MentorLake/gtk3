namespace MentorLake.Pango;

/// <summary>
/// <para>
/// A `PangoFontFace` is used to represent a group of fonts with
/// the same family, slant, weight, and width, but varying sizes.
/// </para>
/// </summary>

public class PangoFontFaceHandle : GObjectHandle
{
}

public static class PangoFontFaceHandleExtensions
{
/// <summary>
/// <para>
/// Returns a font description that matches the face.
/// </para>
/// <para>
/// The resulting font description will have the family, style,
/// variant, weight and stretch of the face, but its size field
/// will be unset.
/// </para>
/// </summary>

/// <param name="face">
/// a `PangoFontFace`
/// </param>
/// <return>
/// a newly-created `PangoFontDescription` structure
///   holding the description of the face. Use [method@Pango.FontDescription.free]
///   to free the result.
/// </return>

	public static MentorLake.Pango.PangoFontDescriptionHandle Describe(this MentorLake.Pango.PangoFontFaceHandle face)
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		return PangoFontFaceHandleExterns.pango_font_face_describe(face);
	}

/// <summary>
/// <para>
/// Gets a name representing the style of this face.
/// </para>
/// <para>
/// Note that a font family may contain multiple faces
/// with the same name (e.g. a variable and a non-variable
/// face for the same style).
/// </para>
/// </summary>

/// <param name="face">
/// a `PangoFontFace`.
/// </param>
/// <return>
/// the face name for the face. This string is
///   owned by the face object and must not be modified or freed.
/// </return>

	public static string GetFaceName(this MentorLake.Pango.PangoFontFaceHandle face)
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		return PangoFontFaceHandleExterns.pango_font_face_get_face_name(face);
	}

/// <summary>
/// <para>
/// Gets the `PangoFontFamily` that @face belongs to.
/// </para>
/// </summary>

/// <param name="face">
/// a `PangoFontFace`
/// </param>
/// <return>
/// the `PangoFontFamily`
/// </return>

	public static MentorLake.Pango.PangoFontFamilyHandle GetFamily(this MentorLake.Pango.PangoFontFaceHandle face)
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		return PangoFontFaceHandleExterns.pango_font_face_get_family(face);
	}

/// <summary>
/// <para>
/// Returns whether a `PangoFontFace` is synthesized.
/// </para>
/// <para>
/// This will be the case if the underlying font rendering engine
/// creates this face from another face, by shearing, emboldening,
/// lightening or modifying it in some other way.
/// </para>
/// </summary>

/// <param name="face">
/// a `PangoFontFace`
/// </param>
/// <return>
/// whether @face is synthesized
/// </return>

	public static bool IsSynthesized(this MentorLake.Pango.PangoFontFaceHandle face)
	{
		if (face.IsInvalid) throw new Exception("Invalid handle (PangoFontFaceHandle)");
		return PangoFontFaceHandleExterns.pango_font_face_is_synthesized(face);
	}

/// <summary>
/// <para>
/// List the available sizes for a font.
/// </para>
/// <para>
/// This is only applicable to bitmap fonts. For scalable fonts, stores
/// %NULL at the location pointed to by @sizes and 0 at the location pointed
/// to by @n_sizes. The sizes returned are in Pango units and are sorted
/// in ascending order.
/// </para>
/// </summary>

/// <param name="face">
/// a `PangoFontFace`.
/// </param>
/// <param name="sizes">
/// 
///   location to store a pointer to an array of int. This array
///   should be freed with g_free().
/// </param>
/// <param name="n_sizes">
/// location to store the number of elements in @sizes
/// </param>

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
	internal static extern void pango_font_face_list_sizes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] MentorLake.Pango.PangoFontFaceHandle face, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out int[] sizes, out int n_sizes);

}
