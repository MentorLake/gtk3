namespace MentorLake.PangoOT;

public class PangoOTBufferHandle : BaseSafeHandle
{
	public static MentorLake.PangoOT.PangoOTBufferHandle New(MentorLake.PangoFc.PangoFcFontHandle font)
	{
		return PangoOTBufferExterns.pango_ot_buffer_new(font);
	}

}


public static class PangoOTBufferExtensions
{
	public static void AddGlyph(this MentorLake.PangoOT.PangoOTBufferHandle buffer, uint glyph, uint properties, uint cluster)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_add_glyph(buffer, glyph, properties, cluster);
	}

	public static void Clear(this MentorLake.PangoOT.PangoOTBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_clear(buffer);
	}

	public static void Destroy(this MentorLake.PangoOT.PangoOTBufferHandle buffer)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_destroy(buffer);
	}

	public static void GetGlyphs(this MentorLake.PangoOT.PangoOTBufferHandle buffer, out MentorLake.PangoOT.PangoOTGlyph[] glyphs, out int n_glyphs)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_get_glyphs(buffer, out glyphs, out n_glyphs);
	}

	public static void Output(this MentorLake.PangoOT.PangoOTBufferHandle buffer, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_output(buffer, glyphs);
	}

	public static void SetRtl(this MentorLake.PangoOT.PangoOTBufferHandle buffer, bool rtl)
	{
		if (buffer.IsInvalid) throw new Exception("Invalid handle (PangoOTBuffer)");
		PangoOTBufferExterns.pango_ot_buffer_set_rtl(buffer, rtl);
	}

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
	internal static extern void pango_ot_buffer_get_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTBufferHandle>))] MentorLake.PangoOT.PangoOTBufferHandle buffer, out MentorLake.PangoOT.PangoOTGlyph[] glyphs, out int n_glyphs);

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
