namespace MentorLake.Gio;


public class GIOStreamAdapterHandle : BaseSafeHandle
{
}


public static class GIOStreamAdapterExtensions
{

	public static GIOStreamAdapter Dereference(this GIOStreamAdapterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOStreamAdapter>(x.DangerousGetHandle());
}
internal class GIOStreamAdapterExterns
{
}


public struct GIOStreamAdapter
{
}
