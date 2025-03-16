namespace MentorLake.Gio;

public class GInetSocketAddressClassHandle : BaseSafeHandle
{
}


public static class GInetSocketAddressClassExtensions
{

	public static GInetSocketAddressClass Dereference(this GInetSocketAddressClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInetSocketAddressClass>(x.DangerousGetHandle());
}
internal class GInetSocketAddressClassExterns
{
}

public struct GInetSocketAddressClass
{
	public GSocketAddressClass parent_class;
}
