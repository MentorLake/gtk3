namespace MentorLake.Gio;

public class GProxyAddressEnumeratorClassHandle : BaseSafeHandle
{
}


public static class GProxyAddressEnumeratorClassExtensions
{

	public static GProxyAddressEnumeratorClass Dereference(this GProxyAddressEnumeratorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyAddressEnumeratorClass>(x.DangerousGetHandle());
}
internal class GProxyAddressEnumeratorClassExterns
{
}

public struct GProxyAddressEnumeratorClass
{
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
}
