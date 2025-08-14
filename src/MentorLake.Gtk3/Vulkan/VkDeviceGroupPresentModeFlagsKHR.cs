namespace MentorLake.Vulkan;


public class VkDeviceGroupPresentModeFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupPresentModeFlagsKHRExtensions
{

	public static VkDeviceGroupPresentModeFlagsKHR Dereference(this VkDeviceGroupPresentModeFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupPresentModeFlagsKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupPresentModeFlagsKHRExterns
{
}


public struct VkDeviceGroupPresentModeFlagsKHR
{
}
