namespace MentorLake.Pango;

public class PangoFontMapHandle : GObjectHandle, GListModelHandle
{
}

public static class PangoFontMapHandleExtensions
{
	public static bool AddFontFile(this MentorLake.Pango.PangoFontMapHandle fontmap, string filename, IntPtr error)
	{
		return PangoFontMapHandleExterns.pango_font_map_add_font_file(fontmap, filename, error);
	}

	public static T Changed<T>(this T fontmap) where T : PangoFontMapHandle
	{
		PangoFontMapHandleExterns.pango_font_map_changed(fontmap);
		return fontmap;
	}

	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.Pango.PangoFontMapHandle fontmap)
	{
		return PangoFontMapHandleExterns.pango_font_map_create_context(fontmap);
	}

	public static MentorLake.Pango.PangoFontFamilyHandle GetFamily(this MentorLake.Pango.PangoFontMapHandle fontmap, string name)
	{
		return PangoFontMapHandleExterns.pango_font_map_get_family(fontmap, name);
	}

	public static uint GetSerial(this MentorLake.Pango.PangoFontMapHandle fontmap)
	{
		return PangoFontMapHandleExterns.pango_font_map_get_serial(fontmap);
	}

	public static T ListFamilies<T>(this T fontmap, out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families) where T : PangoFontMapHandle
	{
		PangoFontMapHandleExterns.pango_font_map_list_families(fontmap, out families, out n_families);
		return fontmap;
	}

	public static MentorLake.Pango.PangoFontHandle LoadFont(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		return PangoFontMapHandleExterns.pango_font_map_load_font(fontmap, context, desc);
	}

	public static MentorLake.Pango.PangoFontsetHandle LoadFontset(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoFontMapHandleExterns.pango_font_map_load_fontset(fontmap, context, desc, language);
	}

	public static MentorLake.Pango.PangoFontHandle ReloadFont(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoFontHandle font, double scale, MentorLake.Pango.PangoContextHandle context, string variations)
	{
		return PangoFontMapHandleExterns.pango_font_map_reload_font(fontmap, font, scale, context, variations);
	}

}

internal class PangoFontMapHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_map_add_font_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, string filename, IntPtr error);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_map_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoContextHandle pango_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontFamilyHandle pango_font_map_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, string name);

	[DllImport(PangoLibrary.Name)]
	internal static extern uint pango_font_map_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_map_list_families([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontHandle pango_font_map_load_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontsetHandle pango_font_map_load_fontset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontHandle pango_font_map_reload_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, double scale, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, string variations);

}
