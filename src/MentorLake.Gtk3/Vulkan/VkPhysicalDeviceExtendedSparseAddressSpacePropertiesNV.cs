namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNVExtensions
{

	public static VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV Dereference(this VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNVExterns
{
}


public struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV
{
}
