namespace MentorLake.Gtk;


public class GtkFlowBoxChildAccessibleClassHandle : BaseSafeHandle
{
}


public static class GtkFlowBoxChildAccessibleClassExtensions
{

	public static GtkFlowBoxChildAccessibleClass Dereference(this GtkFlowBoxChildAccessibleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFlowBoxChildAccessibleClass>(x.DangerousGetHandle());
}
internal class GtkFlowBoxChildAccessibleClassExterns
{
}


public struct GtkFlowBoxChildAccessibleClass
{
	
public GtkContainerAccessibleClass parent_class;
}
