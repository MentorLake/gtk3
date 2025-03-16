namespace MentorLake.GLib;

public class GSourceFuncsHandle : BaseSafeHandle
{
}


public static class GSourceFuncsExtensions
{

	public static GSourceFuncs Dereference(this GSourceFuncsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSourceFuncs>(x.DangerousGetHandle());
}
internal class GSourceFuncsExterns
{
}

public struct GSourceFuncs
{
	public GSourceFuncsPrepareFunc prepare;
	public GSourceFuncsCheckFunc check;
	public GSourceFuncsDispatchFunc dispatch;
	public GSourceFuncsFinalizeFunc finalize;
}
