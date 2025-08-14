namespace MentorLake.xft;


public class XftDrawHandle : BaseSafeHandle
{
}


public static class XftDrawExtensions
{

	public static XftDraw Dereference(this XftDrawHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XftDraw>(x.DangerousGetHandle());
}
internal class XftDrawExterns
{
}


public struct XftDraw
{
}
