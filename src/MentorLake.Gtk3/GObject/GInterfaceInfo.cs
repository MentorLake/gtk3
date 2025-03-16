namespace MentorLake.GObject;

public class GInterfaceInfoHandle : BaseSafeHandle
{
}


public static class GInterfaceInfoExtensions
{

	public static GInterfaceInfo Dereference(this GInterfaceInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInterfaceInfo>(x.DangerousGetHandle());
}
internal class GInterfaceInfoExterns
{
}

public struct GInterfaceInfo
{
	public GInterfaceInitFunc interface_init;
	public GInterfaceFinalizeFunc interface_finalize;
	public IntPtr interface_data;
}
