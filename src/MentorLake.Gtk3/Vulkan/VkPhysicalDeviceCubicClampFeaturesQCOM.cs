namespace MentorLake.Vulkan;

public class VkPhysicalDeviceCubicClampFeaturesQCOMHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceCubicClampFeaturesQCOMExtensions
{

	public static VkPhysicalDeviceCubicClampFeaturesQCOM Dereference(this VkPhysicalDeviceCubicClampFeaturesQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceCubicClampFeaturesQCOM>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceCubicClampFeaturesQCOMExterns
{
}

public struct VkPhysicalDeviceCubicClampFeaturesQCOM
{
}
