namespace MentorLake.Vulkan;

public class VkPhysicalDeviceCoherentMemoryFeaturesAMDHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCoherentMemoryFeaturesAMDExtensions
{

	public static VkPhysicalDeviceCoherentMemoryFeaturesAMD Dereference(this VkPhysicalDeviceCoherentMemoryFeaturesAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCoherentMemoryFeaturesAMD>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCoherentMemoryFeaturesAMDExterns
{
}

public struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
{
}
