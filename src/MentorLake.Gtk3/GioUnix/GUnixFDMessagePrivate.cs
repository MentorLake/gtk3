namespace MentorLake.GioUnix;

public class GUnixFDMessagePrivateHandle : BaseSafeHandle
{
}


public static class GUnixFDMessagePrivateExtensions
{

	public static GUnixFDMessagePrivate Dereference(this GUnixFDMessagePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixFDMessagePrivate>(x.DangerousGetHandle());
}
internal class GUnixFDMessagePrivateExterns
{
}

public struct GUnixFDMessagePrivate
{
}
