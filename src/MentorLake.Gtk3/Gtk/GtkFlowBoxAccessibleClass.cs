namespace MentorLake.Gtk;


public class GtkFlowBoxAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkFlowBoxAccessibleClassExtensions
{

	public static GtkFlowBoxAccessibleClass Dereference(this GtkFlowBoxAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFlowBoxAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkFlowBoxAccessibleClassExterns
{
}


public struct GtkFlowBoxAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
