namespace MentorLake.Vulkan;


public class VkFormatProperties3Handle : BaseSafeHandle
{
}


public static class VkFormatProperties3Extensions
{

	public static VkFormatProperties3 Dereference(this VkFormatProperties3Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormatProperties3>(x.DangerousGetHandle());
}
internal class VkFormatProperties3Externs
{
}


public struct VkFormatProperties3
{
}
