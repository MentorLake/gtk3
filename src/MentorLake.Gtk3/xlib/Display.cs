namespace MentorLake.xlib;

public class DisplayHandle : BaseSafeHandle
{
}


public static class DisplayExtensions
{

	public static Display Dereference(this DisplayHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Display>(x.DangerousGetHandle());
}
internal class DisplayExterns
{
}

public struct Display
{
}
