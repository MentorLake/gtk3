namespace MentorLake.Vulkan;

public class VkPushDescriptorSetInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPushDescriptorSetInfoKHRExtensions
{

	public static VkPushDescriptorSetInfoKHR Dereference(this VkPushDescriptorSetInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPushDescriptorSetInfoKHR>(x.DangerousGetHandle());
}
internal class VkPushDescriptorSetInfoKHRExterns
{
}

public struct VkPushDescriptorSetInfoKHR
{
}
