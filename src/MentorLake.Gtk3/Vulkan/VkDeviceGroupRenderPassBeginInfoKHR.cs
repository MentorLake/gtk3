namespace MentorLake.Vulkan;


public class VkDeviceGroupRenderPassBeginInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupRenderPassBeginInfoKHRExtensions
{

	public static VkDeviceGroupRenderPassBeginInfoKHR Dereference(this VkDeviceGroupRenderPassBeginInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupRenderPassBeginInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupRenderPassBeginInfoKHRExterns
{
}


public struct VkDeviceGroupRenderPassBeginInfoKHR
{
}
