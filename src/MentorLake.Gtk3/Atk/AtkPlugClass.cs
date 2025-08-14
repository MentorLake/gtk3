namespace MentorLake.Atk;


public class AtkPlugClassHandle : BaseSafeHandle
{
}


public static class AtkPlugClassExtensions
{

	public static AtkPlugClass Dereference(this AtkPlugClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkPlugClass>(x.DangerousGetHandle());
}
internal class AtkPlugClassExterns
{
}


public struct AtkPlugClass
{
	
public AtkObjectClass parent_class;
	
public IntPtr get_object_id;
}
