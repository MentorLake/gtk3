namespace MentorLake.Gio;

public class GNativeSocketAddressClassHandle : BaseSafeHandle
{
}


public static class GNativeSocketAddressClassExtensions
{

	public static GNativeSocketAddressClass Dereference(this GNativeSocketAddressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNativeSocketAddressClass>(x.DangerousGetHandle());
}
internal class GNativeSocketAddressClassExterns
{
}

public struct GNativeSocketAddressClass
{
	public GSocketAddressClass parent_class;
}
