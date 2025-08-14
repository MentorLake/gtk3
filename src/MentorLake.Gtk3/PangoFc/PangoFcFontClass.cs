namespace MentorLake.PangoFc;


public class PangoFcFontClassHandle : BaseSafeHandle
{
}


public static class PangoFcFontClassExtensions
{

	public static PangoFcFontClass Dereference(this PangoFcFontClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFcFontClass>(x.DangerousGetHandle());
}
internal class PangoFcFontClassExterns
{
}


public struct PangoFcFontClass
{
}
