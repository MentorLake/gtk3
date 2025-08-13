namespace MentorLake.GLib;

public class GTokenValueHandle : BaseSafeHandle
{
}


public static class GTokenValueExtensions
{

	public static GTokenValue Dereference(this GTokenValueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTokenValue>(x.DangerousGetHandle());
}
internal class GTokenValueExterns
{
}

public struct GTokenValue
{
	public IntPtr v_symbol;
	public string v_identifier;
	public ulong v_binary;
	public ulong v_octal;
	public ulong v_int;
	public ulong v_int64;
	public double v_float;
	public ulong v_hex;
	public string v_string;
	public string v_comment;
	public byte v_char;
	public uint v_error;
}
