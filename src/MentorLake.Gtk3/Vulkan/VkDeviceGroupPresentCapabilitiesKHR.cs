namespace MentorLake.Vulkan;

public class VkDeviceGroupPresentCapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupPresentCapabilitiesKHRExtensions
{

	public static VkDeviceGroupPresentCapabilitiesKHR Dereference(this VkDeviceGroupPresentCapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupPresentCapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkDeviceGroupPresentCapabilitiesKHRExterns
{
}

public struct VkDeviceGroupPresentCapabilitiesKHR
{
}
