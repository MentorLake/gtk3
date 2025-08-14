namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// An opaque type representing a string as an index into a table
/// of strings on the X server.
/// </para>
/// </summary>

public class GdkAtomHandle : BaseSafeHandle
{
}


public static class GdkAtomExtensions
{
/// <summary>
/// <para>
/// Determines the string corresponding to an atom.
/// </para>
/// </summary>

/// <param name="atom">
/// a #GdkAtom.
/// </param>
/// <return>
/// a newly-allocated string containing the string
///   corresponding to @atom. When you are done with the
///   return value, you should free it using g_free().
/// </return>

	public static string Name(MentorLake.Gdk.GdkAtom atom)
	{
		return GdkAtomExterns.gdk_atom_name(atom);
	}


	public static GdkAtom Dereference(this GdkAtomHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkAtom>(x.DangerousGetHandle());
}
internal class GdkAtomExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_atom_name(MentorLake.Gdk.GdkAtom atom);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gdk_atom_intern(string atom_name, bool only_if_exists);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gdk_atom_intern_static_string(string atom_name);

}

/// <summary>
/// <para>
/// An opaque type representing a string as an index into a table
/// of strings on the X server.
/// </para>
/// </summary>

public struct GdkAtom
{
/// <summary>
/// <para>
/// Finds or creates an atom corresponding to a given string.
/// </para>
/// </summary>

/// <param name="atom_name">
/// a string.
/// </param>
/// <param name="only_if_exists">
/// if %TRUE, GDK is allowed to not create a new atom, but
///   just return %GDK_NONE if the requested atom doesn’t already
///   exists. Currently, the flag is ignored, since checking the
///   existance of an atom is as expensive as creating it.
/// </param>
/// <return>
/// the atom corresponding to @atom_name.
/// </return>

	public static MentorLake.Gdk.GdkAtom Intern(string atom_name, bool only_if_exists)
	{
		return GdkAtomExterns.gdk_atom_intern(atom_name, only_if_exists);
	}

/// <summary>
/// <para>
/// Finds or creates an atom corresponding to a given string.
/// </para>
/// <para>
/// Note that this function is identical to gdk_atom_intern() except
/// that if a new #GdkAtom is created the string itself is used rather
/// than a copy. This saves memory, but can only be used if the string
/// will always exist. It can be used with statically
/// allocated strings in the main program, but not with statically
/// allocated memory in dynamically loaded modules, if you expect to
/// ever unload the module again (e.g. do not use this function in
/// GTK+ theme engines).
/// </para>
/// </summary>

/// <param name="atom_name">
/// a static string
/// </param>
/// <return>
/// the atom corresponding to @atom_name
/// </return>

	public static MentorLake.Gdk.GdkAtom InternStaticString(string atom_name)
	{
		return GdkAtomExterns.gdk_atom_intern_static_string(atom_name);
	}

}
