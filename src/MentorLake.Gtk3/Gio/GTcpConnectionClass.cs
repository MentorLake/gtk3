namespace MentorLake.Gio;

public class GTcpConnectionClassHandle : BaseSafeHandle
{
}


public static class GTcpConnectionClassExtensions
{

	public static GTcpConnectionClass Dereference(this GTcpConnectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTcpConnectionClass>(x.DangerousGetHandle());
}
internal class GTcpConnectionClassExterns
{
}

public struct GTcpConnectionClass
{
	public GSocketConnectionClass parent_class;
}
