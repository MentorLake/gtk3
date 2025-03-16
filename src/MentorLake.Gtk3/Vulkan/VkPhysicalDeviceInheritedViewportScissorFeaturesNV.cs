namespace MentorLake.Vulkan;

public class VkPhysicalDeviceInheritedViewportScissorFeaturesNVHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceInheritedViewportScissorFeaturesNVExtensions
{

	public static VkPhysicalDeviceInheritedViewportScissorFeaturesNV Dereference(this VkPhysicalDeviceInheritedViewportScissorFeaturesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceInheritedViewportScissorFeaturesNV>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceInheritedViewportScissorFeaturesNVExterns
{
}

public struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
{
}
