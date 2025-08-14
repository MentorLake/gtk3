namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A union holding the value of the token.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// A union holding the value of the token.
/// </para>
/// </summary>

public struct GTokenValue
{
	/// <summary>
/// <para>
/// token symbol value
/// </para>
/// </summary>

public IntPtr v_symbol;
	/// <summary>
/// <para>
/// token identifier value
/// </para>
/// </summary>

public string v_identifier;
	/// <summary>
/// <para>
/// token binary integer value
/// </para>
/// </summary>

public ulong v_binary;
	/// <summary>
/// <para>
/// octal integer value
/// </para>
/// </summary>

public ulong v_octal;
	/// <summary>
/// <para>
/// integer value
/// </para>
/// </summary>

public ulong v_int;
	/// <summary>
/// <para>
/// 64-bit integer value
/// </para>
/// </summary>

public ulong v_int64;
	/// <summary>
/// <para>
/// floating point value
/// </para>
/// </summary>

public double v_float;
	/// <summary>
/// <para>
/// hex integer value
/// </para>
/// </summary>

public ulong v_hex;
	/// <summary>
/// <para>
/// string value
/// </para>
/// </summary>

public string v_string;
	/// <summary>
/// <para>
/// comment value
/// </para>
/// </summary>

public string v_comment;
	/// <summary>
/// <para>
/// character value
/// </para>
/// </summary>

public byte v_char;
	/// <summary>
/// <para>
/// error value
/// </para>
/// </summary>

public uint v_error;
}
