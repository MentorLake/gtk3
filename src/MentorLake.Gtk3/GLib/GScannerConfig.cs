namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the #GScanner parser configuration. Most settings can
/// be changed during the parsing phase and will affect the lexical
/// parsing of the next unpeeked token.
/// </para>
/// </summary>

public class GScannerConfigHandle : BaseSafeHandle
{
}


public static class GScannerConfigExtensions
{

	public static GScannerConfig Dereference(this GScannerConfigHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GScannerConfig>(x.DangerousGetHandle());
}
internal class GScannerConfigExterns
{
}

/// <summary>
/// <para>
/// Specifies the #GScanner parser configuration. Most settings can
/// be changed during the parsing phase and will affect the lexical
/// parsing of the next unpeeked token.
/// </para>
/// </summary>

public struct GScannerConfig
{
	/// <summary>
/// <para>
/// specifies which characters should be skipped
///     by the scanner (the default is the whitespace characters: space,
///     tab, carriage-return and line-feed).
/// </para>
/// </summary>

public string cset_skip_characters;
	/// <summary>
/// <para>
/// specifies the characters which can start
///     identifiers (the default is %G_CSET_a_2_z, &quot;_&quot;, and %G_CSET_A_2_Z).
/// </para>
/// </summary>

public string cset_identifier_first;
	/// <summary>
/// <para>
/// specifies the characters which can be used
///     in identifiers, after the first character (the default is
///     %G_CSET_a_2_z, &quot;_0123456789&quot;, %G_CSET_A_2_Z, %G_CSET_LATINS,
///     %G_CSET_LATINC).
/// </para>
/// </summary>

public string cset_identifier_nth;
	/// <summary>
/// <para>
/// specifies the characters at the start and
///     end of single-line comments. The default is &quot;#\n&quot; which means
///     that single-line comments start with a &apos;#&apos; and continue until
///     a &apos;\n&apos; (end of line).
/// </para>
/// </summary>

public string cpair_comment_single;
	/// <summary>
/// <para>
/// specifies if symbols are case sensitive (the
///     default is %FALSE).
/// </para>
/// </summary>

public uint case_sensitive;
	/// <summary>
/// <para>
/// specifies if multi-line comments are skipped
///     and not returned as tokens (the default is %TRUE).
/// </para>
/// </summary>

public uint skip_comment_multi;
	/// <summary>
/// <para>
/// specifies if single-line comments are skipped
///     and not returned as tokens (the default is %TRUE).
/// </para>
/// </summary>

public uint skip_comment_single;
	/// <summary>
/// <para>
/// specifies if multi-line comments are recognized
///     (the default is %TRUE).
/// </para>
/// </summary>

public uint scan_comment_multi;
	/// <summary>
/// <para>
/// specifies if identifiers are recognized (the
///     default is %TRUE).
/// </para>
/// </summary>

public uint scan_identifier;
	/// <summary>
/// <para>
/// specifies if single-character
///     identifiers are recognized (the default is %FALSE).
/// </para>
/// </summary>

public uint scan_identifier_1char;
	/// <summary>
/// <para>
/// specifies if %NULL is reported as
///     %G_TOKEN_IDENTIFIER_NULL (the default is %FALSE).
/// </para>
/// </summary>

public uint scan_identifier_NULL;
	/// <summary>
/// <para>
/// specifies if symbols are recognized (the default
///     is %TRUE).
/// </para>
/// </summary>

public uint scan_symbols;
	/// <summary>
/// <para>
/// specifies if binary numbers are recognized (the
///     default is %FALSE).
/// </para>
/// </summary>

public uint scan_binary;
	/// <summary>
/// <para>
/// specifies if octal numbers are recognized (the
///     default is %TRUE).
/// </para>
/// </summary>

public uint scan_octal;
	/// <summary>
/// <para>
/// specifies if floating point numbers are recognized
///     (the default is %TRUE).
/// </para>
/// </summary>

public uint scan_float;
	/// <summary>
/// <para>
/// specifies if hexadecimal numbers are recognized (the
///     default is %TRUE).
/// </para>
/// </summary>

public uint scan_hex;
	/// <summary>
/// <para>
/// specifies if &apos;$&apos; is recognized as a prefix for
///     hexadecimal numbers (the default is %FALSE).
/// </para>
/// </summary>

public uint scan_hex_dollar;
	/// <summary>
/// <para>
/// specifies if strings can be enclosed in single
///     quotes (the default is %TRUE).
/// </para>
/// </summary>

public uint scan_string_sq;
	/// <summary>
/// <para>
/// specifies if strings can be enclosed in double
///     quotes (the default is %TRUE).
/// </para>
/// </summary>

public uint scan_string_dq;
	/// <summary>
/// <para>
/// specifies if binary, octal and hexadecimal numbers
///     are reported as %G_TOKEN_INT (the default is %TRUE).
/// </para>
/// </summary>

public uint numbers_2_int;
	/// <summary>
/// <para>
/// specifies if all numbers are reported as %G_TOKEN_FLOAT
///     (the default is %FALSE).
/// </para>
/// </summary>

public uint int_2_float;
	/// <summary>
/// <para>
/// specifies if identifiers are reported as strings
///     (the default is %FALSE).
/// </para>
/// </summary>

public uint identifier_2_string;
	/// <summary>
/// <para>
/// specifies if characters are reported by setting
///     `token = ch` or as %G_TOKEN_CHAR (the default is %TRUE).
/// </para>
/// </summary>

public uint char_2_token;
	/// <summary>
/// <para>
/// specifies if symbols are reported by setting
///     `token = v_symbol` or as %G_TOKEN_SYMBOL (the default is %FALSE).
/// </para>
/// </summary>

public uint symbol_2_token;
	/// <summary>
/// <para>
/// specifies if a symbol is searched for in the
///     default scope in addition to the current scope (the default is %FALSE).
/// </para>
/// </summary>

public uint scope_0_fallback;
	/// <summary>
/// <para>
/// use value.v_int64 rather than v_int
/// </para>
/// </summary>

public uint store_int64;
}
