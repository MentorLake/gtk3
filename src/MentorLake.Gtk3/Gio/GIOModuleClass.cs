namespace MentorLake.Gio;


public class GIOModuleClassHandle : BaseSafeHandle
{
}


public static class GIOModuleClassExtensions
{

	public static GIOModuleClass Dereference(this GIOModuleClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOModuleClass>(x.DangerousGetHandle());
}
internal class GIOModuleClassExterns
{
}


public struct GIOModuleClass
{
}
