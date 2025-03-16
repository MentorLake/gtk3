namespace MentorLake.Gio;

public class GSocketAddressClassHandle : BaseSafeHandle
{
}


public static class GSocketAddressClassExtensions
{

	public static GSocketAddressClass Dereference(this GSocketAddressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketAddressClass>(x.DangerousGetHandle());
}
internal class GSocketAddressClassExterns
{
}

public struct GSocketAddressClass
{
	public GObjectClass parent_class;
	public IntPtr get_family;
	public IntPtr get_native_size;
	public IntPtr to_native;
}
