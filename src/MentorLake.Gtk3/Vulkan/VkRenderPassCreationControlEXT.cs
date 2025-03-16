namespace MentorLake.Vulkan;

public class VkRenderPassCreationControlEXTHandle : BaseSafeHandle
{
}


public static class VkRenderPassCreationControlEXTExtensions
{

	public static VkRenderPassCreationControlEXT Dereference(this VkRenderPassCreationControlEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassCreationControlEXT>(x.DangerousGetHandle());
}
internal class VkRenderPassCreationControlEXTExterns
{
}

public struct VkRenderPassCreationControlEXT
{
}
