namespace MentorLake.Gio;

public class GNetworkAddressClassHandle : BaseSafeHandle
{
}


public static class GNetworkAddressClassExtensions
{

	public static GNetworkAddressClass Dereference(this GNetworkAddressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNetworkAddressClass>(x.DangerousGetHandle());
}
internal class GNetworkAddressClassExterns
{
}

public struct GNetworkAddressClass
{
	public GObjectClass parent_class;
}
