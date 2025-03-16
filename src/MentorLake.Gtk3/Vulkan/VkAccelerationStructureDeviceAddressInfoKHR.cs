namespace MentorLake.Vulkan;

public class VkAccelerationStructureDeviceAddressInfoKHRHandle : BaseSafeHandle
{
}


public static class VkAccelerationStructureDeviceAddressInfoKHRExtensions
{

	public static VkAccelerationStructureDeviceAddressInfoKHR Dereference(this VkAccelerationStructureDeviceAddressInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccelerationStructureDeviceAddressInfoKHR>(x.DangerousGetHandle());
}
internal class VkAccelerationStructureDeviceAddressInfoKHRExterns
{
}

public struct VkAccelerationStructureDeviceAddressInfoKHR
{
}
