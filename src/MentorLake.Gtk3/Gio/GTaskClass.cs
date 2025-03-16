namespace MentorLake.Gio;

public class GTaskClassHandle : BaseSafeHandle
{
}


public static class GTaskClassExtensions
{

	public static GTaskClass Dereference(this GTaskClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTaskClass>(x.DangerousGetHandle());
}
internal class GTaskClassExterns
{
}

public struct GTaskClass
{
}
