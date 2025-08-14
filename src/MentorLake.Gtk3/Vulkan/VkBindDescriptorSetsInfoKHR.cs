namespace MentorLake.Vulkan;


public class VkBindDescriptorSetsInfoKHRHandle : BaseSafeHandle
{
}


public static class VkBindDescriptorSetsInfoKHRExtensions
{

	public static VkBindDescriptorSetsInfoKHR Dereference(this VkBindDescriptorSetsInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindDescriptorSetsInfoKHR>(x.DangerousGetHandle());
}
internal class VkBindDescriptorSetsInfoKHRExterns
{
}


public struct VkBindDescriptorSetsInfoKHR
{
}
