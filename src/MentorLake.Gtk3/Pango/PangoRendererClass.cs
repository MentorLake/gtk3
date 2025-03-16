namespace MentorLake.Pango;

public class PangoRendererClassHandle : BaseSafeHandle
{
}


public static class PangoRendererClassExtensions
{

	public static PangoRendererClass Dereference(this PangoRendererClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoRendererClass>(x.DangerousGetHandle());
}
internal class PangoRendererClassExterns
{
}

public struct PangoRendererClass
{
	public IntPtr draw_glyphs;
	public IntPtr draw_rectangle;
	public IntPtr draw_error_underline;
	public IntPtr draw_shape;
	public IntPtr draw_trapezoid;
	public IntPtr draw_glyph;
	public IntPtr part_changed;
	public IntPtr begin;
	public IntPtr end;
	public IntPtr prepare_run;
	public IntPtr draw_glyph_item;
	public IntPtr _pango_reserved2;
	public IntPtr _pango_reserved3;
	public IntPtr _pango_reserved4;
}
