namespace MentorLake.Gio;

public class GFileAttributeInfoHandle : BaseSafeHandle
{
}


public static class GFileAttributeInfoExtensions
{

	public static GFileAttributeInfo Dereference(this GFileAttributeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileAttributeInfo>(x.DangerousGetHandle());
}
internal class GFileAttributeInfoExterns
{
}

public struct GFileAttributeInfo
{
	public string name;
	public GFileAttributeType type;
	public GFileAttributeInfoFlags flags;
}
