namespace MentorLake.Vulkan;


public class VkStridedDeviceAddressRegionKHRHandle : BaseSafeHandle
{
}


public static class VkStridedDeviceAddressRegionKHRExtensions
{

	public static VkStridedDeviceAddressRegionKHR Dereference(this VkStridedDeviceAddressRegionKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkStridedDeviceAddressRegionKHR>(x.DangerousGetHandle());
}
internal class VkStridedDeviceAddressRegionKHRExterns
{
}


public struct VkStridedDeviceAddressRegionKHR
{
}
