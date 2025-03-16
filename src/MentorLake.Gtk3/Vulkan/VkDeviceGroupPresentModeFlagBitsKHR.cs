namespace MentorLake.Vulkan;

public class VkDeviceGroupPresentModeFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupPresentModeFlagBitsKHRExtensions
{

	public static VkDeviceGroupPresentModeFlagBitsKHR Dereference(this VkDeviceGroupPresentModeFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupPresentModeFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupPresentModeFlagBitsKHRExterns
{
}

public struct VkDeviceGroupPresentModeFlagBitsKHR
{
}
