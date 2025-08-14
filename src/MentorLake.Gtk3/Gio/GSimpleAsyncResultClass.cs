namespace MentorLake.Gio;


public class GSimpleAsyncResultClassHandle : BaseSafeHandle
{
}


public static class GSimpleAsyncResultClassExtensions
{

	public static GSimpleAsyncResultClass Dereference(this GSimpleAsyncResultClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSimpleAsyncResultClass>(x.DangerousGetHandle());
}
internal class GSimpleAsyncResultClassExterns
{
}


public struct GSimpleAsyncResultClass
{
}
