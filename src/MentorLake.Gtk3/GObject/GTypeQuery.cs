namespace MentorLake.GObject;

public class GTypeQueryHandle : BaseSafeHandle
{
}


public static class GTypeQueryExtensions
{

	public static GTypeQuery Dereference(this GTypeQueryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeQuery>(x.DangerousGetHandle());
}
internal class GTypeQueryExterns
{
}

public struct GTypeQuery
{
	public GType type;
	public string type_name;
	public uint class_size;
	public uint instance_size;
}
