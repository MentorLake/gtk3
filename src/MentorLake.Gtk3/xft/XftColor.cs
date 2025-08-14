namespace MentorLake.xft;


public class XftColorHandle : BaseSafeHandle
{
}


public static class XftColorExtensions
{

	public static XftColor Dereference(this XftColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XftColor>(x.DangerousGetHandle());
}
internal class XftColorExterns
{
}


public struct XftColor
{
}
