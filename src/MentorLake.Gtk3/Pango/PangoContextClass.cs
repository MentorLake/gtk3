namespace MentorLake.Pango;

public class PangoContextClassHandle : BaseSafeHandle
{
}


public static class PangoContextClassExtensions
{

	public static PangoContextClass Dereference(this PangoContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoContextClass>(x.DangerousGetHandle());
}
internal class PangoContextClassExterns
{
}

public struct PangoContextClass
{
}
