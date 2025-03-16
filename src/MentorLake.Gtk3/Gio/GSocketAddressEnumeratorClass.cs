namespace MentorLake.Gio;

public class GSocketAddressEnumeratorClassHandle : BaseSafeHandle
{
}


public static class GSocketAddressEnumeratorClassExtensions
{

	public static GSocketAddressEnumeratorClass Dereference(this GSocketAddressEnumeratorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketAddressEnumeratorClass>(x.DangerousGetHandle());
}
internal class GSocketAddressEnumeratorClassExterns
{
}

public struct GSocketAddressEnumeratorClass
{
	public IntPtr next;
	public IntPtr next_async;
	public IntPtr next_finish;
}
