namespace MentorLake.Gio;

public class GFileIconClassHandle : BaseSafeHandle
{
}


public static class GFileIconClassExtensions
{

	public static GFileIconClass Dereference(this GFileIconClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileIconClass>(x.DangerousGetHandle());
}
internal class GFileIconClassExterns
{
}

public struct GFileIconClass
{
}
