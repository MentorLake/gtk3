namespace MentorLake.Vulkan;

public class VkRenderingFragmentDensityMapAttachmentInfoEXTHandle : BaseSafeHandle
{
}


public static class VkRenderingFragmentDensityMapAttachmentInfoEXTExtensions
{

	public static VkRenderingFragmentDensityMapAttachmentInfoEXT Dereference(this VkRenderingFragmentDensityMapAttachmentInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderingFragmentDensityMapAttachmentInfoEXT>(x.DangerousGetHandle());
}
internal class VkRenderingFragmentDensityMapAttachmentInfoEXTExterns
{
}

public struct VkRenderingFragmentDensityMapAttachmentInfoEXT
{
}
