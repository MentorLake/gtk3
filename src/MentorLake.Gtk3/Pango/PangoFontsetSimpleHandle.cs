namespace MentorLake.Pango;

public class PangoFontsetSimpleHandle : PangoFontsetHandle
{
	public static MentorLake.Pango.PangoFontsetSimpleHandle New(MentorLake.Pango.PangoLanguageHandle language)
	{
		return PangoFontsetSimpleHandleExterns.pango_fontset_simple_new(language);
	}

}

public static class PangoFontsetSimpleHandleExtensions
{
	public static T Append<T>(this T fontset, MentorLake.Pango.PangoFontHandle font) where T : PangoFontsetSimpleHandle
	{
		if (fontset.IsInvalid || fontset.IsClosed) throw new Exception("Invalid or closed handle (PangoFontsetSimpleHandle)");
		PangoFontsetSimpleHandleExterns.pango_fontset_simple_append(fontset, font);
		return fontset;
	}

	public static int Size(this MentorLake.Pango.PangoFontsetSimpleHandle fontset)
	{
		if (fontset.IsInvalid || fontset.IsClosed) throw new Exception("Invalid or closed handle (PangoFontsetSimpleHandle)");
		return PangoFontsetSimpleHandleExterns.pango_fontset_simple_size(fontset);
	}

}

internal class PangoFontsetSimpleHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontsetSimpleHandle pango_fontset_simple_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_fontset_simple_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetSimpleHandle>))] MentorLake.Pango.PangoFontsetSimpleHandle fontset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_fontset_simple_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetSimpleHandle>))] MentorLake.Pango.PangoFontsetSimpleHandle fontset);

}
