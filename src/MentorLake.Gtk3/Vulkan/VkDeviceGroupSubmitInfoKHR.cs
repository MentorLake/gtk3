namespace MentorLake.Vulkan;


public class VkDeviceGroupSubmitInfoKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupSubmitInfoKHRExtensions
{

	public static VkDeviceGroupSubmitInfoKHR Dereference(this VkDeviceGroupSubmitInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupSubmitInfoKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupSubmitInfoKHRExterns
{
}


public struct VkDeviceGroupSubmitInfoKHR
{
}
