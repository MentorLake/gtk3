namespace MentorLake.GObject;


public class GClosureNotifyDataHandle : BaseSafeHandle
{
}


public static class GClosureNotifyDataExtensions
{

	public static GClosureNotifyData Dereference(this GClosureNotifyDataHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GClosureNotifyData>(x.DangerousGetHandle());
}
internal class GClosureNotifyDataExterns
{
}


public struct GClosureNotifyData
{
	
public IntPtr data;
	
public GClosureNotify notify;
}
