namespace MentorLake.Gtk;


public class GtkFlowBoxAccessiblePrivateHandle : BaseSafeHandle
{
}


public static class GtkFlowBoxAccessiblePrivateExtensions
{

	public static GtkFlowBoxAccessiblePrivate Dereference(this GtkFlowBoxAccessiblePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFlowBoxAccessiblePrivate>(x.DangerousGetHandle());
}
internal class GtkFlowBoxAccessiblePrivateExterns
{
}


public struct GtkFlowBoxAccessiblePrivate
{
}
