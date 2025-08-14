namespace MentorLake.Gio;


public class GSettingsBackendPrivateHandle : BaseSafeHandle
{
}


public static class GSettingsBackendPrivateExtensions
{

	public static GSettingsBackendPrivate Dereference(this GSettingsBackendPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSettingsBackendPrivate>(x.DangerousGetHandle());
}
internal class GSettingsBackendPrivateExterns
{
}


public struct GSettingsBackendPrivate
{
}
