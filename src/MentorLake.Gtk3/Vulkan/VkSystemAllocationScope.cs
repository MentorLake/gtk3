namespace MentorLake.Vulkan;

public class VkSystemAllocationScopeHandle : BaseSafeHandle
{
}


public static class VkSystemAllocationScopeExtensions
{

	public static VkSystemAllocationScope Dereference(this VkSystemAllocationScopeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSystemAllocationScope>(x.DangerousGetHandle());
}
internal class VkSystemAllocationScopeExterns
{
}

public struct VkSystemAllocationScope
{
}
