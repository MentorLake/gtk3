namespace MentorLake.Gdk;

public class GdkAtomHandle : BaseSafeHandle
{
}


public static class GdkAtomExtensions
{
	public static string Name(this MentorLake.Gdk.GdkAtom atom)
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

public struct GdkAtom
{
	public static MentorLake.Gdk.GdkAtom Intern(string atom_name, bool only_if_exists)
	{
		return GdkAtomExterns.gdk_atom_intern(atom_name, only_if_exists);
	}

	public static MentorLake.Gdk.GdkAtom InternStaticString(string atom_name)
	{
		return GdkAtomExterns.gdk_atom_intern_static_string(atom_name);
	}

}
