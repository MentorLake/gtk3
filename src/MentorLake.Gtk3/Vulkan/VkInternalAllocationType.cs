namespace MentorLake.Vulkan;


public class VkInternalAllocationTypeHandle : BaseSafeHandle
{
}


public static class VkInternalAllocationTypeExtensions
{

	public static VkInternalAllocationType Dereference(this VkInternalAllocationTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkInternalAllocationType>(x.DangerousGetHandle());
}
internal class VkInternalAllocationTypeExterns
{
}


public struct VkInternalAllocationType
{
}
