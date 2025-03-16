namespace MentorLake.PangoFc;

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

public struct PangoFcDecoderClass
{
	public IntPtr get_charset;
	public IntPtr get_glyph;
	public IntPtr _pango_reserved1;
	public IntPtr _pango_reserved2;
	public IntPtr _pango_reserved3;
	public IntPtr _pango_reserved4;
}
