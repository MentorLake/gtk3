namespace MentorLake.Vulkan;

public class VkPhysicalDeviceMaintenance4FeaturesHandle : BaseSafeHandle
{
}


public static class VkPhysicalDeviceMaintenance4FeaturesExtensions
{

	public static VkPhysicalDeviceMaintenance4Features Dereference(this VkPhysicalDeviceMaintenance4FeaturesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPhysicalDeviceMaintenance4Features>(x.DangerousGetHandle());
}
internal class VkPhysicalDeviceMaintenance4FeaturesExterns
{
}

public struct VkPhysicalDeviceMaintenance4Features
{
}
