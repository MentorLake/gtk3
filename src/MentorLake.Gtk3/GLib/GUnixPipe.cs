namespace MentorLake.GLib;

public class GUnixPipeHandle : BaseSafeHandle
{
}


public static class GUnixPipeExtensions
{

	public static GUnixPipe Dereference(this GUnixPipeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixPipe>(x.DangerousGetHandle());
}
internal class GUnixPipeExterns
{
}

public struct GUnixPipe
{
	[MarshalAs(UnmanagedType.ByValArray)] public int[] fds;
}
