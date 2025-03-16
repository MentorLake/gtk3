namespace MentorLake.Gio;

public class GProxyAddressClassHandle : BaseSafeHandle
{
}


public static class GProxyAddressClassExtensions
{

	public static GProxyAddressClass Dereference(this GProxyAddressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyAddressClass>(x.DangerousGetHandle());
}
internal class GProxyAddressClassExterns
{
}

public struct GProxyAddressClass
{
	public GInetSocketAddressClass parent_class;
}
