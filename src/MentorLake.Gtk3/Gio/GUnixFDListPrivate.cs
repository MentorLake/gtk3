namespace MentorLake.Gio;


public class GUnixFDListPrivateHandle : BaseSafeHandle
{
}


public static class GUnixFDListPrivateExtensions
{

	public static GUnixFDListPrivate Dereference(this GUnixFDListPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixFDListPrivate>(x.DangerousGetHandle());
}
internal class GUnixFDListPrivateExterns
{
}


public struct GUnixFDListPrivate
{
}
