namespace MentorLake.Vulkan;


public class VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNVExtensions
{

	public static VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV Dereference(this VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNVExterns
{
}


public struct VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV
{
}
