namespace MentorLake.Gio;


public class GUnixConnectionClassHandle : BaseSafeHandle
{
}


public static class GUnixConnectionClassExtensions
{

	public static GUnixConnectionClass Dereference(this GUnixConnectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixConnectionClass>(x.DangerousGetHandle());
}
internal class GUnixConnectionClassExterns
{
}


public struct GUnixConnectionClass
{
	
public GSocketConnectionClass parent_class;
}
