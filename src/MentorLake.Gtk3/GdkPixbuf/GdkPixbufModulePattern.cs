namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// The signature prefix for a module.
/// </para>
/// <para>
/// The signature of a module is a set of prefixes. Prefixes are encoded as
/// pairs of ordinary strings, where the second string, called the mask, if
/// not `NULL`, must be of the same length as the first one and may contain
/// ' ', '!', 'x', 'z', and 'n' to indicate bytes that must be matched,
/// not matched, "don't-care"-bytes, zeros and non-zeros, respectively.
/// </para>
/// <para>
/// Each prefix has an associated integer that describes the relevance of
/// the prefix, with 0 meaning a mismatch and 100 a "perfect match".
/// </para>
/// <para>
/// Starting with gdk-pixbuf 2.8, the first byte of the mask may be '*',
/// indicating an unanchored pattern that matches not only at the beginning,
/// but also in the middle. Versions prior to 2.8 will interpret the '*'
/// like an 'x'.
/// </para>
/// <para>
/// The signature of a module is stored as an array of
/// `GdkPixbufModulePatterns`. The array is terminated by a pattern
/// where the `prefix` is `NULL`.
/// </para>
/// <para>
/// ```c
/// GdkPixbufModulePattern *signature[] = {
///   { "abcdx", " !x z", 100 },
///   { "bla", NULL,  90 },
///   { NULL, NULL, 0 }
/// };
/// ```
/// </para>
/// <para>
/// In the example above, the signature matches e.g. "auud\0" with
/// relevance 100, and "blau" with relevance 90.
/// </para>
/// </summary>

public class GdkPixbufModulePatternHandle : BaseSafeHandle
{
}


public static class GdkPixbufModulePatternExtensions
{

	public static GdkPixbufModulePattern Dereference(this GdkPixbufModulePatternHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufModulePattern>(x.DangerousGetHandle());
}
internal class GdkPixbufModulePatternExterns
{
}

/// <summary>
/// <para>
/// The signature prefix for a module.
/// </para>
/// <para>
/// The signature of a module is a set of prefixes. Prefixes are encoded as
/// pairs of ordinary strings, where the second string, called the mask, if
/// not `NULL`, must be of the same length as the first one and may contain
/// ' ', '!', 'x', 'z', and 'n' to indicate bytes that must be matched,
/// not matched, "don't-care"-bytes, zeros and non-zeros, respectively.
/// </para>
/// <para>
/// Each prefix has an associated integer that describes the relevance of
/// the prefix, with 0 meaning a mismatch and 100 a "perfect match".
/// </para>
/// <para>
/// Starting with gdk-pixbuf 2.8, the first byte of the mask may be '*',
/// indicating an unanchored pattern that matches not only at the beginning,
/// but also in the middle. Versions prior to 2.8 will interpret the '*'
/// like an 'x'.
/// </para>
/// <para>
/// The signature of a module is stored as an array of
/// `GdkPixbufModulePatterns`. The array is terminated by a pattern
/// where the `prefix` is `NULL`.
/// </para>
/// <para>
/// ```c
/// GdkPixbufModulePattern *signature[] = {
///   { "abcdx", " !x z", 100 },
///   { "bla", NULL,  90 },
///   { NULL, NULL, 0 }
/// };
/// ```
/// </para>
/// <para>
/// In the example above, the signature matches e.g. "auud\0" with
/// relevance 100, and "blau" with relevance 90.
/// </para>
/// </summary>

public struct GdkPixbufModulePattern
{
	/// <summary>
/// <para>
/// the prefix for this pattern
/// </para>
/// </summary>

public string prefix;
	/// <summary>
/// <para>
/// mask containing bytes which modify how the prefix is matched against
///  test data
/// </para>
/// </summary>

public string mask;
	/// <summary>
/// <para>
/// relevance of this pattern
/// </para>
/// </summary>

public int relevance;
}
