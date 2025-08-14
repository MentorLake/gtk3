namespace MentorLake.Gio;


public class GEmblemedIconClassHandle : BaseSafeHandle
{
}


public static class GEmblemedIconClassExtensions
{

	public static GEmblemedIconClass Dereference(this GEmblemedIconClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GEmblemedIconClass>(x.DangerousGetHandle());
}
internal class GEmblemedIconClassExterns
{
}


public struct GEmblemedIconClass
{
	
public GObjectClass parent_class;
}
