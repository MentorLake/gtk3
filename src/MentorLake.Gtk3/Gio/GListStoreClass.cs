namespace MentorLake.Gio;


public class GListStoreClassHandle : BaseSafeHandle
{
}


public static class GListStoreClassExtensions
{

	public static GListStoreClass Dereference(this GListStoreClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GListStoreClass>(x.DangerousGetHandle());
}
internal class GListStoreClassExterns
{
}


public struct GListStoreClass
{
	
public GObjectClass parent_class;
}
