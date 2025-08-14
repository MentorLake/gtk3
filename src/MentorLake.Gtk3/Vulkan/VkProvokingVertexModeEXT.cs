namespace MentorLake.Vulkan;


public class VkProvokingVertexModeEXTHandle : BaseSafeHandle
{
}


public static class VkProvokingVertexModeEXTExtensions
{

	public static VkProvokingVertexModeEXT Dereference(this VkProvokingVertexModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkProvokingVertexModeEXT>(x.DangerousGetHandle());
}
internal class VkProvokingVertexModeEXTExterns
{
}


public struct VkProvokingVertexModeEXT
{
}
