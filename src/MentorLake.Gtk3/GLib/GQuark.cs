namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A GQuark is a non-zero integer which uniquely identifies a
/// particular string.
/// </para>
/// <para>
/// A GQuark value of zero is associated to `NULL`.
/// </para>
/// <para>
/// Given either the string or the `GQuark` identifier it is possible to
/// retrieve the other.
/// </para>
/// <para>
/// Quarks are used for both
/// [datasets and keyed data lists](datalist-and-dataset.html).
/// </para>
/// <para>
/// To create a new quark from a string, use [func@GLib.quark_from_string]
/// or [func@GLib.quark_from_static_string].
/// </para>
/// <para>
/// To find the string corresponding to a given `GQuark`, use
/// [func@GLib.quark_to_string].
/// </para>
/// <para>
/// To find the `GQuark` corresponding to a given string, use
/// [func@GLib.quark_try_string].
/// </para>
/// <para>
/// Another use for the string pool maintained for the quark functions
/// is string interning, using [func@GLib.intern_string] or
/// [func@GLib.intern_static_string]. An interned string is a canonical
/// representation for a string. One important advantage of interned
/// strings is that they can be compared for equality by a simple
/// pointer comparison, rather than using `strcmp()`.
/// </para>
/// </summary>

public struct GQuark
{
	public uint Value;
}

/// <summary>
/// <para>
/// A GQuark is a non-zero integer which uniquely identifies a
/// particular string.
/// </para>
/// <para>
/// A GQuark value of zero is associated to `NULL`.
/// </para>
/// <para>
/// Given either the string or the `GQuark` identifier it is possible to
/// retrieve the other.
/// </para>
/// <para>
/// Quarks are used for both
/// [datasets and keyed data lists](datalist-and-dataset.html).
/// </para>
/// <para>
/// To create a new quark from a string, use [func@GLib.quark_from_string]
/// or [func@GLib.quark_from_static_string].
/// </para>
/// <para>
/// To find the string corresponding to a given `GQuark`, use
/// [func@GLib.quark_to_string].
/// </para>
/// <para>
/// To find the `GQuark` corresponding to a given string, use
/// [func@GLib.quark_try_string].
/// </para>
/// <para>
/// Another use for the string pool maintained for the quark functions
/// is string interning, using [func@GLib.intern_string] or
/// [func@GLib.intern_static_string]. An interned string is a canonical
/// representation for a string. One important advantage of interned
/// strings is that they can be compared for equality by a simple
/// pointer comparison, rather than using `strcmp()`.
/// </para>
/// </summary>

public class GQuarkHandle : BaseSafeHandle
{
}

public static class GQuarkHandleExtensions
{
	public static GQuark Dereference(this GQuarkHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GQuark>(x.DangerousGetHandle());
	public static uint DereferenceValue(this GQuarkHandle x) => x.Dereference().Value;
}
