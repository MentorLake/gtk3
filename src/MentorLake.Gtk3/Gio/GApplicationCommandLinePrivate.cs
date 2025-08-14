namespace MentorLake.Gio;


public class GApplicationCommandLinePrivateHandle : BaseSafeHandle
{
}


public static class GApplicationCommandLinePrivateExtensions
{

	public static GApplicationCommandLinePrivate Dereference(this GApplicationCommandLinePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GApplicationCommandLinePrivate>(x.DangerousGetHandle());
}
internal class GApplicationCommandLinePrivateExterns
{
}


public struct GApplicationCommandLinePrivate
{
}
