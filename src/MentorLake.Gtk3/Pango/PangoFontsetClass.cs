namespace MentorLake.Pango;

public class PangoFontsetClassHandle : BaseSafeHandle
{
}


public static class PangoFontsetClassExtensions
{

	public static PangoFontsetClass Dereference(this PangoFontsetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontsetClass>(x.DangerousGetHandle());
}
internal class PangoFontsetClassExterns
{
}

public struct PangoFontsetClass
{
	public GObjectClass parent_class;
	public IntPtr get_font;
	public IntPtr get_metrics;
	public IntPtr get_language;
	public IntPtr @foreach;
	public IntPtr _pango_reserved1;
	public IntPtr _pango_reserved2;
	public IntPtr _pango_reserved3;
	public IntPtr _pango_reserved4;
}
