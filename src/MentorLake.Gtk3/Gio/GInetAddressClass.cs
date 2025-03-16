namespace MentorLake.Gio;

public class GInetAddressClassHandle : BaseSafeHandle
{
}


public static class GInetAddressClassExtensions
{

	public static GInetAddressClass Dereference(this GInetAddressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInetAddressClass>(x.DangerousGetHandle());
}
internal class GInetAddressClassExterns
{
}

public struct GInetAddressClass
{
	public GObjectClass parent_class;
	public IntPtr to_string;
	public IntPtr to_bytes;
}
