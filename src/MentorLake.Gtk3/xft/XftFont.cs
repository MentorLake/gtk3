namespace MentorLake.xft;

public class XftFontHandle : BaseSafeHandle
{
}


public static class XftFontExtensions
{

	public static XftFont Dereference(this XftFontHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XftFont>(x.DangerousGetHandle());
}
internal class XftFontExterns
{
}

public struct XftFont
{
}
