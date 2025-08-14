namespace MentorLake.Vulkan;


public class VkDeviceGroupPresentInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupPresentInfoKHRExtensions
{

	public static VkDeviceGroupPresentInfoKHR Dereference(this VkDeviceGroupPresentInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupPresentInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupPresentInfoKHRExterns
{
}


public struct VkDeviceGroupPresentInfoKHR
{
}
