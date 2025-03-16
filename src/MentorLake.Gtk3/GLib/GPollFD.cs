namespace MentorLake.GLib;

public class GPollFDHandle : BaseSafeHandle
{
}


public static class GPollFDExtensions
{

	public static GPollFD Dereference(this GPollFDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPollFD>(x.DangerousGetHandle());
}
internal class GPollFDExterns
{
}

public struct GPollFD
{
	public int fd;
	public ushort events;
	public ushort revents;
}
