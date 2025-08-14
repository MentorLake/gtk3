namespace MentorLake.Gio;


public class GUnixConnectionPrivateHandle : BaseSafeHandle
{
}


public static class GUnixConnectionPrivateExtensions
{

	public static GUnixConnectionPrivate Dereference(this GUnixConnectionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixConnectionPrivate>(x.DangerousGetHandle());
}
internal class GUnixConnectionPrivateExterns
{
}


public struct GUnixConnectionPrivate
{
}
