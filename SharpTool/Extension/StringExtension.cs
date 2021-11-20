namespace SharpTool.Extension
{
    public static class StringExtension
    {
        public static bool AnyOne(this string self, params string[] strs)
        {
            foreach (var str in strs)
            {
                if (str == self)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
