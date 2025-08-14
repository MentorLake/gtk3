namespace MentorLake.xlib;


public class ScreenHandle : BaseSafeHandle
{
}


public static class ScreenExtensions
{

	public static Screen Dereference(this ScreenHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Screen>(x.DangerousGetHandle());
}
internal class ScreenExterns
{
}


public struct Screen
{
}
