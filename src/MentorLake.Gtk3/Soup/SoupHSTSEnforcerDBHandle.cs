namespace MentorLake.Soup;

/// <summary>
/// <para>
/// Persistent HTTP Strict Transport Security enforcer.
/// </para>
/// <para>
/// [class@HSTSEnforcerDB] is a [class@HSTSEnforcer] that uses a SQLite
/// database as a backend for persistency.
/// </para>
/// </summary>

public class SoupHSTSEnforcerDBHandle : SoupHSTSEnforcerHandle, SoupSessionFeatureHandle
{
/// <summary>
/// <para>
/// Creates a [class@HSTSEnforcerDB].
/// </para>
/// <para>
/// @filename will be read in during the initialization of a
/// [class@HSTSEnforcerDB], in order to create an initial set of HSTS
/// policies. If the file doesn&apos;t exist, a new database will be created
/// and initialized. Changes to the policies during the lifetime of a
/// [class@HSTSEnforcerDB] will be written to @filename when
/// [signal@HSTSEnforcer::changed] is emitted.
/// </para>
/// </summary>

/// <param name="filename">
/// the filename of the database to read/write from.
/// </param>
/// <return>
/// the new #SoupHSTSEnforcer
/// </return>

	public static MentorLake.Soup.SoupHSTSEnforcerDBHandle New(string filename)
	{
		return SoupHSTSEnforcerDBHandleExterns.soup_hsts_enforcer_db_new(filename);
	}

}

public static class SoupHSTSEnforcerDBHandleExtensions
{
}

internal class SoupHSTSEnforcerDBHandleExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Soup.SoupHSTSEnforcerDBHandle>))]
	internal static extern MentorLake.Soup.SoupHSTSEnforcerDBHandle soup_hsts_enforcer_db_new(string filename);

}
