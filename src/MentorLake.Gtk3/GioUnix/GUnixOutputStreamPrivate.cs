namespace MentorLake.GioUnix;


public class GUnixOutputStreamPrivateHandle : BaseSafeHandle
{
}


public static class GUnixOutputStreamPrivateExtensions
{

	public static GUnixOutputStreamPrivate Dereference(this GUnixOutputStreamPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixOutputStreamPrivate>(x.DangerousGetHandle());
}
internal class GUnixOutputStreamPrivateExterns
{
}


public struct GUnixOutputStreamPrivate
{
}
