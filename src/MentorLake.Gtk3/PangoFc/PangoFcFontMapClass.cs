namespace MentorLake.PangoFc;


public class PangoFcFontMapClassHandle : BaseSafeHandle
{
}


public static class PangoFcFontMapClassExtensions
{

	public static PangoFcFontMapClass Dereference(this PangoFcFontMapClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFcFontMapClass>(x.DangerousGetHandle());
}
internal class PangoFcFontMapClassExterns
{
}


public struct PangoFcFontMapClass
{
}
