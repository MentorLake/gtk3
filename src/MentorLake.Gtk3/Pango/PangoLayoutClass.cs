namespace MentorLake.Pango;

public class PangoLayoutClassHandle : BaseSafeHandle
{
}


public static class PangoLayoutClassExtensions
{

	public static PangoLayoutClass Dereference(this PangoLayoutClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoLayoutClass>(x.DangerousGetHandle());
}
internal class PangoLayoutClassExterns
{
}

public struct PangoLayoutClass
{
}
