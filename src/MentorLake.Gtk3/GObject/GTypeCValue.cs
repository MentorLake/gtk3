namespace MentorLake.GObject;

public class GTypeCValueHandle : BaseSafeHandle
{
}


public static class GTypeCValueExtensions
{

	public static GTypeCValue Dereference(this GTypeCValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeCValue>(x.DangerousGetHandle());
}
internal class GTypeCValueExterns
{
}

public struct GTypeCValue
{
	public int v_int;
	public long v_long;
	public long v_int64;
	public double v_double;
	public IntPtr v_pointer;
}
