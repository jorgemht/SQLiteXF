namespace SQLite.Exceptions
{
    using System;
    using System.IO;

    public static class UriBuilderExtensions
    {
        internal static void AppendToPath(this UriBuilder builder, string pathToAdd)
        {
            var completePath = Path.Combine(builder.Path, pathToAdd);
            builder.Path = completePath;
        }
    }
}
