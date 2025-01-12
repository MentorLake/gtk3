namespace MentorLake.Gtk3.Gdk3;

public class GdkAtomHandle : BaseSafeHandle
{
}


public static class GdkAtomHandleExtensions
{
	public static string Name(this GdkAtom atom)
	{
		return GdkAtomExterns.gdk_atom_name(atom);
	}

}
internal class GdkAtomExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern string gdk_atom_name(GdkAtom atom);

}

public struct GdkAtom
{
}
