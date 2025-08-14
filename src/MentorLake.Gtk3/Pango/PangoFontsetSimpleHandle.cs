namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoFontsetSimple` is a implementation of the abstract
/// `PangoFontset` base class as an array of fonts.
/// </para>
/// <para>
/// When creating a `PangoFontsetSimple`, you have to provide
/// the array of fonts that make up the fontset.
/// </para>
/// </summary>

public class PangoFontsetSimpleHandle : PangoFontsetHandle
{
/// <summary>
/// <para>
/// Creates a new `PangoFontsetSimple` for the given language.
/// </para>
/// </summary>

/// <param name="language">
/// a `PangoLanguage` tag
/// </param>
/// <return>
/// the newly allocated `PangoFontsetSimple`
/// </return>

	public static MentorLake.Pango.PangoFontsetSimpleHandle New(MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoFontsetSimpleHandleExterns.pango_fontset_simple_new(language);
	}

}

public static class PangoFontsetSimpleHandleExtensions
{
/// <summary>
/// <para>
/// Adds a font to the fontset.
/// </para>
/// <para>
/// The fontset takes ownership of @font.
/// </para>
/// </summary>

/// <param name="fontset">
/// a `PangoFontsetSimple`.
/// </param>
/// <param name="font">
/// a `PangoFont`.
/// </param>

	public static T Append<T>(this T fontset, MentorLake.Pango.PangoFontHandle font) where T : PangoFontsetSimpleHandle
	{
		if (fontset.IsInvalid) throw new Exception("Invalid handle (PangoFontsetSimpleHandle)");
		PangoFontsetSimpleHandleExterns.pango_fontset_simple_append(fontset, font);
		return fontset;
	}

/// <summary>
/// <para>
/// Returns the number of fonts in the fontset.
/// </para>
/// </summary>

/// <param name="fontset">
/// a `PangoFontsetSimple`.
/// </param>
/// <return>
/// the size of @fontset
/// </return>

	public static int Size(this MentorLake.Pango.PangoFontsetSimpleHandle fontset)
	{
		if (fontset.IsInvalid) throw new Exception("Invalid handle (PangoFontsetSimpleHandle)");
		return PangoFontsetSimpleHandleExterns.pango_fontset_simple_size(fontset);
	}

}

internal class PangoFontsetSimpleHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontsetSimpleHandle>))]
	internal static extern MentorLake.Pango.PangoFontsetSimpleHandle pango_fontset_simple_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_fontset_simple_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetSimpleHandle>))] MentorLake.Pango.PangoFontsetSimpleHandle fontset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_fontset_simple_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetSimpleHandle>))] MentorLake.Pango.PangoFontsetSimpleHandle fontset);

}
