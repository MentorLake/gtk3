namespace MentorLake.Pango;


public class PangoFontsetSimpleClassHandle : BaseSafeHandle
{
}


public static class PangoFontsetSimpleClassExtensions
{

	public static PangoFontsetSimpleClass Dereference(this PangoFontsetSimpleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFontsetSimpleClass>(x.DangerousGetHandle());
}
internal class PangoFontsetSimpleClassExterns
{
}


public struct PangoFontsetSimpleClass
{
}
