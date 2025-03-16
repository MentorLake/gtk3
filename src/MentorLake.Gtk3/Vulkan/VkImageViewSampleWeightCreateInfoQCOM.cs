namespace MentorLake.Vulkan;

public class VkImageViewSampleWeightCreateInfoQCOMHandle : BaseSafeHandle
{
}


public static class VkImageViewSampleWeightCreateInfoQCOMExtensions
{

	public static VkImageViewSampleWeightCreateInfoQCOM Dereference(this VkImageViewSampleWeightCreateInfoQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewSampleWeightCreateInfoQCOM>(x.DangerousGetHandle());
}
internal class VkImageViewSampleWeightCreateInfoQCOMExterns
{
}

public struct VkImageViewSampleWeightCreateInfoQCOM
{
}
