namespace MentorLake.Vulkan;

public class VkOpaqueCaptureDescriptorDataCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkOpaqueCaptureDescriptorDataCreateInfoEXTExtensions
{

	public static VkOpaqueCaptureDescriptorDataCreateInfoEXT Dereference(this VkOpaqueCaptureDescriptorDataCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpaqueCaptureDescriptorDataCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkOpaqueCaptureDescriptorDataCreateInfoEXTExterns
{
}

public struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
{
}
