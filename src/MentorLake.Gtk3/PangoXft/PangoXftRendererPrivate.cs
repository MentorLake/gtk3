namespace MentorLake.PangoXft;


public class PangoXftRendererPrivateHandle : BaseSafeHandle
{
}


public static class PangoXftRendererPrivateExtensions
{

	public static PangoXftRendererPrivate Dereference(this PangoXftRendererPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoXftRendererPrivate>(x.DangerousGetHandle());
}
internal class PangoXftRendererPrivateExterns
{
}


public struct PangoXftRendererPrivate
{
}
