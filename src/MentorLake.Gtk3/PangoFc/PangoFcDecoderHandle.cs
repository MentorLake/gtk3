namespace MentorLake.PangoFc;

/// <summary>
/// <para>
/// `PangoFcDecoder` is a virtual base class that implementations will
/// inherit from.
/// </para>
/// <para>
/// It&apos;s the interface that is used to define a custom encoding for a font.
/// These objects are created in your code from a function callback that was
/// originally registered with [method@PangoFc.FontMap.add_decoder_find_func].
/// Pango requires information about the supported charset for a font as well
/// as the individual character to glyph conversions. Pango gets that
/// information via the #get_charset and #get_glyph callbacks into your
/// object implementation.
/// </para>
/// </summary>

public class PangoFcDecoderHandle : GObjectHandle
{
}

public static class PangoFcDecoderHandleExtensions
{
/// <summary>
/// <para>
/// Generates an `FcCharSet` of supported characters for the @fcfont
/// given.
/// </para>
/// <para>
/// The returned `FcCharSet` will be a reference to an
/// internal value stored by the `PangoFcDecoder` and must not
/// be modified or freed.
/// </para>
/// </summary>

/// <param name="decoder">
/// a `PangoFcDecoder`
/// </param>
/// <param name="fcfont">
/// the `PangoFcFont` to query.
/// </param>
/// <return>
/// the `FcCharset` for @fcfont; must not
///   be modified or freed.
/// </return>

	public static MentorLake.fontconfig.FcCharSetHandle GetCharset(this MentorLake.PangoFc.PangoFcDecoderHandle decoder, MentorLake.PangoFc.PangoFcFontHandle fcfont)
	{
		if (decoder.IsInvalid) throw new Exception("Invalid handle (PangoFcDecoderHandle)");
		return PangoFcDecoderHandleExterns.pango_fc_decoder_get_charset(decoder, fcfont);
	}

/// <summary>
/// <para>
/// Generates a `PangoGlyph` for the given Unicode point using the
/// custom decoder.
/// </para>
/// <para>
/// For complex scripts where there can be multiple
/// glyphs for a single character, the decoder will return whatever
/// glyph is most convenient for it. (Usually whatever glyph is directly
/// in the fonts character map table.)
/// </para>
/// </summary>

/// <param name="decoder">
/// a `PangoFcDecoder`
/// </param>
/// <param name="fcfont">
/// a `PangoFcFont` to query.
/// </param>
/// <param name="wc">
/// the Unicode code point to convert to a single `PangoGlyph`.
/// </param>
/// <return>
/// the glyph index, or 0 if the glyph isn&apos;t
/// covered by the font.
/// </return>

	public static MentorLake.Pango.PangoGlyph GetGlyph(this MentorLake.PangoFc.PangoFcDecoderHandle decoder, MentorLake.PangoFc.PangoFcFontHandle fcfont, uint wc)
	{
		if (decoder.IsInvalid) throw new Exception("Invalid handle (PangoFcDecoderHandle)");
		return PangoFcDecoderHandleExterns.pango_fc_decoder_get_glyph(decoder, fcfont, wc);
	}

}

internal class PangoFcDecoderHandleExterns
{
	[DllImport(PangoFcLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcCharSetHandle>))]
	internal static extern MentorLake.fontconfig.FcCharSetHandle pango_fc_decoder_get_charset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcDecoderHandle>))] MentorLake.PangoFc.PangoFcDecoderHandle decoder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle fcfont);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern MentorLake.Pango.PangoGlyph pango_fc_decoder_get_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcDecoderHandle>))] MentorLake.PangoFc.PangoFcDecoderHandle decoder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle fcfont, uint wc);

}
