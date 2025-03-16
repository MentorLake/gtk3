namespace MentorLake.GObject;

public class _Value__data__unionHandle : BaseSafeHandle
{
}


public static class _Value__data__unionExtensions
{

	public static _Value__data__union Dereference(this _Value__data__unionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<_Value__data__union>(x.DangerousGetHandle());
}
internal class _Value__data__unionExterns
{
}

public struct _Value__data__union
{
	public int v_int;
	public uint v_uint;
	public long v_long;
	public ulong v_ulong;
	public long v_int64;
	public ulong v_uint64;
	public float v_float;
	public double v_double;
	public IntPtr v_pointer;
}
