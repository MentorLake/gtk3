namespace MentorLake.PangoFc;

/// <summary>
/// <para>
/// Class structure for `PangoFcDecoder`.
/// </para>
/// </summary>

public class PangoFcDecoderClassHandle : BaseSafeHandle
{
}


public static class PangoFcDecoderClassExtensions
{

	public static PangoFcDecoderClass Dereference(this PangoFcDecoderClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFcDecoderClass>(x.DangerousGetHandle());
}
internal class PangoFcDecoderClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for `PangoFcDecoder`.
/// </para>
/// </summary>

public struct PangoFcDecoderClass
{
	/// <summary>
/// <para>
/// This returns an `FcCharset` given a `PangoFcFont` that
///  includes a list of supported characters in the font.  The
///  #FcCharSet that is returned should be an internal reference to your
///  code.  Pango will not free this structure.  It is important that
///  you make this callback fast because this callback is called
///  separately for each character to determine Unicode coverage.
/// </para>
/// </summary>

public IntPtr get_charset;
	/// <summary>
/// <para>
/// This returns a single `PangoGlyph` for a given Unicode
///  code point.
/// </para>
/// </summary>

public IntPtr get_glyph;
	
public IntPtr _pango_reserved1;
	
public IntPtr _pango_reserved2;
	
public IntPtr _pango_reserved3;
	
public IntPtr _pango_reserved4;
}
