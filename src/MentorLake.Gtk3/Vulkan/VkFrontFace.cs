namespace MentorLake.Vulkan;


public class VkFrontFaceHandle : BaseSafeHandle
{
}


public static class VkFrontFaceExtensions
{

	public static VkFrontFace Dereference(this VkFrontFaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFrontFace>(x.DangerousGetHandle());
}
internal class VkFrontFaceExterns
{
}


public struct VkFrontFace
{
}
