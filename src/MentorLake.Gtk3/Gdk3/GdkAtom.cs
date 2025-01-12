namespace MentorLake.Gtk3.Gdk3;

public class GdkAtomHandle : BaseSafeHandle
{
}


public static class GdkAtomHandleExtensions
{
	public static string Name(GdkAtom atom)
	{
		return GdkAtomExterns.gdk_atom_name(atom);
	}

	public static GdkAtom Intern(string atom_name, bool only_if_exists)
	{
		return GdkAtomExterns.gdk_atom_intern(atom_name, only_if_exists);
	}

	public static GdkAtom InternStaticString(string atom_name)
	{
		return GdkAtomExterns.gdk_atom_intern_static_string(atom_name);
	}

}
internal class GdkAtomExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern string gdk_atom_name(GdkAtom atom);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkAtom gdk_atom_intern(string atom_name, bool only_if_exists);

	[DllImport(Libraries.Gdk3)]
	internal static extern GdkAtom gdk_atom_intern_static_string(string atom_name);

}

public struct GdkAtom
{
}
