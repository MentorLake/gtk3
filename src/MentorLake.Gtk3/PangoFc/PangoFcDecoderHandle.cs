namespace MentorLake.PangoFc;

public class PangoFcDecoderHandle : GObjectHandle
{
}

public static class PangoFcDecoderHandleExtensions
{
	public static MentorLake.fontconfig.FcCharSetHandle GetCharset(this MentorLake.PangoFc.PangoFcDecoderHandle decoder, MentorLake.PangoFc.PangoFcFontHandle fcfont)
	{
		return PangoFcDecoderHandleExterns.pango_fc_decoder_get_charset(decoder, fcfont);
	}

	public static MentorLake.Pango.PangoGlyph GetGlyph(this MentorLake.PangoFc.PangoFcDecoderHandle decoder, MentorLake.PangoFc.PangoFcFontHandle fcfont, uint wc)
	{
		return PangoFcDecoderHandleExterns.pango_fc_decoder_get_glyph(decoder, fcfont, wc);
	}

}

internal class PangoFcDecoderHandleExterns
{
	[DllImport(PangoFcLibrary.Name)]
	internal static extern MentorLake.fontconfig.FcCharSetHandle pango_fc_decoder_get_charset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcDecoderHandle>))] MentorLake.PangoFc.PangoFcDecoderHandle decoder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle fcfont);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGlyph pango_fc_decoder_get_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcDecoderHandle>))] MentorLake.PangoFc.PangoFcDecoderHandle decoder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle fcfont, uint wc);

}
