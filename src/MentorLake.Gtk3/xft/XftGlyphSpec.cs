namespace MentorLake.xft;

public class XftGlyphSpecHandle : BaseSafeHandle
{
}


public static class XftGlyphSpecExtensions
{

	public static XftGlyphSpec Dereference(this XftGlyphSpecHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XftGlyphSpec>(x.DangerousGetHandle());
}
internal class XftGlyphSpecExterns
{
}

public struct XftGlyphSpec
{
}
