namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GPatternSpec` struct is the ‘compiled’ form of a glob-style pattern.
/// </para>
/// <para>
/// The [func@GLib.pattern_match_simple] and [method@GLib.PatternSpec.match] functions
/// match a string against a pattern containing `*` and `?` wildcards with similar
/// semantics as the standard `glob()` function: `*` matches an arbitrary,
/// possibly empty, string, `?` matches an arbitrary character.
/// </para>
/// <para>
/// Note that in contrast to <see href="man:glob(3">glob()</see>), the `/` character can be
/// matched by the wildcards, there are no `[…]` character ranges and `*` and `?`
/// can not be escaped to include them literally in a pattern.
/// </para>
/// <para>
/// When multiple strings must be matched against the same pattern, it is better
/// to compile the pattern to a [struct@GLib.PatternSpec] using
/// [ctor@GLib.PatternSpec.new] and use [method@GLib.PatternSpec.match_string]
/// instead of [func@GLib.pattern_match_simple]. This avoids the overhead of repeated
/// pattern compilation.
/// </para>
/// </summary>

public class GPatternSpecHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Compiles a pattern to a [type@GLib.PatternSpec].
/// </para>
/// </summary>

/// <param name="pattern">
/// a zero-terminated UTF-8 encoded string
/// </param>
/// <return>
/// a newly-allocated [type@GLib.PatternSpec]
/// </return>

	public static MentorLake.GLib.GPatternSpecHandle New(string pattern)
	{
		return GPatternSpecExterns.g_pattern_spec_new(pattern);
	}

}


public static class GPatternSpecExtensions
{
/// <summary>
/// <para>
/// Copies @pspec in a new [type@GLib.PatternSpec].
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GPatternSpec
/// </param>
/// <return>
/// a copy of @pspec.
/// </return>

	public static MentorLake.GLib.GPatternSpecHandle Copy(this MentorLake.GLib.GPatternSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GPatternSpec)");
		return GPatternSpecExterns.g_pattern_spec_copy(pspec);
	}

/// <summary>
/// <para>
/// Compares two compiled pattern specs and returns whether they will
/// match the same set of strings.
/// </para>
/// </summary>

/// <param name="pspec1">
/// a #GPatternSpec
/// </param>
/// <param name="pspec2">
/// another #GPatternSpec
/// </param>
/// <return>
/// Whether the compiled patterns are equal
/// </return>

	public static bool Equal(this MentorLake.GLib.GPatternSpecHandle pspec1, MentorLake.GLib.GPatternSpecHandle pspec2)
	{
		if (pspec1.IsInvalid) throw new Exception("Invalid handle (GPatternSpec)");
		return GPatternSpecExterns.g_pattern_spec_equal(pspec1, pspec2);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for the [type@GLib.PatternSpec].
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GPatternSpec
/// </param>

	public static void Free(this MentorLake.GLib.GPatternSpecHandle pspec)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GPatternSpec)");
		GPatternSpecExterns.g_pattern_spec_free(pspec);
	}

/// <summary>
/// <para>
/// Matches a string against a compiled pattern.
/// </para>
/// <para>
/// Passing the correct
/// length of the string given is mandatory. The reversed string can be
/// omitted by passing `NULL`, this is more efficient if the reversed
/// version of the string to be matched is not at hand, as
/// [method@GLib.PatternSpec.match] will only construct it if the compiled pattern
/// requires reverse matches.
/// </para>
/// <para>
/// Note that, if the user code will (possibly) match a string against a
/// multitude of patterns containing wildcards, chances are high that
/// some patterns will require a reversed string. In this case, it’s
/// more efficient to provide the reversed string to avoid multiple
/// constructions thereof in the various calls to [method@GLib.PatternSpec.match].
/// </para>
/// <para>
/// Note also that the reverse of a UTF-8 encoded string can in general
/// not be obtained by [func@GLib.strreverse]. This works only if the string
/// does not contain any multibyte characters. GLib offers the
/// [func@GLib.utf8_strreverse] function to reverse UTF-8 encoded strings.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GPatternSpec
/// </param>
/// <param name="string_length">
/// the length of @string (in bytes, i.e. `strlen()`,
///    not [func@GLib.utf8_strlen])
/// </param>
/// <param name="@string">
/// the UTF-8 encoded string to match
/// </param>
/// <param name="string_reversed">
/// the reverse of @string
/// </param>
/// <return>
/// %TRUE if @string matches @pspec
/// </return>

	public static bool Match(this MentorLake.GLib.GPatternSpecHandle pspec, UIntPtr string_length, string @string, string string_reversed)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GPatternSpec)");
		return GPatternSpecExterns.g_pattern_spec_match(pspec, string_length, @string, string_reversed);
	}

/// <summary>
/// <para>
/// Matches a string against a compiled pattern.
/// </para>
/// <para>
/// If the string is to be
/// matched against more than one pattern, consider using
/// [method@GLib.PatternSpec.match] instead while supplying the reversed string.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GPatternSpec
/// </param>
/// <param name="@string">
/// the UTF-8 encoded string to match
/// </param>
/// <return>
/// %TRUE if @string matches @pspec
/// </return>

	public static bool MatchString(this MentorLake.GLib.GPatternSpecHandle pspec, string @string)
	{
		if (pspec.IsInvalid) throw new Exception("Invalid handle (GPatternSpec)");
		return GPatternSpecExterns.g_pattern_spec_match_string(pspec, @string);
	}


	public static GPatternSpec Dereference(this GPatternSpecHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPatternSpec>(x.DangerousGetHandle());
}
internal class GPatternSpecExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))]
	internal static extern MentorLake.GLib.GPatternSpecHandle g_pattern_spec_new(string pattern);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))]
	internal static extern MentorLake.GLib.GPatternSpecHandle g_pattern_spec_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_spec_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec2);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pattern_spec_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_spec_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec, UIntPtr string_length, string @string, string string_reversed);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_spec_match_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec, string @string);

}

/// <summary>
/// <para>
/// A `GPatternSpec` struct is the ‘compiled’ form of a glob-style pattern.
/// </para>
/// <para>
/// The [func@GLib.pattern_match_simple] and [method@GLib.PatternSpec.match] functions
/// match a string against a pattern containing `*` and `?` wildcards with similar
/// semantics as the standard `glob()` function: `*` matches an arbitrary,
/// possibly empty, string, `?` matches an arbitrary character.
/// </para>
/// <para>
/// Note that in contrast to <see href="man:glob(3">glob()</see>), the `/` character can be
/// matched by the wildcards, there are no `[…]` character ranges and `*` and `?`
/// can not be escaped to include them literally in a pattern.
/// </para>
/// <para>
/// When multiple strings must be matched against the same pattern, it is better
/// to compile the pattern to a [struct@GLib.PatternSpec] using
/// [ctor@GLib.PatternSpec.new] and use [method@GLib.PatternSpec.match_string]
/// instead of [func@GLib.pattern_match_simple]. This avoids the overhead of repeated
/// pattern compilation.
/// </para>
/// </summary>

public struct GPatternSpec
{
}
