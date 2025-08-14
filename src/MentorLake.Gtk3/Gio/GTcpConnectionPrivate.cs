namespace MentorLake.Gio;


public class GTcpConnectionPrivateHandle : BaseSafeHandle
{
}


public static class GTcpConnectionPrivateExtensions
{

	public static GTcpConnectionPrivate Dereference(this GTcpConnectionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTcpConnectionPrivate>(x.DangerousGetHandle());
}
internal class GTcpConnectionPrivateExterns
{
}


public struct GTcpConnectionPrivate
{
}
