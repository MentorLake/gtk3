namespace MentorLake.Atk;

public class AtkObjectFactoryClassHandle : BaseSafeHandle
{
}


public static class AtkObjectFactoryClassExtensions
{

	public static AtkObjectFactoryClass Dereference(this AtkObjectFactoryClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkObjectFactoryClass>(x.DangerousGetHandle());
}
internal class AtkObjectFactoryClassExterns
{
}

public struct AtkObjectFactoryClass
{
	public GObjectClass parent_class;
	public IntPtr create_accessible;
	public IntPtr invalidate;
	public IntPtr get_accessible_type;
	public AtkFunction pad1;
	public AtkFunction pad2;
}
