namespace MentorLake.Gio;


public class GThemedIconClassHandle : BaseSafeHandle
{
}


public static class GThemedIconClassExtensions
{

	public static GThemedIconClass Dereference(this GThemedIconClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThemedIconClass>(x.DangerousGetHandle());
}
internal class GThemedIconClassExterns
{
}


public struct GThemedIconClass
{
}
