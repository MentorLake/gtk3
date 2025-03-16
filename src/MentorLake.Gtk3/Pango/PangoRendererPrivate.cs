namespace MentorLake.Pango;

public class PangoRendererPrivateHandle : BaseSafeHandle
{
}


public static class PangoRendererPrivateExtensions
{

	public static PangoRendererPrivate Dereference(this PangoRendererPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoRendererPrivate>(x.DangerousGetHandle());
}
internal class PangoRendererPrivateExterns
{
}

public struct PangoRendererPrivate
{
}
