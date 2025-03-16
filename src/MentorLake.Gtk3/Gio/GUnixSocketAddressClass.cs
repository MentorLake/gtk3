namespace MentorLake.Gio;

public class GUnixSocketAddressClassHandle : BaseSafeHandle
{
}


public static class GUnixSocketAddressClassExtensions
{

	public static GUnixSocketAddressClass Dereference(this GUnixSocketAddressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixSocketAddressClass>(x.DangerousGetHandle());
}
internal class GUnixSocketAddressClassExterns
{
}

public struct GUnixSocketAddressClass
{
	public GSocketAddressClass parent_class;
}
