namespace MentorLake.GLib;

public class GSourceCallbackFuncsHandle : BaseSafeHandle
{
}


public static class GSourceCallbackFuncsExtensions
{

	public static GSourceCallbackFuncs Dereference(this GSourceCallbackFuncsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSourceCallbackFuncs>(x.DangerousGetHandle());
}
internal class GSourceCallbackFuncsExterns
{
}

public struct GSourceCallbackFuncs
{
	public IntPtr @ref;
	public IntPtr unref;
	public IntPtr get;
}
