namespace MentorLake.GObject;

public struct GType
{
	public UIntPtr Value;
}

public class GTypeHandle : BaseSafeHandle
{
}

public static class GTypeHandleExtensions
{
	public static GType Dereference(this GTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GType>(x.DangerousGetHandle());
	public static UIntPtr DereferenceValue(this GTypeHandle x) => x.Dereference().Value;
}
