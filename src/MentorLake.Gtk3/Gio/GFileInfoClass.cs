namespace MentorLake.Gio;

public class GFileInfoClassHandle : BaseSafeHandle
{
}


public static class GFileInfoClassExtensions
{

	public static GFileInfoClass Dereference(this GFileInfoClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileInfoClass>(x.DangerousGetHandle());
}
internal class GFileInfoClassExterns
{
}

public struct GFileInfoClass
{
}
