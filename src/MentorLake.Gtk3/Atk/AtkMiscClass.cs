namespace MentorLake.Atk;

public class AtkMiscClassHandle : BaseSafeHandle
{
}


public static class AtkMiscClassExtensions
{

	public static AtkMiscClass Dereference(this AtkMiscClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkMiscClass>(x.DangerousGetHandle());
}
internal class AtkMiscClassExterns
{
}

public struct AtkMiscClass
{
	public GObjectClass parent;
	public IntPtr threads_enter;
	public IntPtr threads_leave;
	public IntPtr vfuncs;
}
