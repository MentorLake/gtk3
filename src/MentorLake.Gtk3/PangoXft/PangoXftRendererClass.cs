namespace MentorLake.PangoXft;

public class PangoXftRendererClassHandle : BaseSafeHandle
{
}


public static class PangoXftRendererClassExtensions
{

	public static PangoXftRendererClass Dereference(this PangoXftRendererClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoXftRendererClass>(x.DangerousGetHandle());
}
internal class PangoXftRendererClassExterns
{
}

public struct PangoXftRendererClass
{
	public IntPtr composite_trapezoids;
	public IntPtr composite_glyphs;
}
