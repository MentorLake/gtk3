namespace MentorLake.PangoOT;


public class PangoOTBufferHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new `PangoOTBuffer` for the given OpenType font.
/// </para>
/// </summary>

/// <param name="font">
/// a `PangoFcFont`
/// </param>
/// <return>
/// the newly allocated `PangoOTBuffer`, which should
///   be freed with [method@PangoOT.Buffer.destroy].
/// </return>

	public static MentorLake.PangoOT.PangoOTBufferHandle New(MentorLake.PangoFc.PangoFcFontHandle font)
	{
		return PangoOTBufferExterns.pango_ot_buffer_new(font);
	}

}


public static class PangoOTBufferExtensions
{
/// <summary>
/// <para>
/// Appends a glyph to a `PangoOTBuffer`, with @properties identifying which
/// features should be applied on this glyph.
/// </para>
/// <para>
/// See [method@PangoOT.Ruleset.add_feature].
/// </para>
/// </summary>

/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>
/// <param name="glyph">
/// the glyph index to add, like a `PangoGlyph`
/// </param>
/// <param name="properties">
/// the glyph properties
/// </param>
/// <param name="cluster">
/// the cluster that this glyph belongs to
/// </param>

	public static void AddGlyph(this MentorLake.PangoOT.PangoOTBufferHandle buffer, uint glyph, uint properties, uint cluster)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_add_glyph(buffer, glyph, properties, cluster);
	}

/// <summary>
/// <para>
/// Empties a `PangoOTBuffer`, make it ready to add glyphs to.
/// </para>
/// </summary>

/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>

	public static void Clear(this MentorLake.PangoOT.PangoOTBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_clear(buffer);
	}

/// <summary>
/// <para>
/// Destroys a `PangoOTBuffer` and free all associated memory.
/// </para>
/// </summary>

/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>

	public static void Destroy(this MentorLake.PangoOT.PangoOTBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_destroy(buffer);
	}

/// <summary>
/// <para>
/// Gets the glyph array contained in a `PangoOTBuffer`.
/// </para>
/// <para>
/// The glyphs are owned by the buffer and should not be freed,
/// and are only valid as long as buffer is not modified.
/// </para>
/// </summary>

/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>
/// <param name="glyphs">
/// location to
///   store the array of glyphs
/// </param>
/// <param name="n_glyphs">
/// location to store the number of glyphs
/// </param>

	public static void GetGlyphs(this MentorLake.PangoOT.PangoOTBufferHandle buffer, out MentorLake.PangoOT.PangoOTGlyph[] glyphs, out int n_glyphs)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_get_glyphs(buffer, out glyphs, out n_glyphs);
	}

/// <summary>
/// <para>
/// Exports the glyphs in a `PangoOTBuffer` into a `PangoGlyphString`.
/// </para>
/// <para>
/// This is typically used after the OpenType layout processing
/// is over, to convert the resulting glyphs into a generic Pango
/// glyph string.
/// </para>
/// </summary>

/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>
/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>

	public static void Output(this MentorLake.PangoOT.PangoOTBufferHandle buffer, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_output(buffer, glyphs);
	}

/// <summary>
/// <para>
/// Sets whether glyphs will be rendered right-to-left.
/// </para>
/// <para>
/// This setting is needed for proper horizontal positioning
/// of right-to-left scripts.
/// </para>
/// </summary>

/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>
/// <param name="rtl">
/// %TRUE for right-to-left text
/// </param>

	public static void SetRtl(this MentorLake.PangoOT.PangoOTBufferHandle buffer, bool rtl)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_set_rtl(buffer, rtl);
	}

/// <summary>
/// <para>
/// Sets whether characters with a mark class should be forced to zero width.
/// </para>
/// <para>
/// This setting is needed for proper positioning of Arabic accents,
/// but will produce incorrect results with standard OpenType Indic
/// fonts.
/// </para>
/// </summary>

/// <param name="buffer">
/// a `PangoOTBuffer`
/// </param>
/// <param name="zero_width_marks">
/// %TRUE if characters with a mark class should
///   be forced to zero width
/// </param>

	public static void SetZeroWidthMarks(this MentorLake.PangoOT.PangoOTBufferHandle buffer, bool zero_width_marks)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_set_zero_width_marks(buffer, zero_width_marks);
	}


	public static PangoOTBuffer Dereference(this PangoOTBufferHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoOTBuffer>(x.DangerousGetHandle());
}
internal class PangoOTBufferExterns
{
	[DllImport(PangoOTLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))]
	internal static extern MentorLake.PangoOT.PangoOTBufferHandle pango_ot_buffer_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle font);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_buffer_add_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer, uint glyph, uint properties, uint cluster);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_buffer_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_buffer_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_buffer_get_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.PangoOT.PangoOTGlyph[] glyphs, out int n_glyphs);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_buffer_output([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_buffer_set_rtl([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer, bool rtl);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_buffer_set_zero_width_marks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer, bool zero_width_marks);

}


public struct PangoOTBuffer
{
}
