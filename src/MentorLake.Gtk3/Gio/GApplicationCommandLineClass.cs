namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The #GApplicationCommandLineClass-struct
/// contains private data only.
/// </para>
/// </summary>

public class GApplicationCommandLineClassHandle : BaseSafeHandle
{
}


public static class GApplicationCommandLineClassExtensions
{

	public static GApplicationCommandLineClass Dereference(this GApplicationCommandLineClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GApplicationCommandLineClass>(x.DangerousGetHandle());
}
internal class GApplicationCommandLineClassExterns
{
}

/// <summary>
/// <para>
/// The #GApplicationCommandLineClass-struct
/// contains private data only.
/// </para>
/// </summary>

public struct GApplicationCommandLineClass
{
	
public IntPtr print_literal;
	
public IntPtr printerr_literal;
	
public IntPtr get_stdin;
	
public IntPtr done;
}
