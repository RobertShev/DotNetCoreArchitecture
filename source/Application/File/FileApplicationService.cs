using DotNetCore.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Application
{
    public sealed class FileApplicationService : IFileApplicationService
    {
        public async Task<IEnumerable<FileBinary>> AddAsync(string directory, IEnumerable<FileBinary> files)
        {
            Directory.CreateDirectory(directory);

            foreach (var file in files)
            {
                var name = string.Concat(file.Id, Path.GetExtension(file.Name));

                var path = Path.Combine(directory, name);

                await File.WriteAllBytesAsync(path, file.Bytes);

                file.Bytes = default;
            }

            return files;
        }

        public async Task<FileBinary> SelectAsync(string directory, Guid id)
        {
            var file = new DirectoryInfo(directory).GetFiles(id + ".*").Single();

            var bytes = await File.ReadAllBytesAsync(file.FullName);

            return new FileBinary(id, file.Name, bytes, file.Length, file.Extension);
        }
    }
}
